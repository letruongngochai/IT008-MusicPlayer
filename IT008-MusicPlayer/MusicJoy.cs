﻿using System;
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
    public partial class MusicJoy : Form
    {
        private Form activeForm = null;
        public MusicJoy()
        {
            InitializeComponent();
            Variables.ListFormPanel.ListFormsPanel.Add(mainPanel);
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
            //LoadChildForm(new SearchScreen(textBox1.Text));
        }
    }
}
