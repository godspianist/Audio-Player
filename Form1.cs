using NAudio.Wave;
using NAudio.WaveFormRenderer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Media_Player
{
    public partial class player : Form
    {
        private FileInfo file = null;
        private IWavePlayer wavePlayer = new WaveOutEvent();
        private AudioFileReader audioFileReader;

        public player()
        {
            InitializeComponent();
            
            playlistData.Columns[0].DefaultCellStyle.NullValue = null;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
        private void PlaylistData_DragEnter_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(format: DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void PlaylistData_DragDrop_1(object sender, DragEventArgs e)
        {
            try
            {
                string[] musicfiles = (string[])e.Data.GetData(format: DataFormats.FileDrop);
                foreach (string file in musicfiles)
                {
                    FileInfo fileInf = new FileInfo(file);
                    TagLib.File tagFile = TagLib.File.Create(fileInf.FullName);
                    var addRows = playlistData.Rows.Add(values: new object[]
                    {
                    null,
                    fileInf.Name,
                    tagFile.Tag.JoinedGenres,
                    tagFile.Tag.JoinedAlbumArtists,
                    Math.Round(tagFile.Properties.Duration.TotalMinutes, 2) + "mins",
                    });
                    playlistData.Rows[addRows].Tag = fileInf;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid File Format dropped. Select only audio files and try again.", "Error copying files");
            }
            
        }

        private void PlaylistData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            file = ((FileInfo)playlistData.Rows[e.RowIndex].Tag);
            play();
        }

        private void play()
        {
            Application.UseWaitCursor = true;
            Application.DoEvents();
            if (file == null) return;
            audioFileReader = new AudioFileReader(file.FullName);
            if (wavePlayer.PlaybackState != PlaybackState.Stopped)
            {
                wavePlayer.Stop();
            }
            wavePlayer.Init(audioFileReader);
            GenerateWave();
            wavePlayer.Play();
            nowPlaying.Enabled = true;
            Application.UseWaitCursor = false;
        }

        private void GenerateWave()
        {
            var RenderConfig = new StandardWaveFormRendererSettings();
            RenderConfig.Width = wavePanel.Width;
            RenderConfig.TopHeight = wavePanel.Height / 2;
            RenderConfig.BottomHeight = wavePanel.Height / 2;
            RenderConfig.TopPeakPen = new Pen(Color.Gray);
            RenderConfig.BottomPeakPen = new Pen(Color.Silver);
            RenderConfig.BackgroundColor = this.BackColor;
            
            var RenderConfig2 = new StandardWaveFormRendererSettings();
            RenderConfig2.Width = wavePanel.Width;
            RenderConfig2.TopHeight = wavePanel.Height / 2;
            RenderConfig2.BottomHeight = wavePanel.Height / 2;
            RenderConfig2.TopPeakPen = new Pen(Color.PaleTurquoise);
            RenderConfig2.BottomPeakPen = new Pen(Color.DodgerBlue);
            RenderConfig2.BackgroundColor = this.BackColor;
            

            var Renderer = new WaveFormRenderer();
            var audioPath = file.FullName;
            wavePanel.BackgroundImage = Renderer.Render(audioPath, new AveragePeakProvider(3), RenderConfig);
            waveform.BackgroundImage = Renderer.Render(audioPath, new AveragePeakProvider(3), RenderConfig2);

        }

        private void Guna2ImageButton2_Click(object sender, EventArgs e)
        {
            try
            {
                wavePlayer.Stop();
                Artist.Text = "Stopped";
                btnPlayPause.Image = playing.Image;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnPlayPause_Click(object sender, EventArgs e)
        {
            try
            {
                if (wavePlayer.PlaybackState == PlaybackState.Playing)
                {
                    wavePlayer.Pause();
                    btnPlayPause.Image = playing.Image;
                    Artist.Text = "Paused";
                }
                else
                {
                    wavePlayer.Play();
                    btnPlayPause.Image = pause.Image;
                    
                }
            }
            catch (Exception)
            {
                goto a;

            a:
                
                if (playlistData.RowCount == 0)
                {
                    openFileDialog1.ShowDialog();
                    if (playlistData.RowCount > 0) goto a;
                }
                else
                {
                    file = ((FileInfo)playlistData.CurrentRow.Tag);
                    play();
                    btnPlayPause.Image = pause.Image;
                }
                
            }
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
                try
                {
                  
                    foreach (var file in openFileDialog1.FileNames)
                    {
                        FileInfo fileInf = new FileInfo(file);
                        TagLib.File tagFile = TagLib.File.Create(fileInf.FullName);
                        var addRows = playlistData.Rows.Add(values: new object[]
                        {
                            null,
                            fileInf.Name,
                            tagFile.Tag.JoinedGenres,
                            tagFile.Tag.JoinedAlbumArtists,
                            Math.Round(tagFile.Properties.Duration.TotalMinutes, 2) + "mins",
                        });
                        playlistData.Rows[addRows].Tag = fileInf;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid File Format dropped. Select only audio files and try again.", "Error copying files");
                }
        }

        private void WavePanel_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                waveform.Width = e.X;
                var maxLength = audioFileReader.Length;
                var position = (e.X * maxLength) / wavePanel.Width;
                audioFileReader.Position = position;
            }

            catch (Exception)
            {
                
            }
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (wavePlayer.PlaybackState == PlaybackState.Playing)
            {
                songName.Text = file.Name;
                nowPlaying.Enabled = true;
                setSlider();
                Artist.Text = playlistData.CurrentRow.Cells[2].Value.ToString();

            }
            else if (wavePlayer.PlaybackState == PlaybackState.Paused)
            {
                    waveform.Width = waveform.Width;
                    nowPlaying.Enabled = false;
                    Artist.Text = "Paused";
            }
            else
            {

                if (wavePlayer.PlaybackState == PlaybackState.Stopped)
                {
                    waveform.Width = 0;
                }
                
                nowPlaying.Enabled = false;
                Artist.Text = "Stopped";
            }
        }

        private void setSlider()
        {
            double maxLength = audioFileReader.Length;
            double currentPosition = audioFileReader.Position;
            var position = (currentPosition*wavePanel.Width)/ maxLength;
            waveform.Width = int.Parse(Math.Truncate(position).ToString());
        }

        private void SearchSongs_KeyUp(object sender, KeyEventArgs e)
        {
            if (searchSongs.Text.Trim().Length != 0 || e.KeyCode == Keys.Enter)
            {
                foreach (DataGridViewRow row in playlistData.Rows)
                {
                    row.Visible = row.Cells[1].ToString().ToLower().Contains(searchSongs.Text.ToString().ToLower());
                }
            }
        }

        private void BtnPlaylist_Click(object sender, EventArgs e)
        {
            playlistData.Visible = !playlistData.Visible;
        }

        private void PlaylistData_VisibleChanged(object sender, EventArgs e)
        {
            this.Height = playlistData.Visible ? 530 : 250;
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                if (playlistData.CurrentRow.Index == 0)
                {
                    playlistData.CurrentCell = playlistData.Rows[playlistData.Rows.GetLastRow(includeFilter: DataGridViewElementStates.Visible)].Cells[1];

                }
                else
                {
                    playlistData.CurrentCell = playlistData.Rows[playlistData.CurrentRow.Index - 1].Cells[1];
                }
                file = ((FileInfo)playlistData.CurrentRow.Tag);
                play();
            }
            catch (Exception)
            {

               
            }
        }

        

        private void Volume_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            audioFileReader.Volume = wavePlayer.Volume = (volumeBar.Value - 1) / 100f;
        }

        private void BtnNext_Click_1(object sender, EventArgs e)
        {
            try
            {
                wavePlayer.Stop();
                if (playlistData.CurrentRow.Index == playlistData.Rows.GetLastRow(includeFilter: DataGridViewElementStates.None))
                {
                    playlistData.CurrentCell = playlistData.Rows[0].Cells[1];
                }
                else
                {
                    playlistData.CurrentCell = playlistData.Rows[playlistData.CurrentRow.Index + 1].Cells[1];

                }
                file = ((FileInfo)playlistData.CurrentRow.Tag);
                play();


            }
            catch (Exception)
            {
            }
        }

        private void SearchSongs_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
