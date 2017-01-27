using System;
using System.Collections.Generic;
using System.Text;

namespace DarkOmen
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y) { this.X = x; this.Y = y; }

        public override string ToString()
        {
            return String.Format("({0},{1})", X, Y);
        }
    }

    public class Dimension
    {
        public int W { get; set; }
        public int H { get; set; }

        public Dimension(int w, int h) { this.W = w; this.H = h; }
        public int Area { get { return this.W * this.H; } }

        public override string ToString()
        {
            return String.Format("({0},{1})", W, H);
        }
    }

    public class Colour
    {
        public byte A { get; set; }
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        public Colour(int A, int R, int G, int B)
        {
            this.A = (byte)A; this.R = (byte)R; this.G = (byte)G; this.B = (byte)B;
        }
    };

}
