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
    public partial class LibraryScreen : Form
    {
        static Bitmap checkbox = (Bitmap)ImageData.ResourceManager.GetObject("checkbox");
        static Bitmap blankCheckbox = (Bitmap)ImageData.ResourceManager.GetObject("blankcheckbox");
        static bool all = true;
        static bool usuk = false;
        static bool vietnam = false;
        static bool rap = false;
        static bool pop = false;
        static bool remix = false;
        static bool[] filter = new bool[6] { all, usuk, vietnam, rap, pop, remix };
        static PictureBox[] pictureBoxes;
        static Color selectedColor, notSelectedColor;
        public DataTable dtAudio;
        public DataTable dtVideo;
        string getAudioQuery = "Select * from MUSIC";
        DataProvider dp = new DataProvider();
        public LibraryScreen()
        {
            InitializeComponent();
            selectedColor = flowLayoutPanel1.BackColor;
            notSelectedColor = BackColor;
            dtAudio = new DataTable();
            dtAudio = dp.ExecuteQuery(getAudioQuery);
            pictureBoxes = new PictureBox[6] { pbAll, pbUSUK, pbVietNam, pbRap, pbPop, pbRemix };
        }
        private void UpdateFilter(int index)
        {
            for (int i = 0; i < filter.Length; i++)
            {
                if (i == index)
                {
                    filter[i] = true;
                    continue;
                }
                filter[i] = false;
            }
        }
        private void FilterCountry(string str)
        {
            string query = $"select * from MUSIC where music_country like N'{str}'";
            dtAudio = new DataTable();
            DataProvider dp = new DataProvider();
            dtAudio = dp.ExecuteQuery(query);
            ShowAudioList();
        }
        private void FilterCategory(string str)
        {
            string query = $"select * from MUSIC where music_category like N'{str}'";
            dtAudio = new DataTable();
            DataProvider dp = new DataProvider();
            dtAudio = dp.ExecuteQuery(query);
            ShowAudioList();
        }
        private void LibraryScreen_Load(object sender, EventArgs e)
        {
            ShowAudioList();
        }

        private void UpdateCheckbox()
        {
            for (int i = 0; i < filter.Length; i++)
            {
                if (filter[i] == false)
                    pictureBoxes[i].BackgroundImage = blankCheckbox;
                else
                    pictureBoxes[i].BackgroundImage = checkbox;
            }
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

        private void iconButton3_Click(object sender, EventArgs e)
        {
            UpdateFilter(0);
            UpdateCheckbox();
            dtAudio = new DataTable();
            dtAudio = dp.ExecuteQuery(getAudioQuery);
            ShowAudioList();
        }

        private void pbAll_Click(object sender, EventArgs e)
        {
            UpdateFilter(0);
            UpdateCheckbox();
            dtAudio = new DataTable();
            dtAudio = dp.ExecuteQuery(getAudioQuery);
            ShowAudioList();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            UpdateFilter(1);
            UpdateCheckbox();
            FilterCountry("US/UK");
        }

        private void pbUSUK_Click(object sender, EventArgs e)
        {
            UpdateFilter(1);
            UpdateCheckbox();
            FilterCountry("US/UK");
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            UpdateFilter(2);
            UpdateCheckbox();
            FilterCountry("Vietnam");
        }

        private void pbVietNam_Click(object sender, EventArgs e)
        {
            UpdateFilter(2);
            UpdateCheckbox();
            FilterCountry("Vietnam");
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            UpdateFilter(3);
            UpdateCheckbox();
            FilterCategory("rap");
        }

        private void pbRap_Click(object sender, EventArgs e)
        {
            UpdateFilter(3);
            UpdateCheckbox();
            FilterCategory("rap");
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            UpdateFilter(4);
            UpdateCheckbox();
            FilterCategory("pop");
        }

        private void pbPop_Click(object sender, EventArgs e)
        {
            UpdateFilter(4);
            UpdateCheckbox();
            FilterCategory("pop");
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            UpdateFilter(5);
            UpdateCheckbox();
            FilterCategory("remix");
        }

        private void pbRemix_Click(object sender, EventArgs e)
        {
            UpdateFilter(5);
            UpdateCheckbox();
            FilterCategory("remix");
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
