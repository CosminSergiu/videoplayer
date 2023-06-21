using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxWMPLib;

namespace proiectIP
{
    public class StopState:VideoState
    {
        public override void Execute()
        {
            _player.Ctlcontrols.stop();
        }

        public StopState(AxWindowsMediaPlayer player) : base(player)
        {
        }
    }
}
