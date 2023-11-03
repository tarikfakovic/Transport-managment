using SistemPrevoz.transport_menadzmentDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace SistemPrevoz
{
    public partial class Admin_forma : Form
    {
        public Admin_forma()
        {
            InitializeComponent();
        }


        private void btnTura_Click(object sender, EventArgs e)
        {
            Tura_forma tura = new Tura_forma();
            tura.ShowDialog();
        }

        private void btnVozac_Click(object sender, EventArgs e)
        {
            Vozac_forma vozac = new Vozac_forma();
            vozac.ShowDialog();
        }

        private void btnVozilo_Click(object sender, EventArgs e)
        {
            Vozilo_forma vozilo = new Vozilo_forma();
            vozilo.ShowDialog();
        }

        private void btnLokacija_Click(object sender, EventArgs e)
        {
            Lokacija_forma lokacija = new Lokacija_forma();   
            lokacija.ShowDialog();
        }

        private void btnPutnik_Click(object sender, EventArgs e)
        {
            Putnik_forma putnici = new Putnik_forma();   
            putnici.ShowDialog();
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

        private void btnPolasci_Click(object sender, EventArgs e)
        {
            Polasci_forma polasci = new Polasci_forma();
            polasci.ShowDialog();
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

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            Korisnici_forma korisnici = new Korisnici_forma();
            korisnici.ShowDialog();
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
    }
}
