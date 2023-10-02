using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dortıslemorn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam, cikar, carp, bol;

              

            sayi1 = Convert.ToDouble(txtSayi1.Text);
            sayi2 = Convert.ToDouble(txtSayi2.Text);

            toplam = sayi1 + sayi2;
            cikar= sayi1 - sayi2;
            carp = sayi1 * sayi2;
            bol = sayi1 / sayi2;

            lblTopla.Text = "toplam " + toplam;
            lblCikar.Text = "fark " + cikar;
            lblCarp.Text = "çarpım " + carp;
            lblBol.Text = "bölüm " + bol;

        }
    }
}
