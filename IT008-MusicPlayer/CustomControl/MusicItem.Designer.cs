
namespace IT008_MusicPlayer.CustomControl
{
    partial class MusicItem
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.musicAuthor = new System.Windows.Forms.Label();
            this.musicName = new System.Windows.Forms.Label();
            this.musicPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.musicPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.Location = new System.Drawing.Point(187, 169);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(40, 40);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // musicAuthor
            // 
            this.musicAuthor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.musicAuthor.AutoSize = true;
            this.musicAuthor.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicAuthor.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.musicAuthor.Location = new System.Drawing.Point(4, 290);
            this.musicAuthor.Name = "musicAuthor";
            this.musicAuthor.Size = new System.Drawing.Size(70, 22);
            this.musicAuthor.TabIndex = 9;
            this.musicAuthor.Text = "Author";
            // 
            // musicName
            // 
            this.musicName.AutoSize = true;
            this.musicName.Font = new System.Drawing.Font("Cascadia Mono", 12F);
            this.musicName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.musicName.Location = new System.Drawing.Point(4, 231);
            this.musicName.MaximumSize = new System.Drawing.Size(240, 0);
            this.musicName.Name = "musicName";
            this.musicName.Size = new System.Drawing.Size(60, 27);
            this.musicName.TabIndex = 8;
            this.musicName.Text = "Name";
            // 
            // musicPicture
            // 
            this.musicPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.musicPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musicPicture.Location = new System.Drawing.Point(12, 7);
            this.musicPicture.Name = "musicPicture";
            this.musicPicture.Size = new System.Drawing.Size(224, 211);
            this.musicPicture.TabIndex = 7;
            this.musicPicture.TabStop = false;
            this.musicPicture.Click += new System.EventHandler(this.musicPicture_Click);
            // 
            // MusicItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.musicAuthor);
            this.Controls.Add(this.musicName);
            this.Controls.Add(this.musicPicture);
            this.Name = "MusicItem";
            this.Size = new System.Drawing.Size(246, 319);
            ((System.ComponentModel.ISupportInitialize)(this.musicPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        public System.Windows.Forms.Label musicAuthor;
        public System.Windows.Forms.Label musicName;
        public System.Windows.Forms.PictureBox musicPicture;
    }
}
