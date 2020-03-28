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
        }

    }
}
