using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxWMPLib;

namespace proiectIP
{
    public class PauseState:VideoState
    {
        public override void Execute()
        {
            _player.Ctlcontrols.pause();
        }

        public PauseState(AxWindowsMediaPlayer player) : base(player)
        {
        }
    }
}
