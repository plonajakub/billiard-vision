namespace ImageDatasetBuilder
{
    partial class mainForm
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.filmToImageTabPage = new System.Windows.Forms.TabPage();
            this.convertionStatusGroupBox = new System.Windows.Forms.GroupBox();
            this.conversionStatusLabel = new System.Windows.Forms.Label();
            this.conversionButton = new System.Windows.Forms.Button();
            this.conversionProgressBar = new System.Windows.Forms.ProgressBar();
            this.convertionAttributesGroupBox = new System.Windows.Forms.GroupBox();
            this.durutionValueLabel = new System.Windows.Forms.Label();
            this.stepValueLabel = new System.Windows.Forms.Label();
            this.offsetValueLabel = new System.Windows.Forms.Label();
            this.durutionTrackBar = new System.Windows.Forms.TrackBar();
            this.durutionConstantLabel = new System.Windows.Forms.Label();
            this.stepTrackBar = new System.Windows.Forms.TrackBar();
            this.offsetTrackBar = new System.Windows.Forms.TrackBar();
            this.stepConstantLabel = new System.Windows.Forms.Label();
            this.offsetConstantLabel = new System.Windows.Forms.Label();
            this.filePropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.chooseOutputDirectoryButton = new System.Windows.Forms.Button();
            this.chooseFilmButton = new System.Windows.Forms.Button();
            this.imagesDirectoryPanel = new System.Windows.Forms.Panel();
            this.outputDirectoryConstantLabel = new System.Windows.Forms.Label();
            this.outputDirectoryStateLabel = new System.Windows.Forms.Label();
            this.outputDirectoryInfoLabel = new System.Windows.Forms.Label();
            this.filmPathPanel = new System.Windows.Forms.Panel();
            this.filmPathConstantLabel = new System.Windows.Forms.Label();
            this.filmPathStatusLabel = new System.Windows.Forms.Label();
            this.filmPathInfoLabel = new System.Windows.Forms.Label();
            this.imgDatasetCreaterTabPage = new System.Windows.Forms.TabPage();
            this.selected_type_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainTabControl.SuspendLayout();
            this.filmToImageTabPage.SuspendLayout();
            this.convertionStatusGroupBox.SuspendLayout();
            this.convertionAttributesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durutionTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetTrackBar)).BeginInit();
            this.filePropertiesGroupBox.SuspendLayout();
            this.imagesDirectoryPanel.SuspendLayout();
            this.filmPathPanel.SuspendLayout();
            this.imgDatasetCreaterTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.filmToImageTabPage);
            this.mainTabControl.Controls.Add(this.imgDatasetCreaterTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(13, 13);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1132, 591);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainTabControl_KeyPress);
            // 
            // filmToImageTabPage
            // 
            this.filmToImageTabPage.Controls.Add(this.convertionStatusGroupBox);
            this.filmToImageTabPage.Controls.Add(this.convertionAttributesGroupBox);
            this.filmToImageTabPage.Controls.Add(this.filePropertiesGroupBox);
            this.filmToImageTabPage.Location = new System.Drawing.Point(4, 25);
            this.filmToImageTabPage.Name = "filmToImageTabPage";
            this.filmToImageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.filmToImageTabPage.Size = new System.Drawing.Size(1124, 562);
            this.filmToImageTabPage.TabIndex = 0;
            this.filmToImageTabPage.Text = "Film-To-Image Converter";
            this.filmToImageTabPage.UseVisualStyleBackColor = true;
            // 
            // convertionStatusGroupBox
            // 
            this.convertionStatusGroupBox.Controls.Add(this.conversionStatusLabel);
            this.convertionStatusGroupBox.Controls.Add(this.conversionButton);
            this.convertionStatusGroupBox.Controls.Add(this.conversionProgressBar);
            this.convertionStatusGroupBox.Location = new System.Drawing.Point(6, 319);
            this.convertionStatusGroupBox.Name = "convertionStatusGroupBox";
            this.convertionStatusGroupBox.Size = new System.Drawing.Size(1112, 237);
            this.convertionStatusGroupBox.TabIndex = 2;
            this.convertionStatusGroupBox.TabStop = false;
            this.convertionStatusGroupBox.Text = "Convertion status";
            // 
            // conversionStatusLabel
            // 
            this.conversionStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conversionStatusLabel.Location = new System.Drawing.Point(473, 138);
            this.conversionStatusLabel.Name = "conversionStatusLabel";
            this.conversionStatusLabel.Size = new System.Drawing.Size(171, 81);
            this.conversionStatusLabel.TabIndex = 2;
            this.conversionStatusLabel.Text = "*conversion status*";
            this.conversionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conversionButton
            // 
            this.conversionButton.Location = new System.Drawing.Point(6, 34);
            this.conversionButton.Name = "conversionButton";
            this.conversionButton.Size = new System.Drawing.Size(128, 43);
            this.conversionButton.TabIndex = 1;
            this.conversionButton.Text = "Convert";
            this.conversionButton.UseVisualStyleBackColor = true;
            // 
            // conversionProgressBar
            // 
            this.conversionProgressBar.Location = new System.Drawing.Point(6, 83);
            this.conversionProgressBar.Name = "conversionProgressBar";
            this.conversionProgressBar.Size = new System.Drawing.Size(1099, 30);
            this.conversionProgressBar.TabIndex = 0;
            // 
            // convertionAttributesGroupBox
            // 
            this.convertionAttributesGroupBox.Controls.Add(this.durutionValueLabel);
            this.convertionAttributesGroupBox.Controls.Add(this.stepValueLabel);
            this.convertionAttributesGroupBox.Controls.Add(this.offsetValueLabel);
            this.convertionAttributesGroupBox.Controls.Add(this.durutionTrackBar);
            this.convertionAttributesGroupBox.Controls.Add(this.durutionConstantLabel);
            this.convertionAttributesGroupBox.Controls.Add(this.stepTrackBar);
            this.convertionAttributesGroupBox.Controls.Add(this.offsetTrackBar);
            this.convertionAttributesGroupBox.Controls.Add(this.stepConstantLabel);
            this.convertionAttributesGroupBox.Controls.Add(this.offsetConstantLabel);
            this.convertionAttributesGroupBox.Location = new System.Drawing.Point(579, 7);
            this.convertionAttributesGroupBox.Name = "convertionAttributesGroupBox";
            this.convertionAttributesGroupBox.Size = new System.Drawing.Size(539, 306);
            this.convertionAttributesGroupBox.TabIndex = 1;
            this.convertionAttributesGroupBox.TabStop = false;
            this.convertionAttributesGroupBox.Text = "Convertion attributes";
            // 
            // durutionValueLabel
            // 
            this.durutionValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.durutionValueLabel.Location = new System.Drawing.Point(431, 191);
            this.durutionValueLabel.Name = "durutionValueLabel";
            this.durutionValueLabel.Size = new System.Drawing.Size(88, 55);
            this.durutionValueLabel.TabIndex = 8;
            this.durutionValueLabel.Text = "*value*";
            this.durutionValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stepValueLabel
            // 
            this.stepValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stepValueLabel.Location = new System.Drawing.Point(431, 112);
            this.stepValueLabel.Name = "stepValueLabel";
            this.stepValueLabel.Size = new System.Drawing.Size(88, 55);
            this.stepValueLabel.TabIndex = 7;
            this.stepValueLabel.Text = "*value*";
            this.stepValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // offsetValueLabel
            // 
            this.offsetValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.offsetValueLabel.Location = new System.Drawing.Point(431, 35);
            this.offsetValueLabel.Name = "offsetValueLabel";
            this.offsetValueLabel.Size = new System.Drawing.Size(88, 55);
            this.offsetValueLabel.TabIndex = 6;
            this.offsetValueLabel.Text = "*value*";
            this.offsetValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // durutionTrackBar
            // 
            this.durutionTrackBar.Location = new System.Drawing.Point(178, 191);
            this.durutionTrackBar.Name = "durutionTrackBar";
            this.durutionTrackBar.Size = new System.Drawing.Size(243, 56);
            this.durutionTrackBar.TabIndex = 5;
            // 
            // durutionConstantLabel
            // 
            this.durutionConstantLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.durutionConstantLabel.Location = new System.Drawing.Point(27, 191);
            this.durutionConstantLabel.Name = "durutionConstantLabel";
            this.durutionConstantLabel.Size = new System.Drawing.Size(134, 56);
            this.durutionConstantLabel.TabIndex = 4;
            this.durutionConstantLabel.Text = "Durution:";
            this.durutionConstantLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stepTrackBar
            // 
            this.stepTrackBar.Location = new System.Drawing.Point(178, 111);
            this.stepTrackBar.Name = "stepTrackBar";
            this.stepTrackBar.Size = new System.Drawing.Size(243, 56);
            this.stepTrackBar.TabIndex = 3;
            // 
            // offsetTrackBar
            // 
            this.offsetTrackBar.Location = new System.Drawing.Point(178, 34);
            this.offsetTrackBar.Name = "offsetTrackBar";
            this.offsetTrackBar.Size = new System.Drawing.Size(243, 56);
            this.offsetTrackBar.TabIndex = 2;
            // 
            // stepConstantLabel
            // 
            this.stepConstantLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stepConstantLabel.Location = new System.Drawing.Point(27, 111);
            this.stepConstantLabel.Name = "stepConstantLabel";
            this.stepConstantLabel.Size = new System.Drawing.Size(134, 56);
            this.stepConstantLabel.TabIndex = 1;
            this.stepConstantLabel.Text = "Step:";
            this.stepConstantLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // offsetConstantLabel
            // 
            this.offsetConstantLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.offsetConstantLabel.Location = new System.Drawing.Point(27, 34);
            this.offsetConstantLabel.Name = "offsetConstantLabel";
            this.offsetConstantLabel.Size = new System.Drawing.Size(134, 56);
            this.offsetConstantLabel.TabIndex = 0;
            this.offsetConstantLabel.Text = "Offset:";
            this.offsetConstantLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filePropertiesGroupBox
            // 
            this.filePropertiesGroupBox.Controls.Add(this.chooseOutputDirectoryButton);
            this.filePropertiesGroupBox.Controls.Add(this.chooseFilmButton);
            this.filePropertiesGroupBox.Controls.Add(this.imagesDirectoryPanel);
            this.filePropertiesGroupBox.Controls.Add(this.filmPathPanel);
            this.filePropertiesGroupBox.Location = new System.Drawing.Point(6, 6);
            this.filePropertiesGroupBox.Name = "filePropertiesGroupBox";
            this.filePropertiesGroupBox.Size = new System.Drawing.Size(566, 307);
            this.filePropertiesGroupBox.TabIndex = 0;
            this.filePropertiesGroupBox.TabStop = false;
            this.filePropertiesGroupBox.Text = "File properties";
            // 
            // chooseOutputDirectoryButton
            // 
            this.chooseOutputDirectoryButton.Location = new System.Drawing.Point(6, 172);
            this.chooseOutputDirectoryButton.Name = "chooseOutputDirectoryButton";
            this.chooseOutputDirectoryButton.Size = new System.Drawing.Size(128, 46);
            this.chooseOutputDirectoryButton.TabIndex = 6;
            this.chooseOutputDirectoryButton.Text = "Choose output directory";
            this.chooseOutputDirectoryButton.UseVisualStyleBackColor = true;
            this.chooseOutputDirectoryButton.Click += new System.EventHandler(this.chooseOutputDirectoryButton_Click);
            // 
            // chooseFilmButton
            // 
            this.chooseFilmButton.Location = new System.Drawing.Point(6, 38);
            this.chooseFilmButton.Name = "chooseFilmButton";
            this.chooseFilmButton.Size = new System.Drawing.Size(127, 46);
            this.chooseFilmButton.TabIndex = 5;
            this.chooseFilmButton.Text = "Choose film";
            this.chooseFilmButton.UseVisualStyleBackColor = true;
            this.chooseFilmButton.Click += new System.EventHandler(this.ChooseFilmButton_Click);
            // 
            // imagesDirectoryPanel
            // 
            this.imagesDirectoryPanel.Controls.Add(this.outputDirectoryConstantLabel);
            this.imagesDirectoryPanel.Controls.Add(this.outputDirectoryStateLabel);
            this.imagesDirectoryPanel.Controls.Add(this.outputDirectoryInfoLabel);
            this.imagesDirectoryPanel.Location = new System.Drawing.Point(6, 222);
            this.imagesDirectoryPanel.Name = "imagesDirectoryPanel";
            this.imagesDirectoryPanel.Size = new System.Drawing.Size(554, 60);
            this.imagesDirectoryPanel.TabIndex = 4;
            // 
            // outputDirectoryConstantLabel
            // 
            this.outputDirectoryConstantLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputDirectoryConstantLabel.Location = new System.Drawing.Point(0, 0);
            this.outputDirectoryConstantLabel.Name = "outputDirectoryConstantLabel";
            this.outputDirectoryConstantLabel.Padding = new System.Windows.Forms.Padding(2);
            this.outputDirectoryConstantLabel.Size = new System.Drawing.Size(128, 23);
            this.outputDirectoryConstantLabel.TabIndex = 0;
            this.outputDirectoryConstantLabel.Text = "Output directory:";
            this.outputDirectoryConstantLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputDirectoryStateLabel
            // 
            this.outputDirectoryStateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputDirectoryStateLabel.Location = new System.Drawing.Point(134, 0);
            this.outputDirectoryStateLabel.Name = "outputDirectoryStateLabel";
            this.outputDirectoryStateLabel.Size = new System.Drawing.Size(417, 23);
            this.outputDirectoryStateLabel.TabIndex = 2;
            this.outputDirectoryStateLabel.Text = "*status*";
            this.outputDirectoryStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDirectoryInfoLabel
            // 
            this.outputDirectoryInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputDirectoryInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputDirectoryInfoLabel.Location = new System.Drawing.Point(0, 32);
            this.outputDirectoryInfoLabel.Name = "outputDirectoryInfoLabel";
            this.outputDirectoryInfoLabel.Size = new System.Drawing.Size(554, 23);
            this.outputDirectoryInfoLabel.TabIndex = 1;
            this.outputDirectoryInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filmPathPanel
            // 
            this.filmPathPanel.Controls.Add(this.filmPathConstantLabel);
            this.filmPathPanel.Controls.Add(this.filmPathStatusLabel);
            this.filmPathPanel.Controls.Add(this.filmPathInfoLabel);
            this.filmPathPanel.Location = new System.Drawing.Point(6, 87);
            this.filmPathPanel.Name = "filmPathPanel";
            this.filmPathPanel.Size = new System.Drawing.Size(554, 61);
            this.filmPathPanel.TabIndex = 3;
            // 
            // filmPathConstantLabel
            // 
            this.filmPathConstantLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filmPathConstantLabel.Location = new System.Drawing.Point(0, 0);
            this.filmPathConstantLabel.Name = "filmPathConstantLabel";
            this.filmPathConstantLabel.Padding = new System.Windows.Forms.Padding(2);
            this.filmPathConstantLabel.Size = new System.Drawing.Size(79, 23);
            this.filmPathConstantLabel.TabIndex = 0;
            this.filmPathConstantLabel.Text = "Film path:";
            this.filmPathConstantLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filmPathStatusLabel
            // 
            this.filmPathStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filmPathStatusLabel.Location = new System.Drawing.Point(85, 0);
            this.filmPathStatusLabel.Name = "filmPathStatusLabel";
            this.filmPathStatusLabel.Size = new System.Drawing.Size(466, 23);
            this.filmPathStatusLabel.TabIndex = 2;
            this.filmPathStatusLabel.Text = "*status*";
            this.filmPathStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filmPathInfoLabel
            // 
            this.filmPathInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.filmPathInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.filmPathInfoLabel.Location = new System.Drawing.Point(0, 32);
            this.filmPathInfoLabel.Name = "filmPathInfoLabel";
            this.filmPathInfoLabel.Size = new System.Drawing.Size(554, 23);
            this.filmPathInfoLabel.TabIndex = 1;
            this.filmPathInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgDatasetCreaterTabPage
            // 
            this.imgDatasetCreaterTabPage.Controls.Add(this.selected_type_label);
            this.imgDatasetCreaterTabPage.Controls.Add(this.pictureBox1);
            this.imgDatasetCreaterTabPage.Location = new System.Drawing.Point(4, 25);
            this.imgDatasetCreaterTabPage.Name = "imgDatasetCreaterTabPage";
            this.imgDatasetCreaterTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.imgDatasetCreaterTabPage.Size = new System.Drawing.Size(1124, 562);
            this.imgDatasetCreaterTabPage.TabIndex = 1;
            this.imgDatasetCreaterTabPage.Text = "Image Dataset Creator";
            this.imgDatasetCreaterTabPage.UseVisualStyleBackColor = true;
            this.imgDatasetCreaterTabPage.Click += new System.EventHandler(this.imgDatasetCreaterTabPage_Click);
            // 
            // selected_type_label
            // 
            this.selected_type_label.AutoSize = true;
            this.selected_type_label.BackColor = System.Drawing.Color.Yellow;
            this.selected_type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selected_type_label.Location = new System.Drawing.Point(12, 108);
            this.selected_type_label.Name = "selected_type_label";
            this.selected_type_label.Size = new System.Drawing.Size(42, 46);
            this.selected_type_label.TabIndex = 1;
            this.selected_type_label.Text = "1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(60, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1068, 553);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 616);
            this.Controls.Add(this.mainTabControl);
            this.Name = "mainForm";
            this.Text = "Image Dataset Builder v0.1";
            this.mainTabControl.ResumeLayout(false);
            this.filmToImageTabPage.ResumeLayout(false);
            this.convertionStatusGroupBox.ResumeLayout(false);
            this.convertionAttributesGroupBox.ResumeLayout(false);
            this.convertionAttributesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durutionTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetTrackBar)).EndInit();
            this.filePropertiesGroupBox.ResumeLayout(false);
            this.imagesDirectoryPanel.ResumeLayout(false);
            this.filmPathPanel.ResumeLayout(false);
            this.imgDatasetCreaterTabPage.ResumeLayout(false);
            this.imgDatasetCreaterTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage filmToImageTabPage;
        private System.Windows.Forms.TabPage imgDatasetCreaterTabPage;
        private System.Windows.Forms.GroupBox filePropertiesGroupBox;
        private System.Windows.Forms.Label filmPathConstantLabel;
        private System.Windows.Forms.Label filmPathInfoLabel;
        private System.Windows.Forms.Label filmPathStatusLabel;
        private System.Windows.Forms.GroupBox convertionStatusGroupBox;
        private System.Windows.Forms.GroupBox convertionAttributesGroupBox;
        private System.Windows.Forms.Panel filmPathPanel;
        private System.Windows.Forms.Panel imagesDirectoryPanel;
        private System.Windows.Forms.Label outputDirectoryConstantLabel;
        private System.Windows.Forms.Label outputDirectoryStateLabel;
        private System.Windows.Forms.Label outputDirectoryInfoLabel;
        private System.Windows.Forms.Label offsetConstantLabel;
        private System.Windows.Forms.Label stepConstantLabel;
        private System.Windows.Forms.TrackBar durutionTrackBar;
        private System.Windows.Forms.Label durutionConstantLabel;
        private System.Windows.Forms.TrackBar stepTrackBar;
        private System.Windows.Forms.TrackBar offsetTrackBar;
        private System.Windows.Forms.Label offsetValueLabel;
        private System.Windows.Forms.Label durutionValueLabel;
        private System.Windows.Forms.Label stepValueLabel;
        private System.Windows.Forms.Label conversionStatusLabel;
        private System.Windows.Forms.Button conversionButton;
        private System.Windows.Forms.ProgressBar conversionProgressBar;
        private System.Windows.Forms.Button chooseOutputDirectoryButton;
        private System.Windows.Forms.Button chooseFilmButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label selected_type_label;
    }
}

