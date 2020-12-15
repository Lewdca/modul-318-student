namespace MeinFahrplan
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvVerbindungen = new System.Windows.Forms.DataGridView();
            this.dgvVerkehrsmittel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDatumZeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReisezeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDatumZeit = new System.Windows.Forms.GroupBox();
            this.dtpZeit = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.gbOrt = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEndStation = new System.Windows.Forms.ComboBox();
            this.cbStartStatoin = new System.Windows.Forms.ComboBox();
            this.btnVerbindung = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIconEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbindungen)).BeginInit();
            this.gbDatumZeit.SuspendLayout();
            this.gbOrt.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVerbindungen
            // 
            this.dgvVerbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerbindungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvVerkehrsmittel,
            this.dgvDatumZeit,
            this.dgvGleis,
            this.dgvStart,
            this.dgvEnd,
            this.dgvReisezeit,
            this.dgvPreis});
            this.dgvVerbindungen.Location = new System.Drawing.Point(69, 328);
            this.dgvVerbindungen.Name = "dgvVerbindungen";
            this.dgvVerbindungen.Size = new System.Drawing.Size(744, 209);
            this.dgvVerbindungen.TabIndex = 0;
            // 
            // dgvVerkehrsmittel
            // 
            this.dgvVerkehrsmittel.HeaderText = "Verkehrsmittel";
            this.dgvVerkehrsmittel.Name = "dgvVerkehrsmittel";
            // 
            // dgvDatumZeit
            // 
            this.dgvDatumZeit.HeaderText = "Datum/Zeit";
            this.dgvDatumZeit.Name = "dgvDatumZeit";
            // 
            // dgvGleis
            // 
            this.dgvGleis.HeaderText = "Gleis";
            this.dgvGleis.Name = "dgvGleis";
            // 
            // dgvStart
            // 
            this.dgvStart.HeaderText = "Start-Station";
            this.dgvStart.Name = "dgvStart";
            // 
            // dgvEnd
            // 
            this.dgvEnd.HeaderText = "End-Station";
            this.dgvEnd.Name = "dgvEnd";
            // 
            // dgvReisezeit
            // 
            this.dgvReisezeit.HeaderText = "Reisezeit";
            this.dgvReisezeit.Name = "dgvReisezeit";
            // 
            // dgvPreis
            // 
            this.dgvPreis.HeaderText = "Preis";
            this.dgvPreis.Name = "dgvPreis";
            // 
            // gbDatumZeit
            // 
            this.gbDatumZeit.Controls.Add(this.label4);
            this.gbDatumZeit.Controls.Add(this.label3);
            this.gbDatumZeit.Controls.Add(this.dtpZeit);
            this.gbDatumZeit.Controls.Add(this.dtpDate);
            this.gbDatumZeit.Location = new System.Drawing.Point(69, 68);
            this.gbDatumZeit.Name = "gbDatumZeit";
            this.gbDatumZeit.Size = new System.Drawing.Size(303, 143);
            this.gbDatumZeit.TabIndex = 1;
            this.gbDatumZeit.TabStop = false;
            this.gbDatumZeit.Text = "Datum/Zeit";
            this.gbDatumZeit.Enter += new System.EventHandler(this.GbDatumZeit_Enter);
            // 
            // dtpZeit
            // 
            this.dtpZeit.Checked = false;
            this.dtpZeit.CustomFormat = "HH:mm";
            this.dtpZeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpZeit.Location = new System.Drawing.Point(54, 93);
            this.dtpZeit.Name = "dtpZeit";
            this.dtpZeit.ShowUpDown = true;
            this.dtpZeit.Size = new System.Drawing.Size(95, 20);
            this.dtpZeit.TabIndex = 2;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(54, 48);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(95, 20);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.Value = new System.DateTime(2020, 12, 15, 11, 9, 51, 0);
            // 
            // gbOrt
            // 
            this.gbOrt.Controls.Add(this.btnIconEnd);
            this.gbOrt.Controls.Add(this.button1);
            this.gbOrt.Controls.Add(this.label2);
            this.gbOrt.Controls.Add(this.label1);
            this.gbOrt.Controls.Add(this.cbEndStation);
            this.gbOrt.Controls.Add(this.cbStartStatoin);
            this.gbOrt.Location = new System.Drawing.Point(409, 68);
            this.gbOrt.Name = "gbOrt";
            this.gbOrt.Size = new System.Drawing.Size(296, 143);
            this.gbOrt.TabIndex = 2;
            this.gbOrt.TabStop = false;
            this.gbOrt.Text = "Ort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End-Station:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start-Station:";
            // 
            // cbEndStation
            // 
            this.cbEndStation.FormattingEnabled = true;
            this.cbEndStation.Location = new System.Drawing.Point(78, 84);
            this.cbEndStation.Name = "cbEndStation";
            this.cbEndStation.Size = new System.Drawing.Size(121, 21);
            this.cbEndStation.TabIndex = 1;
            // 
            // cbStartStatoin
            // 
            this.cbStartStatoin.FormattingEnabled = true;
            this.cbStartStatoin.Location = new System.Drawing.Point(78, 42);
            this.cbStartStatoin.Name = "cbStartStatoin";
            this.cbStartStatoin.Size = new System.Drawing.Size(121, 21);
            this.cbStartStatoin.TabIndex = 0;
            // 
            // btnVerbindung
            // 
            this.btnVerbindung.Location = new System.Drawing.Point(711, 268);
            this.btnVerbindung.Name = "btnVerbindung";
            this.btnVerbindung.Size = new System.Drawing.Size(136, 23);
            this.btnVerbindung.TabIndex = 4;
            this.btnVerbindung.Text = "Verbindungen suchen";
            this.btnVerbindung.UseVisualStyleBackColor = true;
            this.btnVerbindung.Click += new System.EventHandler(this.BtnVerbindung_Click);
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(712, 231);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(135, 23);
            this.btnAbfahrtstafel.TabIndex = 5;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zeit:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnIconEnd
            // 
            this.btnIconEnd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIconEnd.BackgroundImage")));
            this.btnIconEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIconEnd.Location = new System.Drawing.Point(217, 79);
            this.btnIconEnd.Name = "btnIconEnd";
            this.btnIconEnd.Size = new System.Drawing.Size(37, 35);
            this.btnIconEnd.TabIndex = 5;
            this.btnIconEnd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 563);
            this.Controls.Add(this.btnAbfahrtstafel);
            this.Controls.Add(this.btnVerbindung);
            this.Controls.Add(this.gbOrt);
            this.Controls.Add(this.gbDatumZeit);
            this.Controls.Add(this.dgvVerbindungen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbindungen)).EndInit();
            this.gbDatumZeit.ResumeLayout(false);
            this.gbDatumZeit.PerformLayout();
            this.gbOrt.ResumeLayout(false);
            this.gbOrt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerbindungen;
        private System.Windows.Forms.GroupBox gbDatumZeit;
        private System.Windows.Forms.GroupBox gbOrt;
        private System.Windows.Forms.Button btnVerbindung;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEndStation;
        private System.Windows.Forms.ComboBox cbStartStatoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVerkehrsmittel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDatumZeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGleis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReisezeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPreis;
        private System.Windows.Forms.DateTimePicker dtpZeit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIconEnd;
        private System.Windows.Forms.Button button1;
    }
}

