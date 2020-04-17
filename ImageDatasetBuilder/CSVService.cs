using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;

using Point = System.Drawing.Point;
using ObjectClass = ImageDatasetBuilder.HelperStructures.ObjectClass;

namespace ImageDatasetBuilder
{
    public class CsvService
    {
        public class ImageExampleEntry
        {
            public string Filename { get; set; }
            public string ImageFormat { get; set; }
            public double Height { get; set; }
            public double Width { get; set; }
            public string Class { get; set; }
            public int XMin { get; set; }
            public int YMin { get; set; }
            public int XMax { get; set; }
            public int YMax { get; set; }
        }

        public class ImageExampleEntryMap : ClassMap<ImageExampleEntry>
        {
            public ImageExampleEntryMap()
            {
                Map(m => m.Filename).Index(0).Name("filename");
                Map(m => m.ImageFormat).Index(1).Name("img_format");
                Map(m => m.Height).Index(2).Name("height");
                Map(m => m.Width).Index(3).Name("width");
                Map(m => m.Class).Index(4).Name("class");
                Map(m => m.XMin).Index(5).Name("x_min");
                Map(m => m.YMin).Index(6).Name("y_min");
                Map(m => m.XMax).Index(7).Name("x_max");
                Map(m => m.YMax).Index(8).Name("y_max");
            }
        }

        private static IEnumerable<ImageExampleEntry> ReadCsvEntries(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.RegisterClassMap<ImageExampleEntryMap>();
                return csv.GetRecords<ImageExampleEntry>().ToList();
            }
        }

        private static void WriteCsvEntries(string filePath, IEnumerable<ImageExampleEntry> imageExampleEntries)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Configuration.RegisterClassMap<ImageExampleEntryMap>();
                csv.WriteRecords(imageExampleEntries);
            }
        }
        
        public static IEnumerable<ImageExample> ReadCsv(string filePath)
        {
            var csvEntries = ReadCsvEntries(filePath);
            var imageExamples = new List<ImageExample>();
            foreach (var csvEntry in csvEntries)
            {
                var imageExample = imageExamples.FirstOrDefault(example => example.Filename == csvEntry.Filename);
                if (imageExample == default(ImageExample))
                {
                    imageExample = new ImageExample
                    {
                        Filename = csvEntry.Filename,
                        ImageFormat = csvEntry.ImageFormat,
                        Height = csvEntry.Height,
                        Width = csvEntry.Width
                    };

                    imageExamples.Add(imageExample);
                }
                imageExample.Bounds.Add(new Tuple<ObjectClass, Point, Point>(
                    HelperStructures.ObjectClassMapping.FirstOrDefault(m => m.Value == csvEntry.Class).Key,
                    new Point(csvEntry.XMin, csvEntry.YMin),
                    new Point(csvEntry.XMax, csvEntry.YMax)));
            }

            return imageExamples;
        }

        public static void WriteCsv(string filePath, IEnumerable<ImageExample> imageExamples)
        {
            var imageExampleEntries = new List<ImageExampleEntry>();
            foreach (var imageExample in imageExamples)
            {
                foreach (var (boundClass, minPoint, maxPoint) in imageExample.Bounds)
                {
                    imageExampleEntries.Add(new ImageExampleEntry
                    {
                        Filename = imageExample.Filename,
                        ImageFormat = imageExample.ImageFormat,
                        Height = imageExample.Height,
                        Width = imageExample.Width,
                        Class = HelperStructures.ObjectClassMapping[boundClass],
                        XMin = minPoint.X,
                        YMin = minPoint.Y,
                        XMax = maxPoint.X,
                        YMax = maxPoint.Y
                    });
                }
            }
            WriteCsvEntries(filePath, imageExampleEntries);
        }

        public static void AppendToCsv(string filePath, IEnumerable<ImageExample> imageExamplesToAppend)
        {
            var imageExamples = ReadCsv(filePath).ToList();
            imageExamples.AddRange(imageExamplesToAppend);
            WriteCsv(filePath, imageExamples);
        }
    }
}
