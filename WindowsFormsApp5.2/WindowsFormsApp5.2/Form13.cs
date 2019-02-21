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
	public partial class Form13 : Form
	{
        List<otel> oteller;
		public Form13(Üye siz)
		{
			oteller=siz.tavsiye();
			InitializeComponent();
		}

        private void Form13_Load(object sender, EventArgs e)
        {
            foreach (otel otl in oteller)
            {
                string bilg = "";

                foreach (string a in otl.bilgiler)
                {
                    bilg += a + ",";
                }

                ListViewItem otellik = listView1.Items.Add(otl.isim);
                otellik.SubItems.Add(otl.yer_isim);
                otellik.SubItems.Add(bilg);
                

                listView1.Update();
            }
        }
    }
}
