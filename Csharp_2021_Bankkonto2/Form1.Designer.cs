
namespace Csharp_2021_Bankkonto2
{
	partial class frmKonto
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblKontostand = new System.Windows.Forms.Label();
			this.lblKontoauszug = new System.Windows.Forms.Label();
			this.btnKontoauszug = new System.Windows.Forms.Button();
			this.btnKontostand = new System.Windows.Forms.Button();
			this.btnAuszahlen = new System.Windows.Forms.Button();
			this.btnEinzahlen = new System.Windows.Forms.Button();
			this.txtBetrag = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblKontostand
			// 
			this.lblKontostand.AutoSize = true;
			this.lblKontostand.Location = new System.Drawing.Point(63, 96);
			this.lblKontostand.Name = "lblKontostand";
			this.lblKontostand.Size = new System.Drawing.Size(35, 13);
			this.lblKontostand.TabIndex = 15;
			this.lblKontostand.Text = "label2";
			// 
			// lblKontoauszug
			// 
			this.lblKontoauszug.AutoSize = true;
			this.lblKontoauszug.Location = new System.Drawing.Point(35, 210);
			this.lblKontoauszug.Name = "lblKontoauszug";
			this.lblKontoauszug.Size = new System.Drawing.Size(35, 13);
			this.lblKontoauszug.TabIndex = 14;
			this.lblKontoauszug.Text = "label2";
			// 
			// btnKontoauszug
			// 
			this.btnKontoauszug.Location = new System.Drawing.Point(55, 153);
			this.btnKontoauszug.Name = "btnKontoauszug";
			this.btnKontoauszug.Size = new System.Drawing.Size(90, 40);
			this.btnKontoauszug.TabIndex = 13;
			this.btnKontoauszug.Text = "Kontoauszug drucken";
			this.btnKontoauszug.UseVisualStyleBackColor = true;
			this.btnKontoauszug.Click += new System.EventHandler(this.btnKontoauszug_Click);
			// 
			// btnKontostand
			// 
			this.btnKontostand.Location = new System.Drawing.Point(63, 115);
			this.btnKontostand.Name = "btnKontostand";
			this.btnKontostand.Size = new System.Drawing.Size(75, 23);
			this.btnKontostand.TabIndex = 12;
			this.btnKontostand.Text = "Kontostand";
			this.btnKontostand.UseVisualStyleBackColor = true;
			this.btnKontostand.Click += new System.EventHandler(this.btnKontostand_Click);
			// 
			// btnAuszahlen
			// 
			this.btnAuszahlen.Location = new System.Drawing.Point(104, 61);
			this.btnAuszahlen.Name = "btnAuszahlen";
			this.btnAuszahlen.Size = new System.Drawing.Size(75, 23);
			this.btnAuszahlen.TabIndex = 11;
			this.btnAuszahlen.Text = "Auszahlen";
			this.btnAuszahlen.UseVisualStyleBackColor = true;
			this.btnAuszahlen.Click += new System.EventHandler(this.btnAuszahlen_Click);
			// 
			// btnEinzahlen
			// 
			this.btnEinzahlen.Location = new System.Drawing.Point(19, 62);
			this.btnEinzahlen.Name = "btnEinzahlen";
			this.btnEinzahlen.Size = new System.Drawing.Size(75, 23);
			this.btnEinzahlen.TabIndex = 10;
			this.btnEinzahlen.Text = "Einzahlen";
			this.btnEinzahlen.UseVisualStyleBackColor = true;
			this.btnEinzahlen.Click += new System.EventHandler(this.btnEinzahlen_Click);
			// 
			// txtBetrag
			// 
			this.txtBetrag.Location = new System.Drawing.Point(80, 15);
			this.txtBetrag.Name = "txtBetrag";
			this.txtBetrag.Size = new System.Drawing.Size(100, 20);
			this.txtBetrag.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Betrag:";
			// 
			// frmKonto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(218, 319);
			this.Controls.Add(this.lblKontostand);
			this.Controls.Add(this.lblKontoauszug);
			this.Controls.Add(this.btnKontoauszug);
			this.Controls.Add(this.btnKontostand);
			this.Controls.Add(this.btnAuszahlen);
			this.Controls.Add(this.btnEinzahlen);
			this.Controls.Add(this.txtBetrag);
			this.Controls.Add(this.label1);
			this.Name = "frmKonto";
			this.Text = "Bankkonto";
			this.Load += new System.EventHandler(this.frmKonto_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblKontostand;
		private System.Windows.Forms.Label lblKontoauszug;
		private System.Windows.Forms.Button btnKontoauszug;
		private System.Windows.Forms.Button btnKontostand;
		private System.Windows.Forms.Button btnAuszahlen;
		private System.Windows.Forms.Button btnEinzahlen;
		private System.Windows.Forms.TextBox txtBetrag;
		private System.Windows.Forms.Label label1;
	}
}

