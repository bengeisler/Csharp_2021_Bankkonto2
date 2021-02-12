using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_Bankkonto2
{
	public partial class frmKonto : Form
	{
		// Globale Variable für das Konto anlegen:
		// private
		// Datentyp: Konto
		private Konto MeinKonto;

		public frmKonto()
		{
			InitializeComponent();
		}

		private void frmKonto_Load(object sender, EventArgs e)
		{
			// Objekt erzeugen ("instanziieren")
			// => Aus dem Bauplan der Klasse wird ein konkretes Konto erstellt
			MeinKonto = new Konto();
		}

		private void btnEinzahlen_Click(object sender, EventArgs e)
		{
			try
			{
				// Eingegebenen Text in Double konvertieren und 
				// in der Variable "eingabe" speichern
				double eingabe = Convert.ToDouble(txtBetrag.Text);

				MeinKonto.Einzahlen(eingabe);
			}
			catch (Exception ex)
			{
				// Message-Box zur Ausgabe der Fehlermeldung
				// Codeausschnitt: mbox
				MessageBox.Show(ex.Message);
			}
		}

		private void btnKontostand_Click(object sender, EventArgs e)
		{
			lblKontostand.Text = MeinKonto.KontostandAnzeigen();
		}

		private void btnAuszahlen_Click(object sender, EventArgs e)
		{
			try
			{
				double eingabe = Convert.ToDouble(txtBetrag.Text);

				MeinKonto.Auszahlen(eingabe);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnKontoauszug_Click(object sender, EventArgs e)
		{
			lblKontoauszug.Text = MeinKonto.Kontoauszug();
		}
	}
}
