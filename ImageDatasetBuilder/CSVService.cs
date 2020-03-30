using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace ImageDatasetBuilder
{
    public class CsvService
    {
        public static class SImageFormat
        {
            public const string PNG = "png";
            public const string JPEG = "jpeg";
        }

        public static class SClass
        {
            public const string Bill1 = "b1";
            public const string Bill2 = "b2";
            public const string Bill3 = "b3";
            public const string Bill4 = "b4";
            public const string Bill5 = "b5";
            public const string Bill6 = "b6";
            public const string Bill7 = "b7";
            public const string Bill8 = "b8";
            public const string Bill9 = "b9";
            public const string Bill10 = "b10";
            public const string Bill11 = "b11";
            public const string Bill12 = "b12";
            public const string Bill13 = "b13";
            public const string Bill14 = "b14";
            public const string Bill15 = "b15";
            public const string BillWhite = "bw";
            public const string Hole = "h";
        }

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
