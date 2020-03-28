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

namespace ImageDatasetBuilder
{
    public partial class mainForm : Form
    {
        private readonly MediaService mediaService = new MediaService();

        public mainForm()
        {
            InitializeComponent();
        }

        private void ChooseFilmButton_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            filmPathStatusLabel.Text = new HelperStructures().InputStatusMapping[HelperStructures.InputStatus.Empty];

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Film files (*.mp4;*.mpeg;*.ogg;*.mov;*.avi)|*.mp4;*.mpeg;*.ogg;*.mov;*.avi|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    filmPathInfoLabel.Text = filePath;
                    mediaService.LoadFilmFile(filePath, filmPathStatusLabel);
                }
                else
                {
                    filmPathStatusLabel.Text = new HelperStructures().InputStatusMapping[HelperStructures.InputStatus.Empty];
                }
            }
        }

        private void chooseOutputDirectoryButton_Click(object sender, EventArgs e)
        {
            var dirPath = string.Empty;
            outputDirectoryStateLabel.Text = new HelperStructures().InputStatusMapping[HelperStructures.InputStatus.Empty];

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    dirPath = folderBrowserDialog.SelectedPath;

                    outputDirectoryInfoLabel.Text = dirPath;
                    mediaService.OutputBaseDir = dirPath;
                    outputDirectoryStateLabel.Text = new HelperStructures().InputStatusMapping[HelperStructures.InputStatus.Valid];
                }
                else
                {
                    mediaService.OutputBaseDir = string.Empty;
                    outputDirectoryStateLabel.Text = new HelperStructures().InputStatusMapping[HelperStructures.InputStatus.Empty];
                }
            }
        }
    }
}
