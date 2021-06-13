namespace Klijent
{
    partial class FrmKlijent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTestiranje = new System.Windows.Forms.DataGridView();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnSacuvajIzabraneZahteve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestiranje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Republika Srbija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Institut za javno zdravlje \"Dr Milan Jovanovic batut\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dr Subotica 5, 11000 Beograd";
            // 
            // dgvTestiranje
            // 
            this.dgvTestiranje.AllowUserToAddRows = false;
            this.dgvTestiranje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestiranje.Location = new System.Drawing.Point(12, 110);
            this.dgvTestiranje.Name = "dgvTestiranje";
            this.dgvTestiranje.ReadOnly = true;
            this.dgvTestiranje.RowHeadersVisible = false;
            this.dgvTestiranje.RowHeadersWidth = 51;
            this.dgvTestiranje.RowTemplate.Height = 24;
            this.dgvTestiranje.Size = new System.Drawing.Size(1293, 350);
            this.dgvTestiranje.TabIndex = 3;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(12, 484);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(181, 30);
            this.btnIzmeni.TabIndex = 4;
            this.btnIzmeni.Text = "Izmeni izabrani zahtev";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnSacuvajIzabraneZahteve
            // 
            this.btnSacuvajIzabraneZahteve.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajIzabraneZahteve.Location = new System.Drawing.Point(12, 520);
            this.btnSacuvajIzabraneZahteve.Name = "btnSacuvajIzabraneZahteve";
            this.btnSacuvajIzabraneZahteve.Size = new System.Drawing.Size(239, 29);
            this.btnSacuvajIzabraneZahteve.TabIndex = 5;
            this.btnSacuvajIzabraneZahteve.Text = "Sacuvaj obradjene zahteve";
            this.btnSacuvajIzabraneZahteve.UseVisualStyleBackColor = true;
            this.btnSacuvajIzabraneZahteve.Click += new System.EventHandler(this.btnSacuvajIzabraneZahteve_Click);
            // 
            // FrmKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 566);
            this.Controls.Add(this.btnSacuvajIzabraneZahteve);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.dgvTestiranje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmKlijent";
            this.Text = "[FON] COVID19 - klijentski program";
            this.Load += new System.EventHandler(this.FrmKlijent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestiranje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTestiranje;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnSacuvajIzabraneZahteve;
    }
}

