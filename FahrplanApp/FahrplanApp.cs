using SwissTransport;
using System;
using System.Linq;
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


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbtnConnections.Checked && !String.IsNullOrEmpty(txtFrom.Text) && !String.IsNullOrEmpty(txtTo.Text) && !String.IsNullOrEmpty(txtTime.Text) && !String.IsNullOrEmpty(dtpDate.Value.ToString()))
            {
                try
                {
                    ShowConnections(txtFrom.Text, txtTo.Text, dtpDate.Value.ToString(), txtTime.Text);
                }
                catch { MessageBox.Show("Ihre Eingaben sind ungültig"); }
            }
            else if(rbtnStationBoard.Checked && !String.IsNullOrEmpty(txtFrom.Text))
            {
                try
                {
                    ShowStationBoard(txtFrom.Text);
                }
                catch { MessageBox.Show("Ihre Eingaben sind ungültig"); }
            }
            else if(rbtnStationMap.Checked && !String.IsNullOrEmpty(txtFrom.Text))
            {
                try
                {
                    ShowStationMap(txtFrom.Text);
                }
                catch { MessageBox.Show("Ihre Eingaben sind ungültig"); }
            }
        }
        
        private void ShowStationMap(string from)
        {
            var station = transport.GetStations(from).StationList[0];
            if (station.Id != null)
            {
                double x = station.Coordinate.XCoordinate;
                double y = station.Coordinate.YCoordinate;
                gMapStationMap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
                gMapStationMap.Position = new GMap.NET.PointLatLng(x, y);
                
            }
            else
            {
                MessageBox.Show("Ort nicht gefunden");
            }
        }
        private void ShowStationBoard(string from)
        {
            var stationBoard = transport.GetStationBoard(from, "").Entries;

            lviConnections.Items.Clear();
            for (int i = 0; i < stationBoard.Count(); i++)
            {
                string[] item = new string[5] {
                    txtFrom.Text,
                    stationBoard[i].Stop.Departure.ToShortTimeString(),
                    stationBoard[i].To,
                    stationBoard[i].Name,
                    stationBoard[i].Operator
                };

                lviConnections.Items.Add(new ListViewItem(item));
            }
        }

        private void ShowConnections(string from, string to, string date, string time)
        {

            var connections = transport.GetConnections(from, to, date, time).ConnectionList;

            lviConnections.Items.Clear();
            for (int i = 0; i < 4; i++)
            {
                string[] item = new string[5] {
                    connections[i].From.Departure.Remove(0, 11).Remove(5, 8),
                    connections[i].From.Station.Name + "  -  Gleis " + connections[i].From.Platform,
                    connections[i].To.Arrival.Remove(0, 11).Remove(5, 8),
                    connections[i].To.Station.Name + "  -  Gleis " + connections[i].To.Platform,
                    connections[i].Duration.Remove(0, 3)
                };

                lviConnections.Items.Add(new ListViewItem(item));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString().Substring(11, 5);
            transport = new Transport();
            rbtnConnections_Click(rbtnConnections, null);
            gMapStationMap.ShowCenter = false;
        }

        private void btnChangeFromAndTo_Click(object sender, EventArgs e)
        {
            string to = txtTo.Text;
            txtTo.Text = txtFrom.Text;
            txtFrom.Text = to;
            lviFromSuggestions.Visible = false;
            lviToSuggestions.Visible = false;
        }

        private void rbtnConnections_Click(object sender, EventArgs e)
        {
            lblFrom.Visible = true;
            txtFrom.Visible = true;
            lblTo.Visible = true;
            txtTo.Visible = true;
            lblTime.Visible = true;
            txtTime.Visible = true;
            lblDate.Visible = true;
            dtpDate.Visible = true;
            btnChangeFromAndTo.Visible = true;
            lviConnections.Enabled = true;

            lviConnections.Items.Clear();
            lviConnections.Columns.Clear();
            lviConnections.Columns.Add("Zeit", 44);
            lviConnections.Columns.Add("Von", 175);
            lviConnections.Columns.Add("Zeit", 44);
            lviConnections.Columns.Add("Nach", 175);
            lviConnections.Columns.Add("Dauer", 64);

            gMapStationMap.Visible = false;
            gbxConnections.Text = "Verbindungen";
        }


        //change gui to StationBoard with StationBoard, txtFrom and btnSearch
        private void rbtnStationBoard_Click(object sender, EventArgs e)
        {
            lblFrom.Visible = true;
            txtFrom.Visible = true;
            lblTo.Visible = false;
            txtTo.Visible = false;
            lblTime.Visible = false;
            txtTime.Visible = false;
            lblDate.Visible = false;
            dtpDate.Visible = false;
            btnChangeFromAndTo.Visible = false;
            lviConnections.Enabled = true;

            lviConnections.Items.Clear();
            lviConnections.Columns.Clear();
            lviConnections.Columns.Add("Von", 155);
            lviConnections.Columns.Add("Zeit", 40);
            lviConnections.Columns.Add("Nach", 155);
            lviConnections.Columns.Add("Name", 80);
            lviConnections.Columns.Add("Betreiber", 55);

            gMapStationMap.Visible = false;
            gbxConnections.Text = "Abfahrtsplan";
        }


        //change gui to StationMap with Map, txtFrom and btnSearch
        private void rbtnStationMap_Click(object sender, EventArgs e)
        {
            lblFrom.Visible = true;
            txtFrom.Visible = true;
            lblTo.Visible = false;
            txtTo.Visible = false;
            lblTime.Visible = false;
            txtTime.Visible = false;
            lblDate.Visible = false;
            dtpDate.Visible = false;
            btnChangeFromAndTo.Visible = false;

            lviConnections.Enabled = false;
            lviConnections.Items.Clear();
            lviConnections.Columns.Clear();

            gMapStationMap.Visible = true;
            gbxConnections.Text = "Karte";
        }


        //updates Stationsuggestions in Listbox(dropdown) when key typed
        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            if (txtFrom.Text.Length > 0)
            {
                try
                {
                    lviFromSuggestions.Items.Clear();
                    lviFromSuggestions.Visible = true;

                    var stations = transport.GetStations(txtFrom.Text).StationList;
                    {
                        for (int n = 0; n < stations.Count - 1; n++)
                            if (stations[n].Name != null)
                                lviFromSuggestions.Items.Add(stations[n].Name);
                    }
                }
                catch { MessageBox.Show("Ups, da hat etwas nicht funktioniert,\n bitte überprüfen sie ihre Verbindung"); }
            }
        }
        private void txtTo_TextChanged(object sender, EventArgs e)
        {
            if (txtTo.Text.Length > 0)
            {
                try
                {
                    lviToSuggestions.Visible = true;
                    lviToSuggestions.Items.Clear();

                    var stations = transport.GetStations(txtTo.Text).StationList;
                    {
                        for (int n = 0; n < stations.Count - 1; n++)
                            if (stations[n].Name != null)
                                lviToSuggestions.Items.Add(stations[n].Name);
                    }
                }
                catch { MessageBox.Show("Ups, da hat etwas nicht funktioniert,\n bitte überprüfen sie ihre Verbdingun"); }
            }
        }


        //makes Listbox-dropdown with Statigonsuggestions shown
        private void txtTo_Enter(object sender, EventArgs e)
        {
            lviToSuggestions.Visible = true;
        }
        private void txtFrom_Enter(object sender, EventArgs e)
        {
            lviFromSuggestions.Visible = true;
        }


        //makes Listbox-dropdown with Statigonsuggestions disappear
        private void txtFrom_Leave(object sender, EventArgs e)
        {
            if(!(lviFromSuggestions.Focused || txtFrom.Focused))
                lviFromSuggestions.Visible = false;
        }
        private void txtTo_Leave(object sender, EventArgs e)
        {
            if(!(lviToSuggestions.Focused || txtFrom.Focused))
                lviToSuggestions.Visible = false;
        }


        //To be able to select Stationsuggestions with arrow keys out of text Box
        private void txtFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                lviFromSuggestions.SelectedIndex = 0;
                lviFromSuggestions.Focus();
            }
        }
        private void txtTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lviToSuggestions.SelectedIndex = 0;
                lviToSuggestions.Focus();
            }
        }


        //To select Stationsuggestion and put it into textbox on enter key pressed, focus next element
        private void lviFromSuggestions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFrom.Text = lviFromSuggestions.Text;
                txtTo.Focus();
            }
        }
        private void lviToSuggestions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTo.Text = lviToSuggestions.Text;
                btnSearch.Focus();
            }
        }


        //To select Stationsuggestion and put it into textbox on mouse click, focus next element
        private void lviFromSuggestions_Click(object sender, EventArgs e)
        {
            txtFrom.Text = lviFromSuggestions.Text;
            txtTo.Focus();
        }
        private void lviToSuggestions_Click(object sender, EventArgs e)
        {
            txtTo.Text = lviToSuggestions.Text;
            btnSearch.Focus();
        }
    }
}
