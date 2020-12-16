using SwissTransport.Core;
using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeinFahrplan
{
    public partial class Form1 : Form
    {
        ITransport transport = new Transport();

        public Form1()
        {
            InitializeComponent();
        }

        private void GbDatumZeit_Enter(object sender, EventArgs e)
        {

        }

        private void BtnVerbindung_Click(object sender, EventArgs e)
        {
            dgvVerbindungen.Columns[1].HeaderText = "Start-Station";
            dgvVerbindungen.Columns[2].HeaderText = "End-Station";
            dgvVerbindungen.Columns[3].HeaderText = "Plattform";

            var connections = transport.GetConnections(cbStartStatoin.Text, cbEndStation.Text, dtpZeit.Value, dtpDate.Value, 10);

            dgvVerbindungen.Rows.Clear();

            foreach (Connection connection in connections.ConnectionList)
            {
                dgvVerbindungen.Rows.Add(new[]
                {
                     connection.From.Departure.ToString(),
                     connection.From.Station.Name,
                     connection.To.Station.Name,
                     connection.From.Platform,
                     connection.To.Arrival.Value.ToString(),
                     connection.Duration
                 });
            }

        }

        private void DgvVerbindungen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAbfahrtstafel_Click(object sender, EventArgs e)
        {
            var myForm = new Abfahrtstafel();
            myForm.Show();
        }

        private void Btnstation_Click(object sender, EventArgs e)
        {
            var myForm = new StationSuche();
            myForm.Show();
        }

        private void CbStartStatoin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void AutoCompleteText()
        {
            cbStartStatoin.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }
    }
}
