﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Diagnostics.Tracing;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed, foreground, subtracted, subtractedOutput;

        BitmapFilter convFilters;


        private FilterInfoCollection videoDevices; // Collection of camera devices
        private VideoCaptureDevice videoSource; // Selected camera device
     

        public Form1()
        {
            InitializeComponent();

            convFilters = new BitmapFilter();

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
            smoothingButton.Enabled = true;
            blurButton.Enabled = true;
            sharpenButton.Enabled = true;
            meanRemovalButton.Enabled = true;
            embossButton.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
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
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }

            loaded?.Dispose();

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

            if (videoSource != null && videoSource.IsRunning)
            {
                Bitmap temp = (Bitmap)loaded.Clone();

                BasicDIP.Subtract(ref temp, ref foreground, ref subtracted);
            }
            else
            {
                BasicDIP.Subtract(ref loaded, ref foreground, ref subtracted);
            }

           
            subtractView.Image = subtracted;

            subtractGreyScaleButton.Enabled = true;
            subtractSepiaButton.Enabled = true;
            subtractColorInversionButton.Enabled = true;
            subtractHistogramButton.Enabled = true;
            saveSubtractedImageToolStripMenuItem.Enabled = true;

            sepiaSubtractButton.Enabled = true;
            smoothSubtractButton.Enabled = true;
            blurSubtractButton.Enabled = true;
            sharpenSubtractButton.Enabled = true;
            meanSubtractButton.Enabled = true;
            embossSubtractButton.Enabled = true;
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

        private void loadCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No video sources found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            videoSource.Start();

            basicCopyButton.Enabled = true;
            greyScaleButton.Enabled = true;
            sepiaButton.Enabled = true;
            colorInversionButton.Enabled = true;
            histogramButton.Enabled = true;
            loadForegroundToolStripMenuItem.Enabled = true;
            smoothingButton.Enabled = true;
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            loaded = bitmap;


            // Display the frame in the PictureBox
            loadedView.Image = bitmap;
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
            base.OnFormClosing(e);
        }

        private void convuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void greyScaleButton_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                Bitmap temp = (Bitmap)loaded.Clone();

                BasicDIP.Greyscale(ref temp, ref processed);
            }
            else
            {
                BasicDIP.Greyscale(ref loaded, ref processed);
            }

            processedView.Image = processed;


            saveProcessedImageToolStripMenuItem.Enabled = true;
        }

        private void SharpenButton_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)loaded.Clone();

            BitmapFilter.Sharpen(temp, 11);

            processedView.Image = temp;

            saveProcessedImageToolStripMenuItem.Enabled = true;
        }

        private void BlurButton_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)loaded.Clone();

            BitmapFilter.GaussianBlur(temp, 50);

            processedView.Image = temp;

            saveProcessedImageToolStripMenuItem.Enabled = true;
        }

        private void EdgeEnhanceButton_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)loaded.Clone();

            BitmapFilter.EdgeEnhance(temp, (byte)100);

            processedView.Image = temp;

            saveProcessedImageToolStripMenuItem.Enabled = true;
        }

        private void EdgeDetectButton_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)loaded.Clone();

            BitmapFilter.EdgeDetectDifference(temp, (byte)0);

            processedView.Image = temp;

            saveProcessedImageToolStripMenuItem.Enabled = true;
        }

        private void EmbossButton_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)loaded.Clone();

            BitmapFilter.EmbossLaplacian(temp);

            processedView.Image = temp;

            saveProcessedImageToolStripMenuItem.Enabled = true;
        }

        private void basicCopyButton_Click_1(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                Bitmap temp = (Bitmap)loaded.Clone();

                BasicDIP.Copy(ref temp, ref processed);
            }
            else
            {
                BasicDIP.Copy(ref loaded, ref processed);
            }

            processedView.Image = processed;


            saveProcessedImageToolStripMenuItem.Enabled = true;
        }

        private void colorInversionButton_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                Bitmap temp = (Bitmap)loaded.Clone();

                BasicDIP.Inversion(ref temp, ref processed);
            }
            else
            {
                BasicDIP.Inversion(ref loaded, ref processed);
            }

            processedView.Image = processed;


            saveProcessedImageToolStripMenuItem.Enabled = true;
        }

        private void histogramButton_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                Bitmap temp = (Bitmap)loaded.Clone();

                BasicDIP.Histogram(ref temp, ref processed);
            }
            else
            {
                BasicDIP.Histogram(ref loaded, ref processed);
            }

            processedView.Image = processed;


            saveProcessedImageToolStripMenuItem.Enabled = true;
        }

        private void sepiaButton_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                Bitmap temp = (Bitmap)loaded.Clone();

                BasicDIP.Sepia(ref temp, ref processed);
            }
            else
            {
                BasicDIP.Sepia(ref loaded, ref processed);
            }

            processedView.Image = processed;


            saveProcessedImageToolStripMenuItem.Enabled = true;
        }

        private void SmoothingButton_Click(object sender, EventArgs e)
        {

        }

        private void EdgeDetectButton_Click_1(object sender, EventArgs e)
        {

        }

        private void EdgeEnhanceButton_Click_1(object sender, EventArgs e)
        {

        }

        private void BlurButton_Click_1(object sender, EventArgs e)
        {

        }

        private void EmbossButton_Click_1(object sender, EventArgs e)
        {

        }

        private void SmoothingButton_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void smoothingButton_Click_2(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)loaded.Clone();

            BitmapFilter.Smooth(temp, 1);

            processedView.Image = temp;

            saveProcessedImageToolStripMenuItem.Enabled = true;
        }

        private void blurButton_Click_2(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)loaded.Clone();

            BitmapFilter.GaussianBlur(temp, 4);

            processedView.Image = temp;

            saveProcessedImageToolStripMenuItem.Enabled = true;
        }

        private void meanRemovalButton_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)loaded.Clone();

            BitmapFilter.MeanRemoval(temp, 9);

            processedView.Image = temp;

            saveProcessedImageToolStripMenuItem.Enabled = true;
        }

        private void sharpenButton_Click_1(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)loaded.Clone();

            BitmapFilter.Sharpen(temp, 11);

            processedView.Image = temp;

            saveProcessedImageToolStripMenuItem.Enabled = true;
        }

        private void embossButton_Click_2(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)loaded.Clone();

            BitmapFilter.EmbossLaplacian(temp);

            processedView.Image = temp;

            saveProcessedImageToolStripMenuItem.Enabled = true;

        }

        private void subtractGreyScaleButton_Click_1(object sender, EventArgs e)
        {
            BasicDIP.Greyscale(ref subtracted, ref subtractedOutput);
            subtractView.Image = subtractedOutput;
        }

        private void subtractColorInversionButton_Click_1(object sender, EventArgs e)
        {
            BasicDIP.Inversion(ref subtracted, ref subtractedOutput);
            subtractView.Image = subtractedOutput;
        }

        private void subtractHistogramButton_Click_1(object sender, EventArgs e)
        {
            BasicDIP.Histogram(ref subtracted, ref subtractedOutput);
            subtractView.Image = subtractedOutput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)subtracted.Clone();

            BitmapFilter.GaussianBlur(temp, 4);

            processedView.Image = temp;

            saveProcessedImageToolStripMenuItem.Enabled = true;
        }

        private void smoothSubtractButton_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)subtracted.Clone();

            BitmapFilter.Smooth(temp, 1);

            subtractView.Image = temp;
        }

        private void blurSubtractButton_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)subtracted.Clone();

            BitmapFilter.GaussianBlur(temp, 4);

            subtractView.Image = temp;
        }

        private void sharpenSubtractButton_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)subtracted.Clone();

            BitmapFilter.Sharpen(temp, 11);

            subtractView.Image = temp;
        }

        private void meanSubtractButton_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)subtracted.Clone();

            BitmapFilter.MeanRemoval(temp, 9);

            subtractView.Image = temp;

        }

        private void embossSubtractButton_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)subtracted.Clone();

            BitmapFilter.EmbossLaplacian(temp);

            subtractView.Image = temp;
        }

        private void sepiaSubtractButton_Click(object sender, EventArgs e)
        {
            BasicDIP.Sepia(ref subtracted, ref subtractedOutput);
            subtractView.Image = subtractedOutput;
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
