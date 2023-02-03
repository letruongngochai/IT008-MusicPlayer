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
    public partial class LoveItem : UserControl
    {
        static public string id;
        Form activeForm = null;
        public LoveItem()
        {
            InitializeComponent();
        }
        public LoveItem(string ID)
        {
            InitializeComponent();
            pictureBox1.BackgroundImage = (Bitmap)ImageData.ResourceManager.GetObject(ID);
            string query = $"select * from MUSIC where music_id like '{ID}'";
            DataProvider provider = new DataProvider();
            DataTable dtDetail = provider.ExecuteQuery(query);
            lbName.Text = dtDetail.Rows[0]["music_name"].ToString();
            lbSinger.Text = dtDetail.Rows[0]["singer_name"].ToString();
            id = ID;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DataRow[] dr = MusicJoy.loveList.Select(string.Format("ID = '{0}'", id));
            for (int i = 0; i < dr.Length; i++)
                MusicJoy.loveList.Rows.Remove(dr[i]);
            MusicJoy.loveList.AcceptChanges();
        }

        private void LoveItem_Load(object sender, EventArgs e)
        {
            
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

        private void LoveItem_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string query = $"select * from MUSIC where music_id = '{id}'";
            DataTable dt = provider.ExecuteQuery(query);
            LoadChildForm(new MusicDetail((Bitmap)pictureBox1.BackgroundImage, dt));
        }
    }
}
