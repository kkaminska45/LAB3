using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LAB3
{
    public partial class Pracownik : Form

    {
        private Pracownicy glowneOkno;
        public Pracownik(Pracownicy glowneOkno)
        {
            InitializeComponent();
            this.glowneOkno = glowneOkno;
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZatwierdz_Click(object sender, EventArgs e)
        {
            string imie = textBoxImie.Text;
            string nazwisko = textBoxNazwisko.Text;
            string wiek = textBoxWiek.Text;
            string stanowisko = comboBoxStanowisko.SelectedItem.ToString();


            glowneOkno.dodajPracownika(imie, nazwisko, wiek, stanowisko);

            this.Close();

        }
    }
}
