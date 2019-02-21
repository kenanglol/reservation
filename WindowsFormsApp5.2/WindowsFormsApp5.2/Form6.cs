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

	public partial class Form6 : Form
	{
		Üye üyee;
		List<string> press1;
		List<string> press2;
		public Form6(Üye üyeee)
		{
			press1 = new List<string>();
			press2 = new List<string>();
			üyee = üyeee;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int puan = 0;
			string puann = "";
			for (int i = 1; i <= 10; i++)
			{
				if (checkBox10.Checked == true)
				{
					puan = 10;
					puann = "Mükemmel";
					break;
				}
				else if (checkBox9.Checked == true)
				{
					puan = 9;
					puann = "Çok iyi";
					break;
				}
				else if (checkBox8.Checked == true)
				{
					puan = 8;
					puann = "Çok iyi";
					break;
				}
				else if (checkBox7.Checked == true)
				{
					puan = 7;
					puann = "İyi";
					break;
				}
				else if (checkBox6.Checked == true)
				{
					puan = 6;
					puann = "İyi";
					break;
				}
				else if (checkBox5.Checked == true)
				{
					puan = 5;
					puann = "Orta";
					break;
				}
				else if (checkBox4.Checked == true)
				{
					puan = 4;
					puann = "Orta";
					break;
				}
				else if (checkBox3.Checked == true)
				{
					puan = 3;
					puann = "Kötü";
					break;

				}
				else if (checkBox2.Checked == true)
				{
					puan = 2;
					puann = "Çok Kötü";
					break;
				}
				else if (checkBox1.Checked == true)
				{
					puan = 1;
					puann = "Rezalet Kötü";
					break;
				}
				else
				{
					puan = 5;
					puann = "orta";
					break;
				}
			}
			label3.Visible = true;
			string[] words = richTextBox1.Text.Split(' ');

			string temppp = "";

            string dosya_yolux = test.possitive;

			StreamWriter sws = File.AppendText(dosya_yolux);





			foreach (string word in words)
			{
				string temp = "";
				if (word.EndsWith(",") || word.EndsWith(".") || word.EndsWith("?") || word.EndsWith("!"))
				{
					char[] keke = word.ToArray();
					for (int i = 0; i < keke.Length; i++)
					{
						if (i != keke.Length - 1)
						{
							temppp += keke[i];
							temp += keke[i];

						}
					}

					for (int i = 0; i < 30; i++)
					{
						if (word.ToLower().EndsWith(press1[i].ToLower()) && !(word.ToLower().EndsWith(press2[i].ToLower())))
						{
							sws.WriteLine(temp);
						}
					}

					temppp += " ";
				}
				else
				{
					temppp += word + " ";
					for (int i = 0; i < 60; i++)
					{
						if (word.ToLower().EndsWith(press1[i].ToLower()) && !(word.ToLower().EndsWith(press2[i].ToLower())))
						{
							sws.WriteLine(word);
						}
					}
				}

			}

			//3 den fazla positive kelime varsa o cümle positivedir. positive cümlelerde ortak kullanılan kelimeler positive kelimeler dosyasına alınır.
			üyee.gorusler.Add(richTextBox1.Text);
            string dosya_yolu = test.opinion;

			StreamWriter sw = File.AppendText(dosya_yolu);


			sw.WriteLine(üyee.Kullanıcı_adı + "," + puan + "," + temppp + puann);

			sw.Close();
			sws.Close();
		}

		private void Form6_Load(object sender, EventArgs e)
		{
			textBox1.Text = üyee.Kullanıcı_adı;
			string dosya_yolu3 = test.computer_path + "\\press.dat";

			FileStream fsp = new FileStream(dosya_yolu3, FileMode.Open, FileAccess.Read);

			StreamReader swp = new StreamReader(fsp);

			string yazip = swp.ReadLine();
			while (yazip != null)
			{
				press1.Add(yazip);
				yazip = swp.ReadLine();

			}

			swp.Close();
			fsp.Close();

			string dosya_yolu = test.computer_path+"\\press2.dat";

			FileStream ffs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

			StreamReader sww = new StreamReader(ffs);

			string x = sww.ReadLine();
			while (x != null)
			{
				press2.Add(x);
				x = sww.ReadLine();
			}

			sww.Close();
			ffs.Close();
		}

		private void checkBox10_CheckedChanged(object sender, EventArgs e)
		{
			
				if (checkBox10.Checked == true)
				{
					for (int i = 1; i <= 9; i++)
					{
						if (i == 1)
						{
							checkBox1.Checked = true;
						}
						if (i == 2)
						{
							checkBox2.Checked = true;
						}
						if (i == 3)
						{
							checkBox3.Checked = true;
						}
						if (i == 4)
						{
							checkBox4.Checked = true;
						}
						if (i == 5)
						{
							checkBox5.Checked = true;
						}
						if (i == 6)
						{
							checkBox6.Checked = true;
						}
						if (i == 7)
						{
							checkBox7.Checked = true;
						}
						if (i == 8)
						{
							checkBox8.Checked = true;
						}
						if (i == 9)
						{
							checkBox9.Checked = true;
						}
					}
				}
				else
				{
					for (int i = 1; i <= 9; i++)
					{
						if (i == 1)
						{
							checkBox1.Checked = false;
						}
						if (i == 2)
						{
							checkBox2.Checked = false;
						}
						if (i == 3)
						{
							checkBox3.Checked = false;
						}
						if (i == 4)
						{
							checkBox4.Checked = false;
						}
						if (i == 5)
						{
							checkBox5.Checked = false;
						}
						if (i == 6)
						{
							checkBox6.Checked = false;
						}
						if (i == 7)
						{
							checkBox7.Checked = false;
						}
						if (i == 8)
						{
							checkBox8.Checked = false;
						}
						if (i == 9)
						{
							checkBox9.Checked = false;
						}
					}
				}
			}

		private void checkBox9_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox9.Checked == true)
			{
				for (int i = 1; i <= 9; i++)
				{
					if (i == 1)
					{
						checkBox1.Checked = true;
					}
					if (i == 2)
					{
						checkBox2.Checked = true;
					}
					if (i == 3)
					{
						checkBox3.Checked = true;
					}
					if (i == 4)
					{
						checkBox4.Checked = true;
					}
					if (i == 5)
					{
						checkBox5.Checked = true;
					}
					if (i == 6)
					{
						checkBox6.Checked = true;
					}
					if (i == 7)
					{
						checkBox7.Checked = true;
					}
					if (i == 8)
					{
						checkBox8.Checked = true;
					}

				}
			}
			else
			{
				for (int i = 1; i <= 9; i++)
				{
					if (i == 1)
					{
						checkBox1.Checked = false;
					}
					if (i == 2)
					{
						checkBox2.Checked = false;
					}
					if (i == 3)
					{
						checkBox3.Checked = false;
					}
					if (i == 4)
					{
						checkBox4.Checked = false;
					}
					if (i == 5)
					{
						checkBox5.Checked = false;
					}
					if (i == 6)
					{
						checkBox6.Checked = false;
					}
					if (i == 7)
					{
						checkBox7.Checked = false;
					}
					if (i == 8)
					{
						checkBox8.Checked = false;
					}

				}
			}
		}

		private void checkBox8_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox8.Checked == true)
			{
				for (int i = 1; i <= 8; i++)
				{
					if (i == 1)
					{
						checkBox1.Checked = true;
					}
					if (i == 2)
					{
						checkBox2.Checked = true;
					}
					if (i == 3)
					{
						checkBox3.Checked = true;
					}
					if (i == 4)
					{
						checkBox4.Checked = true;
					}
					if (i == 5)
					{
						checkBox5.Checked = true;
					}
					if (i == 6)
					{
						checkBox6.Checked = true;
					}
					if (i == 7)
					{
						checkBox7.Checked = true;
					}

				}
			}
			else
			{
				for (int i = 1; i <= 8; i++)
				{
					if (i == 1)
					{
						checkBox1.Checked = false;
					}
					if (i == 2)
					{
						checkBox2.Checked = false;
					}
					if (i == 3)
					{
						checkBox3.Checked = false;
					}
					if (i == 4)
					{
						checkBox4.Checked = false;
					}
					if (i == 5)
					{
						checkBox5.Checked = false;
					}
					if (i == 6)
					{
						checkBox6.Checked = false;
					}
					if (i == 7)
					{
						checkBox7.Checked = false;
					}

				}
			}
		}

		private void checkBox7_CheckedChanged(object sender, EventArgs e)
		{

			if (checkBox7.Checked == true)
			{
				for (int i = 1; i <= 7; i++)
				{
					if (i == 1)
					{
						checkBox1.Checked = true;
					}
					if (i == 2)
					{
						checkBox2.Checked = true;
					}
					if (i == 3)
					{
						checkBox3.Checked = true;
					}
					if (i == 4)
					{
						checkBox4.Checked = true;
					}
					if (i == 5)
					{
						checkBox5.Checked = true;
					}
					if (i == 6)
					{
						checkBox6.Checked = true;
					}

				}
			}
			else
			{
				for (int i = 1; i <= 7; i++)
				{
					if (i == 1)
					{
						checkBox1.Checked = false;
					}
					if (i == 2)
					{
						checkBox2.Checked = false;
					}
					if (i == 3)
					{
						checkBox3.Checked = false;
					}
					if (i == 4)
					{
						checkBox4.Checked = false;
					}
					if (i == 5)
					{
						checkBox5.Checked = false;
					}
					if (i == 6)
					{
						checkBox6.Checked = false;
					}

				}
			}
		}

		private void checkBox6_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox6.Checked == true)
			{
				for (int i = 1; i <= 6; i++)
				{
					if (i == 1)
					{
						checkBox1.Checked = true;
					}
					if (i == 2)
					{
						checkBox2.Checked = true;
					}
					if (i == 3)
					{
						checkBox3.Checked = true;
					}
					if (i == 4)
					{
						checkBox4.Checked = true;
					}
					if (i == 5)
					{
						checkBox5.Checked = true;
					}

				}
			}
			else
			{
				for (int i = 1; i <= 6; i++)
				{
					if (i == 1)
					{
						checkBox1.Checked = false;
					}
					if (i == 2)
					{
						checkBox2.Checked = false;
					}
					if (i == 3)
					{
						checkBox3.Checked = false;
					}
					if (i == 4)
					{
						checkBox4.Checked = false;
					}
					if (i == 5)
					{
						checkBox5.Checked = false;
					}

				}
			}
		}

		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox5.Checked == true)
			{
				for (int i = 1; i <= 5; i++)
				{
					if (i == 1)
					{
						checkBox1.Checked = true;
					}
					if (i == 2)
					{
						checkBox2.Checked = true;
					}
					if (i == 3)
					{
						checkBox3.Checked = true;
					}
					if (i == 4)
					{
						checkBox4.Checked = true;
					}
					if (i == 5)
					{
						checkBox5.Checked = true;
					}

				}
			}
			else
			{
				for (int i = 1; i <= 5; i++)
				{
					if (i == 1)
					{
						checkBox1.Checked = false;
					}
					if (i == 2)
					{
						checkBox2.Checked = false;
					}
					if (i == 3)
					{
						checkBox3.Checked = false;
					}
					if (i == 4)
					{
						checkBox4.Checked = false;
					}
					if (i == 5)
					{
						checkBox5.Checked = false;
					}

				}
			}
		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox4.Checked == true)
			{
				for (int i = 1; i <= 4; i++)
				{
					if (i == 1)
					{
						checkBox1.Checked = true;
					}
					if (i == 2)
					{
						checkBox2.Checked = true;
					}
					if (i == 3)
					{
						checkBox3.Checked = true;
					}
					if (i == 4)
					{
						checkBox4.Checked = true;
					}

				}
			}
			else
			{
				for (int i = 1; i <= 4; i++)
				{
					if (i == 1)
					{
						checkBox1.Checked = false;
					}
					if (i == 2)
					{
						checkBox2.Checked = false;
					}
					if (i == 3)
					{
						checkBox3.Checked = false;
					}
					if (i == 4)
					{
						checkBox4.Checked = false;
					}

				}
			}
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{

			if (checkBox3.Checked == true)
			{
				for (int i = 1; i <= 3; i++)
				{
					if (i == 1)
					{
						checkBox1.Checked = true;
					}
					if (i == 2)
					{
						checkBox2.Checked = true;
					}
					if (i == 3)
					{
						checkBox3.Checked = true;
					}

				}
			}
			else
			{
				for (int i = 1; i <= 3; i++)
				{
					if (i == 1)
					{
						checkBox1.Checked = false;
					}
					if (i == 2)
					{
						checkBox2.Checked = false;
					}
					if (i == 3)
					{
						checkBox3.Checked = false;
					}

				}
			}
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked == true)
			{
				for (int i = 1; i <= 2; i++)
				{
					if (i == 1)
					{
						checkBox1.Checked = true;
					}
					if (i == 2)
					{
						checkBox2.Checked = true;
					}

				}
			}
			else
			{
				for (int i = 1; i <= 2; i++)
				{
					if (i == 1)
					{
						checkBox1.Checked = false;
					}
					if (i == 2)
					{
						checkBox2.Checked = false;
					}

				}
			}
		}
	}
}
