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
	public partial class Form15 : Form
	{
		class gorus
		{
			public int puan;
			public List<string> yorum;
			public string kullanıcı;
			public string icerik;
			public List<string> possitivex;
			public List<string> negativex;

			public gorus()
			{
				yorum = new List<string>();
				kullanıcı = "";
				possitivex = new List<string>();
				negativex = new List<string>();
				puan = 0;
			}

		}
		List<string> possitive;
		List<string> negative;
		List<gorus> görüş;
		public Form15()
		{
			possitive = new List<string>();
			negative = new List<string>();
			görüş = new List<gorus>();
			InitializeComponent();
		}

		private void Form15_Load(object sender, EventArgs e)
		{
			string opinion =  test.computer_path+"\\görüş.dat";
			string possitive = test.computer_path + "\\possitive.dat";
			string negative = test.computer_path + "\\negative.dat";

			FileStream fsp = new FileStream(possitive, FileMode.Open, FileAccess.Read);

			StreamReader swp = new StreamReader(fsp);

			string yazip = swp.ReadLine();
			while (yazip != null)
			{
				this.possitive.Add(yazip);
				yazip = swp.ReadLine();

			}

			swp.Close();
			fsp.Close();


			FileStream fsn = new FileStream(negative, FileMode.Open, FileAccess.Read);

			StreamReader swn = new StreamReader(fsn);

			string yazin = swn.ReadLine();
			while (yazin != null)
			{
				this.negative.Add(yazin);
				yazin = swn.ReadLine();

			}

			swn.Close();
			fsn.Close();






			//görüş okuma
			FileStream fs = new FileStream(opinion, FileMode.Open, FileAccess.Read);

			StreamReader sw = new StreamReader(fs);

			string yazi = sw.ReadLine();
			while (yazi != null)
			{

				string[] parcalar = yazi.Split(',');
				gorus yenigorus = new gorus();
				yenigorus.kullanıcı = parcalar[0];
				yenigorus.puan = Convert.ToInt32(parcalar[1]);
				yenigorus.icerik = parcalar[2];
				string[] parcalar2 = parcalar[2].Split(' ');
				foreach (string a in parcalar2)
				{
					yenigorus.yorum.Add(a.ToLower());
				}
				görüş.Add(yenigorus);
				yazi = sw.ReadLine();

			}

			sw.Close();
			fs.Close();

			foreach (gorus görüs in görüş)
			{

				int pozitif_kelime_say = 0;
				int negatif_kelime_say = 0;
				foreach (string yorum in görüs.yorum)
				{
					foreach (string pozitif_kelime in this.possitive)
					{
						if (yorum.Contains(pozitif_kelime.ToLower()))
						{
							if (!(görüs.possitivex.Contains(yorum)))
							{
								pozitif_kelime_say++;
								görüs.possitivex.Add(yorum);
							}

						}
					}
					foreach (string negatif_kelime in this.negative)
					{
						if (yorum.Contains(negatif_kelime.ToLower()))
						{
							if (!(görüs.negativex.Contains(yorum)))
							{
								negatif_kelime_say++;
								görüs.negativex.Add(yorum);
							}


						}
					}
				}
				double yuzde = (double)((double)(pozitif_kelime_say * 100)) / görüs.yorum.Count;
				double yuzde2 = (double)((double)(negatif_kelime_say * 100)) / görüs.yorum.Count;
				ListViewItem otellik = listView1.Items.Add(görüs.kullanıcı);
				if (yuzde2 > yuzde)
				{
					otellik.SubItems.Add("Olumsuz");
				}

				else
				{
					otellik.SubItems.Add("Olumlu");
				}


				otellik.SubItems.Add(görüs.icerik);

				listView1.Height += 15;


				listView1.Update();
			}
			List<gorus> görüşş = görüş;
			string aaaa = "şklk";

		}

		
	}
}
