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

            var connections = transport.GetConnections(cbStartStatoin.Text,cbEndStation.Text, dtpZeit.Value, dtpDate.Value, 16);

            dgvVerbindungen.Rows.Clear();
            
            foreach(Connection connection in connections.ConnectionList)
            {
                dgvVerbindungen.Rows.Add(new[] { connection.From.Departure.ToString() ,connection.From.Station.Name,connection.To.Station.Name,connection.From.Platform ,connection.To.Arrival.Value.ToString(), connection.Duration });
            }
        }

        private void DgvVerbindungen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAbfahrtstafel_Click(object sender, EventArgs e)
        {
            dgvVerbindungen.Columns[1].HeaderText = "Zugname";
            dgvVerbindungen.Columns[2].HeaderText = "Start-Station";

            var getStationBoard = transport.GetStationBoard(cbStartStatoin.Text, "1", dtpZeit.Value, dtpDate.Value, 15);

            dgvVerbindungen.Rows.Clear();

            foreach(StationBoard GetStationBoard in getStationBoard.Entries)
            {
                dgvVerbindungen.Rows.Add(new[] { GetStationBoard.Stop.Departure.ToString(), GetStationBoard.Name.ToString(),getStationBoard.Station.Name.ToString()});
            }
        }
    }
}
