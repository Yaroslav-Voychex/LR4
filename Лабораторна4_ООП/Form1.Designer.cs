namespace Лабораторна4_ООП
{
    partial class fMain
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddTown = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbTownsInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddTown
            // 
            this.btnAddTown.Location = new System.Drawing.Point(260, 12);
            this.btnAddTown.Name = "btnAddTown";
            this.btnAddTown.Size = new System.Drawing.Size(75, 38);
            this.btnAddTown.TabIndex = 0;
            this.btnAddTown.Text = "Додати принтер";
            this.btnAddTown.UseVisualStyleBackColor = true;
            this.btnAddTown.Click += new System.EventHandler(this.btnAddTown_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(260, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbTownsInfo
            // 
            this.tbTownsInfo.Location = new System.Drawing.Point(12, 12);
            this.tbTownsInfo.Multiline = true;
            this.tbTownsInfo.Name = "tbTownsInfo";
            this.tbTownsInfo.ReadOnly = true;
            this.tbTownsInfo.Size = new System.Drawing.Size(225, 426);
            this.tbTownsInfo.TabIndex = 3;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 450);
            this.Controls.Add(this.tbTownsInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddTown);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lr4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTown;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbTownsInfo;
    }
}

