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

    

    public partial class mainForm : Form
    {
        private readonly MediaService mediaService = new MediaService();

        private Type selectedType = Type.B1;
        List<Item> results = new List<Item>();
        Point leftUpCorner;
        Point rightBotCorner;
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

        private void imgDatasetCreaterTabPage_Click(object sender, EventArgs e)
        {

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
                addToResult();
            }
            
        }

        private void addToResult()
        {
            //throw new NotImplementedException();
            //adding rectangle to list with results
            results.Add(new Item(new Point(leftUpCorner.X, leftUpCorner.Y), new Point(rightBotCorner.X, rightBotCorner.Y), selectedType));
            leftUpCorner = Point.Empty;
            rightBotCorner = Point.Empty;
        }
        private void cancalPrev()
        {
            //removing last selection
            results.RemoveAt(results.Count - 1);
        }

        private void nextPicture()
        {
            throw new NotImplementedException();
        }

        private void clearSelection()
        {
            throw new NotImplementedException();
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
                case 'c':
                    cancalPrev();
                    break;
                
                case ' ':
                    nextPicture();
                    break;
            }

            selected_type_label.Text = new HelperStructures().ObjectTypeMapping[selectedType];

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!leftUpCorner.IsEmpty)
            {
                //drawing box when cursor moves
                Graphics g = pictureBox1.CreateGraphics();
                g.Clear(Color.White);
                foreach(Item element in results)
                    {
                    g.DrawRectangle(Pens.Black, Rectangle.FromLTRB(element.getLeft(), element.getTop(), element.getRight(), element.getDown()));
                    }
                g.DrawRectangle(Pens.Black, Rectangle.FromLTRB(leftUpCorner.X, leftUpCorner.Y, pictureBox1.PointToClient(Cursor.Position).X, pictureBox1.PointToClient(Cursor.Position).Y));
                g.Dispose();
            }
        }

       
    }
    public class Item
    {
        //selected item
        private Point lU;
        private Point rD;
        private Type type;
        public Item(Point LU, Point RD, Type Type)
        {
            lU = LU;
            rD = RD;
            type = Type;
        }
        public int getLeft()
        {
            return lU.X;
        }
        public int getTop()
        {
            return lU.Y;
        }
        public int getRight()
        {
            return rD.X;
        }
        public int getDown()
        {
            return rD.Y;
        }

    }
}
