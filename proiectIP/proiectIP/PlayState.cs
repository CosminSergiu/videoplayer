using System;
using System.Reflection;
using System.Windows.Forms;
using AxMSVidCtlLib;
using AxWMPLib;

namespace proiectIP
{
    public class PlayState:VideoState
    {
        public override void Execute()
        {
            _player.Ctlcontrols.play();
        }

        public PlayState(AxWindowsMediaPlayer player) : base(player)
        {
        }


    }
    /*public class Mp4State : IVideoState
    {
        private string _path="";
        private AxWindowsMediaPlayer _player;
        
        public Mp4State(string path, AxWindowsMediaPlayer player )
        {
            try
            {
                string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;              
                string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\\..\\..\\video\\");  
                string sFilePath = System.IO.Path.GetFullPath(sFile);
                _path += sFilePath + path;
                _player = player;
                _player.URL = _path;
                _player.settings.volume = 25;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
        public void Pause()
        {
            _player.Ctlcontrols.pause();
        }
        public void setVolume(int range)
        { 
            _player.settings.volume = range;
        }

        public void Play()
        {
            _player.Ctlcontrols.play();

        }
        public void Stop()
        {
            _player.Ctlcontrols.stop();
        }
    }*/
}