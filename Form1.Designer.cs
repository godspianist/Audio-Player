namespace Windows_Media_Player
{
    partial class player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(player));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exitbtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.minimizebtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.searchSongs = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.volumeBar = new Bunifu.UI.WinForms.BunifuHSlider();
            this.pause = new Guna.UI2.WinForms.Guna2ImageButton();
            this.playing = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnPlaylist = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnShuffle = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnStop = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnPrev = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnPlayPause = new Guna.UI2.WinForms.Guna2ImageButton();
            this.playLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Artist = new Bunifu.UI.WinForms.BunifuLabel();
            this.songName = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nowPlaying = new Guna.UI2.WinForms.Guna2PictureBox();
            this.wavePanel = new System.Windows.Forms.Panel();
            this.waveform = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.playlistData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nowPlaying)).BeginInit();
            this.wavePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistData)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.exitbtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.exitbtn.CheckedState.Parent = this.exitbtn;
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.HoverState.ImageSize = new System.Drawing.Size(26, 26);
            this.exitbtn.HoverState.Parent = this.exitbtn;
            this.exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("exitbtn.Image")));
            this.exitbtn.ImageRotate = 0F;
            this.exitbtn.ImageSize = new System.Drawing.Size(26, 26);
            this.exitbtn.Location = new System.Drawing.Point(829, 7);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.PressedState.ImageSize = new System.Drawing.Size(18, 18);
            this.exitbtn.PressedState.Parent = this.exitbtn;
            this.exitbtn.Size = new System.Drawing.Size(27, 28);
            this.exitbtn.TabIndex = 0;
            this.exitbtn.UseTransparentBackground = true;
            this.exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // minimizebtn
            // 
            this.minimizebtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizebtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.minimizebtn.CheckedState.Parent = this.minimizebtn;
            this.minimizebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizebtn.HoverState.ImageSize = new System.Drawing.Size(26, 26);
            this.minimizebtn.HoverState.Parent = this.minimizebtn;
            this.minimizebtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizebtn.Image")));
            this.minimizebtn.ImageRotate = 0F;
            this.minimizebtn.ImageSize = new System.Drawing.Size(26, 26);
            this.minimizebtn.Location = new System.Drawing.Point(795, 7);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.PressedState.ImageSize = new System.Drawing.Size(18, 18);
            this.minimizebtn.PressedState.Parent = this.minimizebtn;
            this.minimizebtn.Size = new System.Drawing.Size(28, 28);
            this.minimizebtn.TabIndex = 0;
            this.minimizebtn.UseTransparentBackground = true;
            this.minimizebtn.Click += new System.EventHandler(this.Minimizebtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.searchSongs);
            this.guna2Panel1.Controls.Add(this.minimizebtn);
            this.guna2Panel1.Controls.Add(this.exitbtn);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(865, 69);
            this.guna2Panel1.TabIndex = 1;
            // 
            // searchSongs
            // 
            this.searchSongs.AcceptsReturn = false;
            this.searchSongs.AcceptsTab = false;
            this.searchSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchSongs.AnimationSpeed = 200;
            this.searchSongs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchSongs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchSongs.BackColor = System.Drawing.Color.Transparent;
            this.searchSongs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchSongs.BackgroundImage")));
            this.searchSongs.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.searchSongs.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.searchSongs.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchSongs.BorderColorIdle = System.Drawing.Color.Silver;
            this.searchSongs.BorderRadius = 15;
            this.searchSongs.BorderThickness = 1;
            this.searchSongs.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchSongs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchSongs.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.searchSongs.DefaultText = "";
            this.searchSongs.FillColor = System.Drawing.Color.White;
            this.searchSongs.HideSelection = true;
            this.searchSongs.IconLeft = null;
            this.searchSongs.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchSongs.IconPadding = 10;
            this.searchSongs.IconRight = null;
            this.searchSongs.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchSongs.Lines = new string[0];
            this.searchSongs.Location = new System.Drawing.Point(12, 12);
            this.searchSongs.MaxLength = 32767;
            this.searchSongs.MinimumSize = new System.Drawing.Size(100, 35);
            this.searchSongs.Modified = false;
            this.searchSongs.Multiline = false;
            this.searchSongs.Name = "searchSongs";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchSongs.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchSongs.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchSongs.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchSongs.OnIdleState = stateProperties4;
            this.searchSongs.PasswordChar = '\0';
            this.searchSongs.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchSongs.PlaceholderText = "Search Playlist";
            this.searchSongs.ReadOnly = false;
            this.searchSongs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchSongs.SelectedText = "";
            this.searchSongs.SelectionLength = 0;
            this.searchSongs.SelectionStart = 0;
            this.searchSongs.ShortcutsEnabled = true;
            this.searchSongs.Size = new System.Drawing.Size(318, 35);
            this.searchSongs.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.searchSongs.TabIndex = 2;
            this.searchSongs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchSongs.TextMarginBottom = 0;
            this.searchSongs.TextMarginLeft = 5;
            this.searchSongs.TextMarginTop = 0;
            this.searchSongs.TextPlaceholder = "Search Playlist";
            this.searchSongs.UseSystemPasswordChar = false;
            this.searchSongs.WordWrap = true;
            this.searchSongs.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchSongs_KeyUp);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.volumeBar);
            this.guna2Panel2.Controls.Add(this.pause);
            this.guna2Panel2.Controls.Add(this.playing);
            this.guna2Panel2.Controls.Add(this.btnPlaylist);
            this.guna2Panel2.Controls.Add(this.btnShuffle);
            this.guna2Panel2.Controls.Add(this.btnStop);
            this.guna2Panel2.Controls.Add(this.btnNext);
            this.guna2Panel2.Controls.Add(this.btnPrev);
            this.guna2Panel2.Controls.Add(this.btnPlayPause);
            this.guna2Panel2.Controls.Add(this.playLogo);
            this.guna2Panel2.Controls.Add(this.Artist);
            this.guna2Panel2.Controls.Add(this.songName);
            this.guna2Panel2.Controls.Add(this.panel2);
            this.guna2Panel2.Controls.Add(this.wavePanel);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 69);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(865, 177);
            this.guna2Panel2.TabIndex = 2;
            // 
            // volumeBar
            // 
            this.volumeBar.AllowCursorChanges = true;
            this.volumeBar.AllowHomeEndKeysDetection = false;
            this.volumeBar.AllowIncrementalClickMoves = true;
            this.volumeBar.AllowMouseDownEffects = false;
            this.volumeBar.AllowMouseHoverEffects = false;
            this.volumeBar.AllowScrollingAnimations = true;
            this.volumeBar.AllowScrollKeysDetection = true;
            this.volumeBar.AllowScrollOptionsMenu = true;
            this.volumeBar.AllowShrinkingOnFocusLost = false;
            this.volumeBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volumeBar.BackgroundImage")));
            this.volumeBar.BindingContainer = null;
            this.volumeBar.BorderRadius = 2;
            this.volumeBar.BorderThickness = 1;
            this.volumeBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeBar.DrawThickBorder = false;
            this.volumeBar.DurationBeforeShrink = 2000;
            this.volumeBar.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(253)))), ((int)(((byte)(17)))));
            this.volumeBar.LargeChange = 10;
            this.volumeBar.Location = new System.Drawing.Point(662, 144);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Minimum = 1;
            this.volumeBar.MinimumSize = new System.Drawing.Size(0, 31);
            this.volumeBar.MinimumThumbLength = 18;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.volumeBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.volumeBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.volumeBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.volumeBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.volumeBar.ShrinkSizeLimit = 3;
            this.volumeBar.Size = new System.Drawing.Size(167, 31);
            this.volumeBar.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.volumeBar.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.volumeBar.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.volumeBar.SmallChange = 1;
            this.volumeBar.TabIndex = 13;
            this.volumeBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(253)))), ((int)(((byte)(17)))));
            this.volumeBar.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.volumeBar.ThumbLength = 18;
            this.volumeBar.ThumbMargin = 1;
            this.volumeBar.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.volumeBar.Value = 50;
            this.volumeBar.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.Volume_Scroll);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.Transparent;
            this.pause.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pause.CheckedState.Parent = this.pause;
            this.pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause.HoverState.ImageSize = new System.Drawing.Size(54, 54);
            this.pause.HoverState.Parent = this.pause;
            this.pause.Image = ((System.Drawing.Image)(resources.GetObject("pause.Image")));
            this.pause.ImageRotate = 0F;
            this.pause.ImageSize = new System.Drawing.Size(50, 50);
            this.pause.Location = new System.Drawing.Point(139, 138);
            this.pause.Name = "pause";
            this.pause.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.pause.PressedState.Parent = this.pause;
            this.pause.Size = new System.Drawing.Size(48, 33);
            this.pause.TabIndex = 12;
            this.pause.UseTransparentBackground = true;
            this.pause.Visible = false;
            // 
            // playing
            // 
            this.playing.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.playing.CheckedState.Parent = this.playing;
            this.playing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playing.HoverState.ImageSize = new System.Drawing.Size(54, 54);
            this.playing.HoverState.Parent = this.playing;
            this.playing.Image = ((System.Drawing.Image)(resources.GetObject("playing.Image")));
            this.playing.ImageRotate = 0F;
            this.playing.ImageSize = new System.Drawing.Size(50, 50);
            this.playing.Location = new System.Drawing.Point(203, 138);
            this.playing.Name = "playing";
            this.playing.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.playing.PressedState.Parent = this.playing;
            this.playing.Size = new System.Drawing.Size(48, 33);
            this.playing.TabIndex = 11;
            this.playing.Visible = false;
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPlaylist.CheckedState.Parent = this.btnPlaylist;
            this.btnPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylist.HoverState.ImageSize = new System.Drawing.Size(39, 39);
            this.btnPlaylist.HoverState.Parent = this.btnPlaylist;
            this.btnPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.Image")));
            this.btnPlaylist.ImageRotate = 0F;
            this.btnPlaylist.ImageSize = new System.Drawing.Size(35, 30);
            this.btnPlaylist.Location = new System.Drawing.Point(299, 144);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPlaylist.PressedState.Parent = this.btnPlaylist;
            this.btnPlaylist.Size = new System.Drawing.Size(45, 22);
            this.btnPlaylist.TabIndex = 10;
            this.btnPlaylist.Click += new System.EventHandler(this.BtnPlaylist_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnShuffle.CheckedState.Parent = this.btnShuffle;
            this.btnShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffle.HoverState.ImageSize = new System.Drawing.Size(39, 39);
            this.btnShuffle.HoverState.Parent = this.btnShuffle;
            this.btnShuffle.Image = ((System.Drawing.Image)(resources.GetObject("btnShuffle.Image")));
            this.btnShuffle.ImageRotate = 0F;
            this.btnShuffle.ImageSize = new System.Drawing.Size(35, 35);
            this.btnShuffle.Location = new System.Drawing.Point(346, 144);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnShuffle.PressedState.Parent = this.btnShuffle;
            this.btnShuffle.Size = new System.Drawing.Size(45, 22);
            this.btnShuffle.TabIndex = 9;
            // 
            // btnStop
            // 
            this.btnStop.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnStop.CheckedState.Parent = this.btnStop;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.HoverState.ImageSize = new System.Drawing.Size(39, 39);
            this.btnStop.HoverState.Parent = this.btnStop;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageRotate = 0F;
            this.btnStop.ImageSize = new System.Drawing.Size(35, 35);
            this.btnStop.Location = new System.Drawing.Point(537, 144);
            this.btnStop.Name = "btnStop";
            this.btnStop.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnStop.PressedState.Parent = this.btnStop;
            this.btnStop.Size = new System.Drawing.Size(45, 22);
            this.btnStop.TabIndex = 8;
            this.btnStop.Click += new System.EventHandler(this.Guna2ImageButton2_Click);
            // 
            // btnNext
            // 
            this.btnNext.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.HoverState.ImageSize = new System.Drawing.Size(39, 39);
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageRotate = 0F;
            this.btnNext.ImageSize = new System.Drawing.Size(35, 35);
            this.btnNext.Location = new System.Drawing.Point(490, 144);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNext.PressedState.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(45, 22);
            this.btnNext.TabIndex = 7;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click_1);
            // 
            // btnPrev
            // 
            this.btnPrev.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPrev.CheckedState.Parent = this.btnPrev;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.HoverState.ImageSize = new System.Drawing.Size(39, 39);
            this.btnPrev.HoverState.Parent = this.btnPrev;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageRotate = 0F;
            this.btnPrev.ImageSize = new System.Drawing.Size(35, 35);
            this.btnPrev.Location = new System.Drawing.Point(393, 144);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPrev.PressedState.Parent = this.btnPrev;
            this.btnPrev.Size = new System.Drawing.Size(45, 22);
            this.btnPrev.TabIndex = 6;
            this.btnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPlayPause.CheckedState.Parent = this.btnPlayPause;
            this.btnPlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayPause.HoverState.ImageSize = new System.Drawing.Size(54, 54);
            this.btnPlayPause.HoverState.Parent = this.btnPlayPause;
            this.btnPlayPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayPause.Image")));
            this.btnPlayPause.ImageRotate = 0F;
            this.btnPlayPause.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPlayPause.Location = new System.Drawing.Point(440, 138);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPlayPause.PressedState.Parent = this.btnPlayPause;
            this.btnPlayPause.Size = new System.Drawing.Size(48, 33);
            this.btnPlayPause.TabIndex = 5;
            this.btnPlayPause.Click += new System.EventHandler(this.BtnPlayPause_Click);
            // 
            // playLogo
            // 
            this.playLogo.BackColor = System.Drawing.Color.Transparent;
            this.playLogo.Image = ((System.Drawing.Image)(resources.GetObject("playLogo.Image")));
            this.playLogo.Location = new System.Drawing.Point(162, 11);
            this.playLogo.Name = "playLogo";
            this.playLogo.ShadowDecoration.Parent = this.playLogo;
            this.playLogo.Size = new System.Drawing.Size(38, 34);
            this.playLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playLogo.TabIndex = 4;
            this.playLogo.TabStop = false;
            this.playLogo.UseTransparentBackground = true;
            // 
            // Artist
            // 
            this.Artist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Artist.AutoEllipsis = false;
            this.Artist.CursorType = null;
            this.Artist.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Artist.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Artist.Location = new System.Drawing.Point(203, 31);
            this.Artist.Name = "Artist";
            this.Artist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Artist.Size = new System.Drawing.Size(31, 17);
            this.Artist.TabIndex = 3;
            this.Artist.Text = "Artist";
            this.Artist.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Artist.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // songName
            // 
            this.songName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.songName.AutoEllipsis = false;
            this.songName.CursorType = null;
            this.songName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.songName.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.songName.Location = new System.Drawing.Point(203, 6);
            this.songName.Name = "songName";
            this.songName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.songName.Size = new System.Drawing.Size(31, 22);
            this.songName.TabIndex = 2;
            this.songName.Text = "N/A";
            this.songName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.songName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nowPlaying);
            this.panel2.Location = new System.Drawing.Point(12, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 78);
            this.panel2.TabIndex = 1;
            // 
            // nowPlaying
            // 
            this.nowPlaying.BackColor = System.Drawing.Color.Transparent;
            this.nowPlaying.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nowPlaying.Enabled = false;
            this.nowPlaying.Image = ((System.Drawing.Image)(resources.GetObject("nowPlaying.Image")));
            this.nowPlaying.Location = new System.Drawing.Point(0, 0);
            this.nowPlaying.Name = "nowPlaying";
            this.nowPlaying.ShadowDecoration.Parent = this.nowPlaying;
            this.nowPlaying.Size = new System.Drawing.Size(131, 78);
            this.nowPlaying.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nowPlaying.TabIndex = 0;
            this.nowPlaying.TabStop = false;
            this.nowPlaying.UseTransparentBackground = true;
            // 
            // wavePanel
            // 
            this.wavePanel.Controls.Add(this.waveform);
            this.wavePanel.Location = new System.Drawing.Point(154, 54);
            this.wavePanel.Name = "wavePanel";
            this.wavePanel.Size = new System.Drawing.Size(699, 78);
            this.wavePanel.TabIndex = 0;
            this.wavePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WavePanel_MouseUp);
            // 
            // waveform
            // 
            this.waveform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.waveform.Dock = System.Windows.Forms.DockStyle.Left;
            this.waveform.Location = new System.Drawing.Point(0, 0);
            this.waveform.Name = "waveform";
            this.waveform.Size = new System.Drawing.Size(10, 78);
            this.waveform.TabIndex = 0;
            this.waveform.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(10, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Playlist";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 272);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(841, 8);
            this.bunifuSeparator1.TabIndex = 4;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // playlistData
            // 
            this.playlistData.AllowDrop = true;
            this.playlistData.AllowUserToAddRows = false;
            this.playlistData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.playlistData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.playlistData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playlistData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.playlistData.BackgroundColor = System.Drawing.Color.White;
            this.playlistData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.playlistData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.playlistData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.playlistData.ColumnHeadersHeight = 21;
            this.playlistData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.genre,
            this.Column3,
            this.Column4});
            this.playlistData.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.playlistData.DefaultCellStyle = dataGridViewCellStyle3;
            this.playlistData.EnableHeadersVisualStyles = false;
            this.playlistData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.playlistData.Location = new System.Drawing.Point(12, 283);
            this.playlistData.Name = "playlistData";
            this.playlistData.RowHeadersVisible = false;
            this.playlistData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.playlistData.Size = new System.Drawing.Size(841, 234);
            this.playlistData.TabIndex = 6;
            this.playlistData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.playlistData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.playlistData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.playlistData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.playlistData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.playlistData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.playlistData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.playlistData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.playlistData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.playlistData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.playlistData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.playlistData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.playlistData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.playlistData.ThemeStyle.HeaderStyle.Height = 21;
            this.playlistData.ThemeStyle.ReadOnly = false;
            this.playlistData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.playlistData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.playlistData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.playlistData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.playlistData.ThemeStyle.RowsStyle.Height = 22;
            this.playlistData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.playlistData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.playlistData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlaylistData_CellContentClick);
            this.playlistData.VisibleChanged += new System.EventHandler(this.PlaylistData_VisibleChanged);
            this.playlistData.DragDrop += new System.Windows.Forms.DragEventHandler(this.PlaylistData_DragDrop_1);
            this.playlistData.DragEnter += new System.Windows.Forms.DragEventHandler(this.PlaylistData_DragEnter_1);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 20F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Track";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // genre
            // 
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Artist";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Duration";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Audio Files|*.mp3";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(865, 530);
            this.Controls.Add(this.playlistData);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "player";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nowPlaying)).EndInit();
            this.wavePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waveform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton exitbtn;
        private Guna.UI2.WinForms.Guna2ImageButton minimizebtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox searchSongs;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Bunifu.UI.WinForms.BunifuLabel Artist;
        private Bunifu.UI.WinForms.BunifuLabel songName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel wavePanel;
        private Guna.UI2.WinForms.Guna2PictureBox playLogo;
        private System.Windows.Forms.PictureBox waveform;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Guna.UI2.WinForms.Guna2DataGridView playlistData;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2PictureBox nowPlaying;
        private Guna.UI2.WinForms.Guna2ImageButton btnShuffle;
        private Guna.UI2.WinForms.Guna2ImageButton btnStop;
        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
        private Guna.UI2.WinForms.Guna2ImageButton btnPrev;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlayPause;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlaylist;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2ImageButton pause;
        private Guna.UI2.WinForms.Guna2ImageButton playing;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuHSlider volumeBar;
    }
}

