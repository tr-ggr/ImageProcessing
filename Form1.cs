using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed, foreground, subtracted, subtractedOutput;
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            loadedView.Image = loaded;

            basicCopyButton.Enabled = true;
            greyScaleButton.Enabled = true;
            sepiaButton.Enabled = true;
            colorInversionButton.Enabled = true;
            histogramButton.Enabled = true;
            loadForegroundToolStripMenuItem.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void basicCopyButton_Click(object sender, EventArgs e)
        {

            BasicDIP.Copy(ref loaded, ref processed);
            processedView.Image = processed;

            saveProcessedImageToolStripMenuItem.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            BasicDIP.Histogram(ref loaded, ref processed);
            processedView.Image = processed;

            saveProcessedImageToolStripMenuItem.Enabled = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            BasicDIP.Greyscale(ref loaded, ref processed);
            processedView.Image = processed;

            saveProcessedImageToolStripMenuItem.Enabled = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            BasicDIP.Inversion(ref loaded, ref processed);
            processedView.Image = processed;

            saveProcessedImageToolStripMenuItem.Enabled = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {

            BasicDIP.Sepia(ref loaded, ref processed);
            processedView.Image = processed;

            saveProcessedImageToolStripMenuItem.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void loadForegroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void sAVEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            BasicDIP.Subtract(ref loaded, ref foreground, ref subtracted);
            subtractView.Image = subtracted;

            subtractGreyScaleButton.Enabled = true;
            subtractSepiaButton.Enabled = true;
            subtractColorInversionButton.Enabled = true;
            subtractHistogramButton.Enabled = true;
            saveSubtractedImageToolStripMenuItem.Enabled = true;
        }

        private void subtractColorInversionButton_Click(object sender, EventArgs e)
        {
            BasicDIP.Inversion(ref subtracted, ref subtractedOutput);
            subtractView.Image = subtractedOutput;
        }

        private void subtractHistogramButton_Click(object sender, EventArgs e)
        {
            BasicDIP.Histogram(ref subtracted, ref subtractedOutput);
            subtractView.Image = subtractedOutput;
        }

        private void subtractSepiaButton_Click(object sender, EventArgs e)
        {
            BasicDIP.Sepia(ref subtracted, ref subtractedOutput);
            subtractView.Image = subtractedOutput;
        }

        private void saveSubtractedImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                subtractView.Image.Save(sfd.FileName, format);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void subtractGreyScaleButton_Click(object sender, EventArgs e)
        {
            BasicDIP.Greyscale(ref subtracted, ref subtractedOutput);
            subtractView.Image = subtractedOutput;


        }

        private void subtractView_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            foreground = new Bitmap(openFileDialog2.FileName);
            foregroundView.Image = foreground;

            subtractButton.Enabled = true;

        }

        private void saveProcessedImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                processedView.Image.Save(sfd.FileName, format);
            }
        }

        //private void errorMessage()
        //{
        //    string message = "Please Load an Image first!";
        //    string title = "Error";
        //    MessageBoxButtons buttons = MessageBoxButtons.OK;
        //    DialogResult result = MessageBox.Show(message, title, buttons);
        //    if (result == DialogResult.OK)
        //    {
        //        openFileDialog1.ShowDialog();
        //    }
        //}
    }
}
