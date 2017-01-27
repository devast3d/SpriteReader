using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

namespace DarkOmen
{ 
    public class Frame : IDisposable
    {
        private Position origin;
        private Dimension dimensions;
        private IImageData data;
        private Palette palette;
        private IFrameTransform transform;

        // CONTSTRUCTORS
        //
        public Frame(Dimension dimensions, 
                     Position origin, 
                     Palette palette, 
                     IImageData data)
        {
            this.palette = palette;
            this.origin = origin;
            this.dimensions = dimensions;
            this.data = data;
            this.transform = new NullTransform();
        }

        public Frame()
        {
            this.palette = null;
            this.origin = new Position(0, 0);
            this.dimensions = new Dimension(0, 0);
            this.data = null;
            this.transform = new EmptyTransform();
        }

        public Frame(Frame toCopy)
        {
            this.palette = toCopy.palette;
            this.origin = toCopy.origin;
            this.dimensions = toCopy.dimensions;
            this.data = toCopy.data;
            this.transform = toCopy.transform;
        }

        // PUBLIC FUNCTIONS
        //
        public System.Drawing.Bitmap ToBitmap()
        {
            return this.transform.ToBitmap(this.dimensions, 
                                           this.data, 
                                           this.palette);
        }

        public void SetTransform(IFrameTransform transform)
        {
            this.transform = transform;
        }
        
        public Position TopLeftPosition()
        {
            return this.origin;
        }

        public Position BottomRightPosition()
        {
            int right = this.origin.X + this.dimensions.W;
            int bottom = this.origin.Y + this.dimensions.H;
            return new Position(right, bottom);
        }

        public void ToFile(ISpriteFileWriter writer)
        {
            writer.AddFrame(this.origin, 
                            this.dimensions, 
                            this.data, 
                            this.palette, 
                            this.transform);
        }

        public void Dispose()
        {
            this.transform.Dispose();
        }

    }

}
