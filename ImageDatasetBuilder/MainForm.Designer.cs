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
            this.classLabel = new System.Windows.Forms.Label();
            this.sourceConstantLabel = new System.Windows.Forms.Label();
            this.sizeConstantLabel = new System.Windows.Forms.Label();
            this.currentImageBoundsTextBox = new System.Windows.Forms.TextBox();
            this.sourceFileLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.currentRdYLabel = new System.Windows.Forms.Label();
            this.currentRdYConstantLabel = new System.Windows.Forms.Label();
            this.currentRdXLabel = new System.Windows.Forms.Label();
            this.currentRdXConstantLabel = new System.Windows.Forms.Label();
            this.currentBoundsConstantLabel = new System.Windows.Forms.Label();
            this.classConstantLabel = new System.Windows.Forms.Label();
            this.currentLuYLabel = new System.Windows.Forms.Label();
            this.currentLuYConstantLabel = new System.Windows.Forms.Label();
            this.currentLuXLabel = new System.Windows.Forms.Label();
            this.currentLuXConstantLabel = new System.Windows.Forms.Label();
            this.currentImagePictureBox = new System.Windows.Forms.PictureBox();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.BackColor = System.Drawing.Color.Yellow;
            this.classLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.classLabel.Location = new System.Drawing.Point(143, 18);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(35, 48);
            this.classLabel.TabIndex = 1;
            this.classLabel.Text = "-";
            this.classLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sourceConstantLabel
            // 
            this.sourceConstantLabel.AutoSize = true;
            this.sourceConstantLabel.Location = new System.Drawing.Point(11, 521);
            this.sourceConstantLabel.Name = "sourceConstantLabel";
            this.sourceConstantLabel.Size = new System.Drawing.Size(57, 17);
            this.sourceConstantLabel.TabIndex = 2;
            this.sourceConstantLabel.Text = "Source:";
            // 
            // sizeConstantLabel
            // 
            this.sizeConstantLabel.AutoSize = true;
            this.sizeConstantLabel.Location = new System.Drawing.Point(11, 555);
            this.sizeConstantLabel.Name = "sizeConstantLabel";
            this.sizeConstantLabel.Size = new System.Drawing.Size(39, 17);
            this.sizeConstantLabel.TabIndex = 4;
            this.sizeConstantLabel.Text = "Size:";
            // 
            // currentImageBoundsTextBox
            // 
            this.currentImageBoundsTextBox.Enabled = false;
            this.currentImageBoundsTextBox.Location = new System.Drawing.Point(14, 172);
            this.currentImageBoundsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentImageBoundsTextBox.Multiline = true;
            this.currentImageBoundsTextBox.Name = "currentImageBoundsTextBox";
            this.currentImageBoundsTextBox.ReadOnly = true;
            this.currentImageBoundsTextBox.Size = new System.Drawing.Size(333, 331);
            this.currentImageBoundsTextBox.TabIndex = 5;
            // 
            // sourceFileLabel
            // 
            this.sourceFileLabel.AutoSize = true;
            this.sourceFileLabel.Location = new System.Drawing.Point(80, 521);
            this.sourceFileLabel.Name = "sourceFileLabel";
            this.sourceFileLabel.Size = new System.Drawing.Size(13, 17);
            this.sourceFileLabel.TabIndex = 6;
            this.sourceFileLabel.Text = "-";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(80, 555);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(13, 17);
            this.sizeLabel.TabIndex = 8;
            this.sizeLabel.Text = "-";
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.currentRdYLabel);
            this.infoPanel.Controls.Add(this.currentRdYConstantLabel);
            this.infoPanel.Controls.Add(this.currentRdXLabel);
            this.infoPanel.Controls.Add(this.currentRdXConstantLabel);
            this.infoPanel.Controls.Add(this.currentBoundsConstantLabel);
            this.infoPanel.Controls.Add(this.classConstantLabel);
            this.infoPanel.Controls.Add(this.currentLuYLabel);
            this.infoPanel.Controls.Add(this.currentLuYConstantLabel);
            this.infoPanel.Controls.Add(this.currentLuXLabel);
            this.infoPanel.Controls.Add(this.currentLuXConstantLabel);
            this.infoPanel.Controls.Add(this.sourceFileLabel);
            this.infoPanel.Controls.Add(this.sizeLabel);
            this.infoPanel.Controls.Add(this.classLabel);
            this.infoPanel.Controls.Add(this.sourceConstantLabel);
            this.infoPanel.Controls.Add(this.currentImageBoundsTextBox);
            this.infoPanel.Controls.Add(this.sizeConstantLabel);
            this.infoPanel.Location = new System.Drawing.Point(13, 13);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(362, 601);
            this.infoPanel.TabIndex = 1;
            // 
            // currentRdYLabel
            // 
            this.currentRdYLabel.AutoSize = true;
            this.currentRdYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentRdYLabel.Location = new System.Drawing.Point(227, 113);
            this.currentRdYLabel.Name = "currentRdYLabel";
            this.currentRdYLabel.Size = new System.Drawing.Size(19, 25);
            this.currentRdYLabel.TabIndex = 18;
            this.currentRdYLabel.Text = "-";
            // 
            // currentRdYConstantLabel
            // 
            this.currentRdYConstantLabel.AutoSize = true;
            this.currentRdYConstantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentRdYConstantLabel.Location = new System.Drawing.Point(172, 113);
            this.currentRdYConstantLabel.Name = "currentRdYConstantLabel";
            this.currentRdYConstantLabel.Size = new System.Drawing.Size(42, 25);
            this.currentRdYConstantLabel.TabIndex = 17;
            this.currentRdYConstantLabel.Text = "Y2:";
            // 
            // currentRdXLabel
            // 
            this.currentRdXLabel.AutoSize = true;
            this.currentRdXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentRdXLabel.Location = new System.Drawing.Point(227, 80);
            this.currentRdXLabel.Name = "currentRdXLabel";
            this.currentRdXLabel.Size = new System.Drawing.Size(19, 25);
            this.currentRdXLabel.TabIndex = 16;
            this.currentRdXLabel.Text = "-";
            // 
            // currentRdXConstantLabel
            // 
            this.currentRdXConstantLabel.AutoSize = true;
            this.currentRdXConstantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentRdXConstantLabel.Location = new System.Drawing.Point(172, 80);
            this.currentRdXConstantLabel.Name = "currentRdXConstantLabel";
            this.currentRdXConstantLabel.Size = new System.Drawing.Size(43, 25);
            this.currentRdXConstantLabel.TabIndex = 15;
            this.currentRdXConstantLabel.Text = "X2:";
            // 
            // currentBoundsConstantLabel
            // 
            this.currentBoundsConstantLabel.AutoSize = true;
            this.currentBoundsConstantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentBoundsConstantLabel.Location = new System.Drawing.Point(13, 145);
            this.currentBoundsConstantLabel.Name = "currentBoundsConstantLabel";
            this.currentBoundsConstantLabel.Size = new System.Drawing.Size(153, 25);
            this.currentBoundsConstantLabel.TabIndex = 14;
            this.currentBoundsConstantLabel.Text = "Current bounds:";
            // 
            // classConstantLabel
            // 
            this.classConstantLabel.AutoSize = true;
            this.classConstantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.classConstantLabel.Location = new System.Drawing.Point(11, 27);
            this.classConstantLabel.Name = "classConstantLabel";
            this.classConstantLabel.Size = new System.Drawing.Size(112, 39);
            this.classConstantLabel.TabIndex = 13;
            this.classConstantLabel.Text = "Class:";
            // 
            // currentLuYLabel
            // 
            this.currentLuYLabel.AutoSize = true;
            this.currentLuYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentLuYLabel.Location = new System.Drawing.Point(74, 113);
            this.currentLuYLabel.Name = "currentLuYLabel";
            this.currentLuYLabel.Size = new System.Drawing.Size(19, 25);
            this.currentLuYLabel.TabIndex = 12;
            this.currentLuYLabel.Text = "-";
            // 
            // currentLuYConstantLabel
            // 
            this.currentLuYConstantLabel.AutoSize = true;
            this.currentLuYConstantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentLuYConstantLabel.Location = new System.Drawing.Point(19, 113);
            this.currentLuYConstantLabel.Name = "currentLuYConstantLabel";
            this.currentLuYConstantLabel.Size = new System.Drawing.Size(42, 25);
            this.currentLuYConstantLabel.TabIndex = 11;
            this.currentLuYConstantLabel.Text = "Y1:";
            // 
            // currentLuXLabel
            // 
            this.currentLuXLabel.AutoSize = true;
            this.currentLuXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentLuXLabel.Location = new System.Drawing.Point(74, 80);
            this.currentLuXLabel.Name = "currentLuXLabel";
            this.currentLuXLabel.Size = new System.Drawing.Size(19, 25);
            this.currentLuXLabel.TabIndex = 10;
            this.currentLuXLabel.Text = "-";
            // 
            // currentLuXConstantLabel
            // 
            this.currentLuXConstantLabel.AutoSize = true;
            this.currentLuXConstantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentLuXConstantLabel.Location = new System.Drawing.Point(19, 80);
            this.currentLuXConstantLabel.Name = "currentLuXConstantLabel";
            this.currentLuXConstantLabel.Size = new System.Drawing.Size(43, 25);
            this.currentLuXConstantLabel.TabIndex = 9;
            this.currentLuXConstantLabel.Text = "X1:";
            // 
            // currentImagePictureBox
            // 
            this.currentImagePictureBox.Location = new System.Drawing.Point(381, 13);
            this.currentImagePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentImagePictureBox.Name = "currentImagePictureBox";
            this.currentImagePictureBox.Size = new System.Drawing.Size(798, 602);
            this.currentImagePictureBox.TabIndex = 0;
            this.currentImagePictureBox.TabStop = false;
            this.currentImagePictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            this.currentImagePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.currentImagePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 626);
            this.Controls.Add(this.currentImagePictureBox);
            this.Controls.Add(this.infoPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Dataset Builder v0.1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label sourceFileLabel;
        private System.Windows.Forms.TextBox currentImageBoundsTextBox;
        private System.Windows.Forms.Label sizeConstantLabel;
        private System.Windows.Forms.Label sourceConstantLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.PictureBox currentImagePictureBox;
        private System.Windows.Forms.Label currentBoundsConstantLabel;
        private System.Windows.Forms.Label classConstantLabel;
        private System.Windows.Forms.Label currentLuYLabel;
        private System.Windows.Forms.Label currentLuYConstantLabel;
        private System.Windows.Forms.Label currentLuXLabel;
        private System.Windows.Forms.Label currentLuXConstantLabel;
        private System.Windows.Forms.Label currentRdYLabel;
        private System.Windows.Forms.Label currentRdYConstantLabel;
        private System.Windows.Forms.Label currentRdXLabel;
        private System.Windows.Forms.Label currentRdXConstantLabel;
    }
}

