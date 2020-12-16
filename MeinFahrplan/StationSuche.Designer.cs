namespace MeinFahrplan
{
    partial class StationSuche
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
            this.btnStationSuchen = new System.Windows.Forms.Button();
            this.tbStationSuche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStationSuchen
            // 
            this.btnStationSuchen.Location = new System.Drawing.Point(263, 81);
            this.btnStationSuchen.Name = "btnStationSuchen";
            this.btnStationSuchen.Size = new System.Drawing.Size(135, 23);
            this.btnStationSuchen.TabIndex = 7;
            this.btnStationSuchen.Text = "Station suchen";
            this.btnStationSuchen.UseVisualStyleBackColor = true;
            this.btnStationSuchen.Click += new System.EventHandler(this.BtnStationSuchen_Click);
            // 
            // tbStationSuche
            // 
            this.tbStationSuche.Location = new System.Drawing.Point(105, 83);
            this.tbStationSuche.Name = "tbStationSuche";
            this.tbStationSuche.Size = new System.Drawing.Size(142, 20);
            this.tbStationSuche.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Station Name:";
            // 
            // StationSuche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 168);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbStationSuche);
            this.Controls.Add(this.btnStationSuchen);
            this.Name = "StationSuche";
            this.Text = "StationSuche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStationSuchen;
        private System.Windows.Forms.TextBox tbStationSuche;
        private System.Windows.Forms.Label label1;
    }
}