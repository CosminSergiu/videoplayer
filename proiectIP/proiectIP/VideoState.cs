using AxMSVidCtlLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AxWMPLib;


namespace proiectIP
{
    public abstract class VideoState
    {
        protected AxWindowsMediaPlayer _player;
        private int _volume = 0;
        protected string _path;
        //UITE TE CUM SE SCRIE PROTECTED IN STANDARD
        //TODO

        public VideoState(AxWindowsMediaPlayer player)
        {
            _player = player;
        }
        //void Play();
       //void Pause();
       //void Stop();
       public string Path   // property
       {
           get { return _path; }   // get method
           set
           {
               _path = value;
           }  // set method
       }

       abstract public void Execute();
       
       public void SetVolume(int value)
       {
           _player.settings.volume = value;
       }

       
       public void MuteMode()
       {
           if (_player.settings.volume == 0)
           {
               _player.settings.volume = _volume;
           }
           else
           {
               _volume = _player.settings.volume;
               _player.settings.volume = 0;
           }
           
           
       }

       public void SetPlayerURL()
       {
           _player.URL = Path;
       }
    }
}
