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
    public partial class Korisnik_forma : Form
    {
        public Korisnik_forma()
        {
            InitializeComponent();
        }

        private void btnPolasci_Click(object sender, EventArgs e)
        {
            Polasci_forma polasci = new Polasci_forma();
            polasci.ShowDialog();
        }

        private void btnPutnik_Click(object sender, EventArgs e)
        {
            Putnik_forma putnici = new Putnik_forma();
            putnici.ShowDialog();
        }

        private void btnRezervacija_po_turi_Click(object sender, EventArgs e)
        {
            Rezervacija_po_turi_forma rezervacije = new Rezervacija_po_turi_forma();
            rezervacije.ShowDialog();
        }

        private void btnRezervacija_Click(object sender, EventArgs e)
        {
            Rezervacija_forma rezervacija = new Rezervacija_forma();
            rezervacija.ShowDialog();
        }

        private void btnVozac_po_turi_Click(object sender, EventArgs e)
        {
            Vozac_po_turi_forma tura_Vozac = new Vozac_po_turi_forma();
            tura_Vozac.ShowDialog();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            DialogResult iIzlaz;

            iIzlaz = MessageBox.Show("Potvrdite izlaz", "Transport menadzment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iIzlaz == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnIzloguj_Click(object sender, EventArgs e)
        {
            DialogResult iIzloguj;

            iIzloguj = MessageBox.Show("Potvrdite", "Transport menadzment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iIzloguj == DialogResult.Yes)
            {
                Glavna_forma glavna_Forma = new Glavna_forma();
                glavna_Forma.Show();
                this.Hide();
            }
        }
    }
}
