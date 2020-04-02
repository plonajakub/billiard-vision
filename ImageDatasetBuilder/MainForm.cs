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
    using Type = HelperStructures.ObjectType;
    using Frame = CsvService.ImageExample;

   
    public partial class mainForm : Form
    {
        private readonly MediaService mediaService = new MediaService();
        private const string CSV_PATH = ".\\tags.csv";
        private const string PICTURES_FORMAT = ".png";
        private const string FILES_FORMAT = "*" + PICTURES_FORMAT;
        private const string PROCESSED_FILES_PATH = ".\\processed\\";
        private const string UNPROCESSED_FILES_PATH = ".\\unprocessed\\";
        private Type selectedType = Type.B1;
        List<Frame> selected_areas = new List<Frame>();
        Frame current_frame = new Frame();
        CsvService csv = new CsvService();
        IndexGenerator gen = new IndexGenerator();
        string[] images;
        System.Collections.IEnumerator images_enumerator;
        string output_file_name;

        Image image;
        Point leftUpCorner;
        Point rightBotCorner;
        private bool createdCsv = false;

        public mainForm()
        {
            
            InitializeComponent();

            images = Directory.GetFiles(UNPROCESSED_FILES_PATH, FILES_FORMAT, SearchOption.AllDirectories);
            if(images.Count() > 0)
            { 
                images_enumerator = images.GetEnumerator();
                nextPicture();
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var coordinates = pictureBox1.PointToClient(Cursor.Position);
            if(leftUpCorner.IsEmpty)
            {
                leftUpCorner = coordinates;
            }
            else
            {
                rightBotCorner = coordinates;
            }
            
        }

        private void addArea()
        {
            current_frame.Height = image.Height;
            current_frame.Width = image.Width;
            current_frame.XMin = leftUpCorner.X;
            current_frame.YMin = leftUpCorner.Y;
            current_frame.XMax = rightBotCorner.X;
            current_frame.YMax = rightBotCorner.Y;
            current_frame.ImageFormat = PICTURES_FORMAT;
            current_frame.Class = new HelperStructures().ObjectTypeMapping[selectedType];
            selected_areas.Add(current_frame);
            leftUpCorner = Point.Empty;
            rightBotCorner = Point.Empty;

            updateUI();
        }

        private void updateUI()
        {

            textBox1.Clear();
            foreach (var area in selected_areas)
            {
                textBox1.AppendText(area.ToString() + "\n");
            }
            if(selected_areas.Count() == 0)
            {
                output_file_name = "";
            } else if (selected_areas.Count() == 1)
            {
                var object_class = selected_areas[0].Class;
                output_file_name = object_class + "_" + gen.next_index(object_class) + PICTURES_FORMAT;
            }
            else
            {
                output_file_name = "multi_" + gen.next_index("multi") + PICTURES_FORMAT;
            }

            output_file_label.Text = output_file_name;

            source_file_label.Text = images_enumerator.Current.ToString();

            size_label.Text = "(w=" + image.Width + ", h=" + image.Height + ")";           
        }

        private void cancelPrev()
        {
            //removing last selection
            if (leftUpCorner.IsEmpty)
            { 
                if(selected_areas.Count > 0)
                { 
                    selected_areas.RemoveAt(selected_areas.Count - 1);
                }
            }
            else
            {
                leftUpCorner = Point.Empty;
                rightBotCorner = Point.Empty;
            }

            updateUI();
           
        }

        private void nextPicture()
        {
            if (selected_areas.Count == 0)
            {
                loadNextImage();
                updateUI();
                return;
            }
            else if (selected_areas.Count == 1)
            {
                
                selected_areas[0].Filename = output_file_name;
                loadNextImage();
            }
            else
            {
                
                foreach (Frame element in selected_areas)
                {
                    element.Filename = output_file_name;
                }
                loadNextImage();
            }

            if (createdCsv)
            {
                csv.AppendToCsv(CSV_PATH , selected_areas);
            }
            else
            {
                csv.WriteCsv(CSV_PATH , selected_areas);
                createdCsv = true;
            }

            
            File.Move(UNPROCESSED_FILES_PATH + images_enumerator.Current.ToString(), PROCESSED_FILES_PATH + output_file_name);
            updateUI();
        }

        private void loadNextImage()
        {
            if(images_enumerator.MoveNext())
            {
                image = Image.FromFile(images_enumerator.Current.ToString());
            }
            selected_areas.Clear();
            pictureBox1.Image.Dispose();
            pictureBox1.Image = image; 
        }



        private void mainTabControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case '1':
                    selectedType = Type.B1;
                    break;
                case '2':
                    selectedType = Type.B2;
                    break;
                case '3':
                    selectedType = Type.B3;
                    break;
                case '4':
                    selectedType = Type.B4;
                    break;
                case '5':
                    selectedType = Type.B5;
                    break;
                case '6':
                    selectedType = Type.B6;
                    break;
                case '7':
                    selectedType = Type.B7;
                    break;
                case '8':
                    selectedType = Type.B8;
                    break;
                case 'q':
                    selectedType = Type.B9;
                    break;
                case 'w':
                    selectedType = Type.B10;
                    break;
                case 'e':
                    selectedType = Type.B11;
                    break;
                case 'r':
                    selectedType = Type.B12;
                    break;
                case 't':
                    selectedType = Type.B13;
                    break;
                case 'y':
                    selectedType = Type.B14;
                    break;
                case 'u':
                    selectedType = Type.B15;
                    break;
                case 'h':
                    selectedType = Type.Hole;
                    break;
                case 'b':
                    selectedType = Type.White;
                    break;
                case 'c':
                    cancelPrev();
                    break;
                case 'n':
                    addArea();
                    break;
                case ' ':
                    nextPicture();
                    break;
            }

            selected_type_label.Text = new HelperStructures().ObjectTypeMapping[selectedType];

        }
        private void drawRectangles()
        {

            //
            /*
            foreach (Frame element in selected_areas)
            {
                g.DrawRectangle(Pens.Black, Rectangle.FromLTRB(Convert.ToInt32(element.XMin), Convert.ToInt32(element.YMin), Convert.ToInt32(element.XMax), Convert.ToInt32(element.YMax)));
            }
            g.DrawRectangle(Pens.Black, Rectangle.FromLTRB(leftUpCorner.X, leftUpCorner.Y, pictureBox1.PointToClient(Cursor.Position).X, pictureBox1.PointToClient(Cursor.Position).Y));
            g.Dispose();
            */
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!leftUpCorner.IsEmpty)
            {
                drawRectangles();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
