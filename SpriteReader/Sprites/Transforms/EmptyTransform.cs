using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;

namespace DarkOmen
{
    public interface IFrameTransform : IDisposable
    {
        System.Drawing.Bitmap ToBitmap(Dimension dims, IImageData source, Palette palette);
    }

    public class EmptyTransform : IFrameTransform
    {
        private static int width = 48, height = 48;
        private Bitmap cachedBitmap = null;
        public EmptyTransform() {}

        public System.Drawing.Bitmap ToBitmap(Dimension dims, IImageData source, Palette palette)
        {
            if (cachedBitmap != null) return cachedBitmap;
            this.cachedBitmap = new System.Drawing.Bitmap(width, height);
            using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(this.cachedBitmap))
            {
                g.FillRectangle(
                    System.Drawing.Brushes.Black,
                    System.Drawing.Rectangle.FromLTRB(0, 0, width, height)
                    );
                g.DrawRectangle(
                    System.Drawing.Pens.Red,
                    System.Drawing.Rectangle.FromLTRB(0, 0, width - 1, height - 1)
                    );

                using (System.Drawing.Font F =
                    new System.Drawing.Font(System.Drawing.FontFamily.GenericMonospace, 10.0f))
                {
                    g.DrawString(
                        "Empty",
                        F,
                        System.Drawing.Brushes.White,
                        new System.Drawing.PointF(1, 5)
                        );
                    g.DrawString(
                        "Frame",
                        F,
                        System.Drawing.Brushes.White,
                        new System.Drawing.PointF(1, 25)
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
