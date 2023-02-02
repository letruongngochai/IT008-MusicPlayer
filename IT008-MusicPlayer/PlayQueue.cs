using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT008_MusicPlayer
{
    public partial class PlayQueue : Form
    {
        public PlayQueue()
        {
            InitializeComponent();
            ShowQueue();
            trackList.SelectedIndexChanged += new System.EventHandler(this.trackList_SelectedIndexChanged);
            if (trackList.Items.Count > 0 && Variables.MediaPlayer.Player.playState != WMPLib.WMPPlayState.wmppsPlaying)
                trackList.SelectedIndex = 0;
        }
        private void trackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (trackList.SelectedItem != null)
            {
                Variables.MediaPlayer.Player.URL = HomeScreen.paths[trackList.SelectedIndex];
                Variables.MediaPlayer.Player.Ctlcontrols.play();
                MusicJoy.isPause = true;
            }
        }
        private void ShowQueue()
        {
            foreach (var item in Variables.TrackQueue.TrackList)
            {
                trackList.Items.Add(item);
            }
        }
    }
}
