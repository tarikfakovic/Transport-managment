using Devart.Data.MySql;
using System;
using System.Windows.Forms;

namespace SistemPrevoz
{
    public partial class Glavna_forma : Form
    {

        MySqlConnection conn = new MySqlConnection("User Id = root; Host = localhost; Database = transport_menadzment");

        public Glavna_forma()
        {
            InitializeComponent();
        }


        private void btnPrijava_Click(object sender, EventArgs e)
        {

            

            if (txtKorisnik.Text == "" && txtLozinka.Text == "") //Error when all text box are not fill
            {
                MessageBox.Show("Niste uneli ni jedan podatak!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtKorisnik.Text == "") //Error when all text box are not fill
            {
                MessageBox.Show("Niste uneli Korisnicko ime!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLozinka.Text == "") //Error when all text box are not fill
            {
                MessageBox.Show("Niste uneli lozinku!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                try
                {

                    MySqlCommand SelectCommand = new MySqlCommand("select * from transport_menadzment.korisnici where korisnik='" + this.txtKorisnik.Text + "' and lozinka='" + this.txtLozinka.Text + "' ;", conn);

                    MySqlDataReader myReader;

                    conn.Open();
                    myReader = SelectCommand.ExecuteReader();
                    int count = 0;
                    string nivo = string.Empty;
                    while (myReader.Read())
                    {
                        count = count + 1;
                        nivo = myReader["nivo"].ToString();
                    }
                    if (count == 1)
                    {

                        if (nivo == "Admin" && nivo == boxNivo.SelectedItem.ToString())
                        {
                            this.Hide();
                            Admin_forma admin_Forma = new Admin_forma();
                            admin_Forma.Show();
                            MessageBox.Show("Uspesno ste ulogovani.", "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        }

                        else if (nivo == "Korisnik" && nivo == boxNivo.SelectedItem.ToString())
                        {
                            this.Hide();
                            Korisnik_forma korisnik_Forma = new Korisnik_forma();
                            korisnik_Forma.Show();
                            MessageBox.Show("Uspesno ste ulogovani.", "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        }
                        else
                        {
                            MessageBox.Show("Profil nije na tom nivou.", "Greska!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Kredencijali su netacni!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                    }
                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    
        private void Glavna_forma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnPrijava.PerformClick();
            }
        }

        private void Glavna_forma_Load(object sender, EventArgs e)
        {
            boxNivo.SelectedIndex = 0;
        }

    }

}

