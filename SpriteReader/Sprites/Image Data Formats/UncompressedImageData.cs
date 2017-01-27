using System;
using System.Collections.Generic;
using System.Text;

namespace DarkOmen
{
    public class UncompressedImageData
    : IImageData
    {
        byte[] internalData;
        public UncompressedImageData(byte[] source)
        {
            internalData = source;
        }

        public void CopyDataToIndexedBitmapArray(byte[] destination)
        {
            Array.Copy(this.internalData, destination, this.internalData.Length);
        }
    }
}
