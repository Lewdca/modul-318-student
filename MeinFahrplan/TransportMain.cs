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
    public partial class TransportMain : Form
    {
        ITransport transport = new Transport();
        AutoCompleteClass autoComplete = new AutoCompleteClass();
        MailVersendenClass mailVersenden = new MailVersendenClass();
        

        public TransportMain()
        {
            InitializeComponent();
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
        private void BtnAbfahrtstafel_Click(object sender, EventArgs e)
        {
            var myForm = new Abfahrtstafel();
            myForm.Show();
        }
        public void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Right && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left)
                autoComplete.getStation((ComboBox)sender);
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string mailName = tbMail.Text;
            string mailText = $"Der Zug fährt von der Station {dgvStart.Selected.ToString()} " +
                $"nach {dgvEnd.Selected.ToString()}" +
                $"\nDatum/Zeit Abfahrt:{dgvDatumZeit.Selected.ToString()}" +
                $"\nAnkunftszeit: {dgvAnkunftZeit.Selected.ToString()} ankommen";

            System.Diagnostics.Process.Start($"mailto:{mailName​}?subject=SBB Fahrplan&body={​mailtext}​");
        }
    }
}
