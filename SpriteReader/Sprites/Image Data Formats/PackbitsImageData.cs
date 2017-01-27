using System;
using System.Collections.Generic;
using System.Text;

namespace DarkOmen
{
    public class PackbitsImageData
        : IImageData
    {
        byte[] internalData;

        public PackbitsImageData(byte[] source)
        {
            this.internalData = source;
        }

        public void CopyDataToIndexedBitmapArray(byte[] destination)
        {
            byte[] source = this.internalData;
            int currentSourcePos = 0, currentDestinationPos = 0;
            while (currentSourcePos < source.Length)
            {
                sbyte packetCode = (sbyte)source[currentSourcePos++];

                if ((packetCode < 0) && (packetCode > -128))
                {
                    byte packetLength = (byte)(1 - packetCode);
                    byte repeatByte = source[currentSourcePos++];
                    for (int i = 0; i < packetLength; i++)
                        destination[currentDestinationPos++] = repeatByte;
                }
                else if (packetCode >= 0)
                {
                    int packetLength = packetCode + 1;
                    Array.Copy(source, currentSourcePos, destination, currentDestinationPos, packetLength);
                    currentDestinationPos += packetLength;
                    currentSourcePos += packetLength;
                }
            }
        }
    }
}
