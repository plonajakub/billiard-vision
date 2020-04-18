using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

using KeyEventArgs = System.Windows.Forms.KeyEventArgs;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

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

        private readonly IndexGenerator _indexGenerator = new IndexGenerator(ProcessedFilesPath);

        private enum ObjectFrameState
        {
            NotDefined,
            LuPointLocked,
            Defined
        }

        private ObjectFrameState _currentFrameState = ObjectFrameState.NotDefined;
        private Tuple<ObjectClass, Point, Point> _currentImageBound = null;
        private ImageExample _currentImageExample = null;

        private IEnumerator _unprocessedImagePathEnumerator = null;
        private readonly List<ImageExample> _processedImageExamples = new List<ImageExample>();

        public MainForm()
        {
            InitializeComponent();
            InitializeProgram();
        }

        private void InitializeProgram()
        {
            var unprocessedImagePaths = Directory.GetFiles(UnprocessedFilesPath, ImageFormatPattern, SearchOption.TopDirectoryOnly);
            if (unprocessedImagePaths.Length > 0)
            {
                _unprocessedImagePathEnumerator = unprocessedImagePaths.GetEnumerator();
                LoadNextImage();
                UpdateUI();
            }
            else
            {
                MessageBox.Show("Raw image data directory is empty.\r\n" +
                                "The program will terminate.", "Images not found!");
                Load += (s, e) => Close();
            }
        }

        private bool SaveCurrentImageData()
        {
            if (_currentImageExample == null)
            {
                return true;
            }

            if (_currentImageExample.Bounds.Count == 0)
            {
                MessageBox.Show("Image has no bounds defined.\r\n" +
                                "Define some and try again.", "Action invalid!");
                return false;
            }
            _processedImageExamples.Add(_currentImageExample);
            return true;
        }

        /// <summary>
        /// Saves image data from _processedImageExamples to the CSV file
        /// and move (with renaming) processed images.
        /// <remarks>
        /// Requires all data in _processedImageExamples to be valid.
        /// </remarks>
        /// </summary>
        private bool SaveProcessedImageData()
        {
            if (_processedImageExamples.Count == 0)
            {
                MessageBox.Show("No processed images.\r\n" +
                                "Process at least one and try again.",
                    "Action invalid!");
                return false;
            }

            var oldPathDict = new Dictionary<string, string>();
            foreach (var imageExample in _processedImageExamples)
            {
                string newFilename;
                switch (imageExample.Bounds.Count)
                {
                    case 0:
                        throw new Exception("imageExample invalid: no bounds in the image");
                    case 1:
                        newFilename = HelperStructures.ObjectClassMapping[imageExample.Bounds[0].Item1] +
                                      "_" +
                                      _indexGenerator.NextIndex(imageExample.Bounds[0].Item1) +
                                      ImageExtension;
                        break;
                    default:
                        newFilename = "multi" +
                                      "_" +
                                       _indexGenerator.NextIndex() +
                                      ImageExtension;
                        break;
                }

                oldPathDict.Add(newFilename, imageExample.Filename);
                imageExample.Filename = newFilename;
            }

            if (File.Exists(CsvPath))
            {
                CsvService.AppendToCsv(CsvPath, _processedImageExamples);
            }
            else
            {
                CsvService.WriteCsv(CsvPath, _processedImageExamples);
            }

            currentImagePictureBox.BackgroundImage?.Dispose();
            foreach (var imageExample in _processedImageExamples)
            {
                File.Move(oldPathDict[imageExample.Filename], ProcessedFilesPath + imageExample.Filename);
            }

            _processedImageExamples.Clear();
            return true;
        }

        private void LoadNextImage()
        {
            if (_unprocessedImagePathEnumerator.MoveNext())
            {
                Debug.Assert(_unprocessedImagePathEnumerator.Current != null, "_unprocessedImagePathEnumerator.Current != null");
                var currentImagePath = _unprocessedImagePathEnumerator.Current.ToString();
                currentImagePictureBox.BackgroundImage = Image.FromFile(currentImagePath);
                currentImagePictureBox.Image = new Bitmap(currentImagePictureBox.BackgroundImage.Width, currentImagePictureBox.BackgroundImage.Height);

                _currentImageExample = new ImageExample
                {
                    Filename = currentImagePath,
                    ImageFormat = HelperStructures.ImageFormatMapping[ImageFormat.PNG],
                    Width = currentImagePictureBox.BackgroundImage.Width,
                    Height = currentImagePictureBox.BackgroundImage.Height
                };
                ResetCurrentBound();
            }
            else
            {
                MessageBox.Show("All images were successfully processed.\r\n" +
                                "Image data saved in: " + ProcessedFilesPath + "\r\n" +
                                "CSV description file saved in: " + CsvPath + "\r\n",
                    "All images processed!");
                Close();
            }
        }

        private void NextImage()
        {
            if (!SaveCurrentImageData())
            {
                return;
            }
            if (!SaveProcessedImageData())
            {
                return;
            }
            LoadNextImage();
        }

        private void UpdateCurrentBoundClass(ObjectClass newClass)
        {
            _currentImageBound = new Tuple<ObjectClass, Point, Point>(newClass, _currentImageBound.Item2, _currentImageBound.Item3);
        }

        private void UpdateCurrentBoundLuPoint(Point luPoint)
        {
            _currentImageBound = new Tuple<ObjectClass, Point, Point>(_currentImageBound.Item1, luPoint, _currentImageBound.Item3);
        }

        private void UpdateCurrentBoundRdPoint(Point rdPoint)
        {
            _currentImageBound = new Tuple<ObjectClass, Point, Point>(_currentImageBound.Item1, _currentImageBound.Item2, rdPoint);
        }

        private void ResetCurrentBound()
        {
            _currentImageBound = new Tuple<ObjectClass, Point, Point>(ObjectClass.B1, Point.Empty, Point.Empty);
            _currentFrameState = ObjectFrameState.NotDefined;
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    UpdateCurrentBoundClass(ObjectClass.B1);
                    break;
                case Keys.D2:
                    UpdateCurrentBoundClass(ObjectClass.B2);
                    break;
                case Keys.D3:
                    UpdateCurrentBoundClass(ObjectClass.B3);
                    break;
                case Keys.D4:
                    UpdateCurrentBoundClass(ObjectClass.B4);
                    break;
                case Keys.D5:
                    UpdateCurrentBoundClass(ObjectClass.B5);
                    break;
                case Keys.D6:
                    UpdateCurrentBoundClass(ObjectClass.B6);
                    break;
                case Keys.D7:
                    UpdateCurrentBoundClass(ObjectClass.B7);
                    break;
                case Keys.D8:
                    UpdateCurrentBoundClass(ObjectClass.B8);
                    break;
                case Keys.Q:
                    UpdateCurrentBoundClass(ObjectClass.B9);
                    break;
                case Keys.W:
                    UpdateCurrentBoundClass(ObjectClass.B10);
                    break;
                case Keys.E:
                    UpdateCurrentBoundClass(ObjectClass.B11);
                    break;
                case Keys.R:
                    UpdateCurrentBoundClass(ObjectClass.B12);
                    break;
                case Keys.T:
                    UpdateCurrentBoundClass(ObjectClass.B13);
                    break;
                case Keys.Y:
                    UpdateCurrentBoundClass(ObjectClass.B14);
                    break;
                case Keys.U:
                    UpdateCurrentBoundClass(ObjectClass.B15);
                    break;
                case Keys.B:
                    UpdateCurrentBoundClass(ObjectClass.BWhite);
                    break;
                case Keys.H:
                    UpdateCurrentBoundClass(ObjectClass.Hole);
                    break;
                case Keys.C:
                    ClearPreviousBound();
                    break;
                case Keys.X:
                    ResetCurrentBound();
                    break;
                case Keys.Tab:
                    SaveCurrentBound();
                    break;
                case Keys.Space:
                    if (e.Modifiers == Keys.Control)
                    {
                        LoadNextImage();
                    }
                    else
                    {
                        NextImage();
                    }
                    break;
            }
            UpdateUI();
        }

        private void ClearPreviousBound()
        {
            if (_currentImageExample.Bounds.Count == 0)
            {
                MessageBox.Show("No bounding boxes have been defined.\r\n" +
                                "Define some and try again.", "Invalid action!");
                return;

            }

            _currentImageExample.Bounds.RemoveAt(_currentImageExample.Bounds.Count - 1);
        }

        private void SaveCurrentBound()
        {
            if (_currentFrameState != ObjectFrameState.Defined)
            {
                MessageBox.Show("Current bounding box has not been fully defined.\r\n" +
                                "Define both rectangle points and try again.", "Operation invalid!");
                return;
            }
            _currentImageExample.Bounds.Add(_currentImageBound);
            ResetCurrentBound();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEventArgs = (MouseEventArgs)e;
            var coordinates = mouseEventArgs.Location;

            if (coordinates.X < 0 || coordinates.X > _currentImageExample.Width ||
                coordinates.Y < 0 || coordinates.Y > _currentImageExample.Height)
            {
                throw new Exception("Point coordinates invalid");
            }

            if (_currentFrameState == ObjectFrameState.NotDefined)
            {
                UpdateCurrentBoundLuPoint(coordinates);
                _currentFrameState = ObjectFrameState.LuPointLocked;
            }
            else
            {
                if (coordinates.X <= _currentImageBound.Item2.X ||
                    coordinates.Y <= _currentImageBound.Item2.Y)
                {
                    MessageBox.Show("Selected point do not make valid rectangle.\r\n" +
                                    "Try again.", "Point invalid!");
                    return;
                }
                UpdateCurrentBoundRdPoint(coordinates);
                _currentFrameState = ObjectFrameState.Defined;
            }
            UpdateUI();
        }

        private void UpdateUI()
        {
            classLabel.Text = HelperStructures.ObjectClassUserFriendlyMapping[_currentImageBound.Item1];
            currentLuXLabel.Text = _currentImageBound.Item2.X.ToString();
            currentLuYLabel.Text = _currentImageBound.Item2.Y.ToString();
            currentRdXLabel.Text = _currentImageBound.Item3.X.ToString();
            currentRdYLabel.Text = _currentImageBound.Item3.Y.ToString();

            currentImageBoundsTextBox.Clear();
            currentImageBoundsTextBox.AppendText(_currentImageExample.ToString());

            sourceFileLabel.Text = Path.GetFileName(_currentImageExample.Filename);
            sizeLabel.Text = "[w=" + Convert.ToInt32(_currentImageExample.Width) + ", h=" + Convert.ToInt32(_currentImageExample.Height) + "]";
            DrawRectangles();
        }
        
        // TODO I have not touched anything below
        ///////////////////////////
        private void DrawRectangles()
        {

            using (Graphics g = Graphics.FromImage(currentImagePictureBox.Image))
            {
                g.Clear(Color.Transparent);
                var pen = new Pen(Color.Black);
                foreach (var (_, upperCorner, lowerCorner) in _currentImageExample.Bounds)
                {
                    g.DrawRectangle(pen, RectangleFromPoints(upperCorner, lowerCorner));
                }

                pen.Color = Color.Orange;
                if (_currentFrameState == ObjectFrameState.Defined)
                {
                    g.DrawRectangle(pen, RectangleFromPoints(_currentImageBound.Item2, _currentImageBound.Item3));
                }
            }

            currentImagePictureBox.Refresh();

        }

        private Rectangle RectangleFromPoints(Point upperBound, Point lowerBound)
        {
            return new Rectangle(upperBound, new Size(lowerBound.X - upperBound.X, lowerBound.Y - upperBound.Y));
        }

    }
}
