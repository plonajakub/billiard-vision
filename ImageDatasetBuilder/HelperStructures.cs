using System;
using System.Collections.Generic;


namespace ImageDatasetBuilder
{
    public class HelperStructures
    {
        public enum InputStatus
        {
            Valid,
            Invalid,
            Empty
        }

        public Dictionary<InputStatus, String> InputStatusMapping { get; private set; }

        public HelperStructures()
        {
            InputStatusMapping = new Dictionary<InputStatus, string>
            {
                { InputStatus.Valid, "Input OK" },
                { InputStatus.Invalid, "Input INCORRECT" },
                { InputStatus.Empty, "Enter information to continue" }
            };

            ObjectTypeMapping = new Dictionary<ObjectType, string>
            {
                {ObjectType.B1, "1"},
                {ObjectType.B2, "2"},
                {ObjectType.B3, "3"},
                {ObjectType.B4, "4"},
                {ObjectType.B5, "5"},
                {ObjectType.B6, "6"},
                {ObjectType.B7, "7"},
                {ObjectType.B8, "8"},
                {ObjectType.B9, "9"},
                {ObjectType.B10, "10"},
                {ObjectType.B11, "11"},
                {ObjectType.B12, "12"},
                {ObjectType.B13, "13"},
                {ObjectType.B14, "14"},
                {ObjectType.B15, "15"},
                {ObjectType.Hole, "H"}
            };
        }

        public enum ObjectType
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
            Hole 
        }

        public Dictionary<ObjectType, string> ObjectTypeMapping{ get; private set;}

    }
}
