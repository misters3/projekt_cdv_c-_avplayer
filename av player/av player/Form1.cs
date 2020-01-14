using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace av_player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bSearch_Click(object sender, EventArgs e) //finding and returning address of file to text box
        {
            OpenFileDialog FindFile = new OpenFileDialog();
            if (FindFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.tbFileLocation.Text = FindFile.FileName;
            }
        }

        private void tbFileLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bPlay_Click(object sender, EventArgs e)//load and play audio or video file when path is added else it throws communicate it's empty
        {
            if (tbFileLocation.Text == "") 
            {
                MessageBox.Show("należy podać lokalizacje pliku");
            }
            else
            {
                wmPlayer.URL = tbFileLocation.Text;
                wmPlayer.Ctlcontrols.play();
            }
        }

        private void bPause_Click(object sender, EventArgs e)//pause file
        {
            wmPlayer.Ctlcontrols.pause();
        }

        private void bStop_Click(object sender, EventArgs e)//stop playing file
        {
            wmPlayer.Ctlcontrols.stop();
        }

        private void bUnPause_Click(object sender, EventArgs e)//unpause file
        {
            wmPlayer.Ctlcontrols.play();
        }

        private void bFastReverse_Click(object sender, EventArgs e)
        {
            wmPlayer.Ctlcontrols.fastReverse();
        }

        private void bFastForward_Click(object sender, EventArgs e)
        {
            wmPlayer.Ctlcontrols.fastForward();
        }
    }
}
