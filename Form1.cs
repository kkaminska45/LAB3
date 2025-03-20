using System.Windows.Forms;

namespace LAB3
{
    public partial class Pracownicy : Form

    {
        private int numerPracownika;
        public Pracownicy()
        {
            InitializeComponent();
        }

        private void Pracownicy_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Pracownik pracownik = new Pracownik(this);
            pracownik.Show();
        }


        public void dodajPracownika(string imie, string nazwisko, string wiek, string stanowisko)
        {
            dataGridView.Rows.Add(imie, nazwisko, wiek, stanowisko);
            numerPracownika++;
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0) 
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    dataGridView.Rows.Remove(row); 
                }
            }
        }
    }
}
