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
    public partial class Form5 : Form
    {
        Üye üyee; MinHeap heap; int cc;
        public Form5(Üye üyeee)
        {
            üyee = üyeee;
            InitializeComponent();
            heap = new MinHeap();
             cc = 0;
            foreach (oda a in test.tum_odalar)
            {
                cc += a.kapasite;
                heap.add(a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 fv = new Form11();


            
            
            int rezerv_say = Convert.ToInt32(textBoxsayi.Text);
            if (rezerv_say < cc)
            {
                int say = 0;
                while (!(say == rezerv_say))
                {
                    oda a = heap.pop();
                    if (a.kapasite > rezerv_say)
                    {
                       
                        for (int i = 0; i < rezerv_say; i++)
                        {

                            a.sahip.rezervasyon(a.id,üyee);
                            say++;



                        }
                        ListViewItem otellik = fv.listViewform11.Items.Add(a.sahip.isim);
                        otellik.SubItems.Add(a.oda_tipi);
                        otellik.SubItems.Add(Convert.ToString(rezerv_say) );
                        otellik.SubItems.Add(Convert.ToString( a.fiyat)+" ₺");

                        fv.listViewform11.Update();
                        break;
                    }
                    else
                    {
                        int aa = 0;
                        
                        for (int i = 0; i < a.kapasite; i++)
                        {
                            

                            a.sahip.rezervasyon(a.id,üyee);

                            if (say == rezerv_say)
                            {
                                break;

                            }

                            aa++;
                            say++;
                        }
                        ListViewItem otellik = fv.listViewform11.Items.Add(a.sahip.isim);
                        otellik.SubItems.Add(a.oda_tipi);
                        otellik.SubItems.Add(Convert.ToString(aa));
                        otellik.SubItems.Add(Convert.ToString(a.fiyat) + " ₺");
                        fv.listViewform11.Update();
                    }


                }
                fv.Show();
            }
            else
            {
                MessageBox.Show("Üzgünüz Otellerimizde Bukadar Rezervasyon için Oda yok !");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
