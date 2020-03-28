using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace ImageDatasetBuilder
{
    class MediaService
    {
        public string OutputBaseDir { get; set; }

        public void LoadFilmFile(string filmPath, Label statusLabel) {
            statusLabel.Text = new HelperStructures().InputStatusMapping[HelperStructures.InputStatus.Invalid];
        }

        public void ConvertFilmToImages()
        {

        }

        private void SaveImage()
        {

        }
    }
}
