using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcelExtantion.UserControls
{
    public partial class UcFile : UserControl
    {
        public event Action<string, string> CompleteEvent;

        public UcFile()
        {
            InitializeComponent();

            btnNext.Click += (s, e) => 
            {
                if (!string.IsNullOrEmpty(uploader1.FileName) || !string.IsNullOrEmpty(uploader2.FileName))
                {
                    CompleteEvent?.Invoke(uploader1.FileName, uploader2.FileName);
                    return;
                }

                MessageBox.Show("Сначала загрузите файлы!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
        }
    }
}
