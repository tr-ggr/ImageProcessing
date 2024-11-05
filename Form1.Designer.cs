namespace ImageProcessing
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
            this.processedView = new System.Windows.Forms.PictureBox();
            this.loadedView = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.basicCopyButton = new System.Windows.Forms.Button();
            this.greyScaleButton = new System.Windows.Forms.Button();
            this.colorInversionButton = new System.Windows.Forms.Button();
            this.histogramButton = new System.Windows.Forms.Button();
            this.sepiaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.foregroundView = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadForegroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProcessedImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSubtractedImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.subtractView = new System.Windows.Forms.PictureBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.subtractSepiaButton = new System.Windows.Forms.Button();
            this.subtractHistogramButton = new System.Windows.Forms.Button();
            this.subtractColorInversionButton = new System.Windows.Forms.Button();
            this.subtractGreyScaleButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.loadCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.processedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foregroundView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subtractView)).BeginInit();
            this.SuspendLayout();
            // 
            // processedView
            // 
            this.processedView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processedView.Location = new System.Drawing.Point(898, 95);
            this.processedView.Name = "processedView";
            this.processedView.Size = new System.Drawing.Size(400, 400);
            this.processedView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.processedView.TabIndex = 0;
            this.processedView.TabStop = false;
            this.processedView.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // loadedView
            // 
            this.loadedView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadedView.Location = new System.Drawing.Point(31, 95);
            this.loadedView.Name = "loadedView";
            this.loadedView.Size = new System.Drawing.Size(400, 400);
            this.loadedView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadedView.TabIndex = 1;
            this.loadedView.TabStop = false;
            this.loadedView.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // basicCopyButton
            // 
            this.basicCopyButton.Enabled = false;
            this.basicCopyButton.Location = new System.Drawing.Point(530, 95);
            this.basicCopyButton.Name = "basicCopyButton";
            this.basicCopyButton.Size = new System.Drawing.Size(301, 53);
            this.basicCopyButton.TabIndex = 4;
            this.basicCopyButton.Text = "Basic Copy";
            this.basicCopyButton.UseVisualStyleBackColor = true;
            this.basicCopyButton.Click += new System.EventHandler(this.basicCopyButton_Click);
            // 
            // greyScaleButton
            // 
            this.greyScaleButton.Enabled = false;
            this.greyScaleButton.Location = new System.Drawing.Point(530, 174);
            this.greyScaleButton.Name = "greyScaleButton";
            this.greyScaleButton.Size = new System.Drawing.Size(301, 53);
            this.greyScaleButton.TabIndex = 5;
            this.greyScaleButton.Text = "Greyscale";
            this.greyScaleButton.UseVisualStyleBackColor = true;
            this.greyScaleButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // colorInversionButton
            // 
            this.colorInversionButton.Enabled = false;
            this.colorInversionButton.Location = new System.Drawing.Point(530, 252);
            this.colorInversionButton.Name = "colorInversionButton";
            this.colorInversionButton.Size = new System.Drawing.Size(301, 53);
            this.colorInversionButton.TabIndex = 6;
            this.colorInversionButton.Text = "Color Inversion";
            this.colorInversionButton.UseVisualStyleBackColor = true;
            this.colorInversionButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // histogramButton
            // 
            this.histogramButton.Enabled = false;
            this.histogramButton.Location = new System.Drawing.Point(530, 338);
            this.histogramButton.Name = "histogramButton";
            this.histogramButton.Size = new System.Drawing.Size(301, 53);
            this.histogramButton.TabIndex = 7;
            this.histogramButton.Text = "Histogram";
            this.histogramButton.UseVisualStyleBackColor = true;
            this.histogramButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // sepiaButton
            // 
            this.sepiaButton.Enabled = false;
            this.sepiaButton.Location = new System.Drawing.Point(530, 418);
            this.sepiaButton.Name = "sepiaButton";
            this.sepiaButton.Size = new System.Drawing.Size(301, 53);
            this.sepiaButton.TabIndex = 8;
            this.sepiaButton.Text = "Sepia";
            this.sepiaButton.UseVisualStyleBackColor = true;
            this.sepiaButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 51);
            this.label1.TabIndex = 9;
            this.label1.Text = "OPTIONS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 51);
            this.label2.TabIndex = 13;
            this.label2.Text = "INPUT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1000, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 51);
            this.label3.TabIndex = 14;
            this.label3.Text = "OUTPUT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // foregroundView
            // 
            this.foregroundView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foregroundView.Location = new System.Drawing.Point(31, 543);
            this.foregroundView.Name = "foregroundView";
            this.foregroundView.Size = new System.Drawing.Size(400, 400);
            this.foregroundView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foregroundView.TabIndex = 16;
            this.foregroundView.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Foreground";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.sAVEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1345, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.loadCameraToolStripMenuItem,
            this.loadForegroundToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // loadForegroundToolStripMenuItem
            // 
            this.loadForegroundToolStripMenuItem.Enabled = false;
            this.loadForegroundToolStripMenuItem.Name = "loadForegroundToolStripMenuItem";
            this.loadForegroundToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadForegroundToolStripMenuItem.Text = "Load Foreground";
            this.loadForegroundToolStripMenuItem.Click += new System.EventHandler(this.loadForegroundToolStripMenuItem_Click);
            // 
            // sAVEToolStripMenuItem
            // 
            this.sAVEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveProcessedImageToolStripMenuItem,
            this.saveSubtractedImageToolStripMenuItem});
            this.sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            this.sAVEToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.sAVEToolStripMenuItem.Text = "Save";
            this.sAVEToolStripMenuItem.Click += new System.EventHandler(this.sAVEToolStripMenuItem_Click);
            // 
            // saveProcessedImageToolStripMenuItem
            // 
            this.saveProcessedImageToolStripMenuItem.Enabled = false;
            this.saveProcessedImageToolStripMenuItem.Name = "saveProcessedImageToolStripMenuItem";
            this.saveProcessedImageToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.saveProcessedImageToolStripMenuItem.Text = "Save Processed Image";
            this.saveProcessedImageToolStripMenuItem.Click += new System.EventHandler(this.saveProcessedImageToolStripMenuItem_Click);
            // 
            // saveSubtractedImageToolStripMenuItem
            // 
            this.saveSubtractedImageToolStripMenuItem.Enabled = false;
            this.saveSubtractedImageToolStripMenuItem.Name = "saveSubtractedImageToolStripMenuItem";
            this.saveSubtractedImageToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.saveSubtractedImageToolStripMenuItem.Text = "Save Subtracted Image";
            this.saveSubtractedImageToolStripMenuItem.Click += new System.EventHandler(this.saveSubtractedImageToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(990, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Subtracted Image";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // subtractView
            // 
            this.subtractView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtractView.Location = new System.Drawing.Point(898, 543);
            this.subtractView.Name = "subtractView";
            this.subtractView.Size = new System.Drawing.Size(400, 400);
            this.subtractView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.subtractView.TabIndex = 20;
            this.subtractView.TabStop = false;
            this.subtractView.Click += new System.EventHandler(this.subtractView_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // subtractSepiaButton
            // 
            this.subtractSepiaButton.Enabled = false;
            this.subtractSepiaButton.Location = new System.Drawing.Point(530, 866);
            this.subtractSepiaButton.Name = "subtractSepiaButton";
            this.subtractSepiaButton.Size = new System.Drawing.Size(301, 53);
            this.subtractSepiaButton.TabIndex = 26;
            this.subtractSepiaButton.Text = "Sepia";
            this.subtractSepiaButton.UseVisualStyleBackColor = true;
            this.subtractSepiaButton.Click += new System.EventHandler(this.subtractSepiaButton_Click);
            // 
            // subtractHistogramButton
            // 
            this.subtractHistogramButton.Enabled = false;
            this.subtractHistogramButton.Location = new System.Drawing.Point(530, 786);
            this.subtractHistogramButton.Name = "subtractHistogramButton";
            this.subtractHistogramButton.Size = new System.Drawing.Size(301, 53);
            this.subtractHistogramButton.TabIndex = 25;
            this.subtractHistogramButton.Text = "Histogram";
            this.subtractHistogramButton.UseVisualStyleBackColor = true;
            this.subtractHistogramButton.Click += new System.EventHandler(this.subtractHistogramButton_Click);
            // 
            // subtractColorInversionButton
            // 
            this.subtractColorInversionButton.Enabled = false;
            this.subtractColorInversionButton.Location = new System.Drawing.Point(530, 700);
            this.subtractColorInversionButton.Name = "subtractColorInversionButton";
            this.subtractColorInversionButton.Size = new System.Drawing.Size(301, 53);
            this.subtractColorInversionButton.TabIndex = 24;
            this.subtractColorInversionButton.Text = "Color Inversion";
            this.subtractColorInversionButton.UseVisualStyleBackColor = true;
            this.subtractColorInversionButton.Click += new System.EventHandler(this.subtractColorInversionButton_Click);
            // 
            // subtractGreyScaleButton
            // 
            this.subtractGreyScaleButton.Enabled = false;
            this.subtractGreyScaleButton.Location = new System.Drawing.Point(530, 622);
            this.subtractGreyScaleButton.Name = "subtractGreyScaleButton";
            this.subtractGreyScaleButton.Size = new System.Drawing.Size(301, 53);
            this.subtractGreyScaleButton.TabIndex = 23;
            this.subtractGreyScaleButton.Text = "Greyscale";
            this.subtractGreyScaleButton.UseVisualStyleBackColor = true;
            this.subtractGreyScaleButton.Click += new System.EventHandler(this.subtractGreyScaleButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Enabled = false;
            this.subtractButton.Location = new System.Drawing.Point(530, 543);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(301, 53);
            this.subtractButton.TabIndex = 22;
            this.subtractButton.Text = "Subtract";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // loadCameraToolStripMenuItem
            // 
            this.loadCameraToolStripMenuItem.Name = "loadCameraToolStripMenuItem";
            this.loadCameraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadCameraToolStripMenuItem.Text = "Load Camera";
            this.loadCameraToolStripMenuItem.Click += new System.EventHandler(this.loadCameraToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 1061);
            this.Controls.Add(this.subtractSepiaButton);
            this.Controls.Add(this.subtractHistogramButton);
            this.Controls.Add(this.subtractColorInversionButton);
            this.Controls.Add(this.subtractGreyScaleButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.subtractView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.foregroundView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sepiaButton);
            this.Controls.Add(this.histogramButton);
            this.Controls.Add(this.colorInversionButton);
            this.Controls.Add(this.greyScaleButton);
            this.Controls.Add(this.basicCopyButton);
            this.Controls.Add(this.loadedView);
            this.Controls.Add(this.processedView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Processing by Tristan Tolentino";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foregroundView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subtractView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox processedView;
        private System.Windows.Forms.PictureBox loadedView;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button basicCopyButton;
        private System.Windows.Forms.Button greyScaleButton;
        private System.Windows.Forms.Button colorInversionButton;
        private System.Windows.Forms.Button histogramButton;
        private System.Windows.Forms.Button sepiaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox foregroundView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadForegroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProcessedImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSubtractedImageToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox subtractView;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button subtractSepiaButton;
        private System.Windows.Forms.Button subtractHistogramButton;
        private System.Windows.Forms.Button subtractColorInversionButton;
        private System.Windows.Forms.Button subtractGreyScaleButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.ToolStripMenuItem loadCameraToolStripMenuItem;
    }
}

