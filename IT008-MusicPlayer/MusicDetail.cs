using FontAwesome.Sharp;
using IT008_MusicPlayer.CustomControl;
using IT008_MusicPlayer.Databases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT008_MusicPlayer.CustomControl
{
    public partial class MusicDetail : Form
    {
        DataTable dt;
        string ID;
        private Form activeForm = null;
        public MusicDetail()
        {
            InitializeComponent();
            LoadMouseEnterAndLeave();
        }
        public MusicDetail(Bitmap bm, DataTable dtMusic) : this()
        {
            dt = dtMusic;
            musicPicture.BackgroundImage = bm;
            DataRow dr = dtMusic.Rows[0];
            lbName.Text = dr["music_name"].ToString();
            lbAuthor.Text = dr["music_author"].ToString();
            lbSinger.Text = dr["singer_name"].ToString();
            lbType.Text = dr["music_category"].ToString();
            lbLength.Text = dr["music_time"].ToString();
            lbYear.Text = dr["music_release"].ToString();
            lbFreq.Text = dr["music_freq"].ToString();
            lbCountry.Text = dr["music_country"].ToString();
            rtbLyrics.Text = dr["music_lyric"].ToString();
            ID = dr["music_id"].ToString();
            LoadStars();
        }

        private void MenuMouseEnter(object sender, EventArgs e)
        {
            (sender as FontAwesome.Sharp.IconButton).BackColor = Color.FromArgb(255, 45, 46, 45);
        }
        private void MenuMouseLeave(object sender, EventArgs e)
        {
            (sender as FontAwesome.Sharp.IconButton).BackColor = panel1.BackColor;
        }
        private void LoadMouseEnterAndLeave()
        {
            btnLove.MouseEnter += new EventHandler(MenuMouseEnter);
            btnPlaylist.MouseEnter += new EventHandler(MenuMouseEnter);
            btnShare.MouseEnter += new EventHandler(MenuMouseEnter);

            btnLove.MouseLeave += new EventHandler(MenuMouseLeave);
            btnPlaylist.MouseLeave += new EventHandler(MenuMouseLeave);
            btnShare.MouseLeave += new EventHandler(MenuMouseLeave);
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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            LoadChildForm(new LibraryScreen());
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows[0];
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Download Position";

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                using (var client = new WebClient())
                {
                    client.DownloadFile($"MusicData/{dr["music_id"]}.mp3", folderPath + $"/{dr["music_name"] + " - " + dr["music_author"]}.mp3");
                }
                MessageBox.Show("Download Successfully!");
            }
            else
                MessageBox.Show("Download Failed!");
        }

        private void btnLove_Click(object sender, EventArgs e)
        {
            MusicJoy.loveList.Rows.Add(ID);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Variables.MediaPlayer.Player.URL = "MusicData/" + ID + ".mp3";
            Variables.MediaPlayer.Player.Ctlcontrols.play();
            MusicJoy.isPause = true;

            string query = $"insert into HISTORY_MUSIC_LIST values('{ID}', '{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}')";
            DataProvider provider = new DataProvider();
            provider.ExecuteNonQuery(query);

            UpdateView();
        }
        private void LoadStars()
        {
            DataProvider provider = new DataProvider();
            string query = $"select [music_stars] from MUSIC where music_id = '{ID}'";
            DataTable dt = provider.ExecuteQuery(query);

            DataRow dr = dt.Rows[0];

            string numberStar = dr["music_stars"].ToString();

            foreach (IconButton item in flowLayoutPanel1.Controls)
            {
                if (Convert.ToInt16(item.Name.Substring(4)) <= Convert.ToInt16(numberStar))
                    item.IconColor = Color.Yellow;
                else
                    item.IconColor = Color.Black;
            }
        }
        private void UpdateView()
        {
            lbFreq.Text = (Convert.ToInt32(lbFreq.Text) + 1).ToString();
            DataProvider provider = new DataProvider();
            string query = $"update MUSIC set music_freq = {Convert.ToInt32(lbFreq.Text)} where music_id = '{ID}'";
            provider.ExecuteNonQuery(query);
        }
    }
}
