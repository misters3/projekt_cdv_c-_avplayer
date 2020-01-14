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
            this.wmPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.wmPlayer.Name = "wmPlayer";
            this.wmPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmPlayer.OcxState")));
            this.wmPlayer.Size = new System.Drawing.Size(554, 335);
            this.wmPlayer.TabIndex = 1;
            // 
            // tbFileLocation
            // 
            this.tbFileLocation.Location = new System.Drawing.Point(0, 339);
            this.tbFileLocation.Margin = new System.Windows.Forms.Padding(2);
            this.tbFileLocation.Name = "tbFileLocation";
            this.tbFileLocation.Size = new System.Drawing.Size(480, 20);
            this.tbFileLocation.TabIndex = 2;
            this.tbFileLocation.TextChanged += new System.EventHandler(this.tbFileLocation_TextChanged);
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(484, 338);
            this.bSearch.Margin = new System.Windows.Forms.Padding(2);
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
            this.bPlay.Text = "odtwórz";
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // bPause
            // 
            this.bPause.Location = new System.Drawing.Point(91, 364);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(88, 38);
            this.bPause.TabIndex = 5;
            this.bPause.Text = "wstrzymaj";
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
            this.bStop.Text = "zatrzymaj";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bUnPause
            // 
            this.bUnPause.Location = new System.Drawing.Point(185, 364);
            this.bUnPause.Name = "bUnPause";
            this.bUnPause.Size = new System.Drawing.Size(88, 38);
            this.bUnPause.TabIndex = 8;
            this.bUnPause.Text = "wznów";
            this.bUnPause.UseVisualStyleBackColor = true;
            this.bUnPause.Click += new System.EventHandler(this.bUnPause_Click);
            // 
            // bFastReverse
            // 
            this.bFastReverse.Location = new System.Drawing.Point(373, 364);
            this.bFastReverse.Name = "bFastReverse";
            this.bFastReverse.Size = new System.Drawing.Size(88, 38);
            this.bFastReverse.TabIndex = 9;
            this.bFastReverse.Text = "przewiń do tyłu";
            this.bFastReverse.UseVisualStyleBackColor = true;
            this.bFastReverse.Click += new System.EventHandler(this.bFastReverse_Click);
            // 
            // bFastForward
            // 
            this.bFastForward.Location = new System.Drawing.Point(467, 364);
            this.bFastForward.Name = "bFastForward";
            this.bFastForward.Size = new System.Drawing.Size(88, 38);
            this.bFastForward.TabIndex = 10;
            this.bFastForward.Text = "przewiń do przodu";
            this.bFastForward.UseVisualStyleBackColor = true;
            this.bFastForward.Click += new System.EventHandler(this.bFastForward_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 404);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

