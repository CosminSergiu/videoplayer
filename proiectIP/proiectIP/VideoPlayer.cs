

using System;
using AxWMPLib;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace proiectIP
{
    public class VideoPlayer
    {
        private VideoState _currentState;
        private bool _isLooping = false;

        public bool IsLooping
        {
            get
            {
                return _isLooping;
            }
        }
        public VideoState videoState
        {
            get { return _currentState; }
            set { _currentState = value; }
        }
        public string Path
        {
            get { return _currentState.Path; }
            set { _currentState.Path = value; }
        }
        public void Execute()
        {
            try
            {
                _currentState.Execute();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void SetNextState(AxWindowsMediaPlayer screenPlayer, State state)
        {
            switch (state)
            {
                case State.Play:
                    _currentState = new PlayState(screenPlayer);
                    break;
                case State.Pause:
                    _currentState = new PauseState(screenPlayer);
                    break;
                case State.Stop:
                    _currentState = new StopState(screenPlayer);
                    break;
            }
        }
        public void SetCurrentState(AxWindowsMediaPlayer screenPlayer, State state)//TODO enum in loc de string
        {
            switch (screenPlayer.playState)
            {
                case WMPPlayState.wmppsPlaying:
                    if (state == State.Play)
                        state = State.Pause;
                    SetNextState(screenPlayer, state);
                    break;
                
                default:
                    SetNextState(screenPlayer, state);
                    break;
            }
        }
        public void SetVolume(int value)
        {
            _currentState.SetVolume(value);
        }
        public void GenerateFullPath()
        {
            try
            {
                string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;              
                string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\\..\\..\\video\\");  
                string sFilePath = System.IO.Path.GetFullPath(sFile); 
                Path = sFilePath + Path;
                _currentState.SetPlayerURL();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void LoopState()
        {
            _isLooping = !_isLooping;
        }
        /*public void setCurrentState(string path, AxWindowsMediaPlayer screenPlayer) 
        {
            string extension = Path.GetExtension(path)?.ToLower();
            switch (extension)
            {
                case ".mp4":
                    _currentState = new Mp4State(path, screenPlayer);
                    // Utilizați clasa MP4Video pentru videoclipuri de tip .mp4
                    break;
                case ".avi":
                    //AviState aviVideo = new AviState(path,screenPlayer);
                    // Utilizați clasa AVIVideo pentru videoclipuri de tip .avi
                    break;
                case ".mov":
                    //MovState movVideo = new MovState(path, screenPlayer);
                    // Utilizați clasa MOVVideo pentru videoclipuri de tip .mov
                    break;
                default:
                    // Gestiunea extensiilor neașteptate sau lipsește o clasă specifică
                    break;
            }
        }*/
        
        
        /*public void Play()
        {
            _currentState.Play();
        }

        public void Pause()
        {
            _currentState.Pause();
        }

        public void Stop()
        {
            _currentState.Stop();
        }

        public void SetVolume(int volume)
        {
            _currentState.setVolume(volume);
        }

        public void MuteMode()
        {
            _currentState.setVolume(0);
        }*/

        public void MuteMode()
        {
            _currentState.MuteMode();
        }
    }
}