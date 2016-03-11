namespace MusicPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLoadFiles = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lvTracks = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mpPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.mpPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.Location = new System.Drawing.Point(12, 12);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(172, 58);
            this.btnLoadFiles.TabIndex = 0;
            this.btnLoadFiles.Text = "Load Files";
            this.btnLoadFiles.UseVisualStyleBackColor = true;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 491);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(172, 58);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play All";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lvTracks
            // 
            this.lvTracks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Location});
            this.lvTracks.Location = new System.Drawing.Point(12, 76);
            this.lvTracks.Name = "lvTracks";
            this.lvTracks.Size = new System.Drawing.Size(172, 409);
            this.lvTracks.TabIndex = 2;
            this.lvTracks.UseCompatibleStateImageBehavior = false;
            this.lvTracks.View = System.Windows.Forms.View.Details;
            this.lvTracks.DoubleClick += new System.EventHandler(this.lvTracks_DoubleClick);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 114;
            // 
            // Location
            // 
            this.Location.Text = "Location";
            this.Location.Width = 107;
            // 
            // mpPlayer
            // 
            this.mpPlayer.Enabled = true;
            this.mpPlayer.Location = new System.Drawing.Point(190, 12);
            this.mpPlayer.Name = "mpPlayer";
            this.mpPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpPlayer.OcxState")));
            this.mpPlayer.Size = new System.Drawing.Size(582, 537);
            this.mpPlayer.TabIndex = 3;            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mpPlayer);
            this.Controls.Add(this.lvTracks);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnLoadFiles);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dTunes";
            ((System.ComponentModel.ISupportInitialize)(this.mpPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFiles;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ListView lvTracks;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Location;
        private AxWMPLib.AxWindowsMediaPlayer mpPlayer;
    }
}

