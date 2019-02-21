using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5._2
{
    public partial class Form7 : Form
    {
        Form1 ana_sayfa;
        public bool is_exist(string kullan)
        {
            bool exist = false;
            foreach (kullanıcı kul in test.tum_kullan)
            {
                if (kul.Kullanıcı_adı.Equals(kullan))
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }
        public Form7(Form1 main)
        {
            ana_sayfa = main;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox6.Text.Equals(""))
            {
                MessageBox.Show("Kullanıcı Adı ve Şifreyi Giriniz.");
            }
            else if (is_exist(textBox1.Text))
            {
                MessageBox.Show("Bu Kullanıcı Adına Sahip Başka Bir Kullanıcı Var.");
            }
            else
            {
                string isim = textBox1.Text + " " + textBox2.Text;
                string yapı = "\nuye" + "," + textBox1.Text + "," + textBox6.Text + "," + isim + "," +
                    textBox3.Text + "," + comboBox1.Text + "," + comboBox2.Text + "," + textBox5.Text + "," + textBox4.Text;
                File.AppendAllText(test.kullanıcı_dat, yapı);
                Üye yeni_uye = new Üye("uye", textBox1.Text, isim, textBox6.Text);
                yeni_uye.cinsiyet = comboBox1.Text;
                yeni_uye.evli = comboBox2.Text;
                yeni_uye.maas = Convert.ToInt32(textBox4.Text);
                yeni_uye.meslek = textBox5.Text;
                test.tum_kullan.Add(yeni_uye);
                this.Close();
            }
        }
    }
}
