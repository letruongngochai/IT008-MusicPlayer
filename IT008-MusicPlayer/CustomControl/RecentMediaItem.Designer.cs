
namespace IT008_MusicPlayer.CustomControl
{
    partial class RecentMediaItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecentMediaItem));
            this.lbTime = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lbSinger = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("Cascadia Mono", 12F);
            this.lbTime.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbTime.Location = new System.Drawing.Point(249, 113);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(1086, 27);
            this.lbTime.TabIndex = 14;
            this.lbTime.Text = "Time: ";
            this.lbTime.Click += new System.EventHandler(this.RecentMediaItem_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.iconButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconButton1.BackgroundImage")));
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1365, 37);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 75);
            this.iconButton1.TabIndex = 13;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // lbSinger
            // 
            this.lbSinger.Font = new System.Drawing.Font("Cascadia Mono", 12F);
            this.lbSinger.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbSinger.Location = new System.Drawing.Point(249, 71);
            this.lbSinger.Name = "lbSinger";
            this.lbSinger.Size = new System.Drawing.Size(661, 27);
            this.lbSinger.TabIndex = 12;
            this.lbSinger.Text = "tên ca sĩ";
            this.lbSinger.Click += new System.EventHandler(this.RecentMediaItem_Click);
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbName.Location = new System.Drawing.Point(247, 10);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(663, 46);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "tên nhạc";
            this.lbName.Click += new System.EventHandler(this.RecentMediaItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(28, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.RecentMediaItem_Click);
            // 
            // RecentMediaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.lbSinger);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RecentMediaItem";
            this.Size = new System.Drawing.Size(1490, 150);
            this.Click += new System.EventHandler(this.RecentMediaItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbTime;
        public FontAwesome.Sharp.IconButton iconButton1;
        public System.Windows.Forms.Label lbSinger;
        public System.Windows.Forms.Label lbName;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}
