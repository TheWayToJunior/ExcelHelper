namespace ExcelExtantion.UserControls.Controls
{
    partial class Uploader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uploader));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lableName = new System.Windows.Forms.Label();
            this.pbUpload = new System.Windows.Forms.PictureBox();
            this.pbBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pbUpload);
            this.panel1.Controls.Add(this.pbBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 158);
            this.panel1.TabIndex = 0;
            // 
            // lableName
            // 
            this.lableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lableName.AutoSize = true;
            this.lableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableName.Location = new System.Drawing.Point(3, 4);
            this.lableName.Name = "lableName";
            this.lableName.Size = new System.Drawing.Size(67, 18);
            this.lableName.TabIndex = 2;
            this.lableName.Text = "file is null";
            // 
            // pbUpload
            // 
            this.pbUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUpload.Image = ((System.Drawing.Image)(resources.GetObject("pbUpload.Image")));
            this.pbUpload.Location = new System.Drawing.Point(36, 34);
            this.pbUpload.Name = "pbUpload";
            this.pbUpload.Size = new System.Drawing.Size(92, 72);
            this.pbUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpload.TabIndex = 1;
            this.pbUpload.TabStop = false;
            // 
            // pbBox
            // 
            this.pbBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBox.Image = ((System.Drawing.Image)(resources.GetObject("pbBox.Image")));
            this.pbBox.Location = new System.Drawing.Point(0, 0);
            this.pbBox.Name = "pbBox";
            this.pbBox.Size = new System.Drawing.Size(158, 158);
            this.pbBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBox.TabIndex = 0;
            this.pbBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lableName);
            this.panel2.Location = new System.Drawing.Point(16, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 26);
            this.panel2.TabIndex = 3;
            // 
            // Uploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(158, 158);
            this.Name = "Uploader";
            this.Size = new System.Drawing.Size(158, 158);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lableName;
        private System.Windows.Forms.PictureBox pbUpload;
        private System.Windows.Forms.PictureBox pbBox;
        private System.Windows.Forms.Panel panel2;
    }
}
