using System;
using System.Runtime.InteropServices;
using System.Text;

namespace RavDav_Media_Player
{
    class PlayerLogic
    {
        // IMPORTING PLAYER LIBRARY
        [DllImport("winmm.dll")]
        // PLAYER LIBRARY INITIALIZATION
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hwdCallBack);
        // VARIOUS VARIABLES FOR BEHAVIORAL METHODS
        public bool repeatenabled = false;
        public ulong songLength = 0;
        public bool isPlaying = false;
        // LIBRARY METHODS WRAPPER
        public void open(string File)
        {
            string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";
            string command = string.Format(Format, File);
            mciSendString(command, null, 0, IntPtr.Zero);
            StringBuilder sb = new StringBuilder(128);
            mciSendString("status mediafile length", sb, 128, IntPtr.Zero);
            songLength = Convert.ToUInt64(sb.ToString());
        }
        public void play()
        {
            isPlaying = true;
            string command = "play MediaFile";
            if (repeatenabled) command += " REPEAT";
            else command = "play MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);

        }
        public void stop()
        {
            isPlaying = false;
            string command = "stop MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }
        public void SetVolume(int volume)
        {
            var command = "setaudio MediaFile volume to " + volume.ToString();
            mciSendString(command, null, 0, IntPtr.Zero);
        }
        public void Dispose()
        {
            isPlaying = false;
            string command = "close MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }
        public void RepeatChange(bool value)
        {
            repeatenabled = value;
        }
        public void BackToStart()
        {
            string command = "seek MediaFile to start";
            mciSendString(command, null, 0, IntPtr.Zero);
        }
        public void GoToEnd()
        {
            string command = "seek MediaFile to " + songLength;
            mciSendString(command, null, 0, IntPtr.Zero);
        }
        public void RecordingTimeNow(out long timenow) {
            string command = "status MediaFile position";
            timenow = mciSendString(command, null, 0, IntPtr.Zero);
        }
        public void SetBalance(int balance)
        {
            if (balance >= 0 && balance <= 1000)
            {
                string command = "setaudio MediaFile left volume to " + (1000 - balance).ToString();
                string command2 = "setaudio MediaFile right volume to " + balance.ToString();
                mciSendString(command, null, 0, IntPtr.Zero);
                mciSendString(command2, null, 0, IntPtr.Zero);
            }
            else
            {

            }    
        }
        // END OF METHODS WRAPPER
    }
}
