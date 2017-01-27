using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkOmen;
using System.IO;

namespace SpriteReader
{
	public partial class MainForm : Form
	{
		private FrameCollection _frames;

		public MainForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				FileStream stream = File.OpenRead(dialog.FileName);
				BinaryReader reader = new BinaryReader(stream);
				SPRFileReader sprReader = new SPRFileReader(reader);
				FrameCollection frames = FrameCollection.FromFile(sprReader);
				reader.Dispose();
				stream.Dispose();

				_frames = frames;
				ComposeImage();
			}
		}

		private void ComposeImage()
		{
			int frameSize = 128;
			int finalSizeX = 8;
			int finalSizeY = _frames.Count / finalSizeX;

			Bitmap finalImage = new Bitmap(finalSizeX * frameSize, finalSizeY * frameSize);
			Graphics g = Graphics.FromImage(finalImage);

			for (int i = 0; i < _frames.Count; ++i)
			{
				var frame = _frames[i];
				Bitmap image = frame.ToBitmap();

				int x = (i % finalSizeX) * frameSize;
				int y = (i / finalSizeX) * frameSize;

				Position p = frame.TopLeftPosition();
				g.DrawImage(image, x + p.X + frameSize / 2, y + p.Y + frameSize);
			}

			if (checkBox3.Checked)
			{
				Pen p = new Pen(Color.Black);

				for (int i = 0; i <= finalImage.Width; i += frameSize)
				{
					g.DrawLine(p, i, 0, i, finalImage.Height);
				}

				for (int j = 0; j <= finalImage.Height; j += frameSize)
				{
					g.DrawLine(p, 0, j, finalImage.Width, j);
				}
			}

			g.Dispose();

			pictureBox1.Image = finalImage;
			pictureBox1.Size = new Size(finalImage.Width, finalImage.Height);
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			ComposeImage();
		}
	}
}
