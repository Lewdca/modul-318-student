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
    public partial class StationSuche : Form
    {
        ITransport transport = new Transport();
        public StationSuche()
        {
            InitializeComponent();
        }

        private void BtnStationSuchen_Click(object sender, EventArgs e)
        {
            var stations = transport.GetStations(tbStationSuche.Text, 1);

            foreach (Station station in stations.StationList)

            if (tbStationSuche.Text != station.Name)
            {
                MessageBox.Show("Diese Station existiert nicht!");
            }
            else
            {
                MessageBox.Show("Die Station " + tbStationSuche.Text + " existiert");
            }
        }
    }
}
