using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ExcelExtantion.UserControls
{
    public partial class UcOptions : UserControl
    {
        public string SavePath { get; set; }

        private string dataPath = AppDomain.CurrentDomain.BaseDirectory + "\\options.xml";

        private List<string> options;

        private FormsSerializer<List<string>> formsSerializer { get; set; }

        public UcOptions()
        {
            InitializeComponent();

            formsSerializer = new FormsSerializer<List<string>>(dataPath);

            if (File.Exists(dataPath))
            {
                options = formsSerializer.Deserialize();
            }

            if (options == null || options.Count == 0)
            {
                SavePath = AppDomain.CurrentDomain.BaseDirectory;
            }
            else
            {
                SavePath = options[0];
            }

            this.Load += (s, e) => tbPath.Text = SavePath;

            btnDealog.Click += (s, e) =>
            {
                SavePath = ShowDialog();

                if (!string.IsNullOrEmpty(SavePath))
                {
                    options = new List<string>() { SavePath };

                    formsSerializer.Serialize(options, (error) => MessageBox.Show(error));

                    tbPath.Text = SavePath;

                    MessageBox.Show("Для применения настроек перезапустипе программу!", string.Empty, 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
        }

        private string ShowDialog()
        {
            string path = string.Empty;

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    path = fbd.SelectedPath;
            }

            return path + "\\";
        }
    }
}
