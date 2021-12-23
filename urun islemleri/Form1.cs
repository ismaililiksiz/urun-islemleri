using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urun_islemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        urun u = new urun();

        private void button1_Click(object sender, EventArgs e)
        {
            u.urunno = int.Parse(textBox1.Text);
            u.uruncesidi = textBox2.Text;
            u.urunkategorisi = textBox3.Text;
            u.fiyat = int.Parse(textBox4.Text);
            u.stokmiktarı = int.Parse(textBox5.Text);
            u.sayac = 0;
            listBox1.Items.Add(u.urunno + " " + u.uruncesidi + " " + u.urunkategorisi + " " + u.fiyat + " " + u.stokmiktarı);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (u.stokmiktarı <= u.sayac)
            {
                MessageBox.Show("Stokta ürün kalmadı");
            }
            else
            {             
                u.kasa = u.kasa + u.fiyat;
                MessageBox.Show("ürün başarıyla satıldı");
                u.sayac++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = u.kasa.ToString();
        }
    }
}
