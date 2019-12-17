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
            this.cbxTo = new System.Windows.Forms.ComboBox();
            this.cbxFrom = new System.Windows.Forms.ComboBox();
            this.btnChangeFromAndTo = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnSearchConnections = new System.Windows.Forms.Button();
            this.lblDateTimePicker = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.groupBoxConnections = new System.Windows.Forms.GroupBox();
            this.listViewConnections = new System.Windows.Forms.ListView();
            this.groupBoxFunction = new System.Windows.Forms.GroupBox();
            this.rbtnStationMap = new System.Windows.Forms.RadioButton();
            this.rbtnStationBoard = new System.Windows.Forms.RadioButton();
            this.rbtnConnections = new System.Windows.Forms.RadioButton();
            this.groupBoxSearchInputs.SuspendLayout();
            this.groupBoxConnections.SuspendLayout();
            this.groupBoxFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSearchInputs
            // 
            this.groupBoxSearchInputs.Controls.Add(this.cbxTo);
            this.groupBoxSearchInputs.Controls.Add(this.cbxFrom);
            this.groupBoxSearchInputs.Controls.Add(this.btnChangeFromAndTo);
            this.groupBoxSearchInputs.Controls.Add(this.lblTime);
            this.groupBoxSearchInputs.Controls.Add(this.txtTime);
            this.groupBoxSearchInputs.Controls.Add(this.btnSearchConnections);
            this.groupBoxSearchInputs.Controls.Add(this.lblDateTimePicker);
            this.groupBoxSearchInputs.Controls.Add(this.dateTimePicker);
            this.groupBoxSearchInputs.Controls.Add(this.lblTo);
            this.groupBoxSearchInputs.Controls.Add(this.lblFrom);
            this.groupBoxSearchInputs.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSearchInputs.Name = "groupBoxSearchInputs";
            this.groupBoxSearchInputs.Size = new System.Drawing.Size(537, 164);
            this.groupBoxSearchInputs.TabIndex = 0;
            this.groupBoxSearchInputs.TabStop = false;
            this.groupBoxSearchInputs.Text = "Verbindungen suchen";
            // 
            // cbxTo
            // 
            this.cbxTo.FormattingEnabled = true;
            this.cbxTo.Location = new System.Drawing.Point(343, 59);
            this.cbxTo.Name = "cbxTo";
            this.cbxTo.Size = new System.Drawing.Size(188, 24);
            this.cbxTo.TabIndex = 2;
            this.cbxTo.TextUpdate += new System.EventHandler(this.cbxTo_TextUpdate);
            // 
            // cbxFrom
            // 
            this.cbxFrom.FormattingEnabled = true;
            this.cbxFrom.Location = new System.Drawing.Point(6, 59);
            this.cbxFrom.MaxDropDownItems = 10;
            this.cbxFrom.Name = "cbxFrom";
            this.cbxFrom.Size = new System.Drawing.Size(188, 24);
            this.cbxFrom.TabIndex = 1;
            this.cbxFrom.TextUpdate += new System.EventHandler(this.cbxFrom_TextUpdate);
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
            // btnSearchConnections
            // 
            this.btnSearchConnections.Location = new System.Drawing.Point(343, 108);
            this.btnSearchConnections.Name = "btnSearchConnections";
            this.btnSearchConnections.Size = new System.Drawing.Size(188, 35);
            this.btnSearchConnections.TabIndex = 5;
            this.btnSearchConnections.Text = "Suchen";
            this.btnSearchConnections.UseVisualStyleBackColor = true;
            this.btnSearchConnections.Click += new System.EventHandler(this.btnSearchConnections_Click);
            // 
            // lblDateTimePicker
            // 
            this.lblDateTimePicker.AutoSize = true;
            this.lblDateTimePicker.Location = new System.Drawing.Point(3, 101);
            this.lblDateTimePicker.Name = "lblDateTimePicker";
            this.lblDateTimePicker.Size = new System.Drawing.Size(49, 17);
            this.lblDateTimePicker.TabIndex = 5;
            this.lblDateTimePicker.Text = "Datum";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(6, 121);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2019, 12, 12, 11, 4, 36, 0);
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
            // groupBoxConnections
            // 
            this.groupBoxConnections.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxConnections.Controls.Add(this.listViewConnections);
            this.groupBoxConnections.Location = new System.Drawing.Point(12, 182);
            this.groupBoxConnections.Name = "groupBoxConnections";
            this.groupBoxConnections.Size = new System.Drawing.Size(686, 382);
            this.groupBoxConnections.TabIndex = 1;
            this.groupBoxConnections.TabStop = false;
            this.groupBoxConnections.Text = "Verbindungen";
            // 
            // listViewConnections
            // 
            this.listViewConnections.FullRowSelect = true;
            this.listViewConnections.GridLines = true;
            this.listViewConnections.Location = new System.Drawing.Point(6, 21);
            this.listViewConnections.Name = "listViewConnections";
            this.listViewConnections.Size = new System.Drawing.Size(674, 355);
            this.listViewConnections.TabIndex = 7;
            this.listViewConnections.UseCompatibleStateImageBehavior = false;
            this.listViewConnections.View = System.Windows.Forms.View.Details;
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
            // FahrplanApp
            // 
            this.AcceptButton = this.btnSearchConnections;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 576);
            this.Controls.Add(this.groupBoxFunction);
            this.Controls.Add(this.groupBoxConnections);
            this.Controls.Add(this.groupBoxSearchInputs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FahrplanApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSearchInputs.ResumeLayout(false);
            this.groupBoxSearchInputs.PerformLayout();
            this.groupBoxConnections.ResumeLayout(false);
            this.groupBoxFunction.ResumeLayout(false);
            this.groupBoxFunction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearchInputs;
        private System.Windows.Forms.Button btnSearchConnections;
        private System.Windows.Forms.Label lblDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.GroupBox groupBoxConnections;
        private System.Windows.Forms.Button btnChangeFromAndTo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ComboBox cbxTo;
        private System.Windows.Forms.ComboBox cbxFrom;
        private System.Windows.Forms.ListView listViewConnections;
        private System.Windows.Forms.GroupBox groupBoxFunction;
        private System.Windows.Forms.RadioButton rbtnStationMap;
        private System.Windows.Forms.RadioButton rbtnStationBoard;
        private System.Windows.Forms.RadioButton rbtnConnections;
    }
}

