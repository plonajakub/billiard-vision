using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;
using ImageDatasetBuilder;


namespace ImageDatasetBuilder
{
    public class IndexGenerator
    {
        public IndexGenerator(string datasetPath = @"images\processed\dataset")
        {
            _datasetPath = datasetPath;
        }
        private readonly string _datasetPath;

        public int NextIntdex(HelperStructures.ObjectClass objectClass)
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
