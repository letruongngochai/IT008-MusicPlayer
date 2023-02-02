
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
    public partial class MusicItem : UserControl
    {
        private Form activeForm = null;
        public MusicItem()
        {
            InitializeComponent();
        }
        public MusicItem(string ID, string name, string author) : this()
        {
            Bitmap bm1 = (Bitmap)ImageData.ResourceManager.GetObject(ID);
            musicPicture.Name = ID;
            musicPicture.BackgroundImage = bm1;
            musicName.Text = name;
            musicAuthor.Text = author;
        }

        private void musicPicture_Click(object sender, EventArgs e)
        {
            Bitmap bm1 = (Bitmap)ImageData.ResourceManager.GetObject(musicPicture.Name);
            string query = $"select * from MUSIC where music_id like '{musicPicture.Name}'";
            DataProvider provider = new DataProvider();
            DataTable dtShowMovieDetail = provider.ExecuteQuery(query);
            openChildForm(new MusicDetail(bm1, dtShowMovieDetail));
        }
        private void openChildForm(Form childForm)
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Variables.MediaPlayer.Player.URL = "MusicData/" + musicPicture.Name + ".mp3";
            Variables.MediaPlayer.Player.Ctlcontrols.play();
            MusicJoy.isPause = true;

            string query = $"insert into HISTORY_MUSIC_LIST values('{musicPicture.Name}', '{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}')";
            DataProvider provider = new DataProvider();
            provider.ExecuteNonQuery(query);

            UpdateView();
        }
        private void UpdateView()
        {
            string query = $"select * from MUSIC where music_id like '{musicPicture.Name}'";
            DataProvider provider = new DataProvider();
            DataTable dt = provider.ExecuteQuery(query);

            query = $"update MUSIC set music_freq = {Convert.ToInt32(dt.Rows[0]["music_freq"].ToString()) + 1} where music_id = '{dt.Rows[0]["music_id"].ToString()}'";
            provider.ExecuteNonQuery(query);
        }
    }
}
