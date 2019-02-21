using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5._2.Properties;

namespace WindowsFormsApp5._2
{
    public partial class Form12 : Form
    {
        private bool isCollapsed;
        private bool isCollapsed2;
        private bool isCollapsed3;
        private bool isCollapsed4;
        otel bulunan;
        int a;
        Üye üyee;
        public Form12(otel bulunann,int aa,Üye üyeee=null)
        {
            a = aa;
            üyee = üyeee;
            bulunan = bulunann;
            InitializeComponent();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button5.Image = Resources.Collapse_Arrow_20px;
                panelDropDownStandart.Height += 10;
                if (panelDropDownStandart.Size == panelDropDownStandart.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button5.Image = Resources.Expand_Arrow_20px;
                panelDropDownStandart.Height -= 10;
                if (panelDropDownStandart.Size == panelDropDownStandart.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(isCollapsed2)
            {
                button51.Image = Resources.Collapse_Arrow_20px;
                panelDropDownSuperior.Height += 10;
                if (panelDropDownSuperior.Size == panelDropDownSuperior.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = false;
                }
            }
            else
            {
                button51.Image = Resources.Expand_Arrow_20px;
                panelDropDownSuperior.Height -= 10;
                if (panelDropDownSuperior.Size == panelDropDownSuperior.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = true;
                }
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsed3)
            {
                button52.Image = Resources.Collapse_Arrow_20px;
                panelDropDownDeluxe.Height += 10;
                if (panelDropDownDeluxe.Size == panelDropDownDeluxe.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed3 = false;
                }
            }
            else
            {
                button52.Image = Resources.Expand_Arrow_20px;
                panelDropDownDeluxe.Height -= 10;
                if (panelDropDownDeluxe.Size == panelDropDownDeluxe.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed3 = true;
                }
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (isCollapsed4)
            {
                button53.Image = Resources.Collapse_Arrow_20px;
                panelDropDownKingDeluxe.Height += 10;
                if (panelDropDownKingDeluxe.Size == panelDropDownKingDeluxe.MaximumSize)
                {
                    timer4.Stop();
                    isCollapsed4 = false;
                }
            }
            else
            {
                button53.Image = Resources.Expand_Arrow_20px;
                panelDropDownKingDeluxe.Height -= 10;
                if (panelDropDownKingDeluxe.Size == panelDropDownKingDeluxe.MinimumSize)
                {
                    timer4.Stop();
                    isCollapsed4 = true;
                }
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
           
                if (bulunan != null)
                {
                if (a == 2)
                {
                    paneld.Visible = true;
                    panelsu.Visible = true;
                    panelkd.Visible = true;
                    panelsd.Visible = true;
                    button1.Visible = true;
                }
                    label3.Text = bulunan.isim;
                    foreach (oda odaa in bulunan.odalar)
                    {
                        if (odaa.oda_tipi.Equals("Standart"))
                        {
                            panelDropDownStandart.Visible = true;
                            if (odaa.yatak_say == 1)
                            {
                                standarttekfiyat.Text = Convert.ToString(odaa.fiyat) + " " + "₺";
                            }
                            if (odaa.yatak_say == 2)
                            {
                                standartçiftfiyat.Text = Convert.ToString(odaa.fiyat) + " " + "₺";
                            }

                        }

                        if (odaa.oda_tipi.Equals("Superior"))
                        {
                            panelDropDownSuperior.Visible = true;
                            if (odaa.yatak_say == 1)
                            {
                                superiortekfiyat.Text = Convert.ToString(odaa.fiyat) + " " + "₺";
                            }
                            if (odaa.yatak_say == 2)
                            {
                                superiorçiftfiyat.Text = Convert.ToString(odaa.fiyat) + " " + "₺";
                            }

                        }
                        if (odaa.oda_tipi.Equals("Deluxe"))
                        {
                            panelDropDownDeluxe.Visible = true;
                            if (odaa.yatak_say == 1)
                            {
                                deluxetekfiyat.Text = Convert.ToString(odaa.fiyat) + " " + "₺";
                            }
                            if (odaa.yatak_say == 2)
                            {
                                deluxeçiftfiyat.Text = Convert.ToString(odaa.fiyat) + " " + "₺";
                            }

                        }
                        if (odaa.oda_tipi.Equals("King Deluxe"))
                        {
                            panelDropDownKingDeluxe.Visible = true;
                            if (odaa.yatak_say == 1)
                            {
                                kingdeluxetekfiyat.Text = Convert.ToString(odaa.fiyat) + " " + "₺";
                            }
                            if (odaa.yatak_say == 2)
                            {
                                kingdeluxeçiftfiyat.Text = Convert.ToString(odaa.fiyat) + " " + "₺";
                            }

                        }



                    }
                }
            

        }

        private void rezervasyonbutonsdt_Click(object sender, EventArgs e)
        {
			string id = null;
			foreach (oda i in bulunan.odalar)
			{
				if (i.oda_tipi.Equals("Standart") && i.yatak_say == 1)
				{
					id = i.id;
					break;
				}
			}
			if ( bulunan.rezervasyon(id,üyee)==false)
            {
                MessageBox.Show("Üzgünüz tüm odalarımız diğer müşterilerimize hizmet vermektedir. \nLütfen diğer odaları deneyiniz.");
            }
            else
            {
                MessageBox.Show("Tek kişilik standart oda rezervasyonunuz tamamlandı.");
            }
            
        }

        private void rezervasyonbutonsdç_Click(object sender, EventArgs e)
        {
			string id = null;
			foreach (oda i in bulunan.odalar)
			{
				if (i.oda_tipi.Equals("Standart") && i.yatak_say == 2)
				{
					id = i.id;
					break;
				}
			}
			if (bulunan.rezervasyon(id, üyee)==false)
            {
                MessageBox.Show("Üzgünüz tüm odalarımız diğer müşterilerimize hizmet vermektedir. \nLütfen diğer odaları deneyiniz.");
            }
            else
            {
                MessageBox.Show("Çift kişilik standart oda rezervasyonunuz tamamlandı.");
                
            }

        }

        private void rezervasyonbutonsut_Click(object sender, EventArgs e)
        {
			string id = null;
			foreach (oda i in bulunan.odalar)
			{
				if (i.oda_tipi.Equals("Superior") && i.yatak_say == 1)
				{
					id = i.id;
					break;
				}
			}
			if (bulunan.rezervasyon(id, üyee)==false)
            {
                MessageBox.Show("Üzgünüz tüm odalarımız diğer müşterilerimize hizmet vermektedir. \nLütfen diğer odaları deneyiniz.");
            }
            else
            {

                MessageBox.Show("Tek kişilik superior oda rezervasyonunuz tamamlandı.");
            }

        }

        private void rezervasyonbutonsuç_Click(object sender, EventArgs e)
        {
			string id = null;
			foreach (oda i in bulunan.odalar)
			{
				if (i.oda_tipi.Equals("Superior") && i.yatak_say == 2)
				{
					id = i.id;
					break;
				}
			}
			if (bulunan.rezervasyon(id, üyee)==false)
            {
                MessageBox.Show("Üzgünüz tüm odalarımız diğer müşterilerimize hizmet vermektedir. \nLütfen diğer odaları deneyiniz.");
            }
            else
            {

                MessageBox.Show("Çift kişilik superior oda rezervasyonunuz tamamlandı.");
            }
        }

        private void rezervasyonbutondt_Click(object sender, EventArgs e)
        {
			string id = null;
			foreach (oda i in bulunan.odalar)
			{
				if (i.oda_tipi.Equals("Deluxe") && i.yatak_say == 1)
				{
					id = i.id;
					break;
				}
			}
			if (bulunan.rezervasyon(id, üyee)==false)
            {
                MessageBox.Show("Üzgünüz tüm odalarımız diğer müşterilerimize hizmet vermektedir. \nLütfen diğer odaları deneyiniz.");
            }
            else
            {
                MessageBox.Show("Tek kişilik deluxe oda rezervasyonunuz tamamlandı.");

            }
        }

        private void rezervasyonbutondç_Click(object sender, EventArgs e)
        {
			string id = null;
			foreach (oda i in bulunan.odalar)
			{
				if (i.oda_tipi.Equals("Deluxe") && i.yatak_say == 2)
				{
					id = i.id;
					break;
				}
			}
			if (bulunan.rezervasyon(id, üyee)==false)
            {
                MessageBox.Show("Üzgünüz tüm odalarımız diğer müşterilerimize hizmet vermektedir. \nLütfen diğer odaları deneyiniz.");
            }
            else
            {
                MessageBox.Show("Çift kişilik deluxe oda rezervasyonunuz tamamlandı.");

            }
        }

        private void rezervasyonbutonkdt_Click(object sender, EventArgs e)
        {
			string id = null;
			foreach (oda i in bulunan.odalar)
			{
				if (i.oda_tipi.Equals("King Deluxe") && i.yatak_say == 1)
				{
					id = i.id;
					break;
				}
			}
			if (bulunan.rezervasyon(id, üyee)==false)
            {
                MessageBox.Show("Üzgünüz tüm odalarımız diğer müşterilerimize hizmet vermektedir. \nLütfen diğer odaları deneyiniz.");
            }
            else
            {
                
                MessageBox.Show("Tek kişilik  king deluxe oda rezervasyonunuz tamamlandı.");

            }
        }

        private void rezervasyonbutonkdç_Click(object sender, EventArgs e)
        {
			string id = null;
			foreach (oda i in bulunan.odalar)
			{
				if (i.oda_tipi.Equals("King Deluxe") && i.yatak_say == 2)
				{
					id = i.id;
					break;
				}
			}
			if (bulunan.rezervasyon(id, üyee)==false)
            {
                MessageBox.Show("Üzgünüz tüm odalarımız diğer müşterilerimize hizmet vermektedir. \nLütfen diğer odaları deneyiniz.");
            }
            else
            {

                MessageBox.Show("Çift kişilik  king deluxe oda rezervasyonunuz tamamlandı.");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp="";
            foreach(oda a in bulunan.odalar)
            {
                temp += a.oda_tipi + "  oda tipinde kalan boş oda sayısı  " + (a.kapasite-a.doluluk)+". \n";
            }
            MessageBox.Show(temp);
        }
    }
}
