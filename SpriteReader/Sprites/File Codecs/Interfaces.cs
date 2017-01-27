using System;
using System.Collections.Generic;
using System.Text;

namespace DarkOmen
{
    public interface IFrameIterator
    {
        bool AtEnd();
        Frame GetNext();
    }

    public interface ISpriteFileReader
    {
        IFrameIterator NewFrameIterator();
    }

    public interface ISpriteFileWriter
    {
        void AddFrame(Position origin, 
                      Dimension dimensions,
                      IImageData data,
                      Palette palette, 
                      IFrameTransform transform);

        void Finalise();
    }
}
