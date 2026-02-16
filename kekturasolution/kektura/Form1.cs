using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibraryKektura;

namespace kektura
{
    public partial class Kektura : Form
    {
        private List<ClassLibraryKektura.Kektura> lathatoLista = new List<ClassLibraryKektura.Kektura>();

        public Kektura()
        {
            InitializeComponent();
        }

        private void Kektura_Load(object sender, EventArgs e)
        {
            try
            {
                ClassLibraryKektura.Kektura.FileBeolvasas("kektura.csv");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            TeljesListaMasolat();
            ListaMegjelenitese();
        }

        private void TeljesListaMasolat()
        {
            lathatoLista.Clear();
            foreach (var obj in ClassLibraryKektura.Kektura.Kekturalista)
            {
                lathatoLista.Add(obj);
            }
        }

        private void ListaMegjelenitese()
        {
            listBoxUtvonalLista.Items.Clear();
            foreach (var obj in lathatoLista)
            {
                listBoxUtvonalLista.Items.Add(obj.KiinduloPont);
            }
        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {
            try
            {
                if(listBoxUtvonalLista.SelectedItem == null)
                {
                    MessageBox.Show("Válasszon ki egy elemet!", "elbasztad!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int index = listBoxUtvonalLista.SelectedIndex;

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}