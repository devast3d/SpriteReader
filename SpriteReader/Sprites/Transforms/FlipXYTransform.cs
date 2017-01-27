using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;

namespace DarkOmen
{
    public class FlipXYTransform : IFrameTransform
    {
        private NullTransform nullTransform;
        private Bitmap cachedBitmap = null;
        public FlipXYTransform()
        {
            nullTransform = new NullTransform();
        }

        public Bitmap ToBitmap(Dimension dims, IImageData source, Palette palette)
        {
            if (cachedBitmap != null) return this.cachedBitmap;
            this.cachedBitmap = nullTransform.ToBitmap(dims, source, palette);
            this.cachedBitmap.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            return this.cachedBitmap;
        }

        public void Dispose()
        {
            if (this.cachedBitmap != null)
            {
                this.nullTransform.Dispose();
                this.cachedBitmap = null;
            }
        }

    }
}
