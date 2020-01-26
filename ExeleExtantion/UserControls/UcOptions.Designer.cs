namespace ExcelExtantion.UserControls
{
    partial class UcOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnDealog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(324, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите путь для сохранения файла с результатом";
            // 
            // tbPath
            // 
            this.tbPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPath.Location = new System.Drawing.Point(452, 216);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(300, 34);
            this.tbPath.TabIndex = 2;
            // 
            // btnDealog
            // 
            this.btnDealog.Location = new System.Drawing.Point(758, 216);
            this.btnDealog.Name = "btnDealog";
            this.btnDealog.Size = new System.Drawing.Size(106, 34);
            this.btnDealog.TabIndex = 3;
            this.btnDealog.Text = "Обзор";
            this.btnDealog.UseVisualStyleBackColor = true;
            // 
            // UcOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDealog);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label1);
            this.Name = "UcOptions";
            this.Size = new System.Drawing.Size(1301, 601);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnDealog;
    }
}
