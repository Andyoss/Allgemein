using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EinstiegspreisRechner
{
    internal class Rechner
    {
        //empfohlen, keine Sonderzeichen wie "ß" in Bezeichnern (Variablen- oder Spaltennamen) zu verwenden
        public static decimal Gesamtkosten(DataGridView dataGridView)
        {
            decimal gesamtkosten = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Positionsgroesse"].Value != null)
                {
                    if (decimal.TryParse(row.Cells["Positionsgroesse"].Value.ToString(), out decimal price))
                    {
                        gesamtkosten += price; 
                    }
                }
            }

            return gesamtkosten;
        }



        public static decimal GesamtanzahlCoins(DataGridView dataGridView)
        {
            decimal anzahlCoins = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["PreisProCcoin"].Value != null && row.Cells["Positionsgroesse"].Value != null)
                {
                    // Preis und Positionsgröße sicher parsen
                    if (decimal.TryParse(row.Cells["PreisProCcoin"].Value.ToString(), out decimal preisProCoin) &&
                        decimal.TryParse(row.Cells["Positionsgroesse"].Value.ToString(), out decimal positionsgroesse))
                    {
                        // Berechnung der Anzahl Coins: Positionsgröße / Preis pro Coin
                        anzahlCoins += positionsgroesse / preisProCoin;
                    }
                }
            }

            return anzahlCoins;
        }













        public static decimal BerechneEinstiegspreis(DataGridView dataGridView)
        {
            decimal totalSum = 0;
            decimal totalPosition = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Positionsgroesse"].Value != null && row.Cells["PreisProCcoin"].Value != null)
                {
                    if (decimal.TryParse(row.Cells["Positionsgroesse"].Value.ToString(), out decimal positionsgroesse) &&
                        decimal.TryParse(row.Cells["PreisProCcoin"].Value.ToString(), out decimal preisProCoin))
                    {
                        totalSum += positionsgroesse * preisProCoin;
                        totalPosition += positionsgroesse;
                    }
                }
            }

            if (totalPosition > 0)
            {
                decimal einstiegspreis = totalSum / totalPosition;
                return Math.Round(einstiegspreis, 5);  // Rundung auf 5 Nachkommastellen
            }

            return 0;
        }



        public static int BerechneNachkaufMenge(DataGridView dataGridView, decimal neuerKaufpreis, decimal gewuenschterEP)
        {
            if (dataGridView == null)
            {
                throw new ArgumentNullException(nameof(dataGridView), "Die DataGridView darf nicht null sein.");
            }

            if (dataGridView.Rows.Count == 0)
            {
                throw new ArgumentException("Die DataGridView enthält keine Daten.");
            }

            decimal totalSum = 0;
            decimal totalPosition = 0;


            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Positionsgroesse"].Value != null && row.Cells["PreisProCoin"].Value != null)
                {
                    if (decimal.TryParse(row.Cells["Positionsgroesse"].Value.ToString(), out decimal positionsgroesse) &&
                        decimal.TryParse(row.Cells["PreisProCoin"].Value.ToString(), out decimal preisProCoin))
                    {
                        totalSum += positionsgroesse * preisProCoin;
                        totalPosition += positionsgroesse;
                    }
                }
            }

            if (totalPosition == 0)
            {
                throw new InvalidOperationException("Es sind keine gültigen Positionen vorhanden.");
            }

            decimal aktuellerEP = totalSum / totalPosition;

            if (neuerKaufpreis >= gewuenschterEP)
            {
                throw new ArgumentException("Der neue Kaufpreis muss niedriger als der gewünschte Durchschnittspreis sein.");
            }

            decimal benoetigteMenge = (gewuenschterEP * totalPosition - aktuellerEP * totalPosition) / (neuerKaufpreis - gewuenschterEP);

            return (int)Math.Ceiling(benoetigteMenge);
        }



    }
}
