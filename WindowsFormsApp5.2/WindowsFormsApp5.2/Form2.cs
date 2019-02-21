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
    public partial class Form2 : Form
    {
        Form1 ff;
     
        public Form2(Form1 anasayf)
        {
            ff = anasayf;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool is_exist = false;
            foreach (kullanıcı user in test.tum_kullan)
            {
                if (user.Password.Equals(textBox2.Text) && user.Kullanıcı_adı.Equals(textBox1.Text))
                {
                    if (user.uye_tip.Equals("admin"))
                    {
                        admin add = (admin)user;
                        Form fv = new Form8(add);


                        this.Close();
                        ff.Hide();
                        fv.Show();
                    }
                    else
                    {
                        Üye üye = (Üye)user;
                        Form3 fv = new Form3(üye);

                        fv.Show();
                        this.Close();
                    }
                    is_exist = true;
                    break;
                }
            }
            if (is_exist == false)
            {
                MessageBox.Show("Kullanıcı Bulunamadı");
            }
        }

		private void Form2_Load(object sender, EventArgs e)
		{

		}
	}
}
