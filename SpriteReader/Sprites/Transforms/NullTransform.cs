using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;

namespace DarkOmen
{
    class NullTransform : IFrameTransform
    {
        private Bitmap cachedBitmap = null;
        public NullTransform() { }

        public Bitmap ToBitmap(Dimension dims, IImageData source, Palette palette)
        {
            if (this.cachedBitmap != null) return this.cachedBitmap;
            this.cachedBitmap = new Bitmap(dims.W, dims.H);

            byte[] pixeldata = new byte[dims.Area];
            source.CopyDataToIndexedBitmapArray(pixeldata);

            int pixeldataindex = 0;
            for (int y = 0; y < dims.H; y++)
            {
                for (int x = 0; x < dims.W; x++)
                {
                    byte thispixel = pixeldata[pixeldataindex++];
                    this.cachedBitmap.SetPixel(
                        x, y,
                        System.Drawing.Color.FromArgb(
                            palette[thispixel].A,
                            palette[thispixel].R,
                            palette[thispixel].G,
                            palette[thispixel].B
                            )
                        );
                }
            }
            return this.cachedBitmap;
        }

        public void Dispose()
        {
            if (this.cachedBitmap != null)
            {
                this.cachedBitmap.Dispose();
            }
        }

    }
}
