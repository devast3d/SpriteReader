using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

namespace DarkOmen
{
    public class FrameCollection : IDisposable
    {
        private List<Frame> frameList;

        public FrameCollection()
        {
            this.frameList = new List<Frame>();
        }

        public void Add(Frame frame) { this.frameList.Add(frame); }
        public int Count { get { return frameList.Count; } }

        public Frame this[int index]
        {
            get { return this.frameList[index]; }
        }

        public static FrameCollection FromFile(ISpriteFileReader stream)
        {
            FrameCollection F = new FrameCollection();
            IFrameIterator it = stream.NewFrameIterator();
            while (!it.AtEnd())
            {
                Frame newFrame = it.GetNext();
                F.Add(newFrame);
            }
            return F;
        }

        public void ToFile(ISpriteFileWriter stream)
        {
            foreach (Frame F in this.frameList)
                F.ToFile(stream);
        }

        public Dimension MaxExtents()
        {
            return null;
        }

        public void Dispose()
        {
            foreach (Frame frame in this.frameList)
                frame.Dispose();
        }

    }
}
