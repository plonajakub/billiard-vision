using System.Collections.Generic;


namespace ImageDatasetBuilder
{
    public static class HelperStructures
    {
        public enum InputStatus
        {
            Valid,
            Invalid,
            Empty
        }

        public static Dictionary<InputStatus, string> InputStatusMapping { get; } = new Dictionary<InputStatus, string>
        {
            { InputStatus.Valid, "Input OK" },
            { InputStatus.Invalid, "Input INCORRECT" },
            { InputStatus.Empty, "Enter information to continue" }
        };

        public enum ObjectClass
        {
            B1,
            B2,
            B3,
            B4,
            B5,
            B6,
            B7,
            B8,
            B9,
            B10,
            B11,
            B12,
            B13,
            B14,
            B15,
            BWhite,
            Hole
        }

        public static Dictionary<ObjectClass, string> ObjectClassMapping { get; } = new Dictionary<ObjectClass, string>
        {
            {ObjectClass.B1, "b1"},
            {ObjectClass.B2, "b2"},
            {ObjectClass.B3, "b3"},
            {ObjectClass.B4, "b4"},
            {ObjectClass.B5, "b5"},
            {ObjectClass.B6, "b6"},
            {ObjectClass.B7, "b7"},
            {ObjectClass.B8, "b8"},
            {ObjectClass.B9, "b9"},
            {ObjectClass.B10, "b10"},
            {ObjectClass.B11, "b11"},
            {ObjectClass.B12, "b12"},
            {ObjectClass.B13, "b13"},
            {ObjectClass.B14, "b14"},
            {ObjectClass.B15, "b15"},
            {ObjectClass.BWhite, "bw"},
            {ObjectClass.Hole, "h"}
        };

        public static Dictionary<ObjectClass, string> ObjectClassUserFriendlyMapping { get; } = new Dictionary<ObjectClass, string>
        {
            {ObjectClass.B1, "1"},
            {ObjectClass.B2, "2"},
            {ObjectClass.B3, "3"},
            {ObjectClass.B4, "4"},
            {ObjectClass.B5, "5"},
            {ObjectClass.B6, "6"},
            {ObjectClass.B7, "7"},
            {ObjectClass.B8, "8"},
            {ObjectClass.B9, "9"},
            {ObjectClass.B10, "10"},
            {ObjectClass.B11, "11"},
            {ObjectClass.B12, "12"},
            {ObjectClass.B13, "13"},
            {ObjectClass.B14, "14"},
            {ObjectClass.B15, "15"},
            {ObjectClass.BWhite, "White"},
            {ObjectClass.Hole, "Hole"}
        };

        public enum ImageFormat
        {
            PNG,
            JPEG
        }

        public static Dictionary<ImageFormat, string> ImageFormatMapping { get; } = new Dictionary<ImageFormat, string>
        {
            {ImageFormat.PNG, "png"},
            {ImageFormat.JPEG, "jpeg"}
        };
    }
}
