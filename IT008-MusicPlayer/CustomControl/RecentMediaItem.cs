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
    public partial class RecentMediaItem : UserControl
    {
        public static string id;
        Form activeForm = null;
        public RecentMediaItem()
        {
            InitializeComponent();
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
        public RecentMediaItem(DataRow dr)
        {
            InitializeComponent();
            pictureBox1.BackgroundImage = (Bitmap)ImageData.ResourceManager.GetObject(dr["history_music_id"].ToString());
            pictureBox1.Name = dr["history_music_id"].ToString();
            lbName.Text = dr["music_name"].ToString();
            lbSinger.Text = dr["singer_name"].ToString();
            lbTime.Text = dr["history_music_time"].ToString();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string query = $"delete from HISTORY_MUSIC_LIST where history_music_id = '{pictureBox1.Name}'";
            provider.ExecuteNonQuery(query);
        }

        private void RecentMediaItem_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string query = $"select * from MUSIC where music_id = '{pictureBox1.Name}'";
            DataTable dt = provider.ExecuteQuery(query);
            LoadChildForm(new MusicDetail((Bitmap)pictureBox1.BackgroundImage, dt));
        }
    }
}
