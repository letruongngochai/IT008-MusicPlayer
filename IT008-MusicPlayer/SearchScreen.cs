using IT008_MusicPlayer.CustomControl;
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
    public partial class SearchScreen : Form
    {
        public DataTable dtAudio;
        string getAudioQuery = "Select * from MUSIC ";
        DataProvider dp = new DataProvider();
        public SearchScreen()
        {
            InitializeComponent();
            dtAudio = new DataTable();
            dtAudio = dp.ExecuteQuery(getAudioQuery);
            ShowAudioList();
        }
        public SearchScreen(string key)
        {
            InitializeComponent();
            if (key != "")
            {
                getAudioQuery += "where (dbo.LanguageComprehension(music_name) like N'%" + key + "%' " +
                         "or music_name like N'%" + key + "%') " +
                         "or (dbo.LanguageComprehension(singer_name) like N'%" + key + "%' " +
                         "or singer_name like N'%" + key + "%')";
            }

            dtAudio = new DataTable();
            dtAudio = dp.ExecuteQuery(getAudioQuery);
            ShowAudioList();
        }
        private void ShowAudioList()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < dtAudio.Rows.Count; i++)
            {
                string id = dtAudio.Rows[i]["music_id"].ToString();
                id = id.Replace(" ", "");

                string name = dtAudio.Rows[i]["music_name"].ToString();
                string author = dtAudio.Rows[i]["music_author"].ToString();

                CustomControl.MusicItem it = new CustomControl.MusicItem(id, name, author);
                it.musicPicture.Click += new EventHandler(OnClickMusicItem);
                flowLayoutPanel1.Controls.Add(it);
            }
        }
        private void OnClickMusicItem(object sender, EventArgs e)
        {
            LoadChildForm(new MusicDetail());
        }
        public void LoadChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            flowLayoutPanel1.Controls.Add(childForm);
            flowLayoutPanel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
