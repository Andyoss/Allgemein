using System.Windows.Forms;

namespace EinstiegspreisRechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string safePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "gridDaten.csv");

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewPosition.AllowUserToAddRows = false;
            dataGridViewPosition.AllowUserToDeleteRows = false;
            dataGridViewPosition.ReadOnly = false;
            dataGridViewPosition.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPosition.MultiSelect = false;
            dataGridViewPosition.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPosition.RowHeadersVisible = false;
            dataGridViewPosition.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewPosition.ColumnHeadersVisible = true;
            dataGridViewPosition.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewPosition.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewPosition.Font = new Font("Arial", 10, FontStyle.Regular);

            LoadDataFromFile(safePath);

            //Führt den Btn wie eine Metohde aus is ganz nice
            BtnBerechnen_Click(null, EventArgs.Empty);

        }

        private void AddHardcodedEntries()
        {
            // Spalten hinzufügen, falls sie noch nicht existieren
            if (dataGridViewPosition.Columns.Count == 0)
            {
                dataGridViewPosition.Columns.Add("PreisProCcoin", "Preis pro Coin");
                dataGridViewPosition.Columns.Add("Positionsgroesse", "Positionsgröße");
            }

            // Hardcodierte Einträge hinzufügen
            dataGridViewPosition.Rows.Add("100", "100");  // 1. Eintrag: Preis 50.000, Positionsgröße 2
            dataGridViewPosition.Rows.Add("100", "50"); // 2. Eintrag: Preis 45.000, Positionsgröße 1.5
        }



        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPosition.SelectedRows.Count > 0)
            {
                dataGridViewPosition.Rows.RemoveAt(dataGridViewPosition.SelectedRows[0].Index);
            }
        }

        private void BtnNeu_Click(object sender, EventArgs e)
        {
            dataGridViewPosition.Rows.Add("", "");
        }

        private void dataGridViewPosition_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridViewPosition.Columns[e.ColumnIndex].Name == "Einstiegspreis" || dataGridViewPosition.Columns[e.ColumnIndex].Name == "PreisProCoin")
            {
                if (!decimal.TryParse(e.FormattedValue.ToString(), out _))
                {
                    MessageBox.Show("Bitte eine gültige Zahl eingeben!");
                    e.Cancel = true;
                }
            }
        }

        private void BtnBerechnen_Click(object sender, EventArgs e)
        {
            lblEinsteigspreis.Text = Rechner.BerechneEinstiegspreis(dataGridViewPosition).ToString();



            PositinGesamt.Text = Rechner.Gesamtkosten(dataGridViewPosition).ToString("N3");

            AnteileGesamt.Text = Rechner.GesamtanzahlCoins(dataGridViewPosition).ToString("N3");

        }



        private void SaveDataToCSV(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Schreibe die Spaltennamen als erste Zeile
                for (int i = 0; i < dataGridViewPosition.Columns.Count; i++)
                {
                    writer.Write(dataGridViewPosition.Columns[i].HeaderText);
                    if (i < dataGridViewPosition.Columns.Count - 1)
                        writer.Write(",");
                }
                writer.WriteLine();

                // Schreibe alle Zeilenwerte
                foreach (DataGridViewRow row in dataGridViewPosition.Rows)
                {
                    for (int i = 0; i < dataGridViewPosition.Columns.Count; i++)
                    {
                        writer.Write(row.Cells[i].Value?.ToString() ?? ""); // Null-Check, um Fehler zu vermeiden
                        if (i < dataGridViewPosition.Columns.Count - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();
                }
            }
        }



        private void LoadDataFromFile(string filePath)
        {
            try
            {
                // Prüfen, ob die Datei existiert
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Die Datei existiert nicht!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Spalten hinzufügen, falls sie noch nicht existieren
                if (dataGridViewPosition.Columns.Count == 0)
                {
                    dataGridViewPosition.Columns.Add("Positionsgröße", "Positionsgröße");
                    dataGridViewPosition.Columns.Add("Preis/pro coin", "Preis/pro coin");
                }

                // Vorhandene Zeilen löschen, um doppelte Einträge zu vermeiden
                dataGridViewPosition.Rows.Clear();

                // Datei lesen und Daten einfügen
                string[] lines = File.ReadAllLines(filePath);

                bool firstLine = true; // Erste Zeile überspringen (Header)
                foreach (string line in lines)
                {
                    if (firstLine)
                    {
                        firstLine = false;
                        continue;
                    }

                    string[] values = line.Split(',');

                    if (values.Length == 2) // Sicherstellen, dass genau 2 Werte vorhanden sind
                    {
                        dataGridViewPosition.Rows.Add(values[0], values[1]);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden der Daten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveDataToCSV(safePath);
        }
    }
}

