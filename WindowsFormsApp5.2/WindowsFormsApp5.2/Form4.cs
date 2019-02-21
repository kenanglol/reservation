using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5._2
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void Form4_Load(object sender, EventArgs e)
		{
			foreach (sehir sehir in test.tum_sehirler)
			{
				comboBox2.Items.Add(sehir.isim);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			sehir sehirr = test.sehir_ara(comboBox2.SelectedItem.ToString());
			listView1.Items.Clear();

			if (comboBox1.SelectedItem.ToString().Equals("İnorder"))
			{

				List<düzey<turistik>> liste = sehirr.yer_agaci.in_order();
				foreach (düzey<turistik> duzeyy in liste)
				{
					ListViewItem otellik = listView1.Items.Add(duzeyy.data.data.isim);

					otellik.SubItems.Add(Convert.ToString(duzeyy.level));


					listView1.Height += 15;
					listView1.Update();
				}

			}
			else if (comboBox1.SelectedItem.ToString().Equals("Postorder"))
			{

				List<düzey<turistik>> liste = sehirr.yer_agaci.post_order();
				foreach (düzey<turistik> duzeyy in liste)
				{
					ListViewItem otellik = listView1.Items.Add(duzeyy.data.data.isim);

					otellik.SubItems.Add(Convert.ToString(duzeyy.level));


					listView1.Height += 15;
					listView1.Update();
				}

			}
			else if (comboBox1.SelectedItem.ToString().Equals("Preorder"))
			{

				List<düzey<turistik>> liste = sehirr.yer_agaci.pre_order();
				foreach (düzey<turistik> duzeyy in liste)
				{
					ListViewItem otellik = listView1.Items.Add(duzeyy.data.data.isim);

					otellik.SubItems.Add(Convert.ToString(duzeyy.level));


					listView1.Height += 15;
					listView1.Update();
				}

			}
		}
	}
}
