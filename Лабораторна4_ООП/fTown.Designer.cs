namespace Лабораторна4_ООП
{
    partial class fTown
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Warranty = new System.Windows.Forms.TextBox();
            this.Printing = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Color = new System.Windows.Forms.CheckBox();
            this.Wifi = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.Warranty);
            this.groupBox1.Controls.Add(this.Printing);
            this.groupBox1.Controls.Add(this.Type);
            this.groupBox1.Controls.Add(this.Country);
            this.groupBox1.Controls.Add(this.Model);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данi";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(144, 152);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 11;
            // 
            // Warranty
            // 
            this.Warranty.Location = new System.Drawing.Point(144, 127);
            this.Warranty.Name = "Warranty";
            this.Warranty.Size = new System.Drawing.Size(100, 20);
            this.Warranty.TabIndex = 10;
            this.Warranty.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Printing
            // 
            this.Printing.Location = new System.Drawing.Point(144, 101);
            this.Printing.Name = "Printing";
            this.Printing.Size = new System.Drawing.Size(100, 20);
            this.Printing.TabIndex = 9;
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(144, 75);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(100, 20);
            this.Type.TabIndex = 8;
            // 
            // Country
            // 
            this.Country.Location = new System.Drawing.Point(144, 50);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(100, 20);
            this.Country.TabIndex = 7;
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(144, 24);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(100, 20);
            this.Model.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Цiна";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Гарантiйний термiн";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Технологiя друку";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тип";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Країна виробника";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Модель";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Color);
            this.groupBox2.Controls.Add(this.Wifi);
            this.groupBox2.Location = new System.Drawing.Point(16, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додатковi данi";
            // 
            // Color
            // 
            this.Color.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(6, 58);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(113, 17);
            this.Color.TabIndex = 3;
            this.Color.Text = "Кольоровий друк";
            this.Color.UseVisualStyleBackColor = true;
            // 
            // Wifi
            // 
            this.Wifi.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.Wifi.AutoSize = true;
            this.Wifi.Location = new System.Drawing.Point(6, 35);
            this.Wifi.Name = "Wifi";
            this.Wifi.Size = new System.Drawing.Size(103, 17);
            this.Wifi.TabIndex = 2;
            this.Wifi.Text = "Наявнiсть WIFI";
            this.Wifi.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(185, 234);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(185, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fTown
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(340, 327);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fTown";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Данi про принтер";
            this.Load += new System.EventHandler(this.fTown_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Warranty;
        private System.Windows.Forms.TextBox Printing;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Color;
        private System.Windows.Forms.CheckBox Wifi;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}