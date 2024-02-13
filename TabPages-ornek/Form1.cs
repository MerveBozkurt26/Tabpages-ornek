using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabPages_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal corbaFiyat = 150;
            decimal salataFiyat = 80;
            decimal anaYemekFiyat = 100;
            decimal tatliFiyat = 50;

            decimal toplamtutar = 0;



            if (tabControl1.SelectedIndex == 2)
            {
                string ad = txtAdSoyad.Text;
                decimal corbaToplam = 0;
                decimal salataToplam = 0;
                decimal anaYemekToplam = 0;
                decimal tatliToplam = 0;

                if (numCorba.Value > 0)
                {
                    corbaToplam = numCorba.Value * corbaFiyat;
                    toplamtutar += corbaToplam;
                }
                if (numSalata.Value > 0)
                {
                    salataToplam = numSalata.Value * salataFiyat;
                    toplamtutar += salataToplam;
                }
                if (numAnaYemek.Value > 0)
                {
                    anaYemekToplam = numAnaYemek.Value * anaYemekFiyat;
                    toplamtutar += anaYemekToplam;
                }
                if (numTatli.Value > 0)
                {
                    tatliToplam = numTatli.Value * tatliFiyat;
                    toplamtutar += tatliToplam;
                }

                lblHesap.Text = String.Format("Ad: {0}\nTelefon: {1}\n\n" +
             
                "{2} x Çorba = {3}\n" +
                "{4} x Salata = {5}\n" +
                "{6} x Ana Yemek = {7}\n" +
                 "{8} x Tatlı = {9}\n" +
               "Toplam Fiyat: {10}\n" +
                "Afiyet olsun. Teşekkür Ederiz.",
                 ad,
                 numCorba.Value,
                 corbaToplam,
                 numSalata.Value,
                 salataToplam,
                 numAnaYemek.Value,
                 anaYemekToplam,
                 numTatli.Value,
                 tatliToplam,
                 toplamtutar);
            }
        }
    }
}
