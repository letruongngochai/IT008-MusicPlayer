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
    public partial class RecentMediaScreen : Form
    {
        DataTable dt;
        public RecentMediaScreen()
        {
            InitializeComponent();
            string query = "SELECT [history_music_id], [music_name], [singer_name], [history_music_time] FROM HISTORY_MUSIC_LIST inner join MUSIC on history_music_id = music_id order by history_music_time desc";
            DataProvider dp = new DataProvider();
            dt = dp.ExecuteQuery(query);
            //dt = RemoveDuplicateRows(dt, "history_music_id");
            LoadHistory(dt);
        }
        private void LoadHistory(DataTable dt)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                RecentMediaItem it = new RecentMediaItem(dr);
                it.iconButton1.Click += new EventHandler(HistoryRemoveButton_Click);
                flowLayoutPanel1.Controls.Add(it);
            }
        }
        private void HistoryRemoveButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            string query = "SELECT [history_music_id], [music_name], [singer_name], [history_music_time] FROM HISTORY_MUSIC_LIST inner join MUSIC on history_music_id = music_id order by history_music_time desc";
            DataProvider dp = new DataProvider();
            dt = dp.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                RecentMediaItem it = new RecentMediaItem(dr);
                it.iconButton1.Click += new EventHandler(HistoryRemoveButton_Click);
                flowLayoutPanel1.Controls.Add(it);
            }
        }
    }
}
