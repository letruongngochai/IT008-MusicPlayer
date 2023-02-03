using IT008_MusicPlayer.Databases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT008_MusicPlayer.CustomControl
{
    public partial class PlaylistMusicItem : UserControl
    {
        public string playlistID, musicID;
        Form activeForm = null;
        public PlaylistMusicItem()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();

            string query = $"delete from PLAYLIST_DETAIL where playlist_id = '{playlistID}' and PLAYLIST_DETAIL.music_id = '{musicID}'";

            //string query = $"update MUSIC set music_love_status = {i} where music_id = '{id}'";

            provider.ExecuteNonQuery(query);
            Load_MusicInPlaylist(playlistID);
        }

        public PlaylistMusicItem(DataRow dr)
        {
            InitializeComponent();
            label1.Text = dr["music_name"].ToString();
            label2.Text = dr["singer_name"].ToString();
            pictureBox1.BackgroundImage = (Bitmap)ImageData.ResourceManager.GetObject(dr["music_id"].ToString());
            playlistID = dr["playlist_id"].ToString();
            musicID = dr["music_id"].ToString();
        }

        private void PlaylistMusicItem_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string query = $"select * from MUSIC where music_id = '{musicID}'";
            DataTable dt = provider.ExecuteQuery(query);
            LoadChildForm(new MusicDetail((Bitmap)pictureBox1.BackgroundImage, dt));
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
        public void LoadChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            Variables.ListFormPanel.ListFormsPanel[0].Controls.Add(childForm);
            Variables.ListFormPanel.ListFormsPanel[0].Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}
