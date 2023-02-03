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
    public partial class PlaylistForAddingItem : UserControl
    {
        public string playlistID, musicID;
        public PlaylistForAddingItem()
        {
            InitializeComponent();
        }

        private void PlaylistForAddingItem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"insert into PLAYLIST_DETAIL values('{playlistID}', '{musicID}', '{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt")}')";
                DataProvider provider = new DataProvider();
                provider.ExecuteNonQuery(query);
                BackColor = Color.Green;
            }
            catch (Exception)
            {
                MessageBox.Show("This playlist already contained your chosen music!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public PlaylistForAddingItem(DataRow dr, string ID)
        {
            InitializeComponent();
            if (!File.Exists(dr["playlist_logo"].ToString().TrimEnd()))
            {
                pictureBox1.BackgroundImage = (Bitmap)ImageData.ResourceManager.GetObject("playlist");
                //MessageBox.Show("true");
            }
            else
            {
                /*MessageBox.Show("false");*/
                pictureBox1.BackgroundImage = Image.FromFile(dr["playlist_logo"].ToString().TrimEnd());
            }
            label1.Text = dr["playlist_name"].ToString();
            playlistID = dr["playlist_id"].ToString();
            musicID = ID;
        }

    }
}
