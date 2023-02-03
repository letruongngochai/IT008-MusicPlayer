using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IT008_MusicPlayer.Variables;


namespace IT008_MusicPlayer
{
    public partial class MusicJoy : Form
    {
        public static bool isPause;
        private Form activeForm = null;
        public static Timer myTimer;
        public static DataTable loveList;
        public MusicJoy()
        {
            InitializeComponent();
            Variables.ListFormPanel.ListFormsPanel.Add(mainPanel);
            myTimer = new Timer() { Enabled = true };
            myTimer.Tick += new EventHandler(myTimer_Tick);

            trackVolume.Value = 50;
            txtVolume.Text = "50";

            progressBar.SetState(3);

            loveList = new DataTable();
            loveList.Columns.Add("ID", typeof(string));
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            if (MediaPlayer.Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar.Maximum = (int)MediaPlayer.Player.Ctlcontrols.currentItem.duration;
                progressBar.Value = (int)MediaPlayer.Player.Ctlcontrols.currentPosition;
            }
            try
            {
                txtTrackStart.Text = MediaPlayer.Player.Ctlcontrols.currentPositionString;
                txtTrackEnd.Text = MediaPlayer.Player.Ctlcontrols.currentItem.durationString;
                if (progressBar.Value == progressBar.Maximum + 1)
                {
                    progressBar.Value = 0;
                    myTimer.Enabled = false;
                }
            }
            catch
            {

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

        private void MenuMouseEnter(object sender, EventArgs e)
        {
            (sender as FontAwesome.Sharp.IconButton).BackColor = Color.FromArgb(255, 45, 46, 45);
        }
        private void MenuMouseLeave(object sender, EventArgs e)
        {
            (sender as FontAwesome.Sharp.IconButton).BackColor = panel2.BackColor;
        }
        private void LoadMouseEnterAndLeave()
        {
            iconButton4.MouseEnter += new EventHandler(MenuMouseEnter);
            iconButton5.MouseEnter += new EventHandler(MenuMouseEnter);
            iconButton6.MouseEnter += new EventHandler(MenuMouseEnter);
            iconButton7.MouseEnter += new EventHandler(MenuMouseEnter);

            iconButton4.MouseLeave += new EventHandler(MenuMouseLeave);
            iconButton5.MouseLeave += new EventHandler(MenuMouseLeave);
            iconButton6.MouseLeave += new EventHandler(MenuMouseLeave);
            iconButton7.MouseLeave += new EventHandler(MenuMouseLeave);
        }

        private void MusicJoy_Load(object sender, EventArgs e)
        {
            LoadMouseEnterAndLeave();
            LoadChildForm(new HomeScreen());
            pbPlayAndPause.BackgroundImage = (Bitmap)ImageData.ResourceManager.GetObject("pause");
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            LoadChildForm(new LibraryScreen());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            LoadChildForm(new HomeScreen());
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            LoadChildForm(new PlayQueue());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            LoadChildForm(new LoveScreen());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            LoadChildForm(new RecentMediaScreen());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            CloseForm();
            LoadChildForm(new PlaylistScreen());
        }
        private void CloseForm()
        {
            if (Application.OpenForms.OfType<PlaylistScreen>().Count() == 1)
                Application.OpenForms.OfType<PlaylistScreen>().First().Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (textBox1.Text == "Search here...")
                textBox1.Click -= textBox1_Click;
            LoadChildForm(new SearchScreen());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadChildForm(new SearchScreen(textBox1.Text));
        }
        double GetValue(int x)
        {
            double value = x * 1.0 / progressBar.Width;
            int max = progressBar.Maximum;
            int min = progressBar.Minimum;
            return min + value * (max - min);
        }
        private void progressBar_MouseDown(object sender, MouseEventArgs e)
        {
            MediaPlayer.Player.Ctlcontrols.currentPosition = GetValue(e.X);
        }

        private void pbPlayAndPause_Click(object sender, EventArgs e)
        {
            isPause = !isPause;
            if (isPause == false)
            {
                pbPlayAndPause.BackgroundImage = (Bitmap)ImageData.ResourceManager.GetObject("play");
                MediaPlayer.Player.Ctlcontrols.pause();
            }
            else
            {
                pbPlayAndPause.BackgroundImage = (Bitmap)ImageData.ResourceManager.GetObject("pause");
                MediaPlayer.Player.Ctlcontrols.play();
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            MediaPlayer.Player.Ctlcontrols.stop();
        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            MediaPlayer.Player.settings.volume = trackVolume.Value;
            txtVolume.Text = trackVolume.Value.ToString();
        }
    }
}
