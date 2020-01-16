namespace ExcelExtantion.UserControls
{
    partial class UcMain
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteRows = new System.Windows.Forms.Button();
            this.btnAddRows = new System.Windows.Forms.Button();
            this.NameTable1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Range1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTable2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NameColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Range2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameTable1,
            this.NameColumn1,
            this.Range1,
            this.NameTable2,
            this.NameColumn2,
            this.Range2});
            this.dgvMain.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMain.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(1301, 513);
            this.dgvMain.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(148)))), ((int)(((byte)(94)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Location = new System.Drawing.Point(822, 529);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(225, 53);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Отмена";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(148)))), ((int)(((byte)(94)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(1053, 529);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(225, 53);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Сравнить";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 1);
            this.panel1.TabIndex = 23;
            // 
            // btnDeleteRows
            // 
            this.btnDeleteRows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(148)))), ((int)(((byte)(94)))));
            this.btnDeleteRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRows.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteRows.Location = new System.Drawing.Point(19, 555);
            this.btnDeleteRows.Name = "btnDeleteRows";
            this.btnDeleteRows.Size = new System.Drawing.Size(214, 29);
            this.btnDeleteRows.TabIndex = 25;
            this.btnDeleteRows.Text = "Удалить";
            this.btnDeleteRows.UseVisualStyleBackColor = false;
            // 
            // btnAddRows
            // 
            this.btnAddRows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(148)))), ((int)(((byte)(94)))));
            this.btnAddRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRows.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddRows.Location = new System.Drawing.Point(19, 528);
            this.btnAddRows.Name = "btnAddRows";
            this.btnAddRows.Size = new System.Drawing.Size(214, 29);
            this.btnAddRows.TabIndex = 26;
            this.btnAddRows.Text = "Добавить";
            this.btnAddRows.UseVisualStyleBackColor = false;
            // 
            // NameTable1
            // 
            this.NameTable1.HeaderText = "Имя таблицы";
            this.NameTable1.MinimumWidth = 6;
            this.NameTable1.Name = "NameTable1";
            // 
            // NameColumn1
            // 
            this.NameColumn1.HeaderText = "Название первого столбеца";
            this.NameColumn1.MinimumWidth = 6;
            this.NameColumn1.Name = "NameColumn1";
            // 
            // Range1
            // 
            this.Range1.HeaderText = "Значени";
            this.Range1.MinimumWidth = 6;
            this.Range1.Name = "Range1";
            // 
            // NameTable2
            // 
            this.NameTable2.HeaderText = "Имя таблицы";
            this.NameTable2.MinimumWidth = 6;
            this.NameTable2.Name = "NameTable2";
            // 
            // NameColumn2
            // 
            this.NameColumn2.HeaderText = "Название второго столбеца";
            this.NameColumn2.MinimumWidth = 6;
            this.NameColumn2.Name = "NameColumn2";
            // 
            // Range2
            // 
            this.Range2.HeaderText = "Значение";
            this.Range2.MinimumWidth = 6;
            this.Range2.Name = "Range2";
            // 
            // UcMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnAddRows);
            this.Controls.Add(this.btnDeleteRows);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvMain);
            this.Name = "UcMain";
            this.Size = new System.Drawing.Size(1301, 601);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteRows;
        private System.Windows.Forms.Button btnAddRows;
        private System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewComboBoxColumn NameTable1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Range1;
        private System.Windows.Forms.DataGridViewComboBoxColumn NameTable2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Range2;
    }
}
