using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcelExtantion.UserControls.Controls
{
    public partial class Uploader : UserControl
    {
        public string FileName { get; set; }

        public event EventHandler UploadEvent;

        public Uploader()
        {
            InitializeComponent();

            pbUpload.MouseEnter += (s, e) => 
            {
                pbUpload.Image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\img\\file2.png");
                pbBox.Visible = false;
            };

            pbUpload.MouseLeave += (s, e) =>
            {
                pbUpload.Image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\img\\file1.png");
                pbBox.Visible = true;
            };

            pbUpload.Click += (s, e) => 
            {
                using (var fileDialog = new OpenFileDialog())
                {
                    fileDialog.Filter = "*.xlsx|*.XLSX|*.xls|*.XLS";

                    if (fileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileName = fileDialog.FileName;
                        lableName.Text = fileDialog.FileName.Split('\\').Last();

                        UploadEvent?.Invoke(this, null);
                    }
                }
            };
        }
    }
}
