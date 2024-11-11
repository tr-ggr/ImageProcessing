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
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.foregroundView = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadForegroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProcessedImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSubtractedImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeEnhanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.subtractView = new System.Windows.Forms.PictureBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.subtractButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sepiaButton = new System.Windows.Forms.Button();
            this.histogramButton = new System.Windows.Forms.Button();
            this.colorInversionButton = new System.Windows.Forms.Button();
            this.greyScaleButton = new System.Windows.Forms.Button();
            this.basicCopyButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.smoothingButton = new System.Windows.Forms.Button();
            this.embossButton = new System.Windows.Forms.Button();
            this.meanRemovalButton = new System.Windows.Forms.Button();
            this.sharpenButton = new System.Windows.Forms.Button();
            this.blurButton = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.subtractSepiaButton = new System.Windows.Forms.Button();
            this.subtractGreyScaleButton = new System.Windows.Forms.Button();
            this.subtractHistogramButton = new System.Windows.Forms.Button();
            this.subtractColorInversionButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.embossSubtractButton = new System.Windows.Forms.Button();
            this.meanSubtractButton = new System.Windows.Forms.Button();
            this.sharpenSubtractButton = new System.Windows.Forms.Button();
            this.blurSubtractButton = new System.Windows.Forms.Button();
            this.smoothSubtractButton = new System.Windows.Forms.Button();
            this.sepiaSubtractButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.processedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foregroundView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subtractView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.sAVEToolStripMenuItem,
            this.convuToolStripMenuItem});
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
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // loadCameraToolStripMenuItem
            // 
            this.loadCameraToolStripMenuItem.Name = "loadCameraToolStripMenuItem";
            this.loadCameraToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.loadCameraToolStripMenuItem.Text = "Load Camera";
            this.loadCameraToolStripMenuItem.Click += new System.EventHandler(this.loadCameraToolStripMenuItem_Click);
            // 
            // loadForegroundToolStripMenuItem
            // 
            this.loadForegroundToolStripMenuItem.Enabled = false;
            this.loadForegroundToolStripMenuItem.Name = "loadForegroundToolStripMenuItem";
            this.loadForegroundToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
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
            // convuToolStripMenuItem
            // 
            this.convuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertToolStripMenuItem,
            this.blurToolStripMenuItem,
            this.edgeEnhanceToolStripMenuItem,
            this.edgeDetectToolStripMenuItem,
            this.embossToolStripMenuItem});
            this.convuToolStripMenuItem.Name = "convuToolStripMenuItem";
            this.convuToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.convuToolStripMenuItem.Text = "Convolution Filters";
            this.convuToolStripMenuItem.Click += new System.EventHandler(this.convuToolStripMenuItem_Click);
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.invertToolStripMenuItem.Text = "Sharpen";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.blurToolStripMenuItem.Text = "Blur";
            // 
            // edgeEnhanceToolStripMenuItem
            // 
            this.edgeEnhanceToolStripMenuItem.Name = "edgeEnhanceToolStripMenuItem";
            this.edgeEnhanceToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.edgeEnhanceToolStripMenuItem.Text = "Edge Enhance";
            // 
            // edgeDetectToolStripMenuItem
            // 
            this.edgeDetectToolStripMenuItem.Name = "edgeDetectToolStripMenuItem";
            this.edgeDetectToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.edgeDetectToolStripMenuItem.Text = "Edge Detect";
            // 
            // embossToolStripMenuItem
            // 
            this.embossToolStripMenuItem.Name = "embossToolStripMenuItem";
            this.embossToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.embossToolStripMenuItem.Text = "Emboss";
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
            // subtractButton
            // 
            this.subtractButton.Enabled = false;
            this.subtractButton.Location = new System.Drawing.Point(518, 534);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(301, 53);
            this.subtractButton.TabIndex = 22;
            this.subtractButton.Text = "Subtract";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(487, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(362, 413);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sepiaButton);
            this.tabPage1.Controls.Add(this.histogramButton);
            this.tabPage1.Controls.Add(this.colorInversionButton);
            this.tabPage1.Controls.Add(this.greyScaleButton);
            this.tabPage1.Controls.Add(this.basicCopyButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(354, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic DIP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sepiaButton
            // 
            this.sepiaButton.Enabled = false;
            this.sepiaButton.Location = new System.Drawing.Point(27, 302);
            this.sepiaButton.Name = "sepiaButton";
            this.sepiaButton.Size = new System.Drawing.Size(301, 53);
            this.sepiaButton.TabIndex = 13;
            this.sepiaButton.Text = "Sepia";
            this.sepiaButton.UseVisualStyleBackColor = true;
            this.sepiaButton.Click += new System.EventHandler(this.sepiaButton_Click);
            // 
            // histogramButton
            // 
            this.histogramButton.Enabled = false;
            this.histogramButton.Location = new System.Drawing.Point(27, 233);
            this.histogramButton.Name = "histogramButton";
            this.histogramButton.Size = new System.Drawing.Size(301, 53);
            this.histogramButton.TabIndex = 12;
            this.histogramButton.Text = "Histogram";
            this.histogramButton.UseVisualStyleBackColor = true;
            this.histogramButton.Click += new System.EventHandler(this.histogramButton_Click);
            // 
            // colorInversionButton
            // 
            this.colorInversionButton.Enabled = false;
            this.colorInversionButton.Location = new System.Drawing.Point(27, 164);
            this.colorInversionButton.Name = "colorInversionButton";
            this.colorInversionButton.Size = new System.Drawing.Size(301, 53);
            this.colorInversionButton.TabIndex = 11;
            this.colorInversionButton.Text = "Color Inversion";
            this.colorInversionButton.UseVisualStyleBackColor = true;
            this.colorInversionButton.Click += new System.EventHandler(this.colorInversionButton_Click);
            // 
            // greyScaleButton
            // 
            this.greyScaleButton.Enabled = false;
            this.greyScaleButton.Location = new System.Drawing.Point(27, 92);
            this.greyScaleButton.Name = "greyScaleButton";
            this.greyScaleButton.Size = new System.Drawing.Size(301, 53);
            this.greyScaleButton.TabIndex = 10;
            this.greyScaleButton.Text = "Greyscale";
            this.greyScaleButton.UseVisualStyleBackColor = true;
            this.greyScaleButton.Click += new System.EventHandler(this.greyScaleButton_Click);
            // 
            // basicCopyButton
            // 
            this.basicCopyButton.Enabled = false;
            this.basicCopyButton.Location = new System.Drawing.Point(27, 24);
            this.basicCopyButton.Name = "basicCopyButton";
            this.basicCopyButton.Size = new System.Drawing.Size(301, 53);
            this.basicCopyButton.TabIndex = 9;
            this.basicCopyButton.Text = "Basic Copy";
            this.basicCopyButton.UseVisualStyleBackColor = true;
            this.basicCopyButton.Click += new System.EventHandler(this.basicCopyButton_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.embossButton);
            this.tabPage2.Controls.Add(this.meanRemovalButton);
            this.tabPage2.Controls.Add(this.sharpenButton);
            this.tabPage2.Controls.Add(this.blurButton);
            this.tabPage2.Controls.Add(this.smoothingButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(354, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conv Filters";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // smoothingButton
            // 
            this.smoothingButton.Enabled = false;
            this.smoothingButton.Location = new System.Drawing.Point(26, 23);
            this.smoothingButton.Name = "smoothingButton";
            this.smoothingButton.Size = new System.Drawing.Size(301, 53);
            this.smoothingButton.TabIndex = 25;
            this.smoothingButton.Text = "Smoothing";
            this.smoothingButton.UseVisualStyleBackColor = true;
            this.smoothingButton.Click += new System.EventHandler(this.smoothingButton_Click_2);
            // 
            // embossButton
            // 
            this.embossButton.Enabled = false;
            this.embossButton.Location = new System.Drawing.Point(26, 299);
            this.embossButton.Name = "embossButton";
            this.embossButton.Size = new System.Drawing.Size(301, 53);
            this.embossButton.TabIndex = 29;
            this.embossButton.Text = "Emboss Laplascian ";
            this.embossButton.UseVisualStyleBackColor = true;
            this.embossButton.Click += new System.EventHandler(this.embossButton_Click_2);
            // 
            // meanRemovalButton
            // 
            this.meanRemovalButton.Enabled = false;
            this.meanRemovalButton.Location = new System.Drawing.Point(26, 230);
            this.meanRemovalButton.Name = "meanRemovalButton";
            this.meanRemovalButton.Size = new System.Drawing.Size(301, 53);
            this.meanRemovalButton.TabIndex = 28;
            this.meanRemovalButton.Text = "Mean Removal ";
            this.meanRemovalButton.UseVisualStyleBackColor = true;
            this.meanRemovalButton.Click += new System.EventHandler(this.meanRemovalButton_Click);
            // 
            // sharpenButton
            // 
            this.sharpenButton.Enabled = false;
            this.sharpenButton.Location = new System.Drawing.Point(26, 162);
            this.sharpenButton.Name = "sharpenButton";
            this.sharpenButton.Size = new System.Drawing.Size(301, 53);
            this.sharpenButton.TabIndex = 27;
            this.sharpenButton.Text = "Sharpen ";
            this.sharpenButton.UseVisualStyleBackColor = true;
            this.sharpenButton.Click += new System.EventHandler(this.sharpenButton_Click_1);
            // 
            // blurButton
            // 
            this.blurButton.Enabled = false;
            this.blurButton.Location = new System.Drawing.Point(26, 93);
            this.blurButton.Name = "blurButton";
            this.blurButton.Size = new System.Drawing.Size(301, 53);
            this.blurButton.TabIndex = 26;
            this.blurButton.Text = "Gaussian Blur";
            this.blurButton.UseVisualStyleBackColor = true;
            this.blurButton.Click += new System.EventHandler(this.blurButton_Click_2);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(487, 608);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(362, 335);
            this.tabControl2.TabIndex = 28;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.sepiaSubtractButton);
            this.tabPage3.Controls.Add(this.subtractSepiaButton);
            this.tabPage3.Controls.Add(this.subtractGreyScaleButton);
            this.tabPage3.Controls.Add(this.subtractHistogramButton);
            this.tabPage3.Controls.Add(this.subtractColorInversionButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(354, 306);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Basic DIP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.embossSubtractButton);
            this.tabPage4.Controls.Add(this.meanSubtractButton);
            this.tabPage4.Controls.Add(this.sharpenSubtractButton);
            this.tabPage4.Controls.Add(this.blurSubtractButton);
            this.tabPage4.Controls.Add(this.smoothSubtractButton);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(354, 306);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Conv Filters";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // subtractSepiaButton
            // 
            this.subtractSepiaButton.Enabled = false;
            this.subtractSepiaButton.Location = new System.Drawing.Point(499, 904);
            this.subtractSepiaButton.Name = "subtractSepiaButton";
            this.subtractSepiaButton.Size = new System.Drawing.Size(301, 53);
            this.subtractSepiaButton.TabIndex = 30;
            this.subtractSepiaButton.Text = "Sepia";
            this.subtractSepiaButton.UseVisualStyleBackColor = true;
            // 
            // subtractGreyScaleButton
            // 
            this.subtractGreyScaleButton.Enabled = false;
            this.subtractGreyScaleButton.Location = new System.Drawing.Point(27, 23);
            this.subtractGreyScaleButton.Name = "subtractGreyScaleButton";
            this.subtractGreyScaleButton.Size = new System.Drawing.Size(301, 53);
            this.subtractGreyScaleButton.TabIndex = 27;
            this.subtractGreyScaleButton.Text = "Greyscale";
            this.subtractGreyScaleButton.UseVisualStyleBackColor = true;
            this.subtractGreyScaleButton.Click += new System.EventHandler(this.subtractGreyScaleButton_Click_1);
            // 
            // subtractHistogramButton
            // 
            this.subtractHistogramButton.Enabled = false;
            this.subtractHistogramButton.Location = new System.Drawing.Point(27, 141);
            this.subtractHistogramButton.Name = "subtractHistogramButton";
            this.subtractHistogramButton.Size = new System.Drawing.Size(301, 53);
            this.subtractHistogramButton.TabIndex = 29;
            this.subtractHistogramButton.Text = "Histogram";
            this.subtractHistogramButton.UseVisualStyleBackColor = true;
            this.subtractHistogramButton.Click += new System.EventHandler(this.subtractHistogramButton_Click_1);
            // 
            // subtractColorInversionButton
            // 
            this.subtractColorInversionButton.Enabled = false;
            this.subtractColorInversionButton.Location = new System.Drawing.Point(27, 82);
            this.subtractColorInversionButton.Name = "subtractColorInversionButton";
            this.subtractColorInversionButton.Size = new System.Drawing.Size(301, 53);
            this.subtractColorInversionButton.TabIndex = 28;
            this.subtractColorInversionButton.Text = "Color Inversion";
            this.subtractColorInversionButton.UseVisualStyleBackColor = true;
            this.subtractColorInversionButton.Click += new System.EventHandler(this.subtractColorInversionButton_Click_1);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(499, 901);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 53);
            this.button1.TabIndex = 30;
            this.button1.Text = "Sepia";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // embossSubtractButton
            // 
            this.embossSubtractButton.Enabled = false;
            this.embossSubtractButton.Location = new System.Drawing.Point(26, 245);
            this.embossSubtractButton.Name = "embossSubtractButton";
            this.embossSubtractButton.Size = new System.Drawing.Size(301, 53);
            this.embossSubtractButton.TabIndex = 40;
            this.embossSubtractButton.Text = "Emboss Laplascian ";
            this.embossSubtractButton.UseVisualStyleBackColor = true;
            this.embossSubtractButton.Click += new System.EventHandler(this.embossSubtractButton_Click);
            // 
            // meanSubtractButton
            // 
            this.meanSubtractButton.Enabled = false;
            this.meanSubtractButton.Location = new System.Drawing.Point(27, 186);
            this.meanSubtractButton.Name = "meanSubtractButton";
            this.meanSubtractButton.Size = new System.Drawing.Size(301, 53);
            this.meanSubtractButton.TabIndex = 39;
            this.meanSubtractButton.Text = "Mean Removal ";
            this.meanSubtractButton.UseVisualStyleBackColor = true;
            this.meanSubtractButton.Click += new System.EventHandler(this.meanSubtractButton_Click);
            // 
            // sharpenSubtractButton
            // 
            this.sharpenSubtractButton.Enabled = false;
            this.sharpenSubtractButton.Location = new System.Drawing.Point(26, 127);
            this.sharpenSubtractButton.Name = "sharpenSubtractButton";
            this.sharpenSubtractButton.Size = new System.Drawing.Size(301, 53);
            this.sharpenSubtractButton.TabIndex = 38;
            this.sharpenSubtractButton.Text = "Sharpen ";
            this.sharpenSubtractButton.UseVisualStyleBackColor = true;
            this.sharpenSubtractButton.Click += new System.EventHandler(this.sharpenSubtractButton_Click);
            // 
            // blurSubtractButton
            // 
            this.blurSubtractButton.Enabled = false;
            this.blurSubtractButton.Location = new System.Drawing.Point(26, 68);
            this.blurSubtractButton.Name = "blurSubtractButton";
            this.blurSubtractButton.Size = new System.Drawing.Size(301, 53);
            this.blurSubtractButton.TabIndex = 37;
            this.blurSubtractButton.Text = "Gaussian Blur";
            this.blurSubtractButton.UseVisualStyleBackColor = true;
            this.blurSubtractButton.Click += new System.EventHandler(this.blurSubtractButton_Click);
            // 
            // smoothSubtractButton
            // 
            this.smoothSubtractButton.Enabled = false;
            this.smoothSubtractButton.Location = new System.Drawing.Point(26, 9);
            this.smoothSubtractButton.Name = "smoothSubtractButton";
            this.smoothSubtractButton.Size = new System.Drawing.Size(301, 53);
            this.smoothSubtractButton.TabIndex = 36;
            this.smoothSubtractButton.Text = "Smoothing";
            this.smoothSubtractButton.UseVisualStyleBackColor = true;
            this.smoothSubtractButton.Click += new System.EventHandler(this.smoothSubtractButton_Click);
            // 
            // sepiaSubtractButton
            // 
            this.sepiaSubtractButton.Enabled = false;
            this.sepiaSubtractButton.Location = new System.Drawing.Point(27, 200);
            this.sepiaSubtractButton.Name = "sepiaSubtractButton";
            this.sepiaSubtractButton.Size = new System.Drawing.Size(301, 53);
            this.sepiaSubtractButton.TabIndex = 31;
            this.sepiaSubtractButton.Text = "Sepia";
            this.sepiaSubtractButton.UseVisualStyleBackColor = true;
            this.sepiaSubtractButton.Click += new System.EventHandler(this.sepiaSubtractButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 1061);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.subtractView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.foregroundView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadedView);
            this.Controls.Add(this.processedView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tabControl2);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox processedView;
        private System.Windows.Forms.PictureBox loadedView;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
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
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.ToolStripMenuItem loadCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeEnhanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button sepiaButton;
        private System.Windows.Forms.Button histogramButton;
        private System.Windows.Forms.Button colorInversionButton;
        private System.Windows.Forms.Button greyScaleButton;
        private System.Windows.Forms.Button basicCopyButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button smoothingButton;
        private System.Windows.Forms.Button embossButton;
        private System.Windows.Forms.Button meanRemovalButton;
        private System.Windows.Forms.Button sharpenButton;
        private System.Windows.Forms.Button blurButton;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button subtractSepiaButton;
        private System.Windows.Forms.Button subtractGreyScaleButton;
        private System.Windows.Forms.Button subtractHistogramButton;
        private System.Windows.Forms.Button subtractColorInversionButton;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button embossSubtractButton;
        private System.Windows.Forms.Button meanSubtractButton;
        private System.Windows.Forms.Button sharpenSubtractButton;
        private System.Windows.Forms.Button blurSubtractButton;
        private System.Windows.Forms.Button smoothSubtractButton;
        private System.Windows.Forms.Button sepiaSubtractButton;
    }
}

