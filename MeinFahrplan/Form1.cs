﻿using SwissTransport.Core;
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
        public List<string> autoComplete(string input)
        {

            List<string> autoCompleteList = new List<string>();
     
            var stations = transport.GetStations(input);
            foreach (var station in stations.StationList)
            {

                autoCompleteList.Add(station.Name);
            }

            if (autoCompleteList.Count == 0)
            {
                autoCompleteList.Add("Kein Resultat");
            }

            return autoCompleteList;
        }
        public void getStation(ComboBox box)
        {
            if(box.Text != "")
            {
                try
                {
                    box.Items.Clear();
                    box.SelectionStart = box.Text.Length + 1;

                    List<string> stations = autoComplete(box.Text);

                    foreach (String station in stations)
                    {
                        if (station != null)
                        {
                            box.Items.Add(station);
                        }
                    }
                    box.DroppedDown = true;
                }
                catch
                {
                    box.Items.Clear();
                    box.SelectionStart = box.Text.Length + 1;
                    box.Items.Add("Kein Resultat");
                }
            }      
        }
        public void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Right && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left)
                getStation((ComboBox)sender);
        }
    }
}
