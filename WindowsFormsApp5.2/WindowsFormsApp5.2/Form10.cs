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
    public partial class Form10 : Form
    {
        public Form10()
        {

            InitializeComponent();
        }

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == null && textBox2.Text == null)
			{
				MessageBox.Show("Şehir ve Yer İsmi Boş Bırakılamaz");
			}
			else if (test.sehir_ara(textBox1.Text) == null)
			{
				DialogResult dgr = MessageBox.Show("Yeni Şehir Ekle", "Kapat", MessageBoxButtons.YesNo);
				if (dgr == DialogResult.Yes)
				{
					string[] cities = test.okuma(test.sehir_dat);
					List<string> cite = cities.ToList();
					string ek = textBox1.Text + "!" + textBox2.Text;
					cite.Add(ek);
					cities = cite.ToArray();
					test.yazma(test.sehir_dat, cities);
					sehir elp = new sehir(textBox1.Text);
					turistik t = new turistik(textBox2.Text);
					elp.yer_agaci.Add(t);
					test.sehirler.add(elp);
					string tur1 = textBox2.Text + "!";
					List<string> eklemedir = test.okuma(test.yer_dat).ToList();
					eklemedir.Add(tur1);
					test.yazma(test.yer_dat, eklemedir.ToArray());
					this.Close();
				}
			}
			else
			{
				turistik tt = new turistik(textBox2.Text);
				sehir ekle = test.sehir_ara(textBox1.Text);
				String[] a = test.okuma(test.yer_dat);
				String[] yerekle = test.okuma(test.sehir_dat);
				for (int t = 0; t < yerekle.Length; t++)
				{
					string ara_city = yerekle[t].Split('!')[0];
					if (ara_city.Equals(textBox1.Text))
					{
						yerekle[t] += "," + textBox2.Text;
					}
				}
				List<string> palace = a.ToList();
				string g = textBox2.Text + "!";
				palace.Add(g);
				test.yazma(test.yer_dat, palace.ToArray());
				test.yazma(test.sehir_dat, yerekle);
				ekle.yer_agaci.Add(tt);
				this.Close();
			}
		}
	}
}
