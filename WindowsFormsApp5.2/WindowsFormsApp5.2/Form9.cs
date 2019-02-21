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
    public partial class Form9 : Form
    {
        public const string oda_dat = test.oda_dat;
        public const string otel_dat = test.otel_dat;
        public const string yer_dat =test.yer_dat;
        public const string ozellik_dat = test.ozellik_dat;
        public Form9()
        {
            InitializeComponent();
        }
		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox2.Text == null || textBox5.Text == null)
			{
				MessageBox.Show("Otel Adı ve Turistik Yer Boş Bırakılamaz.");
			}
			else if (test.turist_ara(textBox2.Text) == null)
			{
				MessageBox.Show("Turistik Yer Bulunamadı.");
			}
			else
			{
				otel yeni_otel = new otel(textBox5.Text, textBox1.Text);

				string otel_topla = textBox5.Text + "!" + textBox1.Text + "," + textBox2.Text + "!";

				List<string> aralar = new List<string>();
				if (checkBox1.Checked == true)
				{
					aralar.Add("Fitness");
					yeni_otel.bilgiler.Add("Fitness");
				}
				if (checkBox2.Checked == true)
				{
					aralar.Add("Sauna");
					yeni_otel.bilgiler.Add("Sauna");
				}
				if (checkBox3.Checked == true)
				{
					aralar.Add("Termal Tesis");
					yeni_otel.bilgiler.Add("Termal Tesis");
				}
				if (checkBox4.Checked == true)
				{
					aralar.Add("Havuz");
					yeni_otel.bilgiler.Add("Havuz");
				}
				if (checkBox5.Checked == true)
				{
					aralar.Add("Tam Pansiyon");
					yeni_otel.bilgiler.Add("Tam Pansiyon");
				}
				for (int i = 0; i < aralar.Count - 1; i++)
				{
					otel_topla += aralar[i] + ",";
				}
				otel_topla += aralar.Last();
				string[] ozellik = test.okuma(ozellik_dat);
				foreach (string a in aralar)
				{
					for (int oz = 0; oz < ozellik.Length; oz++)
					{
						if (ozellik[oz].Split('-')[0].Equals(a))
						{
							ozellik[oz] += "," + textBox5.Text;
						}
					}
					test.specials.Search(a).otels.Add(yeni_otel);
				}
				test.yazma(ozellik_dat, ozellik);

				otel_topla += "!";
				string[] arrLine = test.okuma(oda_dat);
				List<string> arrlist = arrLine.ToList();
				int son = Convert.ToInt32(arrlist.Last().Split('-')[0]) + 1;
				List<int> sonlar = new List<int>();
				if (numericUpDown1.Value != 0)
				{
					string ekle1 = son + "-" + "Standart" + "-3." + numericUpDown1.Value + "." + numericUpDown8.Value;
					arrlist.Add(ekle1);
					oda yen = new oda(Convert.ToString(son), "Standart", 3, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown8.Value));
					yen.sahip = yeni_otel;
					yeni_otel.odalar.Add(yen);
					sonlar.Add(son);
					son += 1;
				}
				if (numericUpDown16.Value != 0)
				{
					string ekle1 = son + "-" + "Standart" + "-2." + numericUpDown16.Value + "." + numericUpDown12.Value;
					arrlist.Add(ekle1);
					oda yen = new oda(Convert.ToString(son), "Standart", 2, Convert.ToInt32(numericUpDown16.Value), Convert.ToInt32(numericUpDown12.Value));
					yen.sahip = yeni_otel;
					yeni_otel.odalar.Add(yen);
					sonlar.Add(son);
					son += 1;
				}
				if (numericUpDown4.Value != 0)
				{
					string ekle1 = son + "-" + "Superior" + "-3." + numericUpDown4.Value + "." + numericUpDown5.Value;
					arrlist.Add(ekle1);
					oda yen = new oda(Convert.ToString(son), "Superior", 3, Convert.ToInt32(numericUpDown4.Value), Convert.ToInt32(numericUpDown5.Value));
					yen.sahip = yeni_otel;
					yeni_otel.odalar.Add(yen);
					sonlar.Add(son);
					son += 1;
				}
				if (numericUpDown13.Value != 0)
				{
					string ekle1 = son + "-" + "Superior" + "-2." + numericUpDown13.Value + "." + numericUpDown9.Value;
					arrlist.Add(ekle1);
					oda yen = new oda(Convert.ToString(son), "Superior", 2, Convert.ToInt32(numericUpDown13.Value), Convert.ToInt32(numericUpDown9.Value));
					yen.sahip = yeni_otel;
					yeni_otel.odalar.Add(yen);
					sonlar.Add(son);
					son += 1;
				}
				if (numericUpDown3.Value != 0)
				{
					string ekle1 = son + "-" + "Deluxe" + "-3." + numericUpDown3.Value + "." + numericUpDown6.Value;
					arrlist.Add(ekle1);
					oda yen = new oda(Convert.ToString(son), "Deluxe", 3, Convert.ToInt32(numericUpDown3.Value), Convert.ToInt32(numericUpDown6.Value));
					yen.sahip = yeni_otel;
					yeni_otel.odalar.Add(yen);
					sonlar.Add(son);
					son += 1;
				}
				if (numericUpDown14.Value != 0)
				{
					string ekle1 = son + "-" + "Deluxe" + "-2." + numericUpDown14.Value + "." + numericUpDown10.Value;
					arrlist.Add(ekle1);
					oda yen = new oda(Convert.ToString(son), "Deluxe", 2, Convert.ToInt32(numericUpDown14.Value), Convert.ToInt32(numericUpDown10.Value));
					yen.sahip = yeni_otel;
					yeni_otel.odalar.Add(yen);
					sonlar.Add(son);
					son += 1;
				}
				if (numericUpDown2.Value != 0)
				{
					string ekle1 = son + "-" + "King Deluxe" + "-3." + numericUpDown2.Value + "." + numericUpDown7.Value;
					arrlist.Add(ekle1);
					oda yen = new oda(Convert.ToString(son), "King Deluxe", 3, Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown7.Value));
					yen.sahip = yeni_otel;
					yeni_otel.odalar.Add(yen);
					sonlar.Add(son);
					son += 1;
				}
				if (numericUpDown15.Value != 0)
				{
					string ekle1 = son + "-" + "King Deluxe" + "-2." + numericUpDown15.Value + "." + numericUpDown11.Value;
					arrlist.Add(ekle1);
					oda yen = new oda(Convert.ToString(son), "King Deluxe", 2, Convert.ToInt32(numericUpDown15.Value), Convert.ToInt32(numericUpDown11.Value));
					yen.sahip = yeni_otel;
					yeni_otel.odalar.Add(yen);
					sonlar.Add(son);
					son += 1;
				}
				for (int i = 0; i < sonlar.Count - 1; i++)
				{
					otel_topla += sonlar[i] + ",";
				}
				otel_topla += sonlar.Last();
				string[] otll = test.okuma(otel_dat);
				List<string> otlist = otll.ToList();
				otlist.Add(otel_topla);
				string[] vac = otlist.ToArray();
				test.yazma(otel_dat, vac);
				string[] aar = arrlist.ToArray();
				test.yazma(oda_dat, aar);
				string[] yrr = File.ReadAllLines(yer_dat);
				for (int y = 0; y < yrr.Length; y++)
				{
					string trr = yrr[y].Split('!')[0];
					if (trr.Equals(textBox2.Text))
					{
						yrr[y] += "," + textBox5.Text;
						test.turist_ara(trr).oteller.Add(yeni_otel);
						break;
					}
				}
				test.yazma(yer_dat, yrr);
			}
			this.Close();
            MessageBox.Show("İşleminiz başarılı");
		}


	}
}
