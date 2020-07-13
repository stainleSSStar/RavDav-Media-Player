namespace RavDav_Media_Player
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopBar = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.RepeatCheckBox = new System.Windows.Forms.CheckBox();
            this.VolumeUpButton = new System.Windows.Forms.Button();
            this.VolumeDownButton = new System.Windows.Forms.Button();
            this.MuteCheckbox = new System.Windows.Forms.CheckBox();
            this.ArtistLabel = new System.Windows.Forms.Label();
            this.AlbumLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.BalanceTrackBar = new System.Windows.Forms.TrackBar();
            this.BalanceSignButton = new System.Windows.Forms.Button();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.Black;
            this.TopBar.Controls.Add(this.ExitButton);
            this.TopBar.Controls.Add(this.label1);
            this.TopBar.Controls.Add(this.StatusLabel);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(745, 55);
            this.TopBar.TabIndex = 0;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(682, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(63, 55);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "RavDav Media Player";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Black;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(276, 31);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(12, 16);
            this.StatusLabel.TabIndex = 9;
            this.StatusLabel.Text = " ";
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.Color.Black;
            this.OpenButton.FlatAppearance.BorderSize = 0;
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Image = global::RavDav_Media_Player.Properties.Resources.baseline_folder_open_white_18dp;
            this.OpenButton.Location = new System.Drawing.Point(26, 394);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(55, 62);
            this.OpenButton.TabIndex = 3;
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LeftButton.FlatAppearance.BorderSize = 0;
            this.LeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftButton.Image = global::RavDav_Media_Player.Properties.Resources.baseline_skip_previous_white_18dp;
            this.LeftButton.Location = new System.Drawing.Point(87, 394);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(65, 62);
            this.LeftButton.TabIndex = 3;
            this.LeftButton.UseVisualStyleBackColor = false;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Image = global::RavDav_Media_Player.Properties.Resources.baseline_play_arrow_white_18dp;
            this.PlayButton.Location = new System.Drawing.Point(158, 398);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(55, 55);
            this.PlayButton.TabIndex = 3;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RightButton.FlatAppearance.BorderSize = 0;
            this.RightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightButton.Image = global::RavDav_Media_Player.Properties.Resources.baseline_skip_next_white_18dp;
            this.RightButton.Location = new System.Drawing.Point(280, 398);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(55, 55);
            this.RightButton.TabIndex = 3;
            this.RightButton.UseVisualStyleBackColor = false;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StopButton.FlatAppearance.BorderSize = 0;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StopButton.Image = global::RavDav_Media_Player.Properties.Resources.baseline_pause_white_18dp;
            this.StopButton.Location = new System.Drawing.Point(219, 398);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(55, 55);
            this.StopButton.TabIndex = 3;
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VolumeTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VolumeTrackBar.LargeChange = 10;
            this.VolumeTrackBar.Location = new System.Drawing.Point(682, 101);
            this.VolumeTrackBar.Maximum = 1000;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.VolumeTrackBar.Size = new System.Drawing.Size(45, 256);
            this.VolumeTrackBar.SmallChange = 5;
            this.VolumeTrackBar.TabIndex = 5;
            this.VolumeTrackBar.TickFrequency = 200;
            this.VolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.VolumeTrackBar.Value = 200;
            this.VolumeTrackBar.Scroll += new System.EventHandler(this.VolumeTrackBar_Scroll);
            // 
            // RepeatCheckBox
            // 
            this.RepeatCheckBox.AutoSize = true;
            this.RepeatCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RepeatCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RepeatCheckBox.Image = global::RavDav_Media_Player.Properties.Resources.baseline_repeat_white_18dp;
            this.RepeatCheckBox.Location = new System.Drawing.Point(601, 407);
            this.RepeatCheckBox.Name = "RepeatCheckBox";
            this.RepeatCheckBox.Size = new System.Drawing.Size(51, 36);
            this.RepeatCheckBox.TabIndex = 6;
            this.RepeatCheckBox.UseVisualStyleBackColor = false;
            this.RepeatCheckBox.CheckedChanged += new System.EventHandler(this.RepeatCheckBox_CheckedChanged);
            // 
            // VolumeUpButton
            // 
            this.VolumeUpButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VolumeUpButton.BackgroundImage = global::RavDav_Media_Player.Properties.Resources.baseline_volume_up_white_18dp;
            this.VolumeUpButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.VolumeUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VolumeUpButton.Location = new System.Drawing.Point(682, 61);
            this.VolumeUpButton.Name = "VolumeUpButton";
            this.VolumeUpButton.Size = new System.Drawing.Size(40, 34);
            this.VolumeUpButton.TabIndex = 7;
            this.VolumeUpButton.UseVisualStyleBackColor = false;
            this.VolumeUpButton.Click += new System.EventHandler(this.VolumeUpButton_Click);
            // 
            // VolumeDownButton
            // 
            this.VolumeDownButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VolumeDownButton.BackgroundImage = global::RavDav_Media_Player.Properties.Resources.baseline_volume_down_white_18dp;
            this.VolumeDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VolumeDownButton.Location = new System.Drawing.Point(682, 351);
            this.VolumeDownButton.Name = "VolumeDownButton";
            this.VolumeDownButton.Size = new System.Drawing.Size(40, 34);
            this.VolumeDownButton.TabIndex = 8;
            this.VolumeDownButton.UseVisualStyleBackColor = false;
            this.VolumeDownButton.Click += new System.EventHandler(this.VolumeDownButton_Click);
            // 
            // MuteCheckbox
            // 
            this.MuteCheckbox.AutoSize = true;
            this.MuteCheckbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MuteCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MuteCheckbox.Image = global::RavDav_Media_Player.Properties.Resources.baseline_volume_off_white_18dp;
            this.MuteCheckbox.Location = new System.Drawing.Point(535, 407);
            this.MuteCheckbox.Name = "MuteCheckbox";
            this.MuteCheckbox.Size = new System.Drawing.Size(51, 36);
            this.MuteCheckbox.TabIndex = 6;
            this.MuteCheckbox.UseVisualStyleBackColor = false;
            this.MuteCheckbox.CheckedChanged += new System.EventHandler(this.MuteCheckBox_CheckedChanged);
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.AutoSize = true;
            this.ArtistLabel.BackColor = System.Drawing.Color.Black;
            this.ArtistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArtistLabel.ForeColor = System.Drawing.Color.White;
            this.ArtistLabel.Location = new System.Drawing.Point(26, 81);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Size = new System.Drawing.Size(16, 24);
            this.ArtistLabel.TabIndex = 9;
            this.ArtistLabel.Text = " ";
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.AutoSize = true;
            this.AlbumLabel.BackColor = System.Drawing.Color.Black;
            this.AlbumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AlbumLabel.ForeColor = System.Drawing.Color.White;
            this.AlbumLabel.Location = new System.Drawing.Point(26, 116);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(16, 24);
            this.AlbumLabel.TabIndex = 9;
            this.AlbumLabel.Text = " ";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.BackColor = System.Drawing.Color.Black;
            this.LengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LengthLabel.ForeColor = System.Drawing.Color.White;
            this.LengthLabel.Location = new System.Drawing.Point(26, 152);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(16, 24);
            this.LengthLabel.TabIndex = 9;
            this.LengthLabel.Text = " ";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.BackColor = System.Drawing.Color.Black;
            this.YearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.YearLabel.ForeColor = System.Drawing.Color.White;
            this.YearLabel.Location = new System.Drawing.Point(26, 186);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(16, 24);
            this.YearLabel.TabIndex = 9;
            this.YearLabel.Text = " ";
            // 
            // BalanceTrackBar
            // 
            this.BalanceTrackBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BalanceTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BalanceTrackBar.LargeChange = 200;
            this.BalanceTrackBar.Location = new System.Drawing.Point(553, 329);
            this.BalanceTrackBar.Maximum = 1000;
            this.BalanceTrackBar.Name = "BalanceTrackBar";
            this.BalanceTrackBar.Size = new System.Drawing.Size(75, 45);
            this.BalanceTrackBar.SmallChange = 100;
            this.BalanceTrackBar.TabIndex = 5;
            this.BalanceTrackBar.TickFrequency = 200;
            this.BalanceTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.BalanceTrackBar.Value = 500;
            this.BalanceTrackBar.Scroll += new System.EventHandler(this.BalanceTrackBar_Scroll);
            // 
            // BalanceSignButton
            // 
            this.BalanceSignButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BalanceSignButton.BackgroundImage = global::RavDav_Media_Player.Properties.Resources.baseline_hearing_white_18dp;
            this.BalanceSignButton.Enabled = false;
            this.BalanceSignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BalanceSignButton.Location = new System.Drawing.Point(571, 289);
            this.BalanceSignButton.Name = "BalanceSignButton";
            this.BalanceSignButton.Size = new System.Drawing.Size(40, 34);
            this.BalanceSignButton.TabIndex = 8;
            this.BalanceSignButton.UseVisualStyleBackColor = false;
            this.BalanceSignButton.Click += new System.EventHandler(this.VolumeDownButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::RavDav_Media_Player.Properties.Resources.FormBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(745, 465);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.AlbumLabel);
            this.Controls.Add(this.ArtistLabel);
            this.Controls.Add(this.BalanceSignButton);
            this.Controls.Add(this.VolumeDownButton);
            this.Controls.Add(this.VolumeUpButton);
            this.Controls.Add(this.MuteCheckbox);
            this.Controls.Add(this.RepeatCheckBox);
            this.Controls.Add(this.BalanceTrackBar);
            this.Controls.Add(this.VolumeTrackBar);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.TopBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.CheckBox RepeatCheckBox;
        private System.Windows.Forms.Button VolumeUpButton;
        private System.Windows.Forms.Button VolumeDownButton;
        private System.Windows.Forms.CheckBox MuteCheckbox;
        private System.Windows.Forms.Label ArtistLabel;
        private System.Windows.Forms.Label AlbumLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TrackBar BalanceTrackBar;
        private System.Windows.Forms.Button BalanceSignButton;
    }
}

