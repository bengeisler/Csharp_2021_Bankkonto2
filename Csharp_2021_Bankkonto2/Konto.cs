using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2021_Bankkonto2
{
	class Konto
	{
		// Eigenschaft:
		// - private,
		// - public
		// - oder Eigenschaft + Eigenschaftsmethode?

		// private: nur innerhalb der Klasse sichtbar
		private double kontostand;

		// Weitere Eigenschaft: Kontohistorie
		private string historie;

		// Kein Konstruktor => Standardkonstruktor existiert automatisch,
		// solange kein anderer Konstruktor definiert wurde

		// Methoden

		// Einzahlen
		public void Einzahlen(double wert)
		{
			if (wert < 0) throw new ArgumentException("Betrag muss > 0€ sein");

			kontostand += wert;

			historie += "+" + wert + "\n";
		}

		// Auszahlen
		public void Auszahlen(double wert)
		{
			// Ungültige Eingaben lösen eine Ausnahme aus
			if ((kontostand - wert) < 0) 
				throw new ArgumentException("Kontostand nicht gedeckt.");
			if (wert < 0) throw new ArgumentException("Betrag muss > 0€ sein");

			kontostand -= wert;

			historie += "-" + wert + "\n";
		}

		// Kontostand Anzeigen
		public string KontostandAnzeigen()
		{
			return "Kontostand: " + kontostand + " €";
		}

		// Methode zur Anzeige des Kontoauszugs
		public string Kontoauszug()
		{
			return
				"Kontoauszug: \n" +
				historie + "\n" +
				"---------------\n" +
				kontostand;
		}
	}
}
