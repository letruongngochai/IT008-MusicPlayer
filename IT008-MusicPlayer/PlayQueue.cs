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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (trackList.SelectedIndex > 0)
                trackList.SelectedIndex -= 1;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (trackList.SelectedIndex < trackList.Items.Count - 1)
                trackList.SelectedIndex += 1;
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            if (trackList.Items.Count > 0)
            {
                HomeScreen.paths = HomeScreen.paths.Except(new string[] { trackList.SelectedItem.ToString() }).ToArray();
                Variables.TrackQueue.TrackList.Remove(trackList.SelectedItem.ToString());
                trackList.Items.RemoveAt(trackList.SelectedIndex);
                Variables.MediaPlayer.Player.Ctlcontrols.stop();
            }
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.Black;
        }

        private void iconButton4_MouseLeave(object sender, EventArgs e)
        {
            iconButton4.BackColor = Color.Black;
        }

        private void iconButton9_MouseLeave(object sender, EventArgs e)
        {
            iconButton9.BackColor = Color.Black;
        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.DarkRed;
        }

        private void iconButton4_MouseEnter(object sender, EventArgs e)
        {
            iconButton4.BackColor = Color.DarkRed;
        }

        private void iconButton9_MouseEnter(object sender, EventArgs e)
        {
            iconButton9.BackColor = Color.DarkRed;
        }
    }
}
