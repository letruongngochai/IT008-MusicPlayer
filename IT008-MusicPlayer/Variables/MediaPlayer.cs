using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT008_MusicPlayer.Variables
{
    class MediaPlayer
    {
        private static AxWMPLib.AxWindowsMediaPlayer player = new AxWMPLib.AxWindowsMediaPlayer()
        {
            Dock = System.Windows.Forms.DockStyle.Fill,
        };

        public static AxWMPLib.AxWindowsMediaPlayer Player
        {
            get
            {
                player.CreateControl();
                return player;
            }
        }
    }
}
