namespace ExcelExtantion.UserControls
{
    partial class UcFile
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.uploader2 = new ExcelExtantion.UserControls.Controls.Uploader();
            this.uploader1 = new ExcelExtantion.UserControls.Controls.Uploader();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(730, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Файл для сверки .xlsx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(457, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Загрузка начальных данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(384, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Основной файл .xlsx";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(148)))), ((int)(((byte)(94)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(1062, 529);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(225, 56);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Загрузить";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(148)))), ((int)(((byte)(94)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Location = new System.Drawing.Point(831, 529);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(225, 56);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Отмена";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // uploader2
            // 
            this.uploader2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uploader2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uploader2.FileName = null;
            this.uploader2.Location = new System.Drawing.Point(750, 163);
            this.uploader2.MaximumSize = new System.Drawing.Size(158, 158);
            this.uploader2.Name = "uploader2";
            this.uploader2.Size = new System.Drawing.Size(158, 158);
            this.uploader2.TabIndex = 12;
            // 
            // uploader1
            // 
            this.uploader1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uploader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uploader1.FileName = null;
            this.uploader1.Location = new System.Drawing.Point(406, 163);
            this.uploader1.MaximumSize = new System.Drawing.Size(158, 158);
            this.uploader1.Name = "uploader1";
            this.uploader1.Size = new System.Drawing.Size(158, 158);
            this.uploader1.TabIndex = 11;
            // 
            // UcFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.uploader2);
            this.Controls.Add(this.uploader1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UcFile";
            this.Size = new System.Drawing.Size(1301, 601);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Controls.Uploader uploader1;
        private Controls.Uploader uploader2;
        private System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.Button btnNext;
    }
}
