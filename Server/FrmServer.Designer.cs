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
            this.txtDanOd = new System.Windows.Forms.TextBox();
            this.txtDanDo = new System.Windows.Forms.TextBox();
            this.cmbLaboratorija = new System.Windows.Forms.ComboBox();
            this.dgvTestovi = new System.Windows.Forms.DataGridView();
            this.cbDanOd = new System.Windows.Forms.CheckBox();
            this.cbDanDo = new System.Windows.Forms.CheckBox();
            this.cbLaboratorija = new System.Windows.Forms.CheckBox();
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
            // txtDanOd
            // 
            this.txtDanOd.Location = new System.Drawing.Point(214, 132);
            this.txtDanOd.Name = "txtDanOd";
            this.txtDanOd.Size = new System.Drawing.Size(309, 22);
            this.txtDanOd.TabIndex = 9;
            // 
            // txtDanDo
            // 
            this.txtDanDo.Location = new System.Drawing.Point(214, 177);
            this.txtDanDo.Name = "txtDanDo";
            this.txtDanDo.Size = new System.Drawing.Size(309, 22);
            this.txtDanDo.TabIndex = 10;
            // 
            // cmbLaboratorija
            // 
            this.cmbLaboratorija.FormattingEnabled = true;
            this.cmbLaboratorija.Location = new System.Drawing.Point(214, 218);
            this.cmbLaboratorija.Name = "cmbLaboratorija";
            this.cmbLaboratorija.Size = new System.Drawing.Size(309, 24);
            this.cmbLaboratorija.TabIndex = 11;
            // 
            // dgvTestovi
            // 
            this.dgvTestovi.AllowUserToAddRows = false;
            this.dgvTestovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestovi.Location = new System.Drawing.Point(12, 257);
            this.dgvTestovi.Name = "dgvTestovi";
            this.dgvTestovi.ReadOnly = true;
            this.dgvTestovi.RowHeadersVisible = false;
            this.dgvTestovi.RowHeadersWidth = 51;
            this.dgvTestovi.RowTemplate.Height = 24;
            this.dgvTestovi.Size = new System.Drawing.Size(511, 158);
            this.dgvTestovi.TabIndex = 12;
            // 
            // cbDanOd
            // 
            this.cbDanOd.AutoSize = true;
            this.cbDanOd.Location = new System.Drawing.Point(12, 132);
            this.cbDanOd.Name = "cbDanOd";
            this.cbDanOd.Size = new System.Drawing.Size(172, 21);
            this.cbDanOd.TabIndex = 13;
            this.cbDanOd.Text = "Dan od (dd.MM.yyyy.):";
            this.cbDanOd.UseVisualStyleBackColor = true;
            // 
            // cbDanDo
            // 
            this.cbDanDo.AutoSize = true;
            this.cbDanDo.Location = new System.Drawing.Point(12, 177);
            this.cbDanDo.Name = "cbDanDo";
            this.cbDanDo.Size = new System.Drawing.Size(172, 21);
            this.cbDanDo.TabIndex = 14;
            this.cbDanDo.Text = "Dan do (dd.MM.yyyy.):";
            this.cbDanDo.UseVisualStyleBackColor = true;
            // 
            // cbLaboratorija
            // 
            this.cbLaboratorija.AutoSize = true;
            this.cbLaboratorija.Location = new System.Drawing.Point(12, 220);
            this.cbLaboratorija.Name = "cbLaboratorija";
            this.cbLaboratorija.Size = new System.Drawing.Size(110, 21);
            this.cbLaboratorija.TabIndex = 15;
            this.cbLaboratorija.Text = "Laboratorija:";
            this.cbLaboratorija.UseVisualStyleBackColor = true;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 429);
            this.Controls.Add(this.cbLaboratorija);
            this.Controls.Add(this.cbDanDo);
            this.Controls.Add(this.cbDanOd);
            this.Controls.Add(this.dgvTestovi);
            this.Controls.Add(this.cmbLaboratorija);
            this.Controls.Add(this.txtDanDo);
            this.Controls.Add(this.txtDanOd);
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
        private System.Windows.Forms.TextBox txtDanOd;
        private System.Windows.Forms.TextBox txtDanDo;
        private System.Windows.Forms.ComboBox cmbLaboratorija;
        private System.Windows.Forms.DataGridView dgvTestovi;
        private System.Windows.Forms.CheckBox cbDanOd;
        private System.Windows.Forms.CheckBox cbDanDo;
        private System.Windows.Forms.CheckBox cbLaboratorija;
    }
}

