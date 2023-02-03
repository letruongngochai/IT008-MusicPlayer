using IT008_MusicPlayer.Databases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT008_MusicPlayer.CustomControl
{
    public partial class PlaylistItem : UserControl
    {
        public string ID;
        public bool isSelected = false;
        public PlaylistItem()
        {
            InitializeComponent();
        }
        public PlaylistItem(DataRow dr)
        {
            InitializeComponent();
            if (!File.Exists(dr["playlist_logo"].ToString().TrimEnd()))
            {
                pictureBox1.BackgroundImage = (Bitmap)ImageData.ResourceManager.GetObject("playlist");
                //MessageBox.Show(dr["playlist_logo"].ToString().TrimEnd());
            }
            else
            {
                /*MessageBox.Show("false");*/
                pictureBox1.BackgroundImage = Image.FromFile(dr["playlist_logo"].ToString().TrimEnd());
            }
            //pictureBox1.BackgroundImage = Image.FromFile(dr["playlist_logo"].ToString());
            playlistName.Text = dr["playlist_name"].ToString();
            playlistTime.Text = dr["playlist_time"].ToString();
            ID = dr["playlist_ID"].ToString();
        }

        private void PlaylistItem_Click(object sender, EventArgs e)
        {
            isSelected = !isSelected;
            if (isSelected == true)
            {
                //BackColor = Color.DarkBlue;
            }
            else
            {
                //BackColor = Color.PaleTurquoise;
            }
            Load_MusicInPlaylist(ID);
        }
        private void Load_MusicInPlaylist(string id)
        {
            Variables.ListFormPanel.ListFormsPanel[1].Controls.Clear();
            string query = $"select [music_name] , [singer_name], [playlist_id], PLAYLIST_DETAIL.music_id, PLAYLIST_DETAIL.music_playlist_time, [music_name] from PLAYLIST_DETAIL inner join MUSIC on PLAYLIST_DETAIL.music_id = MUSIC.music_id where playlist_id = '{id}'";

            DataProvider provider = new DataProvider();
            DataTable dtShowMyList = provider.ExecuteQuery(query);
            if (dtShowMyList.Rows.Count > 0)
            {

                foreach (DataRow row in dtShowMyList.Rows)
                {
                    CustomControl.PlaylistMusicItem item = new CustomControl.PlaylistMusicItem(row);
                    Variables.ListFormPanel.ListFormsPanel[1].Controls.Add(item);
                }
            }
        }
    }
}
