namespace Server
{
    partial class FrmServer
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbDanOd = new System.Windows.Forms.RadioButton();
            this.rbDanDo = new System.Windows.Forms.RadioButton();
            this.rbLaboratorija = new System.Windows.Forms.RadioButton();
            this.txtDanOd = new System.Windows.Forms.TextBox();
            this.txtDanDo = new System.Windows.Forms.TextBox();
            this.cmbLaboratorija = new System.Windows.Forms.ComboBox();
            this.dgvTestovi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestovi)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dr Subotica 5, 11000 Beograd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Institut za javno zdravlje \"Dr Milan Jovanovic batut\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Republika Srbija";
            // 
            // rbDanOd
            // 
            this.rbDanOd.AutoSize = true;
            this.rbDanOd.Location = new System.Drawing.Point(12, 132);
            this.rbDanOd.Name = "rbDanOd";
            this.rbDanOd.Size = new System.Drawing.Size(169, 21);
            this.rbDanOd.TabIndex = 6;
            this.rbDanOd.TabStop = true;
            this.rbDanOd.Text = "Dan od (dd-MM-yyyy):";
            this.rbDanOd.UseVisualStyleBackColor = true;
            // 
            // rbDanDo
            // 
            this.rbDanDo.AutoSize = true;
            this.rbDanDo.Location = new System.Drawing.Point(12, 177);
            this.rbDanDo.Name = "rbDanDo";
            this.rbDanDo.Size = new System.Drawing.Size(169, 21);
            this.rbDanDo.TabIndex = 7;
            this.rbDanDo.TabStop = true;
            this.rbDanDo.Text = "Dan do (dd-MM-yyyy):";
            this.rbDanDo.UseVisualStyleBackColor = true;
            // 
            // rbLaboratorija
            // 
            this.rbLaboratorija.AutoSize = true;
            this.rbLaboratorija.Location = new System.Drawing.Point(12, 220);
            this.rbLaboratorija.Name = "rbLaboratorija";
            this.rbLaboratorija.Size = new System.Drawing.Size(105, 21);
            this.rbLaboratorija.TabIndex = 8;
            this.rbLaboratorija.TabStop = true;
            this.rbLaboratorija.Text = "Laboratorija";
            this.rbLaboratorija.UseVisualStyleBackColor = true;
            // 
            // txtDanOd
            // 
            this.txtDanOd.Location = new System.Drawing.Point(187, 131);
            this.txtDanOd.Name = "txtDanOd";
            this.txtDanOd.Size = new System.Drawing.Size(309, 22);
            this.txtDanOd.TabIndex = 9;
            // 
            // txtDanDo
            // 
            this.txtDanDo.Location = new System.Drawing.Point(187, 176);
            this.txtDanDo.Name = "txtDanDo";
            this.txtDanDo.Size = new System.Drawing.Size(309, 22);
            this.txtDanDo.TabIndex = 10;
            // 
            // cmbLaboratorija
            // 
            this.cmbLaboratorija.FormattingEnabled = true;
            this.cmbLaboratorija.Location = new System.Drawing.Point(187, 217);
            this.cmbLaboratorija.Name = "cmbLaboratorija";
            this.cmbLaboratorija.Size = new System.Drawing.Size(309, 24);
            this.cmbLaboratorija.TabIndex = 11;
            // 
            // dgvTestovi
            // 
            this.dgvTestovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestovi.Location = new System.Drawing.Point(12, 257);
            this.dgvTestovi.Name = "dgvTestovi";
            this.dgvTestovi.RowHeadersWidth = 51;
            this.dgvTestovi.RowTemplate.Height = 24;
            this.dgvTestovi.Size = new System.Drawing.Size(484, 123);
            this.dgvTestovi.TabIndex = 12;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 392);
            this.Controls.Add(this.dgvTestovi);
            this.Controls.Add(this.cmbLaboratorija);
            this.Controls.Add(this.txtDanDo);
            this.Controls.Add(this.txtDanOd);
            this.Controls.Add(this.rbLaboratorija);
            this.Controls.Add(this.rbDanDo);
            this.Controls.Add(this.rbDanOd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmServer";
            this.Text = "[FON] COVID19 - serverski program";
            this.Load += new System.EventHandler(this.FrmServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbDanOd;
        private System.Windows.Forms.RadioButton rbDanDo;
        private System.Windows.Forms.RadioButton rbLaboratorija;
        private System.Windows.Forms.TextBox txtDanOd;
        private System.Windows.Forms.TextBox txtDanDo;
        private System.Windows.Forms.ComboBox cmbLaboratorija;
        private System.Windows.Forms.DataGridView dgvTestovi;
    }
}

