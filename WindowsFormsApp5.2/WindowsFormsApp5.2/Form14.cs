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
    public partial class Form14 : Form
    {
		admin add;
        otel bulunan;
        private bool isCollapsed;
        private bool isCollapsed2;
        private bool isCollapsed3;
        private bool isCollapsed4;

        Üye üyee;
        public Form14(otel bulunann,admin ad)
        {

			add = ad;
            bulunan = bulunann;
			InitializeComponent();
			numeric_ata(numericUpDown1, numericUpDown2, oda_search("Standart", 2));
			numeric_ata(numericUpDown4, numericUpDown3, oda_search("Standart", 3));
			numeric_ata(numericUpDown8, numericUpDown7, oda_search("Superior", 2));
			numeric_ata(numericUpDown6, numericUpDown5, oda_search("Superior", 3));
			numeric_ata(numericUpDown12, numericUpDown11, oda_search("Deluxe", 2));
			numeric_ata(numericUpDown10, numericUpDown9, oda_search("Deluxe", 3));
			numeric_ata(numericUpDown16, numericUpDown15, oda_search("King Deluxe", 2));
			numeric_ata(numericUpDown14, numericUpDown13, oda_search("King Deluxe", 3));
		}
		private oda oda_search(string odatip,int yatak){
			oda hedef = null;
			foreach(oda room in bulunan.odalar){
				if(room.yatak_say==yatak && room.oda_tipi==odatip){
					hedef = room;
					break;
				}
			}
			return hedef;
		}
		private void numeric_ata(NumericUpDown nud,NumericUpDown nud2,oda d){
			if(d==null){
				nud.Value = 0;
				nud2.Value = 0;
			}else{
				nud.Value = d.kapasite;
				nud2.Value = d.fiyat;
			}
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed2)
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

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(numericUpDown1.Value!=0 && oda_search("Standart",2)==null){
				int kap = Convert.ToInt32(numericUpDown1.Value);
				int ucret = Convert.ToInt32(numericUpDown2.Value);
				bulunan.oda_ekle(new oda("Standart",2,kap,ucret));
			}else if(numericUpDown1.Value == 0 && oda_search("Standart", 2) != null)
			{
				bulunan.oda_sil(oda_search("Standart", 2));
			}
			if (numericUpDown4.Value != 0 && oda_search("Standart", 3) == null)
			{
				int kap = Convert.ToInt32(numericUpDown4.Value);
				int ucret = Convert.ToInt32(numericUpDown3.Value);
				bulunan.oda_ekle(new oda("Standart", 3, kap, ucret));
			}
			else if (numericUpDown4.Value == 0 && oda_search("Standart", 3) != null)
			{
				bulunan.oda_sil(oda_search("Standart", 3));
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (numericUpDown8.Value != 0 && oda_search("Superior", 2) == null)
			{
				int kap = Convert.ToInt32(numericUpDown8.Value);
				int ucret = Convert.ToInt32(numericUpDown7.Value);
				bulunan.oda_ekle(new oda("Superior", 2, kap, ucret));
			}
			else if (numericUpDown8.Value == 0 && oda_search("Superior", 2) != null)
			{
				bulunan.oda_sil(oda_search("Superior", 2));
			}
			if (numericUpDown6.Value != 0 && oda_search("Superior", 3) == null)
			{
				int kap = Convert.ToInt32(numericUpDown6.Value);
				int ucret = Convert.ToInt32(numericUpDown5.Value);
				bulunan.oda_ekle(new oda("Superior", 3, kap, ucret));
			}
			else if (numericUpDown6.Value == 0 && oda_search("Superior", 3) != null)
			{
				bulunan.oda_sil(oda_search("Superior", 3));
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (numericUpDown12.Value != 0 && oda_search("Deluxe", 2) == null)
			{
				int kap = Convert.ToInt32(numericUpDown12.Value);
				int ucret = Convert.ToInt32(numericUpDown11.Value);
				bulunan.oda_ekle(new oda("Deluxe", 2, kap, ucret));
			}
			else if (numericUpDown12.Value == 0 && oda_search("Deluxe", 2) != null)
			{
				bulunan.oda_sil(oda_search("Deluxe", 2));
			}
			if (numericUpDown10.Value != 0 && oda_search("Deluxe", 3) == null)
			{
				int kap = Convert.ToInt32(numericUpDown10.Value);
				int ucret = Convert.ToInt32(numericUpDown9.Value);
				bulunan.oda_ekle(new oda("Deluxe",3, kap, ucret));
			}
			else if (numericUpDown10.Value == 0 && oda_search("Deluxe", 3) != null)
			{
				bulunan.oda_sil(oda_search("Deluxe", 3));
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (numericUpDown16.Value != 0 && oda_search("King Deluxe", 2) == null)
			{
				int kap = Convert.ToInt32(numericUpDown16.Value);
				int ucret = Convert.ToInt32(numericUpDown15.Value);
				bulunan.oda_ekle(new oda("King Deluxe", 2, kap, ucret));
			}
			else if (numericUpDown16.Value == 0 && oda_search("King Deluxe", 2) != null)
			{
				bulunan.oda_sil(oda_search("King Deluxe", 2));
			}
			if (numericUpDown14.Value != 0 && oda_search("King Deluxe", 3) == null)
			{
				int kap = Convert.ToInt32(numericUpDown14.Value);
				int ucret = Convert.ToInt32(numericUpDown13.Value);
				bulunan.oda_ekle(new oda("King Deluxe", 3, kap, ucret));
			}
			else if (numericUpDown14.Value == 0 && oda_search("King Deluxe", 3) != null)
			{
				bulunan.oda_sil(oda_search("King Deluxe", 3));
			}
		}
	}
}
