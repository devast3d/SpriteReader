using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

namespace DarkOmen
{
    class SPRFileWriter : ISpriteFileWriter
    {
        private BinaryWriter writer;

        private enum FrameTypeEnum : byte { REPEAT=0, FLIPX=1, FLIPY=2, FLIPXY=3, NORMAL=4, EMPTY=5 }
        private enum CompressionEnum : byte { UNCOMPRESSED = 0, PACKBITS = 1, ZERORUN = 2 }
        private struct FrameStruct
        {
            public FrameTypeEnum type;
            public CompressionEnum compression;
            
            public ushort colorCount;
            public short X, Y;
            public ushort width, height;

            public int dataIndex;
            public int ctabIndex;

            public int compressedSize;
            public int uncompressedSize;
            public int padding;
        }

        private struct PaletteStruct
        {

        }

        public SPRFileWriter(BinaryWriter writer)
        {
            this.writer = writer;
            this.writer.Write(ASCIIEncoding.Default.GetBytes("WHDO"));
            this.writer.Write(0); // filesize will go here later
            this.writer.Write(32); // version
            this.writer.Write(0); // beginning frame data
            this.writer.Write(0); // beginning colour table
            this.writer.Write(0); // colour count
            this.writer.Write(0); // palette count
            this.writer.Write(0); // frame count
        }

        public void AddFrame(Position origin, Dimension dimensions, IImageData data, Palette palette, IFrameTransform transform)
        {
            FrameStruct newFrame;
            newFrame.type = FrameTypeEnum.NORMAL;
            if (transform as EmptyTransform != null) newFrame.type = FrameTypeEnum.EMPTY;
            if (transform as FlipXTransform != null) newFrame.type = FrameTypeEnum.FLIPX;
            if (transform as FlipYTransform != null) newFrame.type = FrameTypeEnum.FLIPY;
            if (transform as FlipXYTransform != null) newFrame.type = FrameTypeEnum.FLIPXY;

            newFrame.compression = CompressionEnum.UNCOMPRESSED;
            if (data as PackbitsImageData != null) newFrame.compression = CompressionEnum.PACKBITS;
            if (data as ZeroRunImageData != null) newFrame.compression = CompressionEnum.ZERORUN;

            newFrame.width = (ushort)dimensions.W;
            newFrame.height = (ushort)dimensions.H;
            newFrame.X = (short)origin.X;
            newFrame.Y = (short)origin.Y;
        }

        public void Finalise()
        {
            throw new NotImplementedException();
        }
    }
}
