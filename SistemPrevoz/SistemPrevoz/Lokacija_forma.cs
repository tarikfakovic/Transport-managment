using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemPrevoz
{
    public partial class Lokacija_forma : Form
    {
        public Lokacija_forma()
        {
            InitializeComponent();
        }

        private void lokacijaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lokacijaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transport_menadzmentDataSet);

        }

        private void Lokacija_forma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_menadzmentDataSet.lokacija' table. You can move, or remove it, as needed.
            this.lokacijaTableAdapter.Fill(this.transport_menadzmentDataSet.lokacija);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.lokacijaBindingSource.AddNew();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            this.lokacijaBindingSource.RemoveCurrent();
        }

        private void btnNapred_Click(object sender, EventArgs e)
        {
            this.lokacijaBindingSource.MoveNext();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.lokacijaBindingSource.MovePrevious();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            DialogResult iCuvaj;

            iCuvaj = MessageBox.Show("Potvrdite cuvanje", "Transport menadzment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iCuvaj == DialogResult.Yes)
            {
                this.Validate();
                this.lokacijaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.transport_menadzmentDataSet);
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
