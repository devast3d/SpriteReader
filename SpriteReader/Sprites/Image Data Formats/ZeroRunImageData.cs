using System;
using System.Collections.Generic;
using System.Text;

namespace DarkOmen
{
    public class ZeroRunImageData
        : IImageData
    {
        private byte[] internalData;
        private int colourCount;

        public ZeroRunImageData(byte[] source, int colourCount)
        {
            this.colourCount = colourCount;
            this.internalData = source;
        }

        public void CopyDataToIndexedBitmapArray(byte[] destination)
        {
            int destIndex = 0;
            for (int i = 0; i < this.internalData.Length; i++)
            {
                byte b = this.internalData[i];
                if (b >= 128)
                {
                    int zeroCount = 255 - b;
                    for (int j = 0; j < zeroCount; j++)
                        destination[destIndex++] = 0;
                }
                else
                {
                    destination[destIndex++] = b;
                }
            }
        }
    }
}
