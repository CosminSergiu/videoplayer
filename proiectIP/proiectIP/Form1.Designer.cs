namespace proiectIP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelPlaylistBottom = new System.Windows.Forms.Panel();
            this.NewPlaylist = new System.Windows.Forms.Button();
            this.DeleteSong = new System.Windows.Forms.Button();
            this.AddSong = new System.Windows.Forms.Button();
            this.panelSubmeniuHome2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panelSubmeniuHome = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.playlist = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeletePlaylist = new System.Windows.Forms.Button();
            this.LoadPlaylist = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loop = new System.Windows.Forms.Button();
            this.shuffle = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnVolume = new System.Windows.Forms.Button();
            this.bunifuRange1 = new Bunifu.Framework.UI.BunifuRange();
            this.listVideo = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.actualPlaylist = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panelPlaylistTop = new System.Windows.Forms.Panel();
            this.screenPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.label5 = new System.Windows.Forms.Label();
            this.actualPlaylist2 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelPlaylistBottom.SuspendLayout();
            this.panelSubmeniuHome2.SuspendLayout();
            this.panelSubmeniuHome.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.panelPlaylistTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.Controls.Add(this.panelPlaylistBottom);
            this.panelMenu.Controls.Add(this.panelSubmeniuHome2);
            this.panelMenu.Controls.Add(this.panelSubmeniuHome);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.playlist);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Location = new System.Drawing.Point(3, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(116, 592);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panelPlaylistBottom
            // 
            this.panelPlaylistBottom.Controls.Add(this.NewPlaylist);
            this.panelPlaylistBottom.Controls.Add(this.DeleteSong);
            this.panelPlaylistBottom.Controls.Add(this.AddSong);
            this.panelPlaylistBottom.Location = new System.Drawing.Point(3, 424);
            this.panelPlaylistBottom.Name = "panelPlaylistBottom";
            this.panelPlaylistBottom.Size = new System.Drawing.Size(113, 117);
            this.panelPlaylistBottom.TabIndex = 8;
            // 
            // NewPlaylist
            // 
            this.NewPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewPlaylist.FlatAppearance.BorderSize = 0;
            this.NewPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewPlaylist.ForeColor = System.Drawing.Color.White;
            this.NewPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("NewPlaylist.Image")));
            this.NewPlaylist.Location = new System.Drawing.Point(27, 3);
            this.NewPlaylist.Name = "NewPlaylist";
            this.NewPlaylist.Size = new System.Drawing.Size(81, 38);
            this.NewPlaylist.TabIndex = 12;
            this.NewPlaylist.Text = "New";
            this.NewPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewPlaylist.UseVisualStyleBackColor = true;
            this.NewPlaylist.Click += new System.EventHandler(this.New_Click);
            // 
            // DeleteSong
            // 
            this.DeleteSong.FlatAppearance.BorderSize = 0;
            this.DeleteSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSong.ForeColor = System.Drawing.Color.White;
            this.DeleteSong.Image = ((System.Drawing.Image)(resources.GetObject("DeleteSong.Image")));
            this.DeleteSong.Location = new System.Drawing.Point(2, 45);
            this.DeleteSong.Name = "DeleteSong";
            this.DeleteSong.Size = new System.Drawing.Size(104, 29);
            this.DeleteSong.TabIndex = 10;
            this.DeleteSong.Text = "Song";
            this.DeleteSong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteSong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteSong.UseVisualStyleBackColor = true;
            this.DeleteSong.Click += new System.EventHandler(this.DeleteSong_Click);
            // 
            // AddSong
            // 
            this.AddSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddSong.FlatAppearance.BorderSize = 0;
            this.AddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSong.ForeColor = System.Drawing.Color.White;
            this.AddSong.Image = ((System.Drawing.Image)(resources.GetObject("AddSong.Image")));
            this.AddSong.Location = new System.Drawing.Point(-3, 77);
            this.AddSong.Name = "AddSong";
            this.AddSong.Size = new System.Drawing.Size(91, 37);
            this.AddSong.TabIndex = 9;
            this.AddSong.Text = "Add";
            this.AddSong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddSong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddSong.UseVisualStyleBackColor = true;
            this.AddSong.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panelSubmeniuHome2
            // 
            this.panelSubmeniuHome2.Controls.Add(this.panel3);
            this.panelSubmeniuHome2.Controls.Add(this.btnHelp);
            this.panelSubmeniuHome2.Controls.Add(this.btnAbout);
            this.panelSubmeniuHome2.Location = new System.Drawing.Point(3, 190);
            this.panelSubmeniuHome2.Name = "panelSubmeniuHome2";
            this.panelSubmeniuHome2.Size = new System.Drawing.Size(113, 83);
            this.panelSubmeniuHome2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 100);
            this.panel3.TabIndex = 7;
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(116, 30);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click_1);
            // 
            // btnAbout
            // 
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 37);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(123, 35);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click_1);
            // 
            // panelSubmeniuHome
            // 
            this.panelSubmeniuHome.Controls.Add(this.btnLoad);
            this.panelSubmeniuHome.Controls.Add(this.btnDelete);
            this.panelSubmeniuHome.Location = new System.Drawing.Point(3, 67);
            this.panelSubmeniuHome.Name = "panelSubmeniuHome";
            this.panelSubmeniuHome.Size = new System.Drawing.Size(113, 77);
            this.panelSubmeniuHome.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(-3, 8);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLoad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLoad.Size = new System.Drawing.Size(119, 30);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(-3, 44);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(126, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.Location = new System.Drawing.Point(3, 138);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btnHome.Size = new System.Drawing.Size(113, 55);
            this.btnHome.TabIndex = 1;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // playlist
            // 
            this.playlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playlist.FlatAppearance.BorderSize = 0;
            this.playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlist.Image = ((System.Drawing.Image)(resources.GetObject("playlist.Image")));
            this.playlist.Location = new System.Drawing.Point(30, 363);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(79, 55);
            this.playlist.TabIndex = 7;
            this.playlist.UseVisualStyleBackColor = true;
            this.playlist.Click += new System.EventHandler(this.playlist_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(116, 64);
            this.panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = ".iMP4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(-3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "     ";
            // 
            // DeletePlaylist
            // 
            this.DeletePlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletePlaylist.FlatAppearance.BorderSize = 0;
            this.DeletePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePlaylist.ForeColor = System.Drawing.Color.White;
            this.DeletePlaylist.Image = ((System.Drawing.Image)(resources.GetObject("DeletePlaylist.Image")));
            this.DeletePlaylist.Location = new System.Drawing.Point(3, 0);
            this.DeletePlaylist.Name = "DeletePlaylist";
            this.DeletePlaylist.Size = new System.Drawing.Size(113, 38);
            this.DeletePlaylist.TabIndex = 11;
            this.DeletePlaylist.Text = "Playlist";
            this.DeletePlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeletePlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeletePlaylist.UseVisualStyleBackColor = true;
            this.DeletePlaylist.Click += new System.EventHandler(this.DeletePlaylist_Click);
            // 
            // LoadPlaylist
            // 
            this.LoadPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadPlaylist.FlatAppearance.BorderSize = 0;
            this.LoadPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPlaylist.ForeColor = System.Drawing.Color.White;
            this.LoadPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("LoadPlaylist.Image")));
            this.LoadPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadPlaylist.Location = new System.Drawing.Point(30, 35);
            this.LoadPlaylist.Name = "LoadPlaylist";
            this.LoadPlaylist.Size = new System.Drawing.Size(83, 32);
            this.LoadPlaylist.TabIndex = 8;
            this.LoadPlaylist.Text = "Load";
            this.LoadPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoadPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoadPlaylist.UseVisualStyleBackColor = true;
            this.LoadPlaylist.Click += new System.EventHandler(this.Load_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.loop);
            this.panel1.Controls.Add(this.shuffle);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.trackVolume);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnVolume);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(125, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 39);
            this.panel1.TabIndex = 2;
            // 
            // loop
            // 
            this.loop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loop.FlatAppearance.BorderSize = 0;
            this.loop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loop.Image = ((System.Drawing.Image)(resources.GetObject("loop.Image")));
            this.loop.Location = new System.Drawing.Point(1008, 4);
            this.loop.Name = "loop";
            this.loop.Size = new System.Drawing.Size(38, 35);
            this.loop.TabIndex = 12;
            this.loop.Text = "   ";
            this.loop.UseVisualStyleBackColor = true;
            this.loop.Click += new System.EventHandler(this.loop_Click);
            // 
            // shuffle
            // 
            this.shuffle.FlatAppearance.BorderSize = 0;
            this.shuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shuffle.Image = ((System.Drawing.Image)(resources.GetObject("shuffle.Image")));
            this.shuffle.Location = new System.Drawing.Point(967, 5);
            this.shuffle.Name = "shuffle";
            this.shuffle.Size = new System.Drawing.Size(35, 29);
            this.shuffle.TabIndex = 11;
            this.shuffle.Text = "  ";
            this.shuffle.UseVisualStyleBackColor = true;
            this.shuffle.Click += new System.EventHandler(this.Shuffle_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.CausesValidation = false;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar1.Location = new System.Drawing.Point(321, 9);
            this.trackBar1.Maximum = 300;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(640, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(37, 9);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(132, 45);
            this.trackVolume.TabIndex = 9;
            this.trackVolume.TabStop = false;
            this.trackVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackVolume.Scroll += new System.EventHandler(this.trackVolume_Scroll_1);
            // 
            // btnStop
            // 
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(253, 9);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(31, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = " ";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(165, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(38, 32);
            this.btnBack.TabIndex = 7;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(290, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 32);
            this.btnNext.TabIndex = 6;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(209, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(38, 32);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnVolume
            // 
            this.btnVolume.FlatAppearance.BorderSize = 0;
            this.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolume.Image = ((System.Drawing.Image)(resources.GetObject("btnVolume.Image")));
            this.btnVolume.Location = new System.Drawing.Point(3, 3);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(38, 32);
            this.btnVolume.TabIndex = 4;
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // bunifuRange1
            // 
            this.bunifuRange1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRange1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuRange1.BorderRadius = 0;
            this.bunifuRange1.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.bunifuRange1.Location = new System.Drawing.Point(2244, 2390);
            this.bunifuRange1.Margin = new System.Windows.Forms.Padding(22);
            this.bunifuRange1.MaximumRange = 100;
            this.bunifuRange1.Name = "bunifuRange1";
            this.bunifuRange1.RangeMax = 49;
            this.bunifuRange1.RangeMin = 0;
            this.bunifuRange1.Size = new System.Drawing.Size(1946, 30);
            this.bunifuRange1.TabIndex = 3;
            // 
            // listVideo
            // 
            this.listVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.listVideo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVideo.ForeColor = System.Drawing.Color.White;
            this.listVideo.FormattingEnabled = true;
            this.listVideo.ItemHeight = 20;
            this.listVideo.Location = new System.Drawing.Point(504, 468);
            this.listVideo.Name = "listVideo";
            this.listVideo.Size = new System.Drawing.Size(670, 120);
            this.listVideo.TabIndex = 4;
            this.listVideo.SelectedIndexChanged += new System.EventHandler(this.listVideo_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.actualPlaylist2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.actualPlaylist);
            this.panel2.Controls.Add(this.searchBar);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(125, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 126);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // actualPlaylist
            // 
            this.actualPlaylist.AutoSize = true;
            this.actualPlaylist.Location = new System.Drawing.Point(5, 38);
            this.actualPlaylist.Name = "actualPlaylist";
            this.actualPlaylist.Size = new System.Drawing.Size(0, 20);
            this.actualPlaylist.TabIndex = 8;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.ForeColor = System.Drawing.Color.White;
            this.searchBar.Location = new System.Drawing.Point(62, 11);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(266, 26);
            this.searchBar.TabIndex = 10;
            this.searchBar.Text = "Search...";
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(55, 95);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(247, 19);
            this.txtTitle.TabIndex = 9;
            this.txtTitle.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(0, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "     ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "     ";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(23, 23);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(23, 23);
            this.toolStripDropDownButton3.Text = "toolStripDropDownButton3";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(100, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // panelPlaylistTop
            // 
            this.panelPlaylistTop.Controls.Add(this.DeletePlaylist);
            this.panelPlaylistTop.Controls.Add(this.LoadPlaylist);
            this.panelPlaylistTop.Location = new System.Drawing.Point(3, 282);
            this.panelPlaylistTop.Name = "panelPlaylistTop";
            this.panelPlaylistTop.Size = new System.Drawing.Size(119, 80);
            this.panelPlaylistTop.TabIndex = 7;
            // 
            // screenPlayer
            // 
            this.screenPlayer.Enabled = true;
            this.screenPlayer.Location = new System.Drawing.Point(125, 6);
            this.screenPlayer.Name = "screenPlayer";
            this.screenPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("screenPlayer.OcxState")));
            this.screenPlayer.Size = new System.Drawing.Size(1046, 415);
            this.screenPlayer.TabIndex = 6;
            this.screenPlayer.Enter += new System.EventHandler(this.screenPlayer_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(7, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "    ";
            // 
            // actualPlaylist2
            // 
            this.actualPlaylist2.AutoSize = true;
            this.actualPlaylist2.ForeColor = System.Drawing.Color.White;
            this.actualPlaylist2.Location = new System.Drawing.Point(58, 52);
            this.actualPlaylist2.Name = "actualPlaylist2";
            this.actualPlaylist2.Size = new System.Drawing.Size(51, 20);
            this.actualPlaylist2.TabIndex = 12;
            this.actualPlaylist2.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1177, 601);
            this.Controls.Add(this.panelPlaylistTop);
            this.Controls.Add(this.screenPlayer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listVideo);
            this.Controls.Add(this.bunifuRange1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(120)))), ((int)(((byte)(140)))));
            this.Name = "Form1";
            this.Text = "Video Player";
            this.panelMenu.ResumeLayout(false);
            this.panelPlaylistBottom.ResumeLayout(false);
            this.panelSubmeniuHome2.ResumeLayout(false);
            this.panelSubmeniuHome.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.panelPlaylistTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.screenPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button loop;

        private System.Windows.Forms.Button shuffle;

        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;

        private System.Windows.Forms.Button DeleteSong;
        private System.Windows.Forms.Button DeletePlaylist;

        private System.Windows.Forms.Button AddSong;
        private System.Windows.Forms.Button NewPlaylist;

        private System.Windows.Forms.Button playlist;
        private System.Windows.Forms.Button LoadPlaylist;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Timer timer;

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSubmeniuHome;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuRange bunifuRange1;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ListBox listVideo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panelSubmeniuHome2;
        private System.Windows.Forms.TextBox searchBar;
        private AxWMPLib.AxWindowsMediaPlayer screenPlayer;
        private System.Windows.Forms.Button btnStop;
        internal System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Label actualPlaylist;
        private System.Windows.Forms.Panel panelPlaylistBottom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelPlaylistTop;
        private System.Windows.Forms.Label actualPlaylist2;
        private System.Windows.Forms.Label label5;
    }
}

