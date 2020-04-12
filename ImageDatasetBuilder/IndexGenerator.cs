using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;


namespace ImageDatasetBuilder
{
    public class IndexGenerator
    {
        public IndexGenerator(string datasetPath = @"images\processed\dataset")
        {
            _datasetPath = datasetPath;
        }
        private readonly string _datasetPath;

        public int NextB1Index()
        {

            try
            {
                var filesList = Directory.EnumerateFiles(_datasetPath, HelperStructures.ObjectClass.B1 + "*");

                return MaxIndex(filesList);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("[Error] Can not find dataset directory.");
                return -1;
            }
            catch (SecurityException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            return -1;

        }
        public int NextB2Index()
        {

            try
            {
                var filesList = Directory.EnumerateFiles(_datasetPath, HelperStructures.ObjectClass.B2 + "*");

                return MaxIndex(filesList);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("[Error] Can not find dataset directory.");
                return -1;
            }
            catch (SecurityException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            return -1;

        }
        public int NextB3Index()
        {

            try
            {
                var filesList = Directory.EnumerateFiles(_datasetPath, HelperStructures.ObjectClass.B3 + "*");

                return MaxIndex(filesList);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("[Error] Can not find dataset directory.");
                return -1;
            }
            catch (SecurityException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            return -1;

        }
        public int NextB4Index()
        {

            try
            {
                var filesList = Directory.EnumerateFiles(_datasetPath, HelperStructures.ObjectClass.B4 + "*");

                return MaxIndex(filesList);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("[Error] Can not find dataset directory.");
                return -1;
            }
            catch (SecurityException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            return -1;

        }
        public int NextB5Index()
        {

            try
            {
                var filesList = Directory.EnumerateFiles(_datasetPath, HelperStructures.ObjectClass.B5 + "*");

                return MaxIndex(filesList);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("[Error] Can not find dataset directory.");
                return -1;
            }
            catch (SecurityException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            return -1;

        }
        public int NextB6Index()
        {

            try
            {
                var filesList = Directory.EnumerateFiles(_datasetPath, HelperStructures.ObjectClass.B6 + "*");

                return MaxIndex(filesList);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("[Error] Can not find dataset directory.");
                return -1;
            }
            catch (SecurityException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            return -1;

        }
        public int NextB7Index()
        {

            try
            {
                var filesList = Directory.EnumerateFiles(_datasetPath, HelperStructures.ObjectClass.B7 + "*");

                return MaxIndex(filesList);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("[Error] Can not find dataset directory.");
                return -1;
            }
            catch (SecurityException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            return -1;

        }
        public int NextB8Index()
        {

            try
            {
                var filesList = Directory.EnumerateFiles(_datasetPath, HelperStructures.ObjectClass.B8 + "*");

                return MaxIndex(filesList);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("[Error] Can not find dataset directory.");
                return -1;
            }
            catch (SecurityException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            return -1;

        }
        public int NextB9Index()
        {

            try
            {
                var filesList = Directory.EnumerateFiles(_datasetPath, HelperStructures.ObjectClass.B9 + "*");

                return MaxIndex(filesList);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("[Error] Can not find dataset directory.");
                return -1;
            }
            catch (SecurityException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            return -1;

        }
        public int NextB10Index()
        {

            try
            {
                var filesList = Directory.EnumerateFiles(_datasetPath, HelperStructures.ObjectClass.B10 + "*");

                return MaxIndex(filesList);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("[Error] Can not find dataset directory.");
                return -1;
            }
            catch (SecurityException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            return -1;

        }
        public int NextB11Index()
        {

            try
            {
                var filesList = Directory.EnumerateFiles(_datasetPath, HelperStructures.ObjectClass.B11 + "*");

                return MaxIndex(filesList);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("[Error] Can not find dataset directory.");
                return -1;
            }
            catch (SecurityException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            return -1;

        }
        public int NextB12Index()
        {

            try
            {
                var filesList = Directory.EnumerateFiles(_datasetPath, HelperStructures.ObjectClass.B12 + "*");

                return MaxIndex(filesList);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("[Error] Can not find dataset directory.");
                return -1;
            }
            catch (SecurityException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            return -1;

        }
        public int NextB13Index()
        {

            try
            {
                var filesList = Directory.EnumerateFiles(_datasetPath, HelperStructures.ObjectClass.B13 + "*");

                return MaxIndex(filesList);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("[Error] Can not find dataset directory.");
                return -1;
            }
            catch (SecurityException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            return -1;

        }
        public int NextB14Index()
        {

            try
            {
                var filesList = Directory.EnumerateFiles(_datasetPath, HelperStructures.ObjectClass.B14 + "*");

                return MaxIndex(filesList);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("[Error] Can not find dataset directory.");
                return -1;
            }
            catch (SecurityException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            return -1;

        }
        public int NextB15Index()
        {

            try
            {
                var filesList = Directory.EnumerateFiles(_datasetPath, HelperStructures.ObjectClass.B15 + "*");

                return MaxIndex(filesList);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("[Error] Can not find dataset directory.");
                return -1;
            }
            catch (SecurityException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            return -1;

        }
        public int NextBWhiteIndex()
        {

            try
            {
                var filesList = Directory.EnumerateFiles(_datasetPath, HelperStructures.ObjectClass.BWhite + "*");

                return MaxIndex(filesList);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("[Error] Can not find dataset directory.");
                return -1;
            }
            catch (SecurityException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            return -1;

        }

        public int NextHoleIndex()
        {

            try
            {
                var filesList = Directory.EnumerateFiles(_datasetPath, HelperStructures.ObjectClass.Hole + "*");

                return MaxIndex(filesList);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("[Error] Can not find dataset directory.");
                return -1;
            }
            catch (SecurityException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            return -1;

        }

        public int NextMultiIndex()
        {
           

            try
            {
                var filesList = Directory.EnumerateFiles(_datasetPath, "multi" + "*");

                return MaxIndex(filesList);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("[Error] Can not find dataset directory.");
                return -1;
            }
            catch (SecurityException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("[Error] No permissions to see {0}", _datasetPath);
            }
            return -1;
        }

        private static int MaxIndex(IEnumerable<string> filesList)
        {
            int maxIndex = 0;
            foreach (var file in filesList)
            {
                int currentIndex = 0;
                var fileName = Path.GetFileName(file); //TODO: Validate filename
                var parsed = Int32.TryParse(fileName.Split('_')[1], out currentIndex);
                if (parsed)
                {
                    if (currentIndex > maxIndex)
                        maxIndex = currentIndex;
                }
            }

            return maxIndex;
        }
    }
}
