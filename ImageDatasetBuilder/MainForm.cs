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

using KeyEventArgs = System.Windows.Forms.KeyEventArgs;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

using ImageExample = ImageDatasetBuilder.CsvService.ImageExample;
using ObjectClass = ImageDatasetBuilder.HelperStructures.ObjectClass;
using ImageFormat = ImageDatasetBuilder.HelperStructures.ImageFormat;
using InputStatus = ImageDatasetBuilder.HelperStructures.InputStatus;

namespace ImageDatasetBuilder
{
    public partial class MainForm : Form
    {
        private const string DataPath = @"..\..\images\";
        private const string CsvPath = DataPath + @"processed\description.csv";
        private const string ProcessedFilesPath = DataPath + @"processed\dataset\";
        private const string UnprocessedFilesPath = DataPath + @"unprocessed\";

        private static readonly string ImageExtension = "." + HelperStructures.ImageFormatMapping[ImageFormat.PNG];
        private static readonly string ImageFormatPattern = "*" + ImageExtension;

        private readonly CsvService _csvService = new CsvService();
        private readonly IndexGenerator _indexGenerator = new IndexGenerator();

        private readonly List<ImageExample> _definedImageObjects = new List<ImageExample>();
        private IEnumerator _unprocessedImagePathEnumerator;
        private ObjectClass _selectedClass;

        private Image _image; // TODO remove
        private Point _leftUpCorner;
        private Point _rightDownCorner;

        private bool _isLeftUpCornerDefined = false;        // TODO create some sort of predefined valid states
        private bool _areObjectBoundingsDefined = false;    //
        private bool _isObjectClassChoosen = false;         //

        public MainForm()
        {
            InitializeComponent();

            LoadImageData();
        }

        private void LoadImageData()
        {
            var unprocessedImagePaths = Directory.GetFiles(UnprocessedFilesPath, ImageFormatPattern, SearchOption.TopDirectoryOnly);
            if (unprocessedImagePaths.Length > 0)
            {
                _unprocessedImagePathEnumerator = unprocessedImagePaths.GetEnumerator();
                LoadNextImage();
            }
            else
            {
                MessageBox.Show("Raw image data directory is empty.\r\n" +
                                "The program will terminate.", "Images not found!");
                Load += (s, e) => Close();
            }
        }

        private void mainForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    _selectedClass = ObjectClass.B1;
                    _isObjectClassChoosen = true;
                    break;
                case Keys.D2:
                    _selectedClass = ObjectClass.B2;
                    _isObjectClassChoosen = true;
                    break;
                case Keys.D3:
                    _selectedClass = ObjectClass.B3;
                    _isObjectClassChoosen = true;
                    break;
                case Keys.D4:
                    _selectedClass = ObjectClass.B4;
                    _isObjectClassChoosen = true;
                    break;
                case Keys.D5:
                    _selectedClass = ObjectClass.B5;
                    _isObjectClassChoosen = true;
                    break;
                case Keys.D6:
                    _selectedClass = ObjectClass.B6;
                    _isObjectClassChoosen = true;
                    break;
                case Keys.D7:
                    _selectedClass = ObjectClass.B7;
                    _isObjectClassChoosen = true;
                    break;
                case Keys.D8:
                    _selectedClass = ObjectClass.B8;
                    _isObjectClassChoosen = true;
                    break;
                case Keys.Q:
                    _selectedClass = ObjectClass.B9;
                    _isObjectClassChoosen = true;
                    break;
                case Keys.W:
                    _selectedClass = ObjectClass.B10;
                    _isObjectClassChoosen = true;
                    break;
                case Keys.E:
                    _selectedClass = ObjectClass.B11;
                    _isObjectClassChoosen = true;
                    break;
                case Keys.R:
                    _selectedClass = ObjectClass.B12;
                    _isObjectClassChoosen = true;
                    break;
                case Keys.T:
                    _selectedClass = ObjectClass.B13;
                    _isObjectClassChoosen = true;
                    break;
                case Keys.Y:
                    _selectedClass = ObjectClass.B14;
                    _isObjectClassChoosen = true;
                    break;
                case Keys.U:
                    _selectedClass = ObjectClass.B15;
                    _isObjectClassChoosen = true;
                    break;
                case Keys.B:
                    _selectedClass = ObjectClass.BWhite;
                    _isObjectClassChoosen = true;
                    break;
                case Keys.H:
                    _selectedClass = ObjectClass.Hole;
                    _isObjectClassChoosen = true;
                    break;
                case Keys.C:
                    ClearPreviousObjectDefinition();
                    UpdateUI();
                    _isLeftUpCornerDefined = false;
                    _areObjectBoundingsDefined = false;
                    break;
                case Keys.Tab:
                    if (!_areObjectBoundingsDefined || !_isObjectClassChoosen)
                    {
                        MessageBox.Show("Define class and object boundings before confirming the data.",
                            "Information not provided!");
                        return;
                    }
                    AddArea();
                    UpdateUI();
                    _isLeftUpCornerDefined = false;
                    _areObjectBoundingsDefined = false;
                    break;
                case Keys.Space:
                    SaveCurrentImageData();
                    LoadNextImage();
                    UpdateUI();
                    break;
            }

