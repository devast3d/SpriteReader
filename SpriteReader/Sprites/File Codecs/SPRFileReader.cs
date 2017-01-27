using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

namespace DarkOmen
{
    class NotAValidSPRFileException : ApplicationException { }
    class UnsupportedFrameCompression : ApplicationException { }
    class UncompressedFrameWrongSizeException : ApplicationException { }
    class UnsupportedFrameType : ApplicationException { }

    public class SPRFileReader : ISpriteFileReader
    {

        //  This class is declared nested since it is closely related to
        //  the enclosing class and uses its private properties
        //
        private class SPRFrameIterator : IFrameIterator
        {
            private SPRFileReader sprFileReader;
            private int currentFrameNumber;

            public SPRFrameIterator(SPRFileReader sprFileReader)
            {
                this.sprFileReader = sprFileReader;
                this.currentFrameNumber = 0;
            }

            public bool AtEnd()
            {
                if (this.currentFrameNumber < sprFileReader.frameCount)
                    return false;
                return true;
            }

            public Frame GetNext()
            {
                this.currentFrameNumber++;
                return this.sprFileReader.LoadFrame();
            }
        }

        private BinaryReader reader;
        private int frameDataOffset;
        private int colourTableOffset;
        private int colourTableEntryCount;
        private int frameCount;

        private Dictionary<int, IImageData> imageDataObjectList;
        private Dictionary<int, Palette> paletteObjectList;

        public SPRFileReader(BinaryReader reader)
        {
            this.reader = reader;

            // The dictionaries have a guess at the initial capacity.
            // doesn't have to be accurate
            //
            this.imageDataObjectList = new Dictionary<int, IImageData>(120);
            this.paletteObjectList = new Dictionary<int, Palette>(5);

            string magic = ASCIIEncoding.Default.GetString(reader.ReadBytes(4));
            int filesize = reader.ReadInt32();
            int version = reader.ReadInt32();
            if ((magic != "WHDO") || (version != 32))
                throw new NotAValidSPRFileException();

            this.frameDataOffset = reader.ReadInt32();
            this.colourTableOffset = reader.ReadInt32();
            this.colourTableEntryCount = reader.ReadInt32();
            reader.ReadInt32(); // palettes in file
            this.frameCount = reader.ReadInt32();
        }

        public IFrameIterator NewFrameIterator()
        {
            return new SPRFrameIterator(this);
        }

        private Frame LoadFrame()
        {
            byte frameType = reader.ReadByte();
            byte compressionType = reader.ReadByte();
            short paletteSize = reader.ReadInt16();
            short xorigin = reader.ReadInt16();
            short yorigin = reader.ReadInt16();
            short width = reader.ReadInt16();
            short height = reader.ReadInt16();
            int dataBeginIndex = reader.ReadInt32();
            int compressedSize = reader.ReadInt32();
            int uncompressedSize = reader.ReadInt32();
            int paletteBeginIndex = reader.ReadInt32();
            reader.ReadInt32(); // padding

            if (frameType == 5) return new Frame();

            Palette palette = RetreivePalette(paletteBeginIndex, paletteSize);
            IImageData data = RetreiveImageData(dataBeginIndex, compressedSize, compressionType, palette);

            Frame newFrame = new Frame(new Dimension(width, height),
                                       new Position(xorigin, yorigin),
                                       palette,
                                       data);
            switch (frameType)
            {
                case 1:
                    newFrame.SetTransform(new FlipXTransform());
                    break;

                case 2:
                    newFrame.SetTransform(new FlipYTransform());
                    break;

                case 3:
                    newFrame.SetTransform(new FlipXYTransform());
                    break;

                case 0:
                case 4:
                    break;

                default:
                    throw new UnsupportedFrameType();
            }

            return newFrame;
        }

        private IImageData RetreiveImageData(int index, int compressedSize, int compressionType, Palette palette)
        {
            // This data has already been loaded, so don't load it twice,
            // share the object instead.
            //
            if (imageDataObjectList.ContainsKey(index))
                return imageDataObjectList[index];

            IImageData data;
            long savedPosition = reader.BaseStream.Position;
            reader.BaseStream.Position = this.frameDataOffset + index;

            // The compression types available in the SPR file format aren't going
            // to change, so these are hard-coded
            switch (compressionType)
            {
                case 0:
                    data = new UncompressedImageData(reader.ReadBytes(compressedSize));
                    break;

                case 1:
                    data = new PackbitsImageData(reader.ReadBytes(compressedSize));
                    break;

                case 2:
                    data = new ZeroRunImageData(reader.ReadBytes(compressedSize), palette.Count);
                    break;

                default:
                    throw new UnsupportedFrameCompression();
            }

            imageDataObjectList[index] = data;
            reader.BaseStream.Position = savedPosition;
            return data;
        }

        private Palette RetreivePalette(int index, int paletteSize)
        {
            // Assumption: there are no palettes in the file with differing sizes but the 
            //             same origin.  I haven't seen one yet.
            //
            if (paletteObjectList.ContainsKey(index))
                return paletteObjectList[index];

            Palette palette;
            long savedPosition = reader.BaseStream.Position;

            const int COLOUR_SIZE = 4;
            reader.BaseStream.Position = this.colourTableOffset + index * COLOUR_SIZE;
            palette = new Palette(paletteSize);

            for (int i = 0; i < paletteSize; i++)
            {
                byte R, G, B;
                B = reader.ReadByte();
                G = reader.ReadByte();
                R = reader.ReadByte();
                reader.ReadByte(); // last byte always 0 in file

                if ((B<8) && (G<8) && (R<8)) palette[i].A = 0;
                else palette[i].A = 255;

                palette[i].B = B;
                palette[i].G = G;
                palette[i].R = R;
            }

            paletteObjectList[index] = palette;
            reader.BaseStream.Position = savedPosition;
            return palette;
        }
    }

}
