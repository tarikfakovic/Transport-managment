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
    public partial class Vozilo_forma : Form
    {
        public Vozilo_forma()
        {
            InitializeComponent();
        }

        private void Vozilo_forma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_menadzmentDataSet.vozilo' table. You can move, or remove it, as needed.
            this.voziloTableAdapter.Fill(this.transport_menadzmentDataSet.vozilo);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.voziloBindingSource.AddNew();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            this.voziloBindingSource.RemoveCurrent();
        }

        private void btnNapred_Click(object sender, EventArgs e)
        {
            this.voziloBindingSource.MoveNext();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.voziloBindingSource.MovePrevious();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            DialogResult iCuvaj;

            iCuvaj = MessageBox.Show("Potvrdite cuvanje", "Transport menadzment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iCuvaj == DialogResult.Yes)
            {
                this.Validate();
                this.voziloBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.transport_menadzmentDataSet);
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
