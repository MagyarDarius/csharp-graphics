using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafika_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int osszeg = 0;

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (buttonResult.Text == "Fizetés")
            {
                kartya_fizetes.Visible = true;
                penz_fizetes.Visible = true;
                buttonResult.Text = "Mégse";
            }
            else
            {
                kartya_fizetes.Visible = false;
                penz_fizetes.Visible = false;
                buttonResult.Text = "Fizetés";
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RadioKevesCukor_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void RadioCukorNelkul_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void ForroItalok_Enter(object sender, EventArgs e)
        {

        }

        private void Radiotea_CheckedChanged(object sender, EventArgs e)
        {
            if(Radiotea.Checked == true)
            {
                kavekrem.Enabled = false;
                Tejszin.Enabled = false;
                Tejpor.Enabled = false;
                Citrom.Enabled = true;
                Citrom.Checked = false;
                kavekrem.Checked = false;
                Tejszin.Checked = false;
                Tejpor.Checked = false;
            }
        }

        private void Radioespresso_CheckedChanged(object sender, EventArgs e)
        {
            IngredientsSettings();
            Calculator();
        }

        private void Radioduplakave_CheckedChanged(object sender, EventArgs e)
        {
            IngredientsSettings();
            Calculator();
        }

        private void Radiohosszukave_CheckedChanged(object sender, EventArgs e)
        {
            IngredientsSettings();
            Calculator();
        }
        private void IngredientsSettings()
        {
            Citrom.Enabled = false;
            Citrom.Checked = false;
            kavekrem.Enabled = true;
            kavekrem.Checked = false;
            Tejszin.Enabled = true;
            Tejszin.Checked = false;
            Tejpor.Enabled = true;
            Tejpor.Checked = false;
            Calculator();
        }

        private void forroitalok_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Calculator()
        {
            int italAr=0, hozzavaloAr=0, cukorAr=0, vegosszeg=0;
            if (Radioespresso.Checked) italAr += 140;
            if (Radioduplakave.Checked) italAr += 200;
            if (Radiohosszukave.Checked) italAr += 170;
            if (Radiotea.Checked) italAr += 120;
            Ital_ar.Text = italAr.ToString() + " Ft";
            if(Citrom.Checked) hozzavaloAr += 20;
            if (kavekrem.Checked) hozzavaloAr += 30;
            if (Tejszin.Checked) hozzavaloAr += 25;
            if (Tejpor.Checked) hozzavaloAr += 15;
            Hozzávalo_ar.Text = hozzavaloAr.ToString() + " Ft";
            if (RadioSokCukor.Checked) cukorAr += 10;
            if (RadioKevesCukor.Checked) cukorAr += 60;
            Cukor_ar.Text = cukorAr.ToString() + " Ft";
            vegosszeg = italAr + hozzavaloAr + cukorAr;
            Osszesen_ar.Text = vegosszeg.ToString() + " Ft";
            osszeg = vegosszeg;
        }

        private void RadioSokCukor_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void kavekrem_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void Tejszin_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void Tejpor_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void Citrom_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void penz_fizetes_Click(object sender, EventArgs e)
        {
            Keszpenz_fizetes.Visible = true;
        }

        private void kartya_fizetes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A kártyaolvasó nem müködik, szopd ki, legyen kp-d","kurva vagy ha nem fizetsz", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonPenzBedobas_Click(object sender, EventArgs e)
        {
            int keszpenz = int.Parse(kp_mennyiseg.Text);
            if (keszpenz == osszeg)
            {
                labelEredmeny.Text = "Pont annyi.";
            }
            else if(keszpenz > osszeg)
            {
                labelEredmeny.Text = $"A visszajáró: {keszpenz-osszeg}Ft";
            }
            else
            {
                labelEredmeny.Text = $"Ez kevés lesz....";
            }
        }
    }
}
