using ExcelExtantion.Models;
using ExcelManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ExcelExtantion.UserControls
{
    public partial class UcMain : UserControl
    {
        public event Func<ExcelResponseModel> CreatingRows;

        public event Action<DataGridViewRowCollection> CompleteEvent;

        public UcMain()
        {
            InitializeComponent();

            btnAddRows.Click += (s, e) => AddDataRows();

            btnDeleteRows.Click += (s, e) => dgvMain.Rows.Remove(dgvMain.SelectedRows[dgvMain.SelectedRows.Count - 1]);

            btnNext.Click += BtnNext_Click;
        }

        public void AddDataRows(List<ExcelWorkModel> models)
        {
            foreach (var item in models)
            {
                int index = dgvMain.Rows.Add();

                dgvMain.Rows[index].Cells["NameColumn1"].Value = item.FirstFile.Name;

                dgvMain.Rows[index].Cells["Range1"].Value = item.FirstFile.Column;

                dgvMain.Rows[index].Cells["NameTable1"].Value = item.FirstFile.WorkSheet;

                dgvMain.Rows[index].Cells["NameColumn2"].Value = item.SecondFile.Name;

                dgvMain.Rows[index].Cells["Range2"].Value = item.SecondFile.Column;

                dgvMain.Rows[index].Cells["NameTable2"].Value = item.SecondFile.WorkSheet;

                AddNameSheet(index);
            }
        }

        private void AddDataRows()
        {
            int index = dgvMain.Rows.Add();

            AddNameSheet(index);
        }

        private void AddNameSheet(int index)
        {
            ExcelResponseModel files = CreatingRows?.Invoke();

            Action<string, IEnumerable<string>> addName = (sName, collection) =>
            {
                foreach (var item in collection)
                    (dgvMain.Rows[index].Cells[sName] as DataGridViewComboBoxCell).Items.Add(item);
            };

            addName("NameTable1", files.FirstFile.WorkSheets);
            addName("NameTable2", files.SecondFile.WorkSheets);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (dgvMain.Rows.Count > 0)
            {
                CompleteEvent?.Invoke(dgvMain.Rows);
                return;
            }

            MessageBox.Show("Введите значения!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
