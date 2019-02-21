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
    public partial class Form1 : Form
    {
        List<otel> listviewOtelleri;
        public Form1(Lineer_Hash a, Chain_Hash b)
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form fv = new Form7(this);

            fv.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form fv = new Form2(this);

            fv.Show();
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

            }
            else
            {
                panel5.Height = 150;
               
                List<otel> bulunan = test.arama(textBox1.Text);
                listviewOtelleri = bulunan;
                panel4.Visible = false;
                panel5.Visible = true;
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
          
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
           
            Form fv = new Form12(listviewOtelleri[e.ItemIndex],1);
            fv.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
