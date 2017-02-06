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
		private enum PlayDirections
		{
			Horizontal,
			Vertical
		}

		private const int RowSize = 8;

		private int _frameSize;
		private FrameCollection _frames;
		private int _currentFrameIndex;
		private int _maxFrames;
		private PlayDirections _playDirection;
		private bool _isPlaying;
		private int _row;
		private int _maxRows;
		
		public MainForm()
		{
			InitializeComponent();
			_frameSize = 128;
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
				Reset();
				UpdateUI();
								
				ComposeImage();
				DrawFrame();
			}
		}

		private void Reset()
		{
			StopPlaying();
			_currentFrameIndex = 0;
			_row = 0;
			_maxRows = _frames.Count / RowSize;
			ChangeDirection();
		}

		private void UpdateUI()
		{
			SetupTrackBar();
			_horizontalRow_numericUpDown.Value = _row;
			_horizontalRow_numericUpDown.Maximum = _maxRows - 1;
		}

		private void ComposeImage()
		{
			int finalSizeX = RowSize;
			int finalSizeY = _frames.Count / finalSizeX;

			Bitmap finalImage = new Bitmap(finalSizeX * _frameSize, finalSizeY * _frameSize);
			Graphics g = Graphics.FromImage(finalImage);

			for (int i = 0; i < _frames.Count; ++i)
			{
				var frame = _frames[i];
				Bitmap image = frame.ToBitmap();

				int x = (i % finalSizeX) * _frameSize;
				int y = (i / finalSizeX) * _frameSize;

				Position p = frame.TopLeftPosition();
				g.DrawImage(image, x + p.X + _frameSize / 2, y + p.Y + _frameSize);
			}

			if (checkBox3.Checked)
			{
				Pen p = new Pen(Color.Black);

				for (int i = 0; i <= finalImage.Width; i += _frameSize)
				{
					g.DrawLine(p, i, 0, i, finalImage.Height);
				}

				for (int j = 0; j <= finalImage.Height; j += _frameSize)
				{
					g.DrawLine(p, 0, j, finalImage.Width, j);
				}
			}

			g.Dispose();

			_sheet_pictureBox.Image = finalImage;
			_sheet_pictureBox.Size = new Size(finalImage.Width, finalImage.Height);
		}

		private void ResetFrame()
		{
			StopPlaying();
			_currentFrameIndex = 0;
		}
		
		private void ChangeFrame(int delta)
		{
			_currentFrameIndex += delta;
			if (_currentFrameIndex >= _maxFrames)
			{
				_currentFrameIndex = 0;
			}
			if (_currentFrameIndex < 0)
			{
				_currentFrameIndex = _maxFrames - 1;
			}
			DrawFrame();
		}

		private void DrawFrame()
		{
			if (_playDirection == PlayDirections.Horizontal)
			{
				Bitmap sheet = _sheet_pictureBox.Image as Bitmap;
				if (sheet != null)
				{
					Bitmap frame = new Bitmap(_frameSize, _frameSize);
					Graphics g = Graphics.FromImage(frame);
					Rectangle rect = new Rectangle(0, 0, _frameSize, _frameSize);
					g.DrawImage(sheet, rect, _currentFrameIndex * _frameSize, _row * _frameSize, _frameSize, _frameSize, GraphicsUnit.Pixel);
					rect.Width = rect.Height = _frameSize - 1;
					g.DrawRectangle(Pens.Red, rect);
					g.Dispose();
					_frame_pictureBox.Image = frame;
				}
				else
				{
					ShowError("Sprite sheet is null");
				}
			}
			else
			{
				//TODo
			}
		}

		private void StopPlaying()
		{
			if (_isPlaying)
			{
				_isPlaying = false;
				//TODO
			}
		}

		private void SetupTrackBar()
		{
			if (_playDirection == PlayDirections.Horizontal)
			{
				_frame_trackBar.Value = 0;
				_frame_trackBar.Maximum = RowSize - 1;
			}
			else
			{
				//TODO
			}
		}

		private void UpdateTrackBar()
		{
			_frame_trackBar.Value = _currentFrameIndex;
		}

		private void ShowError(string message)
		{
			MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			ComposeImage();
		}

		private void ChangeDirection()
		{
			ResetFrame();
			if (_playDirection == PlayDirections.Horizontal)
			{
				_maxFrames = RowSize;
			}
			else
			{
				//TODO
			}
			SetupTrackBar();
		}

		private void _horizontal_checkBox_CheckedChanged(object sender, EventArgs e)
		{
			if (_horizontal_checkBox.Checked)
			{
				_playDirection = PlayDirections.Horizontal;
				_vertical_checkBox.Checked = false;
				ChangeDirection();
			}
		}

		private void _vertical_checkBox_CheckedChanged(object sender, EventArgs e)
		{
			if (_vertical_checkBox.Checked)
			{
				_playDirection = PlayDirections.Vertical;
				_horizontal_checkBox.Checked = false;
				ChangeDirection();
			}
		}
		
		private void _play_button_Click(object sender, EventArgs e)
		{
			//TODO
		}

		private void _stop_button_Click(object sender, EventArgs e)
		{
			//TODO
		}

		private void _nextFrame_button_Click(object sender, EventArgs e)
		{
			StopPlaying();
			ChangeFrame(1);
			UpdateTrackBar();
		}

		private void _prevFrame_button_Click(object sender, EventArgs e)
		{
			StopPlaying();
			ChangeFrame(-1);
			UpdateTrackBar();
		}

		private void _horizontalRow_numericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int val = (int)_horizontalRow_numericUpDown.Value;
			if (val != _row)
			{
				_row = val;
				DrawFrame();
			}
		}

		private void _frame_trackBar_Scroll(object sender, EventArgs e)
		{
			//TODO what about autoplay?

			_currentFrameIndex = _frame_trackBar.Value;
			DrawFrame();
		}
	}
}
