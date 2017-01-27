using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;

namespace DarkOmen
{
    public class FlipYTransform : IFrameTransform
    {
        private NullTransform nullTransform;
        private Bitmap cachedBitmap = null;
        public FlipYTransform()
        {
            nullTransform = new NullTransform();
        }

        public Bitmap ToBitmap(Dimension dims, IImageData source, Palette palette)
        {
            if (cachedBitmap != null) return this.cachedBitmap;
            this.cachedBitmap = nullTransform.ToBitmap(dims, source, palette);
            this.cachedBitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            return this.cachedBitmap;
        }

        public void Dispose()
        {
            if (this.cachedBitmap != null)
            {
                this.cachedBitmap.Dispose();
                this.cachedBitmap = null;
            }
        }

    }

}
