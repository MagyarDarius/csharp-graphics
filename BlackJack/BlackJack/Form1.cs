using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class FormBJ : Form
    {
        public FormBJ()
        {
            InitializeComponent();
        }

        private void FormBJ_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonTetRakasa_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTet_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTetKezdes_Click(object sender, EventArgs e)
        {
            panelTet.Visible = true;
        }

        private void buttonAceInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Az ász alapértelmezésben 11-nek számít, ha így a kéz összértéke nem haladja meg a 21-et. Ha 11-ként számolva a kéz értéke 21 fölé menne (azaz „besokallnál”), akkor az ász automatikusan 1-re változik.",
                "Ász információ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
