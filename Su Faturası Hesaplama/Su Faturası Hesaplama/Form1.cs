using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Su_Faturası_Hesaplama
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = true;
                checkBox3.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = true;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((!checkBox1.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked)) && (textBox1.Text.Trim()!=" " || textBox2.Text.Trim()!= ""))
            {
                MessageBox.Show(" ' * ' İşaretli Tüm Alanları Doldurunuz !");
            }
            else 
            {
                int s_endeks, i_endeks, k_ton;
                s_endeks = Convert.ToInt32(textBox1.Text);
                i_endeks = Convert.ToInt32(textBox2.Text);
                k_ton = s_endeks - i_endeks;
                int toplam = 0;
                int sonuc1 = 30;
                int sonuc2 = k_ton - sonuc1;
                int sonuc3 = k_ton - 100;
                int sonuc4 = sonuc1 + sonuc3;
                int sonuc5 = k_ton - sonuc4;

                if (checkBox1.Checked)
                {
                    mesken(k_ton, toplam, sonuc1, sonuc2, sonuc3, sonuc4, sonuc5);
                }

                if (checkBox2.Checked)
                {
                    isyeri(k_ton, toplam, sonuc1, sonuc2, sonuc3, sonuc4, sonuc5);
                }

                if (checkBox3.Checked)
                {
                    sanayi(k_ton, toplam, sonuc1, sonuc2, sonuc3, sonuc4, sonuc5);
                }
            }   
        }
        
        private static void mesken(int k_ton, int toplam, int sonuc1, int sonuc2, int sonuc3, int sonuc4, int sonuc5)
        {
            if (k_ton >= 0 && k_ton <= 30)
            {
                toplam = k_ton * 3;
            }
            else if (k_ton > 30 && k_ton <= 100)
            {
                toplam = sonuc1 * 3 + sonuc2 * 4;
            }
            else if (k_ton > 100)
            {
                toplam = sonuc1 * 3 + sonuc5 * 4 + sonuc3 * 5;
            }
            MessageBox.Show("Toplamda " + k_ton + " Ton Su Tüketimi Gerçekleştirmişşiniz." + "\n" + "Ödemeniz Gereken Toplam Su Faturası Tutarı :  " + toplam + " ₺");
        }

        private static void isyeri(int k_ton, int toplam, int sonuc1, int sonuc2, int sonuc3, int sonuc4, int sonuc5)
        {
            if (k_ton >= 0 && k_ton <= 30)
            {
                toplam = k_ton * 4;
            }
            else if (k_ton > 30 && k_ton <= 100)
            {
                toplam = sonuc1 * 4 + sonuc2 * 5;
            }
            else if (k_ton > 100)
            {
                toplam = sonuc1 * 4 + sonuc5 * 5 + sonuc3 * 10;
            }
            MessageBox.Show("Toplamda " + k_ton + " Ton Su Tüketimi Gerçekleştirmişşiniz." + "\n" + "Ödemeniz Gereken Toplam Su Faturası Tutarı :  " + toplam + " ₺");
        }

        private static void sanayi(int k_ton, int toplam, int sonuc1, int sonuc2, int sonuc3, int sonuc4, int sonuc5)
        {
            if (k_ton >= 0 && k_ton <= 30)
            {
                toplam = k_ton * 5;
            }
            else if (k_ton > 30 && k_ton <= 100)
            {
                toplam = sonuc1 * 5 + sonuc2 * 6;
            }
            else if (k_ton > 100)
            {
                toplam = sonuc1 * 5 + sonuc5 * 6 + sonuc3 * 11;
            }
            MessageBox.Show("Toplamda " + k_ton + " Ton Su Tüketimi Gerçekleştirmişşiniz." + "\n" + "Ödemeniz Gereken Toplam Su Faturası Tutarı :  " + toplam + " ₺");
        }
    }
}
