using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace proiectIP
{
    public partial class Form1 : Form
    {
        private VideoPlayer videoPlayer;
        private AllPlaylists allPlaylists;
        
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            disableBuittons();
            screenPlayer.uiMode = "none";
            videoPlayer = new VideoPlayer();
            allPlaylists = new AllPlaylists();
            trackVolume.Value = 50;
            Timer timer = new Timer();
            timer.Interval = 100; // Interval in milliseconds (adjust as needed)
            timer.Tick += timer_Tick;
            timer.Start();
            backgroundWorker1.RunWorkerAsync();
        }
        
        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }
        private void customizeDesign()
        {
            panelSubmeniuHome.Visible = false;
            panelSubmeniuHome2.Visible = false;
            panelPlaylistBottom.Visible = false;
            panelPlaylistTop.Visible = false;
        }
        private void hideSubmeniu()
        {
            if (panelSubmeniuHome.Visible == true)
            {

                panelSubmeniuHome.Visible = false;
                panelSubmeniuHome2.Visible = false;
                panelPlaylistBottom.Visible = false;
                panelPlaylistTop.Visible = false;
            }
        }
        private void enableButtons()
        {
            btnVolume.Enabled = true;
            trackVolume.Enabled = true;
            btnBack.Enabled = true;
            btnPlay.Enabled = true;
            btnStop.Enabled = true;
            btnNext.Enabled = true;
            loop.Enabled = true;
            shuffle.Enabled = true;
            DeletePlaylist.Enabled = true;
            btnDelete.Enabled = true;

        }
        private void disableBuittons()
        {
            btnVolume.Enabled = false;
            trackVolume.Enabled = false;
            btnBack.Enabled = false;
            btnPlay.Enabled = false;
            btnStop.Enabled = false;
            btnNext.Enabled = false;
            loop.Enabled = false;
            shuffle.Enabled = false;
            DeletePlaylist.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void showSubmenu(Panel s)
        {
            if (s.Visible == true)
                s.Visible = false;
            else
                s.Visible = true;
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmeniuHome);
            showSubmenu(panelSubmeniuHome2);
            btnLoad.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect Ingineria Programarii, 2023\n© Rotaru Irina & Bacalie Roxana \n& Leonte Rares & Milica Cosmin ");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            listVideo.Items.RemoveAt(listVideo.SelectedIndex);
            
        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (listVideo.SelectedIndex == -1)
                listVideo.SelectedIndex = 0;
            videoPlayer.SetCurrentState(screenPlayer, State.Play);
            
            videoPlayer.Execute();
            /*if(screenPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                videoPlayer.Pause();
            }
            else if(screenPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {

                videoPlayer.Play();
            }
            else
            {
                string path = listVideo.GetItemText(listVideo.SelectedItem);
                videoPlayer.setCurrentState(path, screenPlayer);

                txtTitle.Text = path;
            }*/
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int index = listVideo.SelectedIndex;
            if (videoPlayer.IsLooping)
            {
                listVideo.SetSelected(index, true);
            }
            else if (index > 0)
                listVideo.SetSelected(--index, true);
            else
            {
                listVideo.SetSelected(listVideo.Items.Count - 1, true);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int index = listVideo.SelectedIndex;
            if (videoPlayer.IsLooping)
            {
                listVideo.SetSelected(index, true);
            }
            else if (index < listVideo.Items.Count - 1)
                listVideo.SetSelected(++index, true);
            else
            {
                listVideo.SetSelected(0, true);
            }
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            videoPlayer.MuteMode();

        }

        private void searchBar_OnTextChange(object sender, EventArgs e)
        {

        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBar.Text;

            if (!string.IsNullOrEmpty(searchText))
            {
                int index = listVideo.FindString(searchText);
                if (index != ListBox.NoMatches)
                {
                    listVideo.SelectedIndex = index;
                    listVideo.TopIndex = index;
                }
                else
                {
                    for (int i = 0; i < listVideo.Items.Count; i++)
                    {
                        string itemText = listVideo.GetItemText(listVideo.Items[i]);
                        if (itemText.Contains(searchText))
                        {
                            listVideo.SelectedIndex = i;
                            listVideo.TopIndex = i;
                            break;
                        }
                    }
                }
            }
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Fișiere video (*.mp4;*.avi;*.mov)|*.mp4;*.avi;*.mov";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> validExtensions = new List<string> { ".mp4", ".avi", ".mov" };
                List<string> videoFiles = new List<string>();

                foreach (string fileName in openFileDialog.FileNames)
                {
                    string extension = Path.GetExtension(fileName).ToLower();
                    if (validExtensions.Contains(extension))
                    {
                        videoFiles.Add(Path.GetFileName(fileName));
                    }
                }

                listVideo.Items.AddRange(videoFiles.ToArray());
            }
        }

        private void screenPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void rangeVolume_RangeChanged(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            videoPlayer.SetCurrentState(screenPlayer, State.Stop);
            videoPlayer.Execute();
            /*if(screenPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //videoPlayer.Stop();
            }*/
        }

        private void listVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path;
            path = listVideo.GetItemText(listVideo.SelectedItem);
            txtTitle.Text = path;
            videoPlayer.SetCurrentState(screenPlayer, State.Stop);
            videoPlayer.Path = path;
            videoPlayer.GenerateFullPath();
            enableButtons();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            videoPlayer.SetVolume(trackVolume.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            /*int currentSec;
            currentSec = trackBar1.Value;
            screenPlayer.Ctlcontrols.currentPosition = currentSec;*/
        }

        private void trackVolume_Scroll_1(object sender, EventArgs e)
        {
            videoPlayer.SetVolume(trackVolume.Value);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (screenPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                double currentPosition = screenPlayer.Ctlcontrols.currentPosition;
                double frameRate = Convert.ToDouble(screenPlayer.network.encodedFrameRate);
                double totalFrames = screenPlayer.currentMedia.duration * frameRate;
                
                trackBar1.SetRange(0, Convert.ToInt32(totalFrames));
                int trackBarValue = (int)Math.Min(Math.Max(currentPosition * frameRate, trackBar1.Minimum), trackBar1.Maximum);
                if (trackBarValue != trackBar1.Value)
                {
                    trackBar1.Value = trackBarValue;
                }

                if (currentPosition * frameRate >= totalFrames - 1) // TODO next la finalul melodiei
                {
                    int index = listVideo.SelectedIndex;
                    if (videoPlayer.IsLooping)
                    {
                        listVideo.SetSelected(index, true);
                    }
                    else if (index < listVideo.Items.Count - 1)
                        listVideo.SetSelected(++index, true);
                    else
                    {
                        listVideo.SetSelected(0, true);
                    }
                }
            }
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            if (screenPlayer.playState == WMPPlayState.wmppsPlaying || screenPlayer.playState == WMPPlayState.wmppsPaused)
            {
                double newPosition = trackBar1.Value / Convert.ToDouble(screenPlayer.network.encodedFrameRate);
                screenPlayer.Ctlcontrols.currentPosition = newPosition;

                // Adăugați o pauză mică pentru a simula saltul instantaneu
                System.Threading.Thread.Sleep(200); // Ajustați durata pauzei după necesități
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Fișiere video (*.mp4;*.avi;*.mov)|*.mp4;*.avi;*.mov";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> validExtensions = new List<string> { ".mp4", ".avi", ".mov" };
                List<string> videoFiles = new List<string>();

                foreach (string fileName in openFileDialog.FileNames)
                {
                    string extension = Path.GetExtension(fileName).ToLower();
                    if (validExtensions.Contains(extension))
                    {
                        allPlaylists.GetComponentByName(actualPlaylist2.Text).AddNew(new Song(Path.GetFileName(fileName)));
                        listVideo.Items.Add(Path.GetFileName(fileName));
                    }
                }
            }
        }

        private void playlist_Click(object sender, EventArgs e)
        {
            showSubmenu(panelPlaylistTop);
            showSubmenu(panelPlaylistBottom);
        }

        private void Load_Click(object sender, EventArgs e)
        {
            // Crează un meniu derulant
            ToolStripDropDownMenu dropDownMenu = new ToolStripDropDownMenu();

            // Iterează prin playlisturi și adaugă opțiuni în meniul derulant
            foreach (Playlist playlist in allPlaylists.Playlists)
            {
                dropDownMenu.Items.Add(playlist.Name, null, (s, args) => PlaylistOption_Click(playlist));
            }

            // Afișează meniul derulant într-un anumit loc pe ecran
            dropDownMenu.Show(this, LoadPlaylist.Left, LoadPlaylist.Bottom);
            // Setează poziția meniului derulant
            dropDownMenu.Show(this, LoadPlaylist.PointToScreen(new Point(LoadPlaylist.Width - 80, -120)), ToolStripDropDownDirection.Right);
            btnLoad.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void PlaylistOption_Click(Playlist playlist)
        {

            listVideo.Items.Clear();
            foreach(Song song in playlist.Songs)
            {
                listVideo.Items.Add(song.Name);
            }
            actualPlaylist2.Text = playlist.Name;
        }








        private void New_Click(object sender, EventArgs e)
        {
            /* string name = "";
             if (this.ShowDialog() == DialogResult.OK)
             {
                 allPlaylists.Add(new Playlist(name));
             }*/
           string name = "";
            if (InputBox("Dialog Box", "Cum se va numi playlistul?", ref name) == DialogResult.OK)
            {
                allPlaylists.AddNew(new Playlist(name));
            }
            //allPlaylists.Playlists.Sort();
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            System.Windows.Forms.Button buttonOk = new System.Windows.Forms.Button();
            System.Windows.Forms.Button buttonCancel = new System.Windows.Forms.Button();
            form.Text = title;
            label.Text = promptText;
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            label.SetBounds(36, 36, 372, 13);
            textBox.SetBounds(36, 86, 330, 20);
            buttonOk.SetBounds(50, 160, 100, 30);
            buttonCancel.SetBounds(250, 160, 100, 30);
            label.AutoSize = true;
            form.ClientSize = new Size(400, 200);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void DeletePlaylist_Click(object sender, EventArgs e)
        {
            allPlaylists.Remove(allPlaylists.GetComponentByName(actualPlaylist2.Text));
            actualPlaylist2.Text = "";
        }

        private void DeleteSong_Click(object sender, EventArgs e)
        {
            allPlaylists.GetComponentByName(actualPlaylist2.Text).Remove(new Song(listVideo.SelectedItem.ToString()));
            listVideo.Items.RemoveAt(listVideo.SelectedIndex);
            
           // MessageBox.Show(listVideo.SelectedIndex.ToString());
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Shuffle_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int n = listVideo.Items.Count;  
            while (n > 1) {  
                n--;  
                int k = rng.Next(n + 1);  
                object song = listVideo.Items[k];  
                listVideo.Items[k] = listVideo.Items[n];  
                listVideo.Items[n] = song;  
            }
        }

        private void loop_Click(object sender, EventArgs e)
        {
            videoPlayer.LoopState();
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
