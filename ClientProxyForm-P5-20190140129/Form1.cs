using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P1_20190140129;

namespace ClientProxyForm_P5_20190140129
{
    public partial class Form1 : Form
    {
        ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonHasil_Click(object sender, EventArgs e)
        {
            int Angka1 = Convert.ToInt32(textBox1.Text);
            int Angka2 = Convert.ToInt32(textBox2.Text);

            double hasilTambah = obj.Tambah(Angka1, Angka2);
            double hasilKurang = obj.Kurang(Angka1, Angka2);
            double hasilKali = obj.Kali(Angka1, Angka2);
            double hasilBagi = obj.Bagi(Angka1, Angka2);

            labelPenjumlahan.Text = hasilTambah.ToString();
            labelPengurangan.Text = hasilKurang.ToString();
            labelPerkalian.Text = hasilKali.ToString();
            labelPembagian.Text = hasilBagi.ToString();


        }
    }
}
