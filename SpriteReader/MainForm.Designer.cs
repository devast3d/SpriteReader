namespace SpriteReader
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this._open_button = new System.Windows.Forms.Button();
			this._sheet_pictureBox = new System.Windows.Forms.PictureBox();
			this._sheet_panel = new System.Windows.Forms.Panel();
			this._play_button = new System.Windows.Forms.Button();
			this._stop_button = new System.Windows.Forms.Button();
			this._prevFrame_button = new System.Windows.Forms.Button();
			this._nextFrame_button = new System.Windows.Forms.Button();
			this._playSpeed_label = new System.Windows.Forms.Label();
			this._playSpeed_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this._horizontal_checkBox = new System.Windows.Forms.CheckBox();
			this._vertical_checkBox = new System.Windows.Forms.CheckBox();
			this._playDirection_label = new System.Windows.Forms.Label();
			this._verticalRange_label = new System.Windows.Forms.Label();
			this._rowFrom_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this._rowTo_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this._drawGrid_checkBox = new System.Windows.Forms.CheckBox();
			this._column_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this._column_label = new System.Windows.Forms.Label();
			this._horizontalRow_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this._horizontalRow_label = new System.Windows.Forms.Label();
			this._frame_pictureBox = new System.Windows.Forms.PictureBox();
			this._frame_trackBar = new System.Windows.Forms.TrackBar();
			this._export_button = new System.Windows.Forms.Button();
			this._applyFrameSize_button = new System.Windows.Forms.Button();
			this._main_toolTip = new System.Windows.Forms.ToolTip(this.components);
			this._frameSize_textBox = new System.Windows.Forms.TextBox();
			this._replaceShadow_checkBox = new System.Windows.Forms.CheckBox();
			this._pixOffset_checkBox = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this._sheet_pictureBox)).BeginInit();
			this._sheet_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._playSpeed_numericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._rowFrom_numericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._rowTo_numericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._column_numericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._horizontalRow_numericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._frame_pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._frame_trackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// _open_button
			// 
			this._open_button.Location = new System.Drawing.Point(12, 12);
			this._open_button.Name = "_open_button";
			this._open_button.Size = new System.Drawing.Size(75, 23);
			this._open_button.TabIndex = 0;
			this._open_button.Text = "Open";
			this._main_toolTip.SetToolTip(this._open_button, "Open sprite file");
			this._open_button.UseVisualStyleBackColor = true;
			this._open_button.Click += new System.EventHandler(this._open_button_Click);
			// 
			// _sheet_pictureBox
			// 
			this._sheet_pictureBox.BackColor = System.Drawing.Color.LightGray;
			this._sheet_pictureBox.Location = new System.Drawing.Point(0, 0);
			this._sheet_pictureBox.Name = "_sheet_pictureBox";
			this._sheet_pictureBox.Size = new System.Drawing.Size(612, 442);
			this._sheet_pictureBox.TabIndex = 3;
			this._sheet_pictureBox.TabStop = false;
			// 
			// _sheet_panel
			// 
			this._sheet_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._sheet_panel.AutoScroll = true;
			this._sheet_panel.BackColor = System.Drawing.Color.White;
			this._sheet_panel.Controls.Add(this._sheet_pictureBox);
			this._sheet_panel.Location = new System.Drawing.Point(12, 197);
			this._sheet_panel.Name = "_sheet_panel";
			this._sheet_panel.Size = new System.Drawing.Size(744, 448);
			this._sheet_panel.TabIndex = 4;
			// 
			// _play_button
			// 
			this._play_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._play_button.Location = new System.Drawing.Point(12, 41);
			this._play_button.Name = "_play_button";
			this._play_button.Size = new System.Drawing.Size(35, 23);
			this._play_button.TabIndex = 5;
			this._play_button.Text = "►";
			this._main_toolTip.SetToolTip(this._play_button, "Play animation");
			this._play_button.UseVisualStyleBackColor = true;
			this._play_button.Click += new System.EventHandler(this._play_button_Click);
			// 
			// _stop_button
			// 
			this._stop_button.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._stop_button.Location = new System.Drawing.Point(52, 41);
			this._stop_button.Name = "_stop_button";
			this._stop_button.Size = new System.Drawing.Size(35, 23);
			this._stop_button.TabIndex = 6;
			this._stop_button.Text = "■";
			this._main_toolTip.SetToolTip(this._stop_button, "Stop playing animation");
			this._stop_button.UseVisualStyleBackColor = true;
			this._stop_button.Click += new System.EventHandler(this._stop_button_Click);
			// 
			// _prevFrame_button
			// 
			this._prevFrame_button.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._prevFrame_button.Location = new System.Drawing.Point(93, 41);
			this._prevFrame_button.Name = "_prevFrame_button";
			this._prevFrame_button.Size = new System.Drawing.Size(35, 23);
			this._prevFrame_button.TabIndex = 7;
			this._prevFrame_button.Text = "←";
			this._main_toolTip.SetToolTip(this._prevFrame_button, "Previous frame");
			this._prevFrame_button.UseVisualStyleBackColor = true;
			this._prevFrame_button.Click += new System.EventHandler(this._prevFrame_button_Click);
			// 
			// _nextFrame_button
			// 
			this._nextFrame_button.Location = new System.Drawing.Point(134, 41);
			this._nextFrame_button.Name = "_nextFrame_button";
			this._nextFrame_button.Size = new System.Drawing.Size(35, 23);
			this._nextFrame_button.TabIndex = 8;
			this._nextFrame_button.Text = "→";
			this._main_toolTip.SetToolTip(this._nextFrame_button, "Next frame");
			this._nextFrame_button.UseVisualStyleBackColor = true;
			this._nextFrame_button.Click += new System.EventHandler(this._nextFrame_button_Click);
			// 
			// _playSpeed_label
			// 
			this._playSpeed_label.AutoSize = true;
			this._playSpeed_label.Location = new System.Drawing.Point(175, 46);
			this._playSpeed_label.Name = "_playSpeed_label";
			this._playSpeed_label.Size = new System.Drawing.Size(76, 13);
			this._playSpeed_label.TabIndex = 10;
			this._playSpeed_label.Text = "Frame Time (s)";
			// 
			// _playSpeed_numericUpDown
			// 
			this._playSpeed_numericUpDown.DecimalPlaces = 3;
			this._playSpeed_numericUpDown.Location = new System.Drawing.Point(255, 44);
			this._playSpeed_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this._playSpeed_numericUpDown.Name = "_playSpeed_numericUpDown";
			this._playSpeed_numericUpDown.Size = new System.Drawing.Size(75, 20);
			this._playSpeed_numericUpDown.TabIndex = 11;
			this._playSpeed_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this._playSpeed_numericUpDown.ValueChanged += new System.EventHandler(this._playSpeed_numericUpDown_ValueChanged);
			// 
			// _horizontal_checkBox
			// 
			this._horizontal_checkBox.AutoSize = true;
			this._horizontal_checkBox.Checked = true;
			this._horizontal_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this._horizontal_checkBox.Location = new System.Drawing.Point(93, 117);
			this._horizontal_checkBox.Name = "_horizontal_checkBox";
			this._horizontal_checkBox.Size = new System.Drawing.Size(73, 17);
			this._horizontal_checkBox.TabIndex = 12;
			this._horizontal_checkBox.Text = "Horizontal";
			this._horizontal_checkBox.UseVisualStyleBackColor = true;
			this._horizontal_checkBox.CheckedChanged += new System.EventHandler(this._horizontal_checkBox_CheckedChanged);
			// 
			// _vertical_checkBox
			// 
			this._vertical_checkBox.AutoSize = true;
			this._vertical_checkBox.Location = new System.Drawing.Point(174, 117);
			this._vertical_checkBox.Name = "_vertical_checkBox";
			this._vertical_checkBox.Size = new System.Drawing.Size(61, 17);
			this._vertical_checkBox.TabIndex = 15;
			this._vertical_checkBox.Text = "Vertical";
			this._vertical_checkBox.UseVisualStyleBackColor = true;
			this._vertical_checkBox.CheckedChanged += new System.EventHandler(this._vertical_checkBox_CheckedChanged);
			// 
			// _playDirection_label
			// 
			this._playDirection_label.AutoSize = true;
			this._playDirection_label.Location = new System.Drawing.Point(12, 118);
			this._playDirection_label.Name = "_playDirection_label";
			this._playDirection_label.Size = new System.Drawing.Size(72, 13);
			this._playDirection_label.TabIndex = 16;
			this._playDirection_label.Text = "Play Direction";
			// 
			// _verticalRange_label
			// 
			this._verticalRange_label.AutoSize = true;
			this._verticalRange_label.Location = new System.Drawing.Point(175, 173);
			this._verticalRange_label.Name = "_verticalRange_label";
			this._verticalRange_label.Size = new System.Drawing.Size(77, 13);
			this._verticalRange_label.TabIndex = 18;
			this._verticalRange_label.Text = "Vertical Range";
			// 
			// _rowFrom_numericUpDown
			// 
			this._rowFrom_numericUpDown.Location = new System.Drawing.Point(255, 171);
			this._rowFrom_numericUpDown.Name = "_rowFrom_numericUpDown";
			this._rowFrom_numericUpDown.Size = new System.Drawing.Size(35, 20);
			this._rowFrom_numericUpDown.TabIndex = 19;
			this._rowFrom_numericUpDown.ValueChanged += new System.EventHandler(this._rowFrom_numericUpDown_ValueChanged);
			// 
			// _rowTo_numericUpDown
			// 
			this._rowTo_numericUpDown.Location = new System.Drawing.Point(295, 171);
			this._rowTo_numericUpDown.Name = "_rowTo_numericUpDown";
			this._rowTo_numericUpDown.Size = new System.Drawing.Size(35, 20);
			this._rowTo_numericUpDown.TabIndex = 20;
			this._rowTo_numericUpDown.ValueChanged += new System.EventHandler(this._rowTo_numericUpDown_ValueChanged);
			// 
			// _drawGrid_checkBox
			// 
			this._drawGrid_checkBox.AutoSize = true;
			this._drawGrid_checkBox.Checked = true;
			this._drawGrid_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this._drawGrid_checkBox.Location = new System.Drawing.Point(336, 16);
			this._drawGrid_checkBox.Name = "_drawGrid_checkBox";
			this._drawGrid_checkBox.Size = new System.Drawing.Size(73, 17);
			this._drawGrid_checkBox.TabIndex = 21;
			this._drawGrid_checkBox.Text = "Draw Grid";
			this._drawGrid_checkBox.UseVisualStyleBackColor = true;
			this._drawGrid_checkBox.CheckedChanged += new System.EventHandler(this._drawGrid_checkBox_CheckedChanged);
			// 
			// _column_numericUpDown
			// 
			this._column_numericUpDown.Location = new System.Drawing.Point(93, 171);
			this._column_numericUpDown.Name = "_column_numericUpDown";
			this._column_numericUpDown.Size = new System.Drawing.Size(75, 20);
			this._column_numericUpDown.TabIndex = 22;
			this._column_numericUpDown.ValueChanged += new System.EventHandler(this._column_numericUpDown_ValueChanged);
			// 
			// _column_label
			// 
			this._column_label.AutoSize = true;
			this._column_label.Location = new System.Drawing.Point(12, 173);
			this._column_label.Name = "_column_label";
			this._column_label.Size = new System.Drawing.Size(42, 13);
			this._column_label.TabIndex = 23;
			this._column_label.Text = "Column";
			// 
			// _horizontalRow_numericUpDown
			// 
			this._horizontalRow_numericUpDown.Location = new System.Drawing.Point(93, 145);
			this._horizontalRow_numericUpDown.Name = "_horizontalRow_numericUpDown";
			this._horizontalRow_numericUpDown.Size = new System.Drawing.Size(75, 20);
			this._horizontalRow_numericUpDown.TabIndex = 25;
			this._horizontalRow_numericUpDown.ValueChanged += new System.EventHandler(this._horizontalRow_numericUpDown_ValueChanged);
			// 
			// _horizontalRow_label
			// 
			this._horizontalRow_label.AutoSize = true;
			this._horizontalRow_label.Location = new System.Drawing.Point(12, 147);
			this._horizontalRow_label.Name = "_horizontalRow_label";
			this._horizontalRow_label.Size = new System.Drawing.Size(29, 13);
			this._horizontalRow_label.TabIndex = 26;
			this._horizontalRow_label.Text = "Row";
			// 
			// _frame_pictureBox
			// 
			this._frame_pictureBox.BackColor = System.Drawing.Color.White;
			this._frame_pictureBox.Location = new System.Drawing.Point(336, 41);
			this._frame_pictureBox.Name = "_frame_pictureBox";
			this._frame_pictureBox.Size = new System.Drawing.Size(179, 150);
			this._frame_pictureBox.TabIndex = 27;
			this._frame_pictureBox.TabStop = false;
			// 
			// _frame_trackBar
			// 
			this._frame_trackBar.LargeChange = 1;
			this._frame_trackBar.Location = new System.Drawing.Point(15, 70);
			this._frame_trackBar.Maximum = 7;
			this._frame_trackBar.Name = "_frame_trackBar";
			this._frame_trackBar.Size = new System.Drawing.Size(315, 45);
			this._frame_trackBar.TabIndex = 28;
			this._frame_trackBar.Scroll += new System.EventHandler(this._frame_trackBar_Scroll);
			// 
			// _export_button
			// 
			this._export_button.Location = new System.Drawing.Point(94, 12);
			this._export_button.Name = "_export_button";
			this._export_button.Size = new System.Drawing.Size(75, 23);
			this._export_button.TabIndex = 29;
			this._export_button.Text = "Export";
			this._main_toolTip.SetToolTip(this._export_button, "Export sprite sheet to image");
			this._export_button.UseVisualStyleBackColor = true;
			this._export_button.Click += new System.EventHandler(this._export_button_Click);
			// 
			// _applyFrameSize_button
			// 
			this._applyFrameSize_button.Location = new System.Drawing.Point(255, 12);
			this._applyFrameSize_button.Name = "_applyFrameSize_button";
			this._applyFrameSize_button.Size = new System.Drawing.Size(75, 23);
			this._applyFrameSize_button.TabIndex = 32;
			this._applyFrameSize_button.Text = "Apply Size";
			this._main_toolTip.SetToolTip(this._applyFrameSize_button, "Apply frame size");
			this._applyFrameSize_button.UseVisualStyleBackColor = true;
			this._applyFrameSize_button.Click += new System.EventHandler(this._applyFrameSize_button_Click);
			// 
			// _frameSize_textBox
			// 
			this._frameSize_textBox.Location = new System.Drawing.Point(174, 14);
			this._frameSize_textBox.Name = "_frameSize_textBox";
			this._frameSize_textBox.Size = new System.Drawing.Size(75, 20);
			this._frameSize_textBox.TabIndex = 30;
			this._frameSize_textBox.TextChanged += new System.EventHandler(this._frameSize_textBox_TextChanged);
			this._frameSize_textBox.Validating += new System.ComponentModel.CancelEventHandler(this._frameSize_textBox_Validating);
			// 
			// _replaceShadow_checkBox
			// 
			this._replaceShadow_checkBox.AutoSize = true;
			this._replaceShadow_checkBox.Checked = true;
			this._replaceShadow_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this._replaceShadow_checkBox.Location = new System.Drawing.Point(407, 16);
			this._replaceShadow_checkBox.Name = "_replaceShadow_checkBox";
			this._replaceShadow_checkBox.Size = new System.Drawing.Size(108, 17);
			this._replaceShadow_checkBox.TabIndex = 33;
			this._replaceShadow_checkBox.Text = "Replace Shadow";
			this._replaceShadow_checkBox.UseVisualStyleBackColor = true;
			this._replaceShadow_checkBox.CheckedChanged += new System.EventHandler(this._replaceShadow_checkBox_CheckedChanged);
			// 
			// _pixOffset_checkBox
			// 
			this._pixOffset_checkBox.AutoSize = true;
			this._pixOffset_checkBox.Checked = true;
			this._pixOffset_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this._pixOffset_checkBox.Location = new System.Drawing.Point(521, 16);
			this._pixOffset_checkBox.Name = "_pixOffset_checkBox";
			this._pixOffset_checkBox.Size = new System.Drawing.Size(77, 17);
			this._pixOffset_checkBox.TabIndex = 34;
			this._pixOffset_checkBox.Text = "1 pix offset";
			this._pixOffset_checkBox.UseVisualStyleBackColor = true;
			this._pixOffset_checkBox.CheckedChanged += new System.EventHandler(this._pixOffset_checkBox_CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(768, 657);
			this.Controls.Add(this._pixOffset_checkBox);
			this.Controls.Add(this._replaceShadow_checkBox);
			this.Controls.Add(this._applyFrameSize_button);
			this.Controls.Add(this._frameSize_textBox);
			this.Controls.Add(this._export_button);
			this.Controls.Add(this._frame_trackBar);
			this.Controls.Add(this._frame_pictureBox);
			this.Controls.Add(this._horizontalRow_label);
			this.Controls.Add(this._horizontalRow_numericUpDown);
			this.Controls.Add(this._column_label);
			this.Controls.Add(this._column_numericUpDown);
			this.Controls.Add(this._drawGrid_checkBox);
			this.Controls.Add(this._rowTo_numericUpDown);
			this.Controls.Add(this._rowFrom_numericUpDown);
			this.Controls.Add(this._verticalRange_label);
			this.Controls.Add(this._playDirection_label);
			this.Controls.Add(this._vertical_checkBox);
			this.Controls.Add(this._horizontal_checkBox);
			this.Controls.Add(this._playSpeed_numericUpDown);
			this.Controls.Add(this._playSpeed_label);
			this.Controls.Add(this._nextFrame_button);
			this.Controls.Add(this._prevFrame_button);
			this.Controls.Add(this._stop_button);
			this.Controls.Add(this._play_button);
			this.Controls.Add(this._sheet_panel);
			this.Controls.Add(this._open_button);
			this.Name = "MainForm";
			this.Text = "Sprite Reader";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this._sheet_pictureBox)).EndInit();
			this._sheet_panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._playSpeed_numericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._rowFrom_numericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._rowTo_numericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._column_numericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._horizontalRow_numericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._frame_pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._frame_trackBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _open_button;
		private System.Windows.Forms.PictureBox _sheet_pictureBox;
		private System.Windows.Forms.Panel _sheet_panel;
		private System.Windows.Forms.Button _play_button;
		private System.Windows.Forms.Button _stop_button;
		private System.Windows.Forms.Button _prevFrame_button;
		private System.Windows.Forms.Button _nextFrame_button;
		private System.Windows.Forms.Label _playSpeed_label;
		private System.Windows.Forms.NumericUpDown _playSpeed_numericUpDown;
		private System.Windows.Forms.CheckBox _horizontal_checkBox;
		private System.Windows.Forms.CheckBox _vertical_checkBox;
		private System.Windows.Forms.Label _playDirection_label;
		private System.Windows.Forms.Label _verticalRange_label;
		private System.Windows.Forms.NumericUpDown _rowFrom_numericUpDown;
		private System.Windows.Forms.NumericUpDown _rowTo_numericUpDown;
		private System.Windows.Forms.CheckBox _drawGrid_checkBox;
		private System.Windows.Forms.NumericUpDown _column_numericUpDown;
		private System.Windows.Forms.Label _column_label;
		private System.Windows.Forms.NumericUpDown _horizontalRow_numericUpDown;
		private System.Windows.Forms.Label _horizontalRow_label;
		private System.Windows.Forms.PictureBox _frame_pictureBox;
		private System.Windows.Forms.TrackBar _frame_trackBar;
		private System.Windows.Forms.Button _export_button;
		private System.Windows.Forms.Button _applyFrameSize_button;
		private System.Windows.Forms.ToolTip _main_toolTip;
		private System.Windows.Forms.TextBox _frameSize_textBox;
		private System.Windows.Forms.CheckBox _replaceShadow_checkBox;
		private System.Windows.Forms.CheckBox _pixOffset_checkBox;
	}
}

