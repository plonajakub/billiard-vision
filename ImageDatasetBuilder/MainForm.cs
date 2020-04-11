using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Cursor = System.Windows.Forms.Cursor;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

namespace ImageDatasetBuilder
{
    using ImageExample = CsvService.ImageExample;
    using ObjectClass = HelperStructures.ObjectClass;
    using ImageFormat = HelperStructures.ImageFormat;
    using InputStatus = HelperStructures.InputStatus;

    public partial class MainForm : Form
    {
        private const string CSV_PATH = ".\\tags._csv";
        private readonly string PICTURES_FORMAT = HelperStructures.ImageFormatMapping[ImageFormat.PNG];
        private readonly string IMAGE_FORMAT_PATTERN = "*" + HelperStructures.ImageFormatMapping[ImageFormat.PNG];
        private const string PROCESSED_FILES_PATH = ".\\processed\\";
        private const string UNPROCESSED_FILES_PATH = ".\\";

        private readonly List<ImageExample> _taggedObjects = new List<ImageExample>();
        private readonly CsvService _csv = new CsvService();
        //private readonly IndexGenerator _generator = new IndexGenerator();

        private ObjectClass _selectedClass;
        private IEnumerator _imagesEnumerator;
        private string _outputFileName;

        private Image _image;
        private Point _leftUpCorner;
        private Point _rightBotCorner;
        private bool _isCsvCreated = false;

        public MainForm()
        {
            InitializeComponent();

            InitializeImageData();
        }

