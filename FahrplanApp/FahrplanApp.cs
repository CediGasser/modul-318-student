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
    public partial class FahrplanApp : Form
    {
        private Transport transport;
        public FahrplanApp()
        {
            InitializeComponent();
        }


        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            if (rbtnConnections.Checked && !String.IsNullOrEmpty(cbxFrom.Text) && !String.IsNullOrEmpty(cbxTo.Text) && !String.IsNullOrEmpty(txtTime.Text) && !String.IsNullOrEmpty(dateTimePicker.Value.ToString()))
            {
                try
                {
                    ShowConnections(cbxFrom.Text, cbxTo.Text, dateTimePicker.Value.ToString(), txtTime.Text);
                }
                catch { MessageBox.Show("Ihre Eingaben sind ungültig"); }
            }
            else if(rbtnStationBoard.Checked && !String.IsNullOrEmpty(cbxFrom.Text))
            {
                try
                {
                    ShowStationBoard(cbxFrom.Text);
                }
                catch { MessageBox.Show("Ihre Eingaben sind ungültig"); }
            }
            else if(rbtnStationMap.Checked && !String.IsNullOrEmpty(cbxFrom.Text))
            {

            }
        }
        

        private void ShowStationBoard(string from)
        {
            var stationBoard = transport.GetStationBoard(from, "").Entries;

            listViewConnections.Items.Clear();
            for (int i = 0; i < stationBoard.Count(); i++)
            {
                string[] item = new string[5] {
                    cbxFrom.Text,
                    stationBoard[i].Stop.Departure.ToShortTimeString(),
                    stationBoard[i].To,
                    stationBoard[i].Name,
                    stationBoard[i].Operator
                };

                listViewConnections.Items.Add(new ListViewItem(item));
            }
        }

        private void ShowConnections(string from, string to, string date, string time)
        {

            var connections = transport.GetConnections(from, to, date, time).ConnectionList;

            listViewConnections.Items.Clear();
            for (int i = 0; i < 4; i++)
            {
                string[] item = new string[5] {
                    connections[i].From.Departure.Remove(0, 11).Remove(5, 8),
                    connections[i].From.Station.Name + "  -  Gleis " + connections[i].From.Platform,
                    connections[i].To.Arrival.Remove(0, 11).Remove(5, 8),
                    connections[i].To.Station.Name + "  -  Gleis " + connections[i].To.Platform,
                    connections[i].Duration.Remove(0, 3)
                };

                listViewConnections.Items.Add(new ListViewItem(item));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString().Substring(11, 5);
            transport = new Transport();
            rbtnConnections_Click(rbtnConnections, null);
            this.AcceptButton = btnSearchConnections;
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
                catch { MessageBox.Show("Ihre Eingaben sind ungültig"); }
            }
        }

        private void rbtnConnections_Click(object sender, EventArgs e)
        {
            lblFrom.Visible = true;
            cbxFrom.Visible = true;
            lblTo.Visible = true;
            cbxTo.Visible = true;
            lblTime.Visible = true;
            txtTime.Visible = true;
            lblDateTimePicker.Visible = true;
            dateTimePicker.Visible = true;
            btnChangeFromAndTo.Visible = true;
            listViewConnections.Enabled = true;

            listViewConnections.Items.Clear();
            listViewConnections.Columns.Clear();
            listViewConnections.Columns.Add("Zeit", 44);
            listViewConnections.Columns.Add("Von", 175);
            listViewConnections.Columns.Add("Zeit", 44);
            listViewConnections.Columns.Add("Nach", 175);
            listViewConnections.Columns.Add("Dauer", 64);
        }

        private void rbtnStationBoard_Click(object sender, EventArgs e)
        {
            lblFrom.Visible = true;
            cbxFrom.Visible = true;

            lblTo.Visible = false;
            cbxTo.Visible = false;

            lblTime.Visible = false;
            txtTime.Visible = false;

            lblDateTimePicker.Visible = false;
            dateTimePicker.Visible = false;

            btnChangeFromAndTo.Visible = false;
            listViewConnections.Enabled = true;

            listViewConnections.Items.Clear();
            listViewConnections.Columns.Clear();
            listViewConnections.Columns.Add("Von", 155);
            listViewConnections.Columns.Add("Zeit", 40);
            listViewConnections.Columns.Add("Nach", 155);
            listViewConnections.Columns.Add("Name", 80);
            listViewConnections.Columns.Add("Betreiber", 55);

        }

        private void rbtnStationMap_Click(object sender, EventArgs e)
        {
            lblFrom.Visible = true;
            cbxFrom.Visible = true;
            lblTo.Visible = false;
            cbxTo.Visible = false;
            lblTime.Visible = false;
            txtTime.Visible = false;
            lblDateTimePicker.Visible = false;
            dateTimePicker.Visible = false;
            btnChangeFromAndTo.Visible = false;

            listViewConnections.Enabled = false;
            listViewConnections.Items.Clear();
            listViewConnections.Columns.Clear();
        }
    }
}
