using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FahrplanApp
{
    public partial class Form1 : Form
    {
        private Transport transport;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text != String.Empty || txtTo.Text != String.Empty || txtTime.Text != String.Empty) ;
        }

        private void btnChangeFromAndTo_Click(object sender, EventArgs e)
        {
            string to = txtTo.Text;
            txtTo.Text = txtFrom.Text;
            txtFrom.Text = to;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString().Substring(11, 5);
            transport = new Transport();
        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            if (txtFrom.Text.Length > 3)
            {
                try
                {
                    txtFrom.AutoCompleteSource
                    List<string> suggestedStations = new List<string>();
                    var stations = transport.GetStations(txtFrom.Text);
                    foreach (var Station in stations.StationList)
                    {
                        suggestedStations.Add(Station.Name);
                    }
                    txtFrom.AutoCompleteSource = suggestedStations.ToArray();
                }
                catch { }
            }
        }
    }
}
