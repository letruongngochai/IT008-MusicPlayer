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

namespace IT008_MusicPlayer
{
    public partial class PlaylistScreen : Form
    {
        static Bitmap defaultCoverImg = (Bitmap)ImageData.ResourceManager.GetObject("playlist");
        static string imgPath = "";
        public PlaylistScreen()
        {
            InitializeComponent();
            LoadPlayList();
            Variables.ListFormPanel.ListFormsPanel.Add(playlistItemPanel);
        }
        private void LoadPlayList()
        {
            playlistPanel.Controls.Clear();
            string query = "SELECT * FROM PLAYLIST";

            DataProvider provider = new DataProvider();
            DataTable dtShowMyList = provider.ExecuteQuery(query);
            //this.label_soluongLP.Text = dtShowMyList.Rows.Count.ToString();

            foreach (DataRow row in dtShowMyList.Rows)
            {
                CustomControl.PlaylistItem item = new CustomControl.PlaylistItem(row);
                item.iconButton1.Click += new EventHandler(removePlaylistClick);
                item.iconButton1.Name = row["playlist_id"].ToString();
                playlistPanel.Controls.Add(item);
            }
        }
        private void removePlaylistClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this playlist?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                string playlistID = (sender as FontAwesome.Sharp.IconButton).Name;
                DataProvider provider = new DataProvider();
                string query = $"delete from PLAYLIST where playlist_id = '{playlistID}'";
                provider.ExecuteNonQuery(query);
                query = $"delete from PLAYLIST_DETAIL where playlist_id = '{playlistID}'";
                provider.ExecuteNonQuery(query);
                LoadPlayList();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = new Bitmap(ofd.FileName);
                imgPath = ofd.FileName;
            }
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            newPlaylistPanel.Visible = true;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            newPlaylistPanel.Visible = false;

            AddPlaylist();

            tbName.Text = "";
            pictureBox1.BackgroundImage = defaultCoverImg;
        }
        private void AddPlaylist()
        {
            string query;
            DataProvider provider = new DataProvider();
            query = "select * from PLAYLIST";
            DataTable dt = provider.ExecuteQuery(query);

            int number_of_playlist = Convert.ToInt16(dt.AsEnumerable().Last()["playlist_id"].ToString().Substring(2));

            query = $"select * from PLAYLIST where playlist_name = N'{tbName.Text}'";
            dt = provider.ExecuteQuery(query);
            if (dt.Rows.Count != 0)
                MessageBox.Show("Playlist Existed!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string a;
                number_of_playlist++;
                if (number_of_playlist < 10)
                    a = "0" + number_of_playlist.ToString();
                else
                    a = number_of_playlist.ToString();

                query = $"insert into PLAYLIST values('pl{a}', N'{tbName.Text}', '{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt")}', N'{imgPath}')";
                provider.ExecuteNonQuery(query);
            }
            LoadPlayList();
        }

        private void PlaylistScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Variables.ListFormPanel.ListFormsPanel.RemoveAt(Variables.ListFormPanel.ListFormsPanel.Count - 1);
        }
    }
}
