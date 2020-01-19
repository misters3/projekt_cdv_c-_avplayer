namespace av_player
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wmPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.tbFileLocation = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.bPlay = new System.Windows.Forms.Button();
            this.bPause = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.bStop = new System.Windows.Forms.Button();
            this.bUnPause = new System.Windows.Forms.Button();
            this.bFastReverse = new System.Windows.Forms.Button();
            this.bFastForward = new System.Windows.Forms.Button();
            this.tbExtension = new System.Windows.Forms.TextBox();
            this.lFileExtension = new System.Windows.Forms.Label();
            this.lFileSize = new System.Windows.Forms.Label();
            this.tbFileSize = new System.Windows.Forms.TextBox();
            this.lFileDuration = new System.Windows.Forms.Label();
            this.tbFileDuration = new System.Windows.Forms.TextBox();
            this.lHeight = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.lWidth = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wmPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wmPlayer
            // 
            this.wmPlayer.Enabled = true;
            this.wmPlayer.Location = new System.Drawing.Point(0, 0);
            this.wmPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wmPlayer.Name = "wmPlayer";
            this.wmPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmPlayer.OcxState")));
            this.wmPlayer.Size = new System.Drawing.Size(554, 335);
            this.wmPlayer.TabIndex = 1;
            // 
            // tbFileLocation
            // 
            this.tbFileLocation.Location = new System.Drawing.Point(0, 339);
            this.tbFileLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFileLocation.Name = "tbFileLocation";
            this.tbFileLocation.Size = new System.Drawing.Size(480, 20);
            this.tbFileLocation.TabIndex = 2;
            this.tbFileLocation.TextChanged += new System.EventHandler(this.tbFileLocation_TextChanged);
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(484, 339);
            this.bSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(71, 21);
            this.bSearch.TabIndex = 3;
            this.bSearch.Text = "szukaj pliku";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bPlay
            // 
            this.bPlay.AutoSize = true;
            this.bPlay.Location = new System.Drawing.Point(0, 364);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(85, 38);
            this.bPlay.TabIndex = 4;
            this.bPlay.Text = "Odtwórz";
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // bPause
            // 
            this.bPause.Location = new System.Drawing.Point(91, 364);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(88, 38);
            this.bPause.TabIndex = 5;
            this.bPause.Text = "Wstrzymaj";
            this.bPause.UseVisualStyleBackColor = true;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(698, 24);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(279, 364);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(88, 38);
            this.bStop.TabIndex = 7;
            this.bStop.Text = "Zatrzymaj";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bUnPause
            // 
            this.bUnPause.Location = new System.Drawing.Point(185, 364);
            this.bUnPause.Name = "bUnPause";
            this.bUnPause.Size = new System.Drawing.Size(88, 38);
            this.bUnPause.TabIndex = 8;
            this.bUnPause.Text = "Wznów";
            this.bUnPause.UseVisualStyleBackColor = true;
            this.bUnPause.Click += new System.EventHandler(this.bUnPause_Click);
            // 
            // bFastReverse
            // 
            this.bFastReverse.Location = new System.Drawing.Point(373, 364);
            this.bFastReverse.Name = "bFastReverse";
            this.bFastReverse.Size = new System.Drawing.Size(88, 38);
            this.bFastReverse.TabIndex = 9;
            this.bFastReverse.Text = "Przewiń do tyłu";
            this.bFastReverse.UseVisualStyleBackColor = true;
            this.bFastReverse.Click += new System.EventHandler(this.bFastReverse_Click);
            // 
            // bFastForward
            // 
            this.bFastForward.Location = new System.Drawing.Point(467, 364);
            this.bFastForward.Name = "bFastForward";
            this.bFastForward.Size = new System.Drawing.Size(88, 38);
            this.bFastForward.TabIndex = 10;
            this.bFastForward.Text = "Przewiń do przodu";
            this.bFastForward.UseVisualStyleBackColor = true;
            this.bFastForward.Click += new System.EventHandler(this.bFastForward_Click);
            // 
            // tbExtension
            // 
            this.tbExtension.Location = new System.Drawing.Point(559, 28);
            this.tbExtension.Name = "tbExtension";
            this.tbExtension.ReadOnly = true;
            this.tbExtension.Size = new System.Drawing.Size(138, 20);
            this.tbExtension.TabIndex = 11;
            this.tbExtension.TextChanged += new System.EventHandler(this.tbExtension_TextChanged);
            // 
            // lFileExtension
            // 
            this.lFileExtension.AutoSize = true;
            this.lFileExtension.Location = new System.Drawing.Point(556, 11);
            this.lFileExtension.Name = "lFileExtension";
            this.lFileExtension.Size = new System.Drawing.Size(98, 13);
            this.lFileExtension.TabIndex = 12;
            this.lFileExtension.Text = "Rozszerzenie pliku:";
            // 
            // lFileSize
            // 
            this.lFileSize.AutoSize = true;
            this.lFileSize.Location = new System.Drawing.Point(556, 60);
            this.lFileSize.Name = "lFileSize";
            this.lFileSize.Size = new System.Drawing.Size(79, 13);
            this.lFileSize.TabIndex = 13;
            this.lFileSize.Text = "Wielkość pliku:";
            // 
            // tbFileSize
            // 
            this.tbFileSize.Location = new System.Drawing.Point(559, 76);
            this.tbFileSize.Name = "tbFileSize";
            this.tbFileSize.ReadOnly = true;
            this.tbFileSize.Size = new System.Drawing.Size(138, 20);
            this.tbFileSize.TabIndex = 14;
            this.tbFileSize.TextChanged += new System.EventHandler(this.tbFileSize_TextChanged);
            // 
            // lFileDuration
            // 
            this.lFileDuration.AutoSize = true;
            this.lFileDuration.Location = new System.Drawing.Point(556, 113);
            this.lFileDuration.Name = "lFileDuration";
            this.lFileDuration.Size = new System.Drawing.Size(95, 13);
            this.lFileDuration.TabIndex = 15;
            this.lFileDuration.Text = "Czas trwania pliku:";
            // 
            // tbFileDuration
            // 
            this.tbFileDuration.Location = new System.Drawing.Point(559, 129);
            this.tbFileDuration.Name = "tbFileDuration";
            this.tbFileDuration.ReadOnly = true;
            this.tbFileDuration.Size = new System.Drawing.Size(139, 20);
            this.tbFileDuration.TabIndex = 16;
            this.tbFileDuration.TextChanged += new System.EventHandler(this.tbFileDuration_TextChanged);
            // 
            // lHeight
            // 
            this.lHeight.AutoSize = true;
            this.lHeight.Location = new System.Drawing.Point(556, 166);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(57, 13);
            this.lHeight.TabIndex = 17;
            this.lHeight.Text = "Wysokość";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(559, 182);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.ReadOnly = true;
            this.tbHeight.Size = new System.Drawing.Size(139, 20);
            this.tbHeight.TabIndex = 18;
            this.tbHeight.TextChanged += new System.EventHandler(this.tbHeight_TextChanged);
            // 
            // lWidth
            // 
            this.lWidth.AutoSize = true;
            this.lWidth.Location = new System.Drawing.Point(556, 220);
            this.lWidth.Name = "lWidth";
            this.lWidth.Size = new System.Drawing.Size(57, 13);
            this.lWidth.TabIndex = 19;
            this.lWidth.Text = "Szerokość";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(559, 237);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.ReadOnly = true;
            this.tbWidth.Size = new System.Drawing.Size(139, 20);
            this.tbWidth.TabIndex = 20;
            this.tbWidth.TextChanged += new System.EventHandler(this.tbWidth_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 404);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.lWidth);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.lHeight);
            this.Controls.Add(this.tbFileDuration);
            this.Controls.Add(this.lFileDuration);
            this.Controls.Add(this.tbFileSize);
            this.Controls.Add(this.lFileSize);
            this.Controls.Add(this.lFileExtension);
            this.Controls.Add(this.tbExtension);
            this.Controls.Add(this.bFastForward);
            this.Controls.Add(this.bFastReverse);
            this.Controls.Add(this.bUnPause);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bPause);
            this.Controls.Add(this.bPlay);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.tbFileLocation);
            this.Controls.Add(this.wmPlayer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "odtwarzacz Audio/Video";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private AxWMPLib.AxWindowsMediaPlayer wmPlayer;
        private System.Windows.Forms.TextBox tbFileLocation;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Button bPause;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bUnPause;
        private System.Windows.Forms.Button bFastReverse;
        private System.Windows.Forms.Button bFastForward;
        private System.Windows.Forms.TextBox tbExtension;
        private System.Windows.Forms.Label lFileExtension;
        private System.Windows.Forms.Label lFileSize;
        private System.Windows.Forms.TextBox tbFileSize;
        private System.Windows.Forms.Label lFileDuration;
        private System.Windows.Forms.TextBox tbFileDuration;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label lWidth;
        private System.Windows.Forms.TextBox tbWidth;
    }
}

