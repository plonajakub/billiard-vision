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
            this.outputConstantLabel = new System.Windows.Forms.Label();
            this.sizeConstantLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.sourceFileLabel = new System.Windows.Forms.Label();
            this.outputFileLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.BackColor = System.Drawing.Color.Yellow;
            this.classLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.classLabel.Location = new System.Drawing.Point(24, 20);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(44, 48);
            this.classLabel.TabIndex = 1;
            this.classLabel.Text = "1";
            // 
            // sourceConstantLabel
            // 
            this.sourceConstantLabel.AutoSize = true;
            this.sourceConstantLabel.Location = new System.Drawing.Point(21, 97);
            this.sourceConstantLabel.Name = "sourceConstantLabel";
            this.sourceConstantLabel.Size = new System.Drawing.Size(57, 17);
            this.sourceConstantLabel.TabIndex = 2;
            this.sourceConstantLabel.Text = "Source:";
            // 
            // outputConstantLabel
            // 
            this.outputConstantLabel.AutoSize = true;
            this.outputConstantLabel.Location = new System.Drawing.Point(21, 130);
            this.outputConstantLabel.Name = "outputConstantLabel";
            this.outputConstantLabel.Size = new System.Drawing.Size(55, 17);
            this.outputConstantLabel.TabIndex = 3;
            this.outputConstantLabel.Text = "Output:";
            // 
            // sizeConstantLabel
            // 
            this.sizeConstantLabel.AutoSize = true;
            this.sizeConstantLabel.Location = new System.Drawing.Point(21, 162);
            this.sizeConstantLabel.Name = "sizeConstantLabel";
            this.sizeConstantLabel.Size = new System.Drawing.Size(39, 17);
            this.sizeConstantLabel.TabIndex = 4;
            this.sizeConstantLabel.Text = "Size:";
            // 
            // textBox
            // 
            this.textBox.Enabled = false;
            this.textBox.Location = new System.Drawing.Point(13, 205);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(333, 331);
            this.textBox.TabIndex = 5;
            // 
            // sourceFileLabel
            // 
            this.sourceFileLabel.AutoSize = true;
            this.sourceFileLabel.Location = new System.Drawing.Point(84, 97);
            this.sourceFileLabel.Name = "sourceFileLabel";
            this.sourceFileLabel.Size = new System.Drawing.Size(13, 17);
            this.sourceFileLabel.TabIndex = 6;
            this.sourceFileLabel.Text = "-";
            // 
            // outputFileLabel
            // 
            this.outputFileLabel.AutoSize = true;
            this.outputFileLabel.Location = new System.Drawing.Point(84, 130);
            this.outputFileLabel.Name = "outputFileLabel";
            this.outputFileLabel.Size = new System.Drawing.Size(13, 17);
            this.outputFileLabel.TabIndex = 7;
            this.outputFileLabel.Text = "-";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(84, 162);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(13, 17);
            this.sizeLabel.TabIndex = 8;
            this.sizeLabel.Text = "-";
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.sourceFileLabel);
            this.infoPanel.Controls.Add(this.sizeLabel);
            this.infoPanel.Controls.Add(this.classLabel);
            this.infoPanel.Controls.Add(this.outputFileLabel);
            this.infoPanel.Controls.Add(this.sourceConstantLabel);
            this.infoPanel.Controls.Add(this.outputConstantLabel);
            this.infoPanel.Controls.Add(this.textBox);
            this.infoPanel.Controls.Add(this.sizeConstantLabel);
            this.infoPanel.Location = new System.Drawing.Point(13, 13);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(362, 601);
            this.infoPanel.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(381, 13);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(798, 602);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 626);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.infoPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Image Dataset Builder v0.1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyUp);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label outputFileLabel;
        private System.Windows.Forms.Label sourceFileLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label sizeConstantLabel;
        private System.Windows.Forms.Label outputConstantLabel;
        private System.Windows.Forms.Label sourceConstantLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

