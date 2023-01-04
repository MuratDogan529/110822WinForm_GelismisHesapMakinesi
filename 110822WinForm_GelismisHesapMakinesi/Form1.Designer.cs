namespace _110822WinForm_GelismisHesapMakinesi
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmbIslem = new System.Windows.Forms.ComboBox();
            this.nudSayi1 = new System.Windows.Forms.NumericUpDown();
            this.nudSayi2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayi2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbIslem
            // 
            this.cmbIslem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslem.FormattingEnabled = true;
            this.cmbIslem.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
            this.cmbIslem.Location = new System.Drawing.Point(78, 53);
            this.cmbIslem.Name = "cmbIslem";
            this.cmbIslem.Size = new System.Drawing.Size(120, 24);
            this.cmbIslem.TabIndex = 1;
            // 
            // nudSayi1
            // 
            this.nudSayi1.Location = new System.Drawing.Point(78, 10);
            this.nudSayi1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudSayi1.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.nudSayi1.Name = "nudSayi1";
            this.nudSayi1.Size = new System.Drawing.Size(120, 22);
            this.nudSayi1.TabIndex = 0;
            // 
            // nudSayi2
            // 
            this.nudSayi2.Location = new System.Drawing.Point(78, 100);
            this.nudSayi2.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudSayi2.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.nudSayi2.Name = "nudSayi2";
            this.nudSayi2.Size = new System.Drawing.Size(120, 22);
            this.nudSayi2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sayı1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "İşlem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sayı2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sonuç:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 259);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudSayi2);
            this.Controls.Add(this.nudSayi1);
            this.Controls.Add(this.cmbIslem);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSayi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbIslem;
        private System.Windows.Forms.NumericUpDown nudSayi1;
        private System.Windows.Forms.NumericUpDown nudSayi2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

