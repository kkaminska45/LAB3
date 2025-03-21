using System.Data;
using System.Text;
using System.Windows.Forms;

namespace LAB3
{
    public partial class Pracownicy : Form

    {
        private int numerPracownika = 1;
        public Pracownicy()
        {
            InitializeComponent();
        }
        private void Pracownicy_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Add(1, "Grzegorz", "Kowalski", 31, "Kierownik");
            dataGridView.Rows.Add(2, "Krystyna", "Czubówna", 22, "Dyrektor");
            dataGridView.Rows.Add(3, "Piotr", "Mak³owicz", 46, "Sta¿ysta");
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Pracownik pracownik = new Pracownik(this);
            pracownik.Show();
        }
        public void dodajPracownika(string imie, string nazwisko, string wiek, string stanowisko)
        {
            dataGridView.Rows.Add(numerPracownika, imie, nazwisko, wiek, stanowisko);
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

        private void ZapiszCSV(DataGridView dataGridView)
        {

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Pliki CSV (*.csv)|*.csv";
                sfd.FileName = "pracownicy.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder csvContent = new StringBuilder();

                    string[] columnNames = dataGridView.Columns
                        .Cast<DataGridViewColumn>()
                        .Select(col => col.HeaderText)
                        .ToArray();
                    csvContent.AppendLine(string.Join(",", columnNames));

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string[] rowData = row.Cells
                                .Cast<DataGridViewCell>()
                                .Select(cell => cell.Value?.ToString() ?? "")
                                .ToArray();

                            csvContent.AppendLine(string.Join(",", rowData));
                        }
                    }

                    File.WriteAllText(sfd.FileName, csvContent.ToString(), Encoding.UTF8);
                    MessageBox.Show("Dane zosta³y zapisane!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnZapis_Click(object sender, EventArgs e)
        {
            ZapiszCSV(dataGridView);
        }

        private void OdczytCSV(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

                if (dataGridView.Columns.Count == 0)
                {
                    string[] headers = lines[0].Split(',');
                    foreach (string header in headers)
                    {
                        dataGridView.Columns.Add(header.Trim(), header.Trim());
                    }
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(',');
                    if (values.Length == dataGridView.Columns.Count)
                    {
                        dataGridView.Rows.Add(values);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("B³¹d podczas wczytywania pliku CSV: " + ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdczyt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
                openFileDialog.Title = "Wybierz plik CSV do wczytania";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    OdczytCSV(openFileDialog.FileName);
                }
            }
        }
    }
}
