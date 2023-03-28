using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt16(textBox1.Text);
            switch (ay)
            {
                case 1: label2.Text = "Ocak"; break;
                case 2: label2.Text = "Şubat"; break;
                case 3: label2.Text = "Mart"; break;
                case 4: label2.Text = "Nisan"; break;
                case 5: label2.Text = "Mayıs"; break;
                case 6: label2.Text = "Haziran"; break;
                case 7: label2.Text = "Temmuz"; break;
                case 8: label2.Text = "Ağustos"; break;
                case 9: label2.Text = "Eylül"; break;
                case 10: label2.Text = "Ekim"; break;
                case 11: label2.Text = "Kasım"; break;
                case 12: label2.Text = "Aralık"; break;
                default: label2.Text = "Hatalı Ay!"; break;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mevsim = textBox2.Text;
            switch (mevsim)
            {
                case "ilkbahar": label4.Text = "Mart, Nisan, Mayıs"; break;
                case "yaz": label4.Text = "Haziran, Temmuz, Ağustos"; break;
                case "sonbahar": label4.Text = "Eylül, Ekim, Kasım"; break;
                case "kış": label4.Text = "Aralık, Ocak, Şubat"; break;
                default: label4.Text = "Hatalı Mevsim!"; break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double s1, s2, topla, cikart, bol, carp;
            string islem = comboBox1.Text; // char operatörler = Convert.ToChar(comboBox1.Text)
            s1 = Convert.ToDouble(textBox3.Text);
            s2 = Convert.ToDouble(textBox4.Text);
            topla = s1 + s2;
            cikart = s1 - s2;
            bol = s1 / s2;
            carp = s1 * s2;
            switch (islem)
            {
                case "Topla": label6.Text = "Toplam = " + topla; break;
                case "Cikar": label6.Text = "Fark = " + cikart; break;
                case "Bol": label6.Text = "Bölüm = " + bol.ToString("0.00"); break;
                case "Carp": label6.Text = "Çarpım = " + carp; break;
                default: label6.Text = "Hatalı Giriş!"; break;
            }
        }
    }
}
