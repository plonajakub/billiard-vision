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
                {ObjectType.B1, "b1"},
                {ObjectType.B2, "b2"},
                {ObjectType.B3, "b3"},
                {ObjectType.B4, "b4"},
                {ObjectType.B5, "b5"},
                {ObjectType.B6, "b6"},
                {ObjectType.B7, "b7"},
                {ObjectType.B8, "b8"},
                {ObjectType.B9, "b9"},
                {ObjectType.B10, "b10"},
                {ObjectType.B11, "b11"},
                {ObjectType.B12, "b12"},
                {ObjectType.B13, "b13"},
                {ObjectType.B14, "b14"},
                {ObjectType.B15, "b15"},
                {ObjectType.Hole, "h"},
                {ObjectType.White, "bw"}
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
            Hole,
            White
        }

        public Dictionary<ObjectType, string> ObjectTypeMapping{ get; private set;}

    }
}
