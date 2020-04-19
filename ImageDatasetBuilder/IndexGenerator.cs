using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;
using static System.Int32;


namespace ImageDatasetBuilder
{
    public class IndexGenerator
    {
        static readonly int OFFSET_VALUE = 5000;
        public IndexGenerator(string datasetPath = @"images\processed\dataset")
        {
            _datasetPath = datasetPath;
        }
        private readonly string _datasetPath;

        public int NextIndex(HelperStructures.ObjectClass objectClass)
        {
            return NextIndex(objectClass.ToString());
        }
        public int NextIndex()
        {
            return NextIndex(HelperStructures.MultiClassFilesPrefix);
        }
        private int NextIndex(string objectClass)
        {

            try
            {
                var filesList = Directory.EnumerateFiles(_datasetPath, objectClass + "*");

                return MaxIndex(filesList) + 1;
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
            int maxIndex = OFFSET_VALUE;
            foreach (var file in filesList)
            {
                var fileName = Path.GetFileName(file); //TODO: Validate filename
                var parsed = TryParse(fileName.Split('_')[1], out var currentIndex);
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
