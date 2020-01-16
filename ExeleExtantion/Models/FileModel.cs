using ExcelManager.Models;
using System;
using System.Collections.Generic;

namespace ExcelExtantion.Models
{
    [Serializable]
    public class ExcelWorkModel
    {
        public ExcelWork FirstFile { get; set; }

        public ExcelWork SecondFile { get; set; }
    }

    public class ExcelResponseModel
    {
        public ExcelResponse FirstFile { get; set; }

        public ExcelResponse SecondFile { get; set; }
    }
}
