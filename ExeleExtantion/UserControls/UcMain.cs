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
            dgvMain.Rows.Clear();

            foreach (var item in models)
            {
                int index = dgvMain.Rows.Add();

                AddNameSheet(index);

                /// Заполнение первой части таблицы
                dgvMain.Rows[index].Cells["NameColumn1"].Value = item.FirstFile.Name;

                dgvMain.Rows[index].Cells["Range1"].Value = item.FirstFile.Column;

                /// Перед добавление проводится проверка есть ли это имя в коллекции 
                dgvMain.Rows[index].Cells["NameTable1"].Value = GetValidName(dgvMain.Rows[index].Cells["NameTable1"], item.FirstFile.WorkSheet);

                /// Заполнение второй части таблицы
                dgvMain.Rows[index].Cells["NameColumn2"].Value = item.SecondFile.Name;

                dgvMain.Rows[index].Cells["Range2"].Value = item.SecondFile.Column;

                /// Проверка аналогична первому DataGridViewComboBoxCell
                dgvMain.Rows[index].Cells["NameTable2"].Value = GetValidName(dgvMain.Rows[index].Cells["NameTable2"], item.SecondFile.WorkSheet);
            }
        }

        private string GetValidName(object arg, string value)
        {
            return (arg as DataGridViewComboBoxCell).Items.Contains(value) ? value
                : (arg as DataGridViewComboBoxCell).Items[(arg as DataGridViewComboBoxCell).Items.Count - 1].ToString();
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
