using System;
using System.Collections.Generic;
using System.Text;

namespace DarkOmen
{
    public interface IImageData
    {
        void CopyDataToIndexedBitmapArray(byte[] destination);
    }
}
