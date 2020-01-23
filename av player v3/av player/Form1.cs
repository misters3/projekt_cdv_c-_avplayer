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
using WMPLib;
using Newtonsoft.Json;

namespace av_player
{
    public partial class Form1 : Form
    {
        string jsonFilePath = @"d:\json.json";
        List<MediaFileAddress> mediaFileAddressList = new List<MediaFileAddress>();
        List<MediaFileAddress> mediaFileAddressListDes = new List<MediaFileAddress>();
        JsonSerializer addresToJson = new JsonSerializer();
        string json;
        public Form1()
        {
            InitializeComponent();
            if (File.Exists(jsonFilePath) == true)
            {
                json = File.ReadAllText(jsonFilePath);
                mediaFileAddressListDes = JsonConvert.DeserializeObject<List<MediaFileAddress>>(json);
                mediaFileAddressList.AddRange(mediaFileAddressListDes);
            }
            lbHistory.DataSource = mediaFileAddressList;
            lbHistory.DisplayMember = "mediaAddres";
            
        }

        private void bSearch_Click(object sender, EventArgs e) //finding and returning address of file to text box tbFileLocation
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
                MessageBox.Show("Należy podać lokalizacje pliku.");
            }
            else
            {
                if (File.Exists(tbFileLocation.Text) == true)//chceck if file exists, if there is no file then it's popup messege box with information "there is no file like this"
                {
                    
                    wmPlayer.URL = tbFileLocation.Text;
                    wmPlayer.Ctlcontrols.play();

                    
                    MediaFileAddress mediaAddress = new MediaFileAddress(tbFileLocation.Text);
                    mediaFileAddressList.Add(mediaAddress);
                    json = JsonConvert.SerializeObject(mediaFileAddressList, Formatting.Indented);
                    
                    File.WriteAllText(jsonFilePath, json);
                    lbHistory.DataSource = mediaFileAddressListDes;
                    lbHistory.DataSource = mediaFileAddressList;
                    lbHistory.DisplayMember = "mediaAddres";
                    addresToJson.NullValueHandling = NullValueHandling.Ignore;
                    tbExtension.Text = Path.GetExtension(tbFileLocation.Text);//checking file extensions and writing it to tbExtension textbox
                    long sizeOfFile = new System.IO.FileInfo(tbFileLocation.Text).Length;//get size of files in bytes
                    double sizeOfFileInGB = System.Math.Round(Convert.ToDouble(sizeOfFile) / 1073741824, 3);//this line is converting Bytes to Gigabytes and rounds it to more clear number
                    tbFileSize.Text = sizeOfFileInGB.ToString() + " GB";//this line sends file size in GB to tbFileSize textbox
                    var file = wmPlayer.newMedia(tbFileLocation.Text);
                    TimeSpan fileDuration = TimeSpan.FromSeconds(file.duration);//in this line FileDuration variable finding file total duration using File variable and sending it to tbFileDuration
                    tbFileDuration.Text = fileDuration.ToString();
                    tbHeight.Text = wmPlayer.Height.ToString() + " px";
                    tbWidth.Text = wmPlayer.Width.ToString() + " px";

                }
                else
                {
                    MessageBox.Show("Taki plik nie istnieje.");
                }
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

        private void bFastReverse_Click(object sender, EventArgs e)//playing file in fast reverse mode
        {
            wmPlayer.Ctlcontrols.fastReverse();
        }

        private void bFastForward_Click(object sender, EventArgs e)//playing file in fast forward mode
        {
            wmPlayer.Ctlcontrols.fastForward();
        }

        private void tbExtension_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFileSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFileDuration_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tbHistoryChoiceValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