        private void InitializeImageData()
        {
            var unprocessedImagePaths = Directory.GetFiles(UNPROCESSED_FILES_PATH, IMAGE_FORMAT_PATTERN, SearchOption.AllDirectories);
            if (unprocessedImagePaths.Length > 0)
            {
                _imagesEnumerator = unprocessedImagePaths.GetEnumerator();
                NextPicture();
            }
            else
            {
                // TODO give information to the user
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var coordinates = pictureBox.PointToClient(Cursor.Position);
            if(_leftUpCorner.IsEmpty)
            {
                _leftUpCorner = coordinates;
            }
            else
            {
                _rightBotCorner = coordinates;
            }
        }

        private void AddArea()
        {
            var currentExample = new ImageExample
            {
                Height = _image.Height,
                Width = _image.Width,
                XMin = _leftUpCorner.X,
                YMin = _leftUpCorner.Y,
                XMax = _rightBotCorner.X,
                YMax = _rightBotCorner.Y,
                ImageFormat = HelperStructures.ImageFormatMapping[ImageFormat.PNG],
                Class = HelperStructures.ObjectClassMapping[_selectedClass]
            };
            _taggedObjects.Add(currentExample);

            _leftUpCorner = Point.Empty;
            _rightBotCorner = Point.Empty;

            UpdateUI();
        }

        private void UpdateUI()
        {
            textBox.Clear();
            foreach (var taggedObject in _taggedObjects)
            {
                textBox.AppendText(taggedObject + "\r\n");
            }

            if(_taggedObjects.Any())
            {
                _outputFileName = "";
            } else if (_taggedObjects.Count() == 1)
            {
                var objectClass = _taggedObjects[0].Class;
                _outputFileName = objectClass + "_" + IndexGenerator.NextIndex(HelperStructures.ObjectClassMapping.
                    FirstOrDefault(p => p.Value == objectClass).Key) + PICTURES_FORMAT;
            }
            else
            {
                _outputFileName = "multi_" + IndexGenerator.NextMultiIndex() + PICTURES_FORMAT;
            }

            outputFileLabel.Text = _outputFileName;
            sourceFileLabel.Text = _imagesEnumerator.Current.ToString();
            sizeLabel.Text = "(w=" + _image.Width + ", h=" + _image.Height + ")";           
        }

        private void CancelPrev()
        {
            //removing last selection
            if (_leftUpCorner.IsEmpty)
            { 
                if(_taggedObjects.Count > 0)
                { 
                    _taggedObjects.RemoveAt(_taggedObjects.Count - 1);
                }
            }
            else
            {
                _leftUpCorner = Point.Empty;
                _rightBotCorner = Point.Empty;
            }

            UpdateUI();
        }

        private void NextPicture()
        {
            string processed_picture = "";
            if (_image != null)
                processed_picture = _imagesEnumerator.Current.ToString();

            if (_taggedObjects.Count == 0)
            {
                LoadNextImage();
                UpdateUI();
                return;
            }
            else if (_taggedObjects.Count == 1)
            {
                
                _taggedObjects[0].Filename = _outputFileName;
                LoadNextImage();
            }
            else
            {
                
                foreach (ImageExample element in _taggedObjects)
                {
                    element.Filename = _outputFileName;
                }
                LoadNextImage();
            }

            if (_isCsvCreated)
            {
                _csv.AppendToCsv(CSV_PATH , _taggedObjects);
            }
            else
            {
                _csv.WriteCsv(CSV_PATH , _taggedObjects);
                _isCsvCreated = true;
            }

            
            File.Move(UNPROCESSED_FILES_PATH + processed_picture, PROCESSED_FILES_PATH + _outputFileName);
            UpdateUI();
        }

        private void LoadNextImage()
        {

            if (pictureBox.Image != null)
            {
                _image.Dispose();
                pictureBox.Image.Dispose();
            }
            if (_imagesEnumerator.MoveNext())
            {
                _image = Image.FromFile(_imagesEnumerator.Current.ToString());
            }
            _taggedObjects.Clear();


            
            pictureBox.Image = _image;
        }

        private void mainForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    _selectedClass = ObjectClass.B1;
                    break;
                case Keys.D2:
                    _selectedClass = ObjectClass.B2;
                    break;
                case Keys.D3:
                    _selectedClass = ObjectClass.B3;
                    break;
                case Keys.D4:
                    _selectedClass = ObjectClass.B4;
                    break;
                case Keys.D5:
                    _selectedClass = ObjectClass.B5;
                    break;
                case Keys.D6:
                    _selectedClass = ObjectClass.B6;
                    break;
                case Keys.D7:
                    _selectedClass = ObjectClass.B7;
                    break;
                case Keys.D8:
                    _selectedClass = ObjectClass.B8;
                    break;
                case Keys.Q:
                    _selectedClass = ObjectClass.B9;
                    break;
                case Keys.W:
                    _selectedClass = ObjectClass.B10;
                    break;
                case Keys.E:
                    _selectedClass = ObjectClass.B11;
                    break;
                case Keys.R:
                    _selectedClass = ObjectClass.B12;
                    break;
                case Keys.T:
                    _selectedClass = ObjectClass.B13;
                    break;
                case Keys.Y:
                    _selectedClass = ObjectClass.B14;
                    break;
                case Keys.U:
                    _selectedClass = ObjectClass.B15;
                    break;
                case Keys.B:
                    _selectedClass = ObjectClass.BWhite;
                    break;
                case Keys.H:
                    _selectedClass = ObjectClass.Hole;
                    break;
                case Keys.C:
                    CancelPrev();
                    break;
                case Keys.N:
                    AddArea();
                    break;
                case Keys.Space:
                    NextPicture();
                    break;
            }

            classLabel.Text = HelperStructures.ObjectClassMapping[_selectedClass];
        }

        private void DrawRectangles()
        {

            //
            /*
            foreach (Frame element in _taggedObjects)
            {
                g.DrawRectangle(Pens.Black, Rectangle.FromLTRB(Convert.ToInt32(element.XMin), Convert.ToInt32(element.YMin), Convert.ToInt32(element.XMax), Convert.ToInt32(element.YMax)));
            }
            g.DrawRectangle(Pens.Black, Rectangle.FromLTRB(leftUpCorner.X, leftUpCorner.Y, pictureBox1.PointToClient(Cursor.Position).X, pictureBox1.PointToClient(Cursor.Position).Y));
            g.Dispose();
            */
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_leftUpCorner.IsEmpty)
            {
                DrawRectangles();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
