using SwissTransport.Core;
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
            string userDate = dtpDate.Text;
            dgvVerbindungen.Rows[0].Cells[1].Value = userDate;
        }
    }
}
