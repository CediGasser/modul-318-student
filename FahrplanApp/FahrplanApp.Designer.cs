namespace FahrplanApp
{
    partial class FahrplanApp
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FahrplanApp));
            this.groupBoxSearchInputs = new System.Windows.Forms.GroupBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.btnChangeFromAndTo = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.gbxConnections = new System.Windows.Forms.GroupBox();
            this.gMapStationMap = new GMap.NET.WindowsForms.GMapControl();
            this.lviConnections = new System.Windows.Forms.ListView();
            this.groupBoxFunction = new System.Windows.Forms.GroupBox();
            this.rbtnStationMap = new System.Windows.Forms.RadioButton();
            this.rbtnStationBoard = new System.Windows.Forms.RadioButton();
            this.rbtnConnections = new System.Windows.Forms.RadioButton();
            this.lviFromSuggestions = new System.Windows.Forms.ListBox();
            this.lviToSuggestions = new System.Windows.Forms.ListBox();
            this.groupBoxSearchInputs.SuspendLayout();
            this.gbxConnections.SuspendLayout();
            this.groupBoxFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSearchInputs
            // 
            this.groupBoxSearchInputs.Controls.Add(this.txtTo);
            this.groupBoxSearchInputs.Controls.Add(this.txtFrom);
            this.groupBoxSearchInputs.Controls.Add(this.btnChangeFromAndTo);
            this.groupBoxSearchInputs.Controls.Add(this.lblTime);
            this.groupBoxSearchInputs.Controls.Add(this.txtTime);
            this.groupBoxSearchInputs.Controls.Add(this.btnSearch);
            this.groupBoxSearchInputs.Controls.Add(this.lblDate);
            this.groupBoxSearchInputs.Controls.Add(this.dtpDate);
            this.groupBoxSearchInputs.Controls.Add(this.lblTo);
            this.groupBoxSearchInputs.Controls.Add(this.lblFrom);
            this.groupBoxSearchInputs.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSearchInputs.Name = "groupBoxSearchInputs";
            this.groupBoxSearchInputs.Size = new System.Drawing.Size(537, 164);
            this.groupBoxSearchInputs.TabIndex = 0;
            this.groupBoxSearchInputs.TabStop = false;
            this.groupBoxSearchInputs.Text = "Suchen";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(338, 59);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(193, 22);
            this.txtTo.TabIndex = 11;
            this.txtTo.TextChanged += new System.EventHandler(this.txtTo_TextChanged);
            this.txtTo.Enter += new System.EventHandler(this.txtTo_Enter);
            this.txtTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTo_KeyDown);
            this.txtTo.Leave += new System.EventHandler(this.txtTo_Leave);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(6, 59);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(182, 22);
            this.txtFrom.TabIndex = 10;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            this.txtFrom.Enter += new System.EventHandler(this.txtFrom_Enter);
            this.txtFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFrom_KeyDown);
            this.txtFrom.Leave += new System.EventHandler(this.txtFrom_Leave);
            // 
            // btnChangeFromAndTo
            // 
            this.btnChangeFromAndTo.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangeFromAndTo.FlatAppearance.BorderSize = 0;
            this.btnChangeFromAndTo.ForeColor = System.Drawing.Color.Black;
            this.btnChangeFromAndTo.Location = new System.Drawing.Point(235, 48);
            this.btnChangeFromAndTo.Name = "btnChangeFromAndTo";
            this.btnChangeFromAndTo.Size = new System.Drawing.Size(61, 42);
            this.btnChangeFromAndTo.TabIndex = 9;
            this.btnChangeFromAndTo.Text = "---->      <----";
            this.btnChangeFromAndTo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangeFromAndTo.UseVisualStyleBackColor = false;
            this.btnChangeFromAndTo.Click += new System.EventHandler(this.btnChangeFromAndTo_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(251, 101);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 17);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Uhrzeit";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(254, 121);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(54, 22);
            this.txtTime.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(343, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(188, 35);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(3, 101);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 17);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Datum";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(6, 121);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(220, 22);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.Value = new System.DateTime(2019, 12, 12, 11, 4, 36, 0);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(335, 39);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(41, 17);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "Nach";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(3, 39);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 17);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "Von";
            // 
            // gbxConnections
            // 
            this.gbxConnections.BackColor = System.Drawing.SystemColors.Control;
            this.gbxConnections.Controls.Add(this.gMapStationMap);
            this.gbxConnections.Controls.Add(this.lviConnections);
            this.gbxConnections.Location = new System.Drawing.Point(12, 182);
            this.gbxConnections.Name = "gbxConnections";
            this.gbxConnections.Size = new System.Drawing.Size(686, 382);
            this.gbxConnections.TabIndex = 1;
            this.gbxConnections.TabStop = false;
            this.gbxConnections.Text = "Verbindungen";
            // 
            // gMapStationMap
            // 
            this.gMapStationMap.Bearing = 0F;
            this.gMapStationMap.CanDragMap = true;
            this.gMapStationMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapStationMap.GrayScaleMode = false;
            this.gMapStationMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapStationMap.LevelsKeepInMemmory = 5;
            this.gMapStationMap.Location = new System.Drawing.Point(6, 21);
            this.gMapStationMap.MarkersEnabled = true;
            this.gMapStationMap.MaxZoom = 18;
            this.gMapStationMap.MinZoom = 2;
            this.gMapStationMap.MouseWheelZoomEnabled = true;
            this.gMapStationMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapStationMap.Name = "gMapStationMap";
            this.gMapStationMap.NegativeMode = false;
            this.gMapStationMap.PolygonsEnabled = true;
            this.gMapStationMap.RetryLoadTile = 0;
            this.gMapStationMap.RoutesEnabled = true;
            this.gMapStationMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapStationMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapStationMap.ShowTileGridLines = false;
            this.gMapStationMap.Size = new System.Drawing.Size(674, 355);
            this.gMapStationMap.TabIndex = 8;
            this.gMapStationMap.Visible = false;
            this.gMapStationMap.Zoom = 16D;
            // 
            // lviConnections
            // 
            this.lviConnections.FullRowSelect = true;
            this.lviConnections.GridLines = true;
            this.lviConnections.Location = new System.Drawing.Point(6, 21);
            this.lviConnections.Name = "lviConnections";
            this.lviConnections.Size = new System.Drawing.Size(674, 355);
            this.lviConnections.TabIndex = 7;
            this.lviConnections.UseCompatibleStateImageBehavior = false;
            this.lviConnections.View = System.Windows.Forms.View.Details;
            // 
            // groupBoxFunction
            // 
            this.groupBoxFunction.Controls.Add(this.rbtnStationMap);
            this.groupBoxFunction.Controls.Add(this.rbtnStationBoard);
            this.groupBoxFunction.Controls.Add(this.rbtnConnections);
            this.groupBoxFunction.Location = new System.Drawing.Point(555, 12);
            this.groupBoxFunction.Name = "groupBoxFunction";
            this.groupBoxFunction.Size = new System.Drawing.Size(143, 164);
            this.groupBoxFunction.TabIndex = 2;
            this.groupBoxFunction.TabStop = false;
            this.groupBoxFunction.Text = "Funktion";
            // 
            // rbtnStationMap
            // 
            this.rbtnStationMap.AutoSize = true;
            this.rbtnStationMap.Location = new System.Drawing.Point(6, 101);
            this.rbtnStationMap.Name = "rbtnStationMap";
            this.rbtnStationMap.Size = new System.Drawing.Size(112, 21);
            this.rbtnStationMap.TabIndex = 2;
            this.rbtnStationMap.Text = "Stationskarte";
            this.rbtnStationMap.UseVisualStyleBackColor = true;
            this.rbtnStationMap.Click += new System.EventHandler(this.rbtnStationMap_Click);
            // 
            // rbtnStationBoard
            // 
            this.rbtnStationBoard.AutoSize = true;
            this.rbtnStationBoard.Location = new System.Drawing.Point(6, 69);
            this.rbtnStationBoard.Name = "rbtnStationBoard";
            this.rbtnStationBoard.Size = new System.Drawing.Size(109, 21);
            this.rbtnStationBoard.TabIndex = 1;
            this.rbtnStationBoard.Text = "Abfahrtsplan";
            this.rbtnStationBoard.UseVisualStyleBackColor = true;
            this.rbtnStationBoard.Click += new System.EventHandler(this.rbtnStationBoard_Click);
            // 
            // rbtnConnections
            // 
            this.rbtnConnections.AutoSize = true;
            this.rbtnConnections.Checked = true;
            this.rbtnConnections.Location = new System.Drawing.Point(6, 35);
            this.rbtnConnections.Name = "rbtnConnections";
            this.rbtnConnections.Size = new System.Drawing.Size(118, 21);
            this.rbtnConnections.TabIndex = 0;
            this.rbtnConnections.TabStop = true;
            this.rbtnConnections.Text = "Verbindungen";
            this.rbtnConnections.UseVisualStyleBackColor = true;
            this.rbtnConnections.Click += new System.EventHandler(this.rbtnConnections_Click);
            // 
            // lviFromSuggestions
            // 
            this.lviFromSuggestions.FormattingEnabled = true;
            this.lviFromSuggestions.ItemHeight = 16;
            this.lviFromSuggestions.Location = new System.Drawing.Point(17, 93);
            this.lviFromSuggestions.Name = "lviFromSuggestions";
            this.lviFromSuggestions.Size = new System.Drawing.Size(182, 148);
            this.lviFromSuggestions.TabIndex = 14;
            this.lviFromSuggestions.Visible = false;
            this.lviFromSuggestions.Click += new System.EventHandler(this.lviFromSuggestions_Click);
            this.lviFromSuggestions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lviFromSuggestions_KeyDown);
            this.lviFromSuggestions.Leave += new System.EventHandler(this.txtFrom_Leave);
            // 
            // lviToSuggestions
            // 
            this.lviToSuggestions.FormattingEnabled = true;
            this.lviToSuggestions.ItemHeight = 16;
            this.lviToSuggestions.Location = new System.Drawing.Point(351, 93);
            this.lviToSuggestions.Name = "lviToSuggestions";
            this.lviToSuggestions.Size = new System.Drawing.Size(193, 148);
            this.lviToSuggestions.TabIndex = 15;
            this.lviToSuggestions.Visible = false;
            this.lviToSuggestions.Click += new System.EventHandler(this.lviToSuggestions_Click);
            this.lviToSuggestions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lviToSuggestions_KeyDown);
            this.lviToSuggestions.Leave += new System.EventHandler(this.txtTo_Leave);
            // 
            // FahrplanApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 576);
            this.Controls.Add(this.lviToSuggestions);
            this.Controls.Add(this.lviFromSuggestions);
            this.Controls.Add(this.groupBoxFunction);
            this.Controls.Add(this.gbxConnections);
            this.Controls.Add(this.groupBoxSearchInputs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FahrplanApp";
            this.Text = "FahrplanApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSearchInputs.ResumeLayout(false);
            this.groupBoxSearchInputs.PerformLayout();
            this.gbxConnections.ResumeLayout(false);
            this.groupBoxFunction.ResumeLayout(false);
            this.groupBoxFunction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearchInputs;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.GroupBox gbxConnections;
        private System.Windows.Forms.Button btnChangeFromAndTo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ListView lviConnections;
        private System.Windows.Forms.GroupBox groupBoxFunction;
        private System.Windows.Forms.RadioButton rbtnStationMap;
        private System.Windows.Forms.RadioButton rbtnStationBoard;
        private System.Windows.Forms.RadioButton rbtnConnections;
        private GMap.NET.WindowsForms.GMapControl gMapStationMap;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.ListBox lviFromSuggestions;
        private System.Windows.Forms.ListBox lviToSuggestions;
    }
}

