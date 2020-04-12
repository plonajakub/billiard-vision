using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDatasetBuilder
{
    public class IndexGenerator
    {
        private static int _currentB1 = 0;
        private static int _currentB2 = 0;
        private static int _currentB3 = 0;
        private static int _currentB4 = 0;
        private static int _currentB5 = 0;
        private static int _currentB6 = 0;
        private static int _currentB7 = 0;
        private static int _currentB8 = 0;
        private static int _currentB9 = 0;
        private static int _currentB10 = 0;
        private static int _currentB11 = 0;
        private static int _currentB12 = 0;
        private static int _currentB13 = 0;
        private static int _currentB14 = 0;
        private static int _currentB15 = 0;
        private static int _currentBWhite = 0;
        private static int _currentHole = 0;
        private static int _currentMulti = 0;

        public int NextIndex(HelperStructures.ObjectClass objectClass)
        {
            switch (objectClass)
            {
                case HelperStructures.ObjectClass.B1:
                    return ++_currentB1;

                case HelperStructures.ObjectClass.B2:
                    return ++_currentB2;

                case HelperStructures.ObjectClass.B3:
                    return ++_currentB3;

                case HelperStructures.ObjectClass.B4:
                    return ++_currentB4;

                case HelperStructures.ObjectClass.B5:
                    return ++_currentB5;

                case HelperStructures.ObjectClass.B6:
                    return ++_currentB6;

                case HelperStructures.ObjectClass.B7:
                    return ++_currentB7;

                case HelperStructures.ObjectClass.B8:
                    return ++_currentB8;

                case HelperStructures.ObjectClass.B9:
                    return ++_currentB9;

                case HelperStructures.ObjectClass.B10:
                    return ++_currentB10;

                case HelperStructures.ObjectClass.B11:
                    return ++_currentB11;

                case HelperStructures.ObjectClass.B12:
                    return ++_currentB12;

                case HelperStructures.ObjectClass.B13:
                    return ++_currentB13;

                case HelperStructures.ObjectClass.B14:
                    return ++_currentB14;

                case HelperStructures.ObjectClass.B15:
                    return ++_currentB15;

                case HelperStructures.ObjectClass.BWhite:
                    return ++_currentBWhite;

                case HelperStructures.ObjectClass.Hole:
                    return ++_currentHole;

                default:
                    return -1;
            }
        }

        public int NextMultiIndex()
        {
            return ++_currentMulti;
        }
    }
}
