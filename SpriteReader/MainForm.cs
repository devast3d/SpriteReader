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
		private int _minFrame;
		private int _maxFrame;
		private PlayDirections _playDirection;
		private bool _isPlaying;
		private int _row;
		private int _maxRows;
		private int _rowFrom;
		private int _rowTo;
		private int _column;
		private Timer _playTimer;
		

		public MainForm()
		{
			InitializeComponent();

			_frameSize = 128;
			_currentFrameIndex = 0;
			_row = 0;
			_rowFrom = _rowTo = 0;
			_column = 0;

			_playTimer = new Timer();
			_playTimer.Interval = 200;
			_playTimer.Tick += _playTimer_Tick;
		}


		private void OpenFile()
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

				RedrawSheet();
				DrawFrame();
			}
		}

		private void ShowError(string message)
		{
			MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void Reset()
		{
			StopPlaying();

			_currentFrameIndex = 0;
			_row = 0;
			_column = 0;
			_rowFrom = _rowTo = 0;
			_maxRows = _frames.Count / RowSize;

			ApplyDirection();
		}	

		private void ApplyDirection()
		{
			ResetFrame();

			if (_playDirection == PlayDirections.Horizontal)
			{
				_minFrame = 0;
				_maxFrame = RowSize - 1;
			}
			else
			{
				_minFrame = _rowFrom;
				_maxFrame = _rowTo;
				if (_minFrame > _maxFrame)
				{
					ShowError("Min frame can't be larger than max frame");
					_minFrame = _maxFrame;
					UpdateUI();
				}
			}

			SetupTrackBar();
			RedrawSheet();
		}

		private void ResetFrame()
		{
			StopPlaying();
			_currentFrameIndex = _minFrame;
		}
		
		private void ChangeFrame(int delta)
		{
			_currentFrameIndex += delta;
			if (_currentFrameIndex > _maxFrame)
			{
				_currentFrameIndex = _minFrame;
			}
			if (_currentFrameIndex < _minFrame)
			{
				_currentFrameIndex = _maxFrame;
			}
			DrawFrame();
		}

		private void DrawFrame()
		{
			Bitmap sheet = _sheet_pictureBox.Image as Bitmap;
			if (sheet != null)
			{
				Bitmap frame = new Bitmap(_frameSize, _frameSize);
				Graphics g = Graphics.FromImage(frame);
				Rectangle rect = new Rectangle(0, 0, _frameSize, _frameSize);

				if (_playDirection == PlayDirections.Horizontal)
				{
					g.DrawImage(sheet, rect, _currentFrameIndex * _frameSize, _row * _frameSize, _frameSize, _frameSize, GraphicsUnit.Pixel);
				}
				else
				{
					g.DrawImage(sheet, rect, _column * _frameSize, _currentFrameIndex * _frameSize, _frameSize, _frameSize, GraphicsUnit.Pixel);
				}

				rect.Width = rect.Height = _frameSize - 1;
				g.DrawRectangle(Pens.Red, rect);
				g.Dispose();

				_frame_pictureBox.Image = frame;
			}
			else
			{
				StopPlaying();
				ShowError("Sprite sheet is null");		
			}
		}

		private void ComposeImage(bool export)
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

			if (!export)
			{
				if (_drawGrid_checkBox.Checked)
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

				Pen frameSpanPen = new Pen(Color.Yellow, 3);
				if (_playDirection == PlayDirections.Horizontal)
				{
					g.DrawRectangle(frameSpanPen, 0, _row * _frameSize, RowSize * _frameSize, _frameSize);
				}
				else
				{
					g.DrawRectangle(frameSpanPen, _column * _frameSize, _minFrame * _frameSize, _frameSize, (_maxFrame - _minFrame + 1) * _frameSize);
				}
			}

			g.Dispose();

			_sheet_pictureBox.Image = finalImage;
			_sheet_pictureBox.Size = new Size(finalImage.Width, finalImage.Height);
		}

		private void RedrawSheet()
		{
			ComposeImage(false);
		}

		private void Export()
		{
			Bitmap image = _sheet_pictureBox.Image as Bitmap;
			if (image != null)
			{
				ComposeImage(true);
				SaveFileDialog dialog = new SaveFileDialog();
				dialog.Filter = "PNG Files (*.png)|*.png|All Files (*.*)|*.*";
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					image = _sheet_pictureBox.Image as Bitmap;
					image.Save(dialog.FileName);
				}
				ComposeImage(false);
			}
		}

		private void Play()
		{
			if (!_isPlaying)
			{
				_isPlaying = true;
				_playTimer.Start();

				_frame_trackBar.Enabled = false;
				_frame_trackBar.BackColor = Color.Red;
			}
		}

		private void StopPlaying()
		{
			if (_isPlaying)
			{
				_isPlaying = false;
				_playTimer.Stop();

				_frame_trackBar.Enabled = true;
				_frame_trackBar.BackColor = SystemColors.Control;
			}
		}

		private void _playTimer_Tick(object sender, EventArgs e)
		{
			ChangeFrame(1);
			UpdateTrackBar();
		}
		

		private void UpdateUI()
		{
			SetupTrackBar();
			int maxRowsMinOne = _maxRows - 1;

			_playSpeed_numericUpDown.Value = (decimal)(_playTimer.Interval / 1000f);

			_horizontalRow_numericUpDown.Maximum = maxRowsMinOne;
			_horizontalRow_numericUpDown.Value = _row;

			_column_numericUpDown.Maximum = RowSize - 1;
			_column_numericUpDown.Value = _column;

			_rowFrom_numericUpDown.Maximum = maxRowsMinOne;
			_rowFrom_numericUpDown.Value = _rowFrom;

			_rowTo_numericUpDown.Maximum = maxRowsMinOne;
			_rowTo_numericUpDown.Value = _rowTo;
		}

		private void SetupTrackBar()
		{
			if (_playDirection == PlayDirections.Horizontal)
			{
				_frame_trackBar.Minimum = 0;
				_frame_trackBar.Maximum = RowSize - 1;
				_frame_trackBar.Value = 0;
			}
			else
			{
				_frame_trackBar.Minimum = _minFrame;
				_frame_trackBar.Maximum = _maxFrame;
				_frame_trackBar.Value = _minFrame;
			}
		}

		private void UpdateTrackBar()
		{
			_frame_trackBar.Value = _currentFrameIndex;
		}


		private void _open_button_Click(object sender, EventArgs e)
		{
			OpenFile();
		}

		private void _export_button_Click(object sender, EventArgs e)
		{
			Export();
		}

		private void _drawGrid_checkBox_CheckedChanged(object sender, EventArgs e)
		{
			RedrawSheet();
		}

		private void _play_button_Click(object sender, EventArgs e)
		{
			Play();
		}

		private void _stop_button_Click(object sender, EventArgs e)
		{
			StopPlaying();
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

		private void _frame_trackBar_Scroll(object sender, EventArgs e)
		{
			if (_isPlaying)
			{
				StopPlaying();
			}
			_currentFrameIndex = _frame_trackBar.Value;
			DrawFrame();
		}

		private void _playSpeed_numericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int val = (int)((float)_playSpeed_numericUpDown.Value * 1000f);
			if (val != _playTimer.Interval)
			{
				StopPlaying();
				_playTimer.Interval = val;
				Play();
			}
		}

		private void _horizontal_checkBox_CheckedChanged(object sender, EventArgs e)
		{
			if (_horizontal_checkBox.Checked)
			{
				_playDirection = PlayDirections.Horizontal;
				_vertical_checkBox.Checked = false;
				ApplyDirection();
			}
		}

		private void _vertical_checkBox_CheckedChanged(object sender, EventArgs e)
		{
			if (_vertical_checkBox.Checked)
			{
				_playDirection = PlayDirections.Vertical;
				_horizontal_checkBox.Checked = false;
				ApplyDirection();
			}
		}
		
		private void _horizontalRow_numericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int val = (int)_horizontalRow_numericUpDown.Value;
			if (val != _row)
			{
				_row = val;
				DrawFrame();
				RedrawSheet();
			}
		}
		
		private void _column_numericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int val = (int)_column_numericUpDown.Value;
			if (val != _column)
			{
				_column = val;
				DrawFrame();
				RedrawSheet();
			}
		}

		private void _rowFrom_numericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int val = (int)_rowFrom_numericUpDown.Value;
			if (val != _rowFrom)
			{
				_rowFrom = val;
				ApplyDirection();
				DrawFrame();
			}
		}

		private void _rowTo_numericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int val = (int)_rowTo_numericUpDown.Value;
			if (val != _rowFrom)
			{
				_rowTo = val;
				ApplyDirection();
				DrawFrame();
			}
		}
	}
}
