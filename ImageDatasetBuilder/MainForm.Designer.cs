namespace ImageDatasetBuilder
{
    partial class MainForm
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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.FilmToImageTabPage = new System.Windows.Forms.TabPage();
            this.ImgDatasetCreaterTabPage = new System.Windows.Forms.TabPage();
            this.FilePropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.FilmPathConstantLabel = new System.Windows.Forms.Label();
            this.FilmPathInfoLabel = new System.Windows.Forms.Label();
            this.FilmPathStatusLabel = new System.Windows.Forms.Label();
            this.ConvertionAttributesGroupBox = new System.Windows.Forms.GroupBox();
            this.ConvertionStatusGroupBox = new System.Windows.Forms.GroupBox();
            this.FilmPathPanel = new System.Windows.Forms.Panel();
            this.ImagesDirectoryPanel = new System.Windows.Forms.Panel();
            this.OutputDirectoryConstantLabel = new System.Windows.Forms.Label();
            this.OutputDirectoryStateLabel = new System.Windows.Forms.Label();
            this.OutputDirectoryInfoLabel = new System.Windows.Forms.Label();
            this.OffsetConstantLabel = new System.Windows.Forms.Label();
            this.StepConstantLabel = new System.Windows.Forms.Label();
            this.OffsetTrackBar = new System.Windows.Forms.TrackBar();
            this.StepTrackBar = new System.Windows.Forms.TrackBar();
            this.DurutionConstantLabel = new System.Windows.Forms.Label();
            this.DurutionTrackBar = new System.Windows.Forms.TrackBar();
            this.OffsetValueLabel = new System.Windows.Forms.Label();
            this.StepValueLabel = new System.Windows.Forms.Label();
            this.DurutionValueLabel = new System.Windows.Forms.Label();
            this.ConversionProgressBar = new System.Windows.Forms.ProgressBar();
            this.ConversionButton = new System.Windows.Forms.Button();
            this.ConversionStatusLabel = new System.Windows.Forms.Label();
            this.ChooseFilmButton = new System.Windows.Forms.Button();
            this.ChooseOutputDirectoryButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.FilmToImageTabPage.SuspendLayout();
            this.FilePropertiesGroupBox.SuspendLayout();
            this.ConvertionAttributesGroupBox.SuspendLayout();
            this.ConvertionStatusGroupBox.SuspendLayout();
            this.FilmPathPanel.SuspendLayout();
            this.ImagesDirectoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurutionTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.FilmToImageTabPage);
            this.MainTabControl.Controls.Add(this.ImgDatasetCreaterTabPage);
            this.MainTabControl.Location = new System.Drawing.Point(13, 13);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1132, 591);
            this.MainTabControl.TabIndex = 0;
            // 
            // FilmToImageTabPage
            // 
            this.FilmToImageTabPage.Controls.Add(this.ConvertionStatusGroupBox);
            this.FilmToImageTabPage.Controls.Add(this.ConvertionAttributesGroupBox);
            this.FilmToImageTabPage.Controls.Add(this.FilePropertiesGroupBox);
            this.FilmToImageTabPage.Location = new System.Drawing.Point(4, 25);
            this.FilmToImageTabPage.Name = "FilmToImageTabPage";
            this.FilmToImageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FilmToImageTabPage.Size = new System.Drawing.Size(1124, 562);
            this.FilmToImageTabPage.TabIndex = 0;
            this.FilmToImageTabPage.Text = "Film-To-Image Converter";
            this.FilmToImageTabPage.UseVisualStyleBackColor = true;
            // 
            // ImgDatasetCreaterTabPage
            // 
            this.ImgDatasetCreaterTabPage.Location = new System.Drawing.Point(4, 25);
            this.ImgDatasetCreaterTabPage.Name = "ImgDatasetCreaterTabPage";
            this.ImgDatasetCreaterTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ImgDatasetCreaterTabPage.Size = new System.Drawing.Size(1124, 562);
            this.ImgDatasetCreaterTabPage.TabIndex = 1;
            this.ImgDatasetCreaterTabPage.Text = "Image Dataset Creator";
            this.ImgDatasetCreaterTabPage.UseVisualStyleBackColor = true;
            // 
            // FilePropertiesGroupBox
            // 
            this.FilePropertiesGroupBox.Controls.Add(this.ChooseOutputDirectoryButton);
            this.FilePropertiesGroupBox.Controls.Add(this.ChooseFilmButton);
            this.FilePropertiesGroupBox.Controls.Add(this.ImagesDirectoryPanel);
            this.FilePropertiesGroupBox.Controls.Add(this.FilmPathPanel);
            this.FilePropertiesGroupBox.Location = new System.Drawing.Point(6, 6);
            this.FilePropertiesGroupBox.Name = "FilePropertiesGroupBox";
            this.FilePropertiesGroupBox.Size = new System.Drawing.Size(566, 307);
            this.FilePropertiesGroupBox.TabIndex = 0;
            this.FilePropertiesGroupBox.TabStop = false;
            this.FilePropertiesGroupBox.Text = "File properties";
            // 
            // FilmPathConstantLabel
            // 
            this.FilmPathConstantLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilmPathConstantLabel.Location = new System.Drawing.Point(0, 0);
            this.FilmPathConstantLabel.Name = "FilmPathConstantLabel";
            this.FilmPathConstantLabel.Padding = new System.Windows.Forms.Padding(2);
            this.FilmPathConstantLabel.Size = new System.Drawing.Size(79, 23);
            this.FilmPathConstantLabel.TabIndex = 0;
            this.FilmPathConstantLabel.Text = "Film path:";
            this.FilmPathConstantLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FilmPathInfoLabel
            // 
            this.FilmPathInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.FilmPathInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FilmPathInfoLabel.Location = new System.Drawing.Point(0, 32);
            this.FilmPathInfoLabel.Name = "FilmPathInfoLabel";
            this.FilmPathInfoLabel.Size = new System.Drawing.Size(554, 23);
            this.FilmPathInfoLabel.TabIndex = 1;
            this.FilmPathInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FilmPathStatusLabel
            // 
            this.FilmPathStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilmPathStatusLabel.Location = new System.Drawing.Point(85, 0);
            this.FilmPathStatusLabel.Name = "FilmPathStatusLabel";
            this.FilmPathStatusLabel.Size = new System.Drawing.Size(99, 23);
            this.FilmPathStatusLabel.TabIndex = 2;
            this.FilmPathStatusLabel.Text = "*status*";
            this.FilmPathStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConvertionAttributesGroupBox
            // 
            this.ConvertionAttributesGroupBox.Controls.Add(this.DurutionValueLabel);
            this.ConvertionAttributesGroupBox.Controls.Add(this.StepValueLabel);
            this.ConvertionAttributesGroupBox.Controls.Add(this.OffsetValueLabel);
            this.ConvertionAttributesGroupBox.Controls.Add(this.DurutionTrackBar);
            this.ConvertionAttributesGroupBox.Controls.Add(this.DurutionConstantLabel);
            this.ConvertionAttributesGroupBox.Controls.Add(this.StepTrackBar);
            this.ConvertionAttributesGroupBox.Controls.Add(this.OffsetTrackBar);
            this.ConvertionAttributesGroupBox.Controls.Add(this.StepConstantLabel);
            this.ConvertionAttributesGroupBox.Controls.Add(this.OffsetConstantLabel);
            this.ConvertionAttributesGroupBox.Location = new System.Drawing.Point(579, 7);
            this.ConvertionAttributesGroupBox.Name = "ConvertionAttributesGroupBox";
            this.ConvertionAttributesGroupBox.Size = new System.Drawing.Size(539, 306);
            this.ConvertionAttributesGroupBox.TabIndex = 1;
            this.ConvertionAttributesGroupBox.TabStop = false;
            this.ConvertionAttributesGroupBox.Text = "Convertion attributes";
            // 
            // ConvertionStatusGroupBox
            // 
            this.ConvertionStatusGroupBox.Controls.Add(this.ConversionStatusLabel);
            this.ConvertionStatusGroupBox.Controls.Add(this.ConversionButton);
            this.ConvertionStatusGroupBox.Controls.Add(this.ConversionProgressBar);
            this.ConvertionStatusGroupBox.Location = new System.Drawing.Point(6, 319);
            this.ConvertionStatusGroupBox.Name = "ConvertionStatusGroupBox";
            this.ConvertionStatusGroupBox.Size = new System.Drawing.Size(1112, 237);
            this.ConvertionStatusGroupBox.TabIndex = 2;
            this.ConvertionStatusGroupBox.TabStop = false;
            this.ConvertionStatusGroupBox.Text = "Convertion status";
            // 
            // FilmPathPanel
            // 
            this.FilmPathPanel.Controls.Add(this.FilmPathConstantLabel);
            this.FilmPathPanel.Controls.Add(this.FilmPathStatusLabel);
            this.FilmPathPanel.Controls.Add(this.FilmPathInfoLabel);
            this.FilmPathPanel.Location = new System.Drawing.Point(6, 87);
            this.FilmPathPanel.Name = "FilmPathPanel";
            this.FilmPathPanel.Size = new System.Drawing.Size(554, 61);
            this.FilmPathPanel.TabIndex = 3;
            // 
            // ImagesDirectoryPanel
            // 
            this.ImagesDirectoryPanel.Controls.Add(this.OutputDirectoryConstantLabel);
            this.ImagesDirectoryPanel.Controls.Add(this.OutputDirectoryStateLabel);
            this.ImagesDirectoryPanel.Controls.Add(this.OutputDirectoryInfoLabel);
            this.ImagesDirectoryPanel.Location = new System.Drawing.Point(6, 222);
            this.ImagesDirectoryPanel.Name = "ImagesDirectoryPanel";
            this.ImagesDirectoryPanel.Size = new System.Drawing.Size(554, 60);
            this.ImagesDirectoryPanel.TabIndex = 4;
            // 
            // OutputDirectoryConstantLabel
            // 
            this.OutputDirectoryConstantLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputDirectoryConstantLabel.Location = new System.Drawing.Point(0, 0);
            this.OutputDirectoryConstantLabel.Name = "OutputDirectoryConstantLabel";
            this.OutputDirectoryConstantLabel.Padding = new System.Windows.Forms.Padding(2);
            this.OutputDirectoryConstantLabel.Size = new System.Drawing.Size(128, 23);
            this.OutputDirectoryConstantLabel.TabIndex = 0;
            this.OutputDirectoryConstantLabel.Text = "Output directory:";
            this.OutputDirectoryConstantLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OutputDirectoryStateLabel
            // 
            this.OutputDirectoryStateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputDirectoryStateLabel.Location = new System.Drawing.Point(134, 0);
            this.OutputDirectoryStateLabel.Name = "OutputDirectoryStateLabel";
            this.OutputDirectoryStateLabel.Size = new System.Drawing.Size(99, 23);
            this.OutputDirectoryStateLabel.TabIndex = 2;
            this.OutputDirectoryStateLabel.Text = "*status*";
            this.OutputDirectoryStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputDirectoryInfoLabel
            // 
            this.OutputDirectoryInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputDirectoryInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputDirectoryInfoLabel.Location = new System.Drawing.Point(0, 32);
            this.OutputDirectoryInfoLabel.Name = "OutputDirectoryInfoLabel";
            this.OutputDirectoryInfoLabel.Size = new System.Drawing.Size(554, 23);
            this.OutputDirectoryInfoLabel.TabIndex = 1;
            this.OutputDirectoryInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OffsetConstantLabel
            // 
            this.OffsetConstantLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OffsetConstantLabel.Location = new System.Drawing.Point(27, 34);
            this.OffsetConstantLabel.Name = "OffsetConstantLabel";
            this.OffsetConstantLabel.Size = new System.Drawing.Size(134, 56);
            this.OffsetConstantLabel.TabIndex = 0;
            this.OffsetConstantLabel.Text = "Offset:";
            this.OffsetConstantLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StepConstantLabel
            // 
            this.StepConstantLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StepConstantLabel.Location = new System.Drawing.Point(27, 111);
            this.StepConstantLabel.Name = "StepConstantLabel";
            this.StepConstantLabel.Size = new System.Drawing.Size(134, 56);
            this.StepConstantLabel.TabIndex = 1;
            this.StepConstantLabel.Text = "Step:";
            this.StepConstantLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OffsetTrackBar
            // 
            this.OffsetTrackBar.Location = new System.Drawing.Point(178, 34);
            this.OffsetTrackBar.Name = "OffsetTrackBar";
            this.OffsetTrackBar.Size = new System.Drawing.Size(243, 56);
            this.OffsetTrackBar.TabIndex = 2;
            // 
            // StepTrackBar
            // 
            this.StepTrackBar.Location = new System.Drawing.Point(178, 111);
            this.StepTrackBar.Name = "StepTrackBar";
            this.StepTrackBar.Size = new System.Drawing.Size(243, 56);
            this.StepTrackBar.TabIndex = 3;
            // 
            // DurutionConstantLabel
            // 
            this.DurutionConstantLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DurutionConstantLabel.Location = new System.Drawing.Point(27, 191);
            this.DurutionConstantLabel.Name = "DurutionConstantLabel";
            this.DurutionConstantLabel.Size = new System.Drawing.Size(134, 56);
            this.DurutionConstantLabel.TabIndex = 4;
            this.DurutionConstantLabel.Text = "Durution:";
            this.DurutionConstantLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DurutionTrackBar
            // 
            this.DurutionTrackBar.Location = new System.Drawing.Point(178, 191);
            this.DurutionTrackBar.Name = "DurutionTrackBar";
            this.DurutionTrackBar.Size = new System.Drawing.Size(243, 56);
            this.DurutionTrackBar.TabIndex = 5;
            // 
            // OffsetValueLabel
            // 
            this.OffsetValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OffsetValueLabel.Location = new System.Drawing.Point(431, 35);
            this.OffsetValueLabel.Name = "OffsetValueLabel";
            this.OffsetValueLabel.Size = new System.Drawing.Size(88, 55);
            this.OffsetValueLabel.TabIndex = 6;
            this.OffsetValueLabel.Text = "*value*";
            this.OffsetValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StepValueLabel
            // 
            this.StepValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StepValueLabel.Location = new System.Drawing.Point(431, 112);
            this.StepValueLabel.Name = "StepValueLabel";
            this.StepValueLabel.Size = new System.Drawing.Size(88, 55);
            this.StepValueLabel.TabIndex = 7;
            this.StepValueLabel.Text = "*value*";
            this.StepValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DurutionValueLabel
            // 
            this.DurutionValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DurutionValueLabel.Location = new System.Drawing.Point(431, 191);
            this.DurutionValueLabel.Name = "DurutionValueLabel";
            this.DurutionValueLabel.Size = new System.Drawing.Size(88, 55);
            this.DurutionValueLabel.TabIndex = 8;
            this.DurutionValueLabel.Text = "*value*";
            this.DurutionValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConversionProgressBar
            // 
            this.ConversionProgressBar.Location = new System.Drawing.Point(6, 83);
            this.ConversionProgressBar.Name = "ConversionProgressBar";
            this.ConversionProgressBar.Size = new System.Drawing.Size(1099, 30);
            this.ConversionProgressBar.TabIndex = 0;
            // 
            // ConversionButton
            // 
            this.ConversionButton.Location = new System.Drawing.Point(6, 34);
            this.ConversionButton.Name = "ConversionButton";
            this.ConversionButton.Size = new System.Drawing.Size(128, 43);
            this.ConversionButton.TabIndex = 1;
            this.ConversionButton.Text = "Convert";
            this.ConversionButton.UseVisualStyleBackColor = true;
            // 
            // ConversionStatusLabel
            // 
            this.ConversionStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConversionStatusLabel.Location = new System.Drawing.Point(473, 138);
            this.ConversionStatusLabel.Name = "ConversionStatusLabel";
            this.ConversionStatusLabel.Size = new System.Drawing.Size(171, 81);
            this.ConversionStatusLabel.TabIndex = 2;
            this.ConversionStatusLabel.Text = "*conversion status*";
            this.ConversionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseFilmButton
            // 
            this.ChooseFilmButton.Location = new System.Drawing.Point(7, 35);
            this.ChooseFilmButton.Name = "ChooseFilmButton";
            this.ChooseFilmButton.Size = new System.Drawing.Size(127, 46);
            this.ChooseFilmButton.TabIndex = 5;
            this.ChooseFilmButton.Text = "Choose film";
            this.ChooseFilmButton.UseVisualStyleBackColor = true;
            // 
            // ChooseOutputDirectoryButton
            // 
            this.ChooseOutputDirectoryButton.Location = new System.Drawing.Point(6, 172);
            this.ChooseOutputDirectoryButton.Name = "ChooseOutputDirectoryButton";
            this.ChooseOutputDirectoryButton.Size = new System.Drawing.Size(128, 46);
            this.ChooseOutputDirectoryButton.TabIndex = 6;
            this.ChooseOutputDirectoryButton.Text = "Choose output directory";
            this.ChooseOutputDirectoryButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 616);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainForm";
            this.Text = "Image Dataset Builder v0.1";
            this.MainTabControl.ResumeLayout(false);
            this.FilmToImageTabPage.ResumeLayout(false);
            this.FilePropertiesGroupBox.ResumeLayout(false);
            this.ConvertionAttributesGroupBox.ResumeLayout(false);
            this.ConvertionAttributesGroupBox.PerformLayout();
            this.ConvertionStatusGroupBox.ResumeLayout(false);
            this.FilmPathPanel.ResumeLayout(false);
            this.ImagesDirectoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OffsetTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurutionTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage FilmToImageTabPage;
        private System.Windows.Forms.TabPage ImgDatasetCreaterTabPage;
        private System.Windows.Forms.GroupBox FilePropertiesGroupBox;
        private System.Windows.Forms.Label FilmPathConstantLabel;
        private System.Windows.Forms.Label FilmPathInfoLabel;
        private System.Windows.Forms.Label FilmPathStatusLabel;
        private System.Windows.Forms.GroupBox ConvertionStatusGroupBox;
        private System.Windows.Forms.GroupBox ConvertionAttributesGroupBox;
        private System.Windows.Forms.Panel FilmPathPanel;
        private System.Windows.Forms.Panel ImagesDirectoryPanel;
        private System.Windows.Forms.Label OutputDirectoryConstantLabel;
        private System.Windows.Forms.Label OutputDirectoryStateLabel;
        private System.Windows.Forms.Label OutputDirectoryInfoLabel;
        private System.Windows.Forms.Label OffsetConstantLabel;
        private System.Windows.Forms.Label StepConstantLabel;
        private System.Windows.Forms.TrackBar DurutionTrackBar;
        private System.Windows.Forms.Label DurutionConstantLabel;
        private System.Windows.Forms.TrackBar StepTrackBar;
        private System.Windows.Forms.TrackBar OffsetTrackBar;
        private System.Windows.Forms.Label OffsetValueLabel;
        private System.Windows.Forms.Label DurutionValueLabel;
        private System.Windows.Forms.Label StepValueLabel;
        private System.Windows.Forms.Label ConversionStatusLabel;
        private System.Windows.Forms.Button ConversionButton;
        private System.Windows.Forms.ProgressBar ConversionProgressBar;
        private System.Windows.Forms.Button ChooseOutputDirectoryButton;
        private System.Windows.Forms.Button ChooseFilmButton;
    }
}

