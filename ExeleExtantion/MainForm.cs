using ExcelExtantion.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcelExtantion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var buttons = panelMenu.Controls.Cast<Control>().Where(c => c is Button)
                .Cast<Button>().ToList();

            btnFilse.Click += (s, e) => 
            {
                UndoChanges(buttons);
                ((Button)s).ToChange(ButtonColor.OnClick);
            };

            btnMain.Click += (s, e) =>
            {
                UndoChanges(buttons);
                ((Button)s).ToChange(ButtonColor.OnClick);
            };

            btnOptions.Click += (s, e) =>
            {
                UndoChanges(buttons);
                ((Button)s).ToChange(ButtonColor.OnClick);
            };

            btnClose.Click += (s, e) => Application.Exit();
        }

        private void UndoChanges(IEnumerable<Button> controls)
        {
            foreach (var item in controls)
                item.ToChange(ButtonColor.Default);
        }

        public void AddControlsToPanel(UserControl control)
        {
            control.Dock = DockStyle.Fill;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(control);
        }

        public void ShowMessageError(string errorMessage)
        {
            MessageBox.Show(errorMessage, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
