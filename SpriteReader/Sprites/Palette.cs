using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

namespace DarkOmen
{
    public class Palette
    {
        private Colour[] colourList;
        private int colourCount;

        public Palette(int count)
        {
            this.colourCount = count;
            this.colourList = new Colour[count];
            for (int colourNum = 0; colourNum < count; colourNum++)
                this.colourList[colourNum] = new Colour(0, 0, 0, 0);
        }

        public int Count { get { return this.colourCount; } }

        public Colour this[int index]
        {
            get { return this.colourList[index]; }
            set { this.colourList[index] = value; }
        }
    }
}
