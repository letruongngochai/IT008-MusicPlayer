
namespace IT008_MusicPlayer.CustomControl
{
    partial class PlaylistItem
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
            this.playlistTime = new System.Windows.Forms.Label();
            this.playlistName = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // playlistTime
            // 
            this.playlistTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.playlistTime.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playlistTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playlistTime.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistTime.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.playlistTime.Location = new System.Drawing.Point(3, 196);
            this.playlistTime.Name = "playlistTime";
            this.playlistTime.Size = new System.Drawing.Size(403, 22);
            this.playlistTime.TabIndex = 24;
            this.playlistTime.Text = "Time";
            // 
            // playlistName
            // 
            this.playlistName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playlistName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playlistName.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playlistName.Location = new System.Drawing.Point(192, 4);
            this.playlistName.Name = "playlistName";
            this.playlistName.Size = new System.Drawing.Size(168, 180);
            this.playlistName.TabIndex = 23;
            this.playlistName.Text = "Name";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.iconButton1.IconColor = System.Drawing.Color.Red;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(368, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(38, 40);
            this.iconButton1.TabIndex = 25;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.BackgroundImage = global::IT008_MusicPlayer.ImageData.playlist;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // PlaylistItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.playlistTime);
            this.Controls.Add(this.playlistName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PlaylistItem";
            this.Size = new System.Drawing.Size(409, 228);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public FontAwesome.Sharp.IconButton iconButton1;
        public System.Windows.Forms.Label playlistTime;
        public System.Windows.Forms.Label playlistName;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}
