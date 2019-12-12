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
            if (cbxFrom.Text != String.Empty && cbxTo.Text != String.Empty && txtTime.Text != String.Empty && dateTimePicker.Value != null)
            {
                Connections
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString().Substring(11, 5);
            transport = new Transport();
        }
        private void btnChangeFromAndTo_Click(object sender, EventArgs e)
        {
            string to = cbxTo.Text;
            cbxTo.Text = cbxFrom.Text;
            cbxFrom.Text = to;
            ShowStationSuggestionsInItems(cbxFrom);
            ShowStationSuggestionsInItems(cbxTo);
        }
        private void cbxFrom_TextUpdate(object sender, EventArgs e)
        {
            ShowStationSuggestionsInItems(cbxFrom);
        }
        private void cbxTo_TextUpdate(object sender, EventArgs e)
        {
            ShowStationSuggestionsInItems(cbxTo);
        }
        private void ShowStationSuggestionsInItems(ComboBox comboBox)
        {
            if (comboBox.Text.Length > 1)
            {
                try
                {
                    comboBox.DroppedDown = true;
                    Cursor.Current = Cursors.Default;

                    for (int i = comboBox.Items.Count - 1; i >= 0; i--)
                        comboBox.Items.RemoveAt(i);

                    var stations = transport.GetStations(comboBox.Text).StationList;
                    {
                        for (int n = 0; n < stations.Count - 1; n++)
                            if (stations[n].Name != null)
                                comboBox.Items.Add(stations[n].Name);
                    }
                }
                catch { }
            }
        }
    }
}
