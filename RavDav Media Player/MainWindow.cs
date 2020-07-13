using System;
using System.Drawing;
using System.Windows.Forms;
namespace RavDav_Media_Player
{
    public partial class MainWindow : Form
    {
        // INITIALIZATION OF MEDIA PLAYER LOGIC
        private PlayerLogic PlayerObj = new PlayerLogic();
        // VOLUME VARIABLE FOR MUTE BEHAVIOUR
        private int volumebefore;
        // MD - MOUSE DOWN BEHAVIOUR
        // LL - LAST LOCATION
        private bool md;
        private Point ll;
        private bool mdtopbar;
        private Point lltopbar;
        // END OF INITIALIZATION
        // MAIN WINDOW INITIALIZATION
        public MainWindow()
        {
            InitializeComponent();
            //ADD ICON TO MAIN WINDOW TASKBAR FIX
            this.Icon = Properties.Resources.ikonai;
        }
        // END OF INITIALIZATION
        // BEHAVIORAL METHODS INITIALIZATION
        private void OpenButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog files = new OpenFileDialog())
            {
                PlayerObj.Dispose();
                files.Filter = "Mp3 Files| *.mp3";
                if (files.ShowDialog() == DialogResult.OK)
                {
                    PlayerObj.open(files.FileName);
                    PlayerObj.SetVolume(200);
                    VolumeTrackBar.Value = 200;
                    TagLib.File file = TagLib.File.Create(files.FileName);
                    ArtistLabel.Text = file.Tag.Title;
                    AlbumLabel.Text = file.Tag.Album;
                    YearLabel.Text = file.Tag.Year.ToString();
                    String LengthTrim = file.Properties.Duration.ToString();
                    LengthLabel.Text = LengthTrim.Substring(0, 8);
                    StatusLabel.Text = "Now Playing : " + files.SafeFileName;
                }
                else
                {
                    ArtistLabel.Text = " ";
                    LengthLabel.Text = " ";
                    AlbumLabel.Text = " ";
                    YearLabel.Text = " ";
                    StatusLabel.Text = "Status : Idle";
                }
            }
        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            PlayerObj.play();
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            PlayerObj.stop();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            PlayerObj.SetVolume(VolumeTrackBar.Value);
        }
        private void BalanceTrackBar_Scroll(object sender, EventArgs e)
        {
            PlayerObj.SetBalance(BalanceTrackBar.Value);
        }
        private void RepeatCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PlayerObj.RepeatChange(RepeatCheckBox.Checked);
            PlayerObj.stop();
            PlayerObj.play();
        }
        private void MuteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (VolumeTrackBar.Enabled == true)
            {
                volumebefore = VolumeTrackBar.Value;
                VolumeTrackBar.Enabled = false;
                BalanceTrackBar.Enabled = false;
                VolumeUpButton.Enabled = false;
                VolumeDownButton.Enabled = false;
                PlayerObj.SetVolume(0);
            }
            else
            {
                VolumeTrackBar.Value = volumebefore;
                VolumeTrackBar.Enabled = true;
                BalanceTrackBar.Enabled = true;
                VolumeUpButton.Enabled = true;
                VolumeDownButton.Enabled = true;
                PlayerObj.SetVolume(VolumeTrackBar.Value);
            }
        }
        private void LeftButton_Click(object sender, EventArgs e)
        {
            PlayerObj.BackToStart();
        }
        private void RightButton_Click(object sender, EventArgs e)
        {
            PlayerObj.GoToEnd();
        }
        private void VolumeDownButton_Click(object sender, EventArgs e)
        {

            if (VolumeTrackBar.Value != 0 && VolumeTrackBar.Value >= 15)
            {
                VolumeTrackBar.Value -= 15;
                PlayerObj.SetVolume(VolumeTrackBar.Value);
            }
            else if (VolumeTrackBar.Value != 0 && VolumeTrackBar.Value < 15)
            {
                VolumeTrackBar.Value = 0;
                PlayerObj.SetVolume(VolumeTrackBar.Value);
            }
            else
            {
                VolumeTrackBar.Value = 0;
                PlayerObj.SetVolume(VolumeTrackBar.Value);
            }
        }
        private void VolumeUpButton_Click(object sender, EventArgs e)
        {
            if (VolumeTrackBar.Value == 1000)
            {
                VolumeTrackBar.Value = 1000;
                PlayerObj.SetVolume(VolumeTrackBar.Value);
            }
            else if (VolumeTrackBar.Value <= 985)
            {
                VolumeTrackBar.Value += 15;
                PlayerObj.SetVolume(VolumeTrackBar.Value);
            }
            else
            {
                VolumeTrackBar.Value = 1000;
                PlayerObj.SetVolume(VolumeTrackBar.Value);
            }
        }
        // END OF BEHAVIORAL INITIALIZATION
        // BORDERLESS DRAGGING ONLY FOR OBJECT FORM
        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            md = true;
            ll = e.Location;
        }
        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            mdtopbar = true;
            lltopbar = e.Location;
        }
        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (md)
            {
                this.Location = new Point(
                    (this.Location.X - ll.X) + e.X, (this.Location.Y - ll.Y) + e.Y);

                this.Update();
            }
        }
        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mdtopbar)
            {
                this.Location = new Point(
                    (this.Location.X - lltopbar.X) + e.X, (this.Location.Y - lltopbar.Y) + e.Y);

                this.Update();
            }
        }
        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            md = false;
        }
        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            mdtopbar = false;
        }
        // END OF DRAGGING OBJECT INITIALIZATION
    }
}
