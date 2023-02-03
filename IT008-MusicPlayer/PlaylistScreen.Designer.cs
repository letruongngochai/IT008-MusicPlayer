
namespace IT008_MusicPlayer
{
    partial class PlaylistScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistScreen));
            this.newPlaylistPanel = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playlistItemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.playlistPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnPlaylist = new FontAwesome.Sharp.IconButton();
            this.newPlaylistPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newPlaylistPanel
            // 
            this.newPlaylistPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newPlaylistPanel.Controls.Add(this.iconButton3);
            this.newPlaylistPanel.Controls.Add(this.iconButton2);
            this.newPlaylistPanel.Controls.Add(this.label4);
            this.newPlaylistPanel.Controls.Add(this.pictureBox1);
            this.newPlaylistPanel.Controls.Add(this.tbName);
            this.newPlaylistPanel.Controls.Add(this.label3);
            this.newPlaylistPanel.Controls.Add(this.label2);
            this.newPlaylistPanel.Location = new System.Drawing.Point(454, 91);
            this.newPlaylistPanel.Name = "newPlaylistPanel";
            this.newPlaylistPanel.Size = new System.Drawing.Size(647, 553);
            this.newPlaylistPanel.TabIndex = 20;
            this.newPlaylistPanel.Visible = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.Font = new System.Drawing.Font("Cascadia Mono", 12F);
            this.iconButton3.ForeColor = System.Drawing.Color.Chocolate;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButton3.IconColor = System.Drawing.Color.Chocolate;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 40;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(269, 472);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(115, 54);
            this.iconButton3.TabIndex = 20;
            this.iconButton3.Text = "Done";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.Font = new System.Drawing.Font("Cascadia Mono", 12F);
            this.iconButton2.ForeColor = System.Drawing.Color.Chocolate;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.iconButton2.IconColor = System.Drawing.Color.Chocolate;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(254, 172);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(141, 54);
            this.iconButton2.TabIndex = 19;
            this.iconButton2.Text = "Change";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(8, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 56);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cover image:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(225, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Cascadia Mono", 18F);
            this.tbName.Location = new System.Drawing.Point(243, 116);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(388, 42);
            this.tbName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(8, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 58);
            this.label3.TabIndex = 15;
            this.label3.Text = "Enter name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(644, 69);
            this.label2.TabIndex = 14;
            this.label2.Text = "Make your new playlist";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playlistItemPanel
            // 
            this.playlistItemPanel.AutoScroll = true;
            this.playlistItemPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.playlistItemPanel.Location = new System.Drawing.Point(1040, 190);
            this.playlistItemPanel.Name = "playlistItemPanel";
            this.playlistItemPanel.Size = new System.Drawing.Size(441, 427);
            this.playlistItemPanel.TabIndex = 18;
            // 
            // playlistPanel
            // 
            this.playlistPanel.AutoScroll = true;
            this.playlistPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.playlistPanel.Location = new System.Drawing.Point(109, 113);
            this.playlistPanel.Name = "playlistPanel";
            this.playlistPanel.Size = new System.Drawing.Size(866, 504);
            this.playlistPanel.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 79);
            this.label1.TabIndex = 16;
            this.label1.Text = "Your playlists";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1040, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(441, 110);
            this.label5.TabIndex = 21;
            this.label5.Text = "Playlist\'s Item";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.LongArrowDown;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 47;
            this.iconPictureBox1.Location = new System.Drawing.Point(1233, 122);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(47, 62);
            this.iconPictureBox1.TabIndex = 22;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylist.Font = new System.Drawing.Font("Cascadia Mono", 12F);
            this.btnPlaylist.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlaylist.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btnPlaylist.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlaylist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.Location = new System.Drawing.Point(109, 650);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(219, 54);
            this.btnPlaylist.TabIndex = 19;
            this.btnPlaylist.Text = "New Playlist";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlaylist.UseVisualStyleBackColor = false;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // PlaylistScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1522, 750);
            this.Controls.Add(this.newPlaylistPanel);
            this.Controls.Add(this.playlistItemPanel);
            this.Controls.Add(this.playlistPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPlaylist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlaylistScreen";
            this.Text = "PlaylistScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlaylistScreen_FormClosing);
            this.newPlaylistPanel.ResumeLayout(false);
            this.newPlaylistPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel newPlaylistPanel;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel playlistItemPanel;
        private System.Windows.Forms.FlowLayoutPanel playlistPanel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnPlaylist;
    }
}