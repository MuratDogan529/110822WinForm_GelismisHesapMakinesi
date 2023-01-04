using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _110822WinForm_GelismisHesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbIslem.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal s1 = nudSayi1.Value;
            decimal s2 = nudSayi2.Value;

            decimal toplam = 0;

            switch(cmbIslem.Text)
            {
                case "+":toplam = s1 + s2; break;
                case "-":toplam = s1 - s2; break;
                case "*":toplam = s1 * s2; break;
                case "/":toplam = s1 / s2; break;
                case "%":toplam = s1 % s2; break;
                default: break;

            }
            label5.Text=toplam.ToString();//sayısal değeri labele string olarak yzarız.

        }
    }
}
