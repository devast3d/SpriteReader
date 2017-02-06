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
			this.button1 = new System.Windows.Forms.Button();
			this._sheet_pictureBox = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this._play_button = new System.Windows.Forms.Button();
			this._stop_button = new System.Windows.Forms.Button();
			this._prevFrame_button = new System.Windows.Forms.Button();
			this._nextFrame_button = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this._horizontal_checkBox = new System.Windows.Forms.CheckBox();
			this._vertical_checkBox = new System.Windows.Forms.CheckBox();
			this._playDirection_label = new System.Windows.Forms.Label();
			this._verticalRange_label = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
			this._column_label = new System.Windows.Forms.Label();
			this._horizontalRow_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this._horizontalRow_label = new System.Windows.Forms.Label();
			this._frame_pictureBox = new System.Windows.Forms.PictureBox();
			this._frame_trackBar = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this._sheet_pictureBox)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._horizontalRow_numericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._frame_pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._frame_trackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Open";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoScroll = true;
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this._sheet_pictureBox);
			this.panel1.Location = new System.Drawing.Point(12, 197);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(744, 448);
			this.panel1.TabIndex = 4;
			// 
			// _play_button
			// 
			this._play_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._play_button.Location = new System.Drawing.Point(12, 41);
			this._play_button.Name = "_play_button";
			this._play_button.Size = new System.Drawing.Size(35, 23);
			this._play_button.TabIndex = 5;
			this._play_button.Text = "►";
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
			this._nextFrame_button.UseVisualStyleBackColor = true;
			this._nextFrame_button.Click += new System.EventHandler(this._nextFrame_button_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(188, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Play Speed";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.DecimalPlaces = 2;
			this.numericUpDown1.Location = new System.Drawing.Point(255, 44);
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
			this.numericUpDown1.TabIndex = 11;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
			this._vertical_checkBox.Enabled = false;
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
			this._verticalRange_label.Location = new System.Drawing.Point(12, 147);
			this._verticalRange_label.Name = "_verticalRange_label";
			this._verticalRange_label.Size = new System.Drawing.Size(77, 13);
			this._verticalRange_label.TabIndex = 18;
			this._verticalRange_label.Text = "Vertical Range";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(93, 145);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(35, 20);
			this.numericUpDown2.TabIndex = 19;
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(134, 145);
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(35, 20);
			this.numericUpDown3.TabIndex = 20;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.Location = new System.Drawing.Point(93, 16);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(73, 17);
			this.checkBox3.TabIndex = 21;
			this.checkBox3.Text = "Draw Grid";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// numericUpDown4
			// 
			this.numericUpDown4.Location = new System.Drawing.Point(255, 145);
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.Size = new System.Drawing.Size(75, 20);
			this.numericUpDown4.TabIndex = 22;
			// 
			// _column_label
			// 
			this._column_label.AutoSize = true;
			this._column_label.Location = new System.Drawing.Point(207, 147);
			this._column_label.Name = "_column_label";
			this._column_label.Size = new System.Drawing.Size(42, 13);
			this._column_label.TabIndex = 23;
			this._column_label.Text = "Column";
			// 
			// _horizontalRow_numericUpDown
			// 
			this._horizontalRow_numericUpDown.Location = new System.Drawing.Point(93, 171);
			this._horizontalRow_numericUpDown.Name = "_horizontalRow_numericUpDown";
			this._horizontalRow_numericUpDown.Size = new System.Drawing.Size(75, 20);
			this._horizontalRow_numericUpDown.TabIndex = 25;
			this._horizontalRow_numericUpDown.ValueChanged += new System.EventHandler(this._horizontalRow_numericUpDown_ValueChanged);
			// 
			// _horizontalRow_label
			// 
			this._horizontalRow_label.AutoSize = true;
			this._horizontalRow_label.Location = new System.Drawing.Point(12, 173);
			this._horizontalRow_label.Name = "_horizontalRow_label";
			this._horizontalRow_label.Size = new System.Drawing.Size(79, 13);
			this._horizontalRow_label.TabIndex = 26;
			this._horizontalRow_label.Text = "Horizontal Row";
			// 
			// _frame_pictureBox
			// 
			this._frame_pictureBox.BackColor = System.Drawing.Color.White;
			this._frame_pictureBox.Location = new System.Drawing.Point(336, 12);
			this._frame_pictureBox.Name = "_frame_pictureBox";
			this._frame_pictureBox.Size = new System.Drawing.Size(160, 160);
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(768, 657);
			this.Controls.Add(this._frame_trackBar);
			this.Controls.Add(this._frame_pictureBox);
			this.Controls.Add(this._horizontalRow_label);
			this.Controls.Add(this._horizontalRow_numericUpDown);
			this.Controls.Add(this._column_label);
			this.Controls.Add(this.numericUpDown4);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.numericUpDown3);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this._verticalRange_label);
			this.Controls.Add(this._playDirection_label);
			this.Controls.Add(this._vertical_checkBox);
			this.Controls.Add(this._horizontal_checkBox);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._nextFrame_button);
			this.Controls.Add(this._prevFrame_button);
			this.Controls.Add(this._stop_button);
			this.Controls.Add(this._play_button);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "Sprite Reader";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this._sheet_pictureBox)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._horizontalRow_numericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._frame_pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._frame_trackBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox _sheet_pictureBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button _play_button;
		private System.Windows.Forms.Button _stop_button;
		private System.Windows.Forms.Button _prevFrame_button;
		private System.Windows.Forms.Button _nextFrame_button;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.CheckBox _horizontal_checkBox;
		private System.Windows.Forms.CheckBox _vertical_checkBox;
		private System.Windows.Forms.Label _playDirection_label;
		private System.Windows.Forms.Label _verticalRange_label;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.NumericUpDown numericUpDown4;
		private System.Windows.Forms.Label _column_label;
		private System.Windows.Forms.NumericUpDown _horizontalRow_numericUpDown;
		private System.Windows.Forms.Label _horizontalRow_label;
		private System.Windows.Forms.PictureBox _frame_pictureBox;
		private System.Windows.Forms.TrackBar _frame_trackBar;
	}
}

