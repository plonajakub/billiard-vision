using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDatasetBuilder
{
    class IndexGenerator
    {
        static int current_b1;
        static int current_b2;
        static int current_b3;
        static int current_b4;
        static int current_b5;
        static int current_b6;
        static int current_b7;
        static int current_b8;
        static int current_b9;
        static int current_b10;
        static int current_b11;
        static int current_b12;
        static int current_b13;
        static int current_b14;
        static int current_b15;
        static int current_hole; 
        static int current_white;
        static int current_multi;

        public int next_index(string object_class)
        {
            switch (object_class)
                {
                case CsvService.SClass.Bill1:
                    return ++current_b1;

                case CsvService.SClass.Bill2:
                    return ++current_b2;

                case CsvService.SClass.Bill3:
                    return ++current_b3;

                case CsvService.SClass.Bill4:
                    return ++current_b4;

                case CsvService.SClass.Bill5:
                    return ++current_b5;

                case CsvService.SClass.Bill6:
                    return ++current_b6;

                case CsvService.SClass.Bill7:
                    return ++current_b7;

                case CsvService.SClass.Bill8:
                    return ++current_b8;

                case CsvService.SClass.Bill9:
                    return ++current_b9;

                case CsvService.SClass.Bill10:
                    return ++current_b10;

                case CsvService.SClass.Bill11:
                    return ++current_b11;

                case CsvService.SClass.Bill12:
                    return ++current_b12;

                case CsvService.SClass.Bill13:
                    return ++current_b13;

                case CsvService.SClass.Bill14:
                    return ++current_b14;

                case CsvService.SClass.Bill15:
                    return ++current_b15;

                case CsvService.SClass.BillWhite:
                    return ++current_white;

                case CsvService.SClass.Hole:
                    return ++current_hole;

                case "multi":
                    return ++current_multi;

                default:
                    return -1;
            }
        }
    }
}
