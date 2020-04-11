using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;

namespace ImageDatasetBuilder
{
    public class CsvService
    {
        public class ImageExample
        {
            public string Filename { get; set; }
            public string ImageFormat { get; set; }
            public double Height { get; set; }
            public double Width { get; set; }
            public string Class { get; set; }
            public int XMin { get; set; }
            public int XMax { get; set; }
            public int YMin { get; set; }
            public int YMax { get; set; }
            
            public override string ToString()
            {
                return "(" + XMin + ", " + YMin + ", " + XMax + ", " + YMax + ", " + Class + ")";
            }
        }

        public class ImageExampleMap : ClassMap<ImageExample>
        {
            public ImageExampleMap()
            {
                Map(m => m.Filename).Index(0).Name("filename");
                Map(m => m.ImageFormat).Index(1).Name("img_format");
                Map(m => m.Height).Index(2).Name("height");
                Map(m => m.Width).Index(3).Name("width");
                Map(m => m.Class).Index(4).Name("class");
                Map(m => m.XMin).Index(5).Name("x_min");
                Map(m => m.XMax).Index(6).Name("x_max");
                Map(m => m.YMin).Index(7).Name("y_min");
                Map(m => m.YMax).Index(8).Name("y_max");
            }
        }

        public List<ImageExample> ReadCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {    
                csv.Configuration.RegisterClassMap<ImageExampleMap>();
                return csv.GetRecords<ImageExample>().ToList();
            }
        }

        public void WriteCsv(string filePath, List<ImageExample> imageExamples)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Configuration.RegisterClassMap<ImageExampleMap>();
                csv.WriteRecords(imageExamples);
            }
        }

        public void AppendToCsv(string filePath, List<ImageExample> imageExamplesToAppend)
        {
            var imageExamples = this.ReadCsv(filePath);
            imageExamples.AddRange(imageExamplesToAppend);
            this.WriteCsv(filePath, imageExamples);
        }
    }
}
