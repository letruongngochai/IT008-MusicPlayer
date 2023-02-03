using IT008_MusicPlayer.CustomControl;
using System;
using System.Collections;
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
    public partial class LoveScreen : Form
    {
        public static DataTable dt;
        public LoveScreen()
        {
            InitializeComponent();
            dt = MusicJoy.loveList;
            dt = RemoveDuplicateRows(dt, "ID");
            LoadLoveList();
        }
        private void LoadLoveList()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                //Load each item(ID)
                LoveItem it = new LoveItem(dr["ID"].ToString());
                it.iconButton1.Click += new EventHandler(btnRemove_Click);
                flowLayoutPanel1.Controls.Add(it);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            dt = MusicJoy.loveList;
            flowLayoutPanel1.Controls.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                LoveItem it = new LoveItem(dr["ID"].ToString());
                it.iconButton1.Click += new EventHandler(btnRemove_Click);
                flowLayoutPanel1.Controls.Add(it);
            }
        }
        public DataTable RemoveDuplicateRows(DataTable dTable, string colName)
        {
            Hashtable hTable = new Hashtable();
            ArrayList duplicateList = new ArrayList();

            //Add list of all the unique item value to hashtable, which stores combination of key, value pair.
            //And add duplicate item value in arraylist.
            foreach (DataRow drow in dTable.Rows)
            {
                if (hTable.Contains(drow[colName]))
                    duplicateList.Add(drow);
                else
                    hTable.Add(drow[colName], string.Empty);
            }

            //Removing a list of duplicate items from datatable.
            foreach (DataRow dRow in duplicateList)
                dTable.Rows.Remove(dRow);

            //Datatable which contains unique records will be return as output.
            return dTable;
        }
    }
}
