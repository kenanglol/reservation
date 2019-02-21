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
    public partial class Form8 : Form
    {
		admin addi;
        List<otel> listviewOtelleri;
        public Form8(admin add)
        {
			addi = add;
            this.kişi = new Label();
            InitializeComponent();
            this.kişi.Text = add.Kullanıcı_adı;
			this.label4.Text = admin.kar.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            if (textBox1.Text == null || textBox1.Text.Equals(""))
            {
                MessageBox.Show("Arama Kısmına Birşeyler Yazın");
            }
            else if (textBox1.Text.Contains("..."))
            {
                MessageBox.Show("Arama Kısmına Birşeyler Yazın");

            }
            else
            {
                panel5.Height = 150;

                List<otel> bulunan = test.arama(textBox1.Text);
                listviewOtelleri = bulunan;
                
                
                listView1.Items.Clear();
                List<otel> sonuclar = test.arama(textBox1.Text);
                if (sonuclar == null)
                {
                    MessageBox.Show("Bu Aramaya Uygun Hiç Otel Bulunamadı.");
                }
                else
                {

                    foreach (otel i in sonuclar)
                    {
                        string bilg = "";

                        foreach (string a in i.bilgiler)
                        {
                            bilg += a + ",";
                        }

                        ListViewItem otellik = listView1.Items.Add(i.isim);

                        otellik.SubItems.Add(i.yer_isim);
                        otellik.SubItems.Add(bilg);

                        listView1.Height += 15;
                        panel5.Height += 15;

                        listView1.Update();
                    }
                }

                // Form ff11 = new Form11(bulunan);
                //this.Hide();
            }
        }

        private void ağaçGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fv = new Form9();

            fv.Show();
        }

        private void sizeÖzelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fv = new Form10();

            fv.Show();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Form fv = new Form14(listviewOtelleri[e.ItemIndex],addi);
            fv.Show();
        }

		private void çokluRezerveToolStripMenuItem_Click(object sender, EventArgs e)
		{

			Form fv = new Form15();

			fv.Show();
		}

		private void Form8_Load(object sender, EventArgs e)
		{

		}
	}
}
