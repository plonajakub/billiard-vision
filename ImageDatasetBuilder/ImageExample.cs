using System;
using System.Collections.Generic;
using System.Text;

using Point = System.Drawing.Point;
using ObjectClass = ImageDatasetBuilder.HelperStructures.ObjectClass;

namespace ImageDatasetBuilder
{
    public class ImageExample
    {
        public string Filename { get; set; }
        public string ImageFormat { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        /// <summary>
        /// Single entry: (class, (x_min, y_min), (x_max, y_max))
        /// </summary>
        public List<Tuple<ObjectClass, Point, Point>> Bounds { get; } = new List<Tuple<ObjectClass, Point, Point>>();

        public override string ToString()
        {
            var builder = new StringBuilder();
            foreach (var (boundClass, minPoint, maxPoint) in Bounds)
            {
                builder.Append("(" + boundClass + ", " + 
                               "(" + minPoint.X + ", " + minPoint.Y + "), " +
                               "(" + maxPoint.X + ", " + maxPoint.Y + "))" + "\r\n");
            }
            return builder.ToString();
        }
    }
}