            classLabel.Text = HelperStructures.ObjectClassUserFriendlyMapping[_selectedClass];
        }

        private void AddArea()
        {
            var imageObject = new ImageExample
            {
                Height = _image.Height,
                Width = _image.Width,
                ImageFormat = HelperStructures.ImageFormatMapping[ImageFormat.PNG],

                XMin = _leftUpCorner.X,
                YMin = _leftUpCorner.Y,
                XMax = _rightDownCorner.X,
                YMax = _rightDownCorner.Y,
                Class = HelperStructures.ObjectClassMapping[_selectedClass]
            };
            _definedImageObjects.Add(imageObject);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEventArgs = (MouseEventArgs)e;
            var coordinates = mouseEventArgs.Location;

            if (!_isLeftUpCornerDefined)
            {
                _leftUpCorner = coordinates;
                _isLeftUpCornerDefined = true;
            }
            else
            {
                if (coordinates.X <= _leftUpCorner.X ||
                    coordinates.Y <= _leftUpCorner.Y)
                {
                    MessageBox.Show("Selected point do not make valid rectangle.\r\n" +
                                    "Try again.", "Point invalid!");
                    return;
                }
                _rightDownCorner = coordinates;
                _areObjectBoundingsDefined = true;
            }
        }

        private void UpdateUI()
        {
            textBox.Clear();
            foreach (var taggedObject in _definedImageObjects)
            {
                textBox.AppendText(taggedObject + "\r\n");
            }

            sourceFileLabel.Text = _unprocessedImagePathEnumerator.Current.ToString();
            //outputFileLabel.Text = CreateCurrentExampleFilename(); // TODO there can be many files
            sizeLabel.Text = "(w=" + _image.Width + ", h=" + _image.Height + ")";
        }

        private string CreateCurrentExampleFilename()
        {
            string outputFileName;
            if (!_definedImageObjects.Any())
            {
                outputFileName = string.Empty;
            }
            else if (_definedImageObjects.Count() == 1)
            {
                var objectClass = _definedImageObjects[0].Class;
                outputFileName = objectClass + "_" + _indexGenerator.NextIndex(HelperStructures.ObjectClassMapping.
                    FirstOrDefault(p => p.Value == objectClass).Key) + ImageExtension;
                // Carefully with FirstOrDefault() -> ObjectClassMapping must contain objectClass value to have this working.
            }
            else
            {
                outputFileName = "multi_" + _indexGenerator.NextIndex() + ImageExtension;
            }

            return outputFileName;
        }

        private void ClearPreviousObjectDefinition()
        {
            if (!_definedImageObjects.Any())
            {
                MessageBox.Show("Action invalid.\r\nNo object definitions have been defined.", "Invalid action!");
                return;
            }

            _definedImageObjects.RemoveAt(_definedImageObjects.Count - 1);
        }

        private void SaveCurrentImageData()
        {
            if (_definedImageObjects.Count == 0)
            {
                MessageBox.Show("No objects defined on the image. Define at least one and try again.",
                    "No defined objects!");
                return;
            }

            if (_definedImageObjects.Count == 1)
            {

                _definedImageObjects[0].Filename = CreateCurrentExampleFilename();
            }
            else
            {
                foreach (var imageExample in _definedImageObjects)
                {
                    imageExample.Filename = CreateCurrentExampleFilename();
                }
            }

            if (File.Exists(CsvPath))
            {
                _csvService.AppendToCsv(CsvPath, _definedImageObjects);
            }
            else
            {
                _csvService.WriteCsv(CsvPath, _definedImageObjects);
            }

            foreach (var imageExample in _definedImageObjects)
            {
                File.Move(UnprocessedFilesPath + _unprocessedImagePathEnumerator.Current, ProcessedFilesPath + imageExample.Filename);
            }

            _definedImageObjects.Clear();
            _isLeftUpCornerDefined = false;
            _areObjectBoundingsDefined = false;
            _isObjectClassChoosen = false;
        }

        private void LoadNextImage()
        {

            if (pictureBox.Image != null)
            {
                _image.Dispose();
                pictureBox.Image.Dispose();
            }

            if (_unprocessedImagePathEnumerator.MoveNext())
            {
                _image = Image.FromFile(_unprocessedImagePathEnumerator.Current.ToString());
                pictureBox.Image = _image;
            }
            else
            {
                // TODO end of raw image data -> handle this
            }
        }


        // TODO I have not touched anything below
        ///////////////////////////
        private void DrawRectangles()
        {

            //
            /*
            foreach (Frame element in _definedImageObjects)
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
