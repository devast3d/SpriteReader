using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpriteReader
{
	public partial class ImageGridUserControl : UserControl
	{
		private PictureBox[] _boxes;
		private int _stride;

		public ImageGridUserControl()
		{
			InitializeComponent();
		}

		public void Init(int cellX, int cellY, int blockSize, int padding, Bitmap[] images)
		{
			Controls.Clear();
			_boxes = new PictureBox[cellX * cellY];
			_stride = cellX;

			int offset = blockSize + padding;

			for (int j = 0; j < cellY; ++j)
			{
				for (int i = 0; i < cellX; ++i)
				{
					int x = i * offset;
					int y = j * offset;

					PictureBox box = new PictureBox();
					box.Size = new Size(blockSize, blockSize);
					box.BorderStyle = BorderStyle.FixedSingle;
					box.Image = images[i + j * cellX];
					box.BackColor = Color.White;

					Controls.Add(box);
					box.Location = new Point(x, y);
				}
			}
		}
	}
}
