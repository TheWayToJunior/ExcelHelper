using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelManager.Models
{
    [Serializable]
    public class ExcelWork
    {
        [NonSerialized]
        private string fileName;

        public string FileName 
        { 
            get 
            {
                return fileName; 
            }
            set 
            {
                fileName = value; 
            }
        }

        public string Name { get; set; }

        public string Column { get; set; }

        public string WorkSheet { get; set; }

    }

    public class ExcelResponse 
    {
        public string Name { get; set; }

        public string FileName { get; set; }

        public IEnumerable<string> WorkSheets { get; set; }
    }
}
