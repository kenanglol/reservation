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
    public partial class Form3 : Form
    {
        Üye üyee;
        List<otel> listviewOtelleri;
        
        public Form3(Üye a)
        {
            üyee = a;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == null || textBox1.Text.Equals(""))
            {
                MessageBox.Show("Arama Kısmına Birşeyler Yazın");
            }
            else if (textBox1.Text.Contains("..."))
            {
                MessageBox.Show("Arama Kısmına Birşeyler Yazın");

            }else if(test.arama(textBox1.Text)==null){
				MessageBox.Show("Arama Bulunamadı");
			}
            else
            {
                panel4.Height = 250;

                List<otel> bulunan = test.arama(textBox1.Text);
                listviewOtelleri = bulunan;
                panel4.Visible = true;
                
                listView1.Items.Clear();
                List<otel> sonuclar = test.arama(textBox1.Text);
                List<otel> listviewOtelleri2 = new List<otel>();



                foreach (otel a in sonuclar)
                    {
                        foreach (oda b in a.odalar)
                        {
                            if (b.fiyat >= numericUpDownmin.Value && b.fiyat <= numericUpDownmax.Value)
                            {
                               if (listviewOtelleri2.Contains(a) == false)
                               {
                                listviewOtelleri2.Add(a);
                               }
                            }
                        }
                    }
                    sonuclar = listviewOtelleri2;
                   listviewOtelleri = listviewOtelleri2;
               
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
                            panel4.Height += 15;

                            listView1.Update();
                        
                    }
                }

                // Form ff11 = new Form11(bulunan);
                //this.Hide();
            }

        }

        private void ağaçGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fv = new Form4();

            fv.Show();
        }

        private void sizeÖzelToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Form tavsiye = new Form13(üyee);
			tavsiye.Show();

        }

        private void çokluRezerveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fv = new Form5(üyee);

            fv.Show();
        }

        private void bizeBildirinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fv = new Form6(üyee);

            fv.Show();
        }

        private void kişi_MouseHover(object sender, EventArgs e)
        {
           
                toolTip1.Show("Profilinizi görüntülemek için tıklayınız.", kişi);
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {


            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ItemSelectionChanged_1(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            Form fv = new Form12(listviewOtelleri[e.ItemIndex],2,üyee);
            fv.Show();
        }

		private void Form3_Load(object sender, EventArgs e)
		{
			kişi.Text = üyee.Kullanıcı_adı;
		}
	}
}
