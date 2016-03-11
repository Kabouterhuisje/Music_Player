using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
            var fileDia = new OpenFileDialog
            {
                InitialDirectory = @"C:\\",
                Filter =
                    @"MP3 Audio File (.mp3)|*.mp3|Windows Media Audio File (.wma)|*.wma|WAV Audio File (.wav)|*.wav|All Files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = false,
                Multiselect = true
            };


            if (fileDia.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream myStream = null;
                    if ((myStream = fileDia.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string[] fileNameAndPath = fileDia.FileNames;
                            string[] filename = fileDia.SafeFileNames;

                            for (int i = 0; i < fileDia.SafeFileNames.Count(); i++)
                            {
                                string[] trackItem = new string[2];

                                trackItem[0] = filename[i];
                                trackItem[1] = fileNameAndPath[i];

                                ListViewItem lvi = new ListViewItem(trackItem);
                                lvTracks.Items.Add(lvi);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: Could not read file from disk");
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            WMPLib.IWMPPlaylist playlist = mpPlayer.playlistCollection.newPlaylist("myPlaylist");

            for (int i = 0; i < lvTracks.Items.Count; i++)
            {
                int ii = 1;
                var media = mpPlayer.newMedia(lvTracks.Items[i].SubItems[ii].Text);
                playlist.appendItem(media);
                ii++;

                mpPlayer.currentPlaylist = playlist;
                mpPlayer.Ctlcontrols.play();
            }
        }

        private void lvTracks_DoubleClick(object sender, EventArgs e)
        {
            string selectedFile = lvTracks.FocusedItem.SubItems[1].Text;

            mpPlayer.URL = @selectedFile;
        }
    }
}
