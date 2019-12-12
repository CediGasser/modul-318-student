namespace FahrplanApp
{
    partial class Form1
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
            this.groupBoxSearchInputs = new System.Windows.Forms.GroupBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.btnChangeFromAndTo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnSearchConnections = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxConnections = new System.Windows.Forms.GroupBox();
            this.listViewConnections = new System.Windows.Forms.ListView();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.listViewDetailedConnection = new System.Windows.Forms.ListView();
            this.groupBoxSearchInputs.SuspendLayout();
            this.groupBoxConnections.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSearchInputs
            // 
            this.groupBoxSearchInputs.Controls.Add(this.txtTo);
            this.groupBoxSearchInputs.Controls.Add(this.txtFrom);
            this.groupBoxSearchInputs.Controls.Add(this.btnChangeFromAndTo);
            this.groupBoxSearchInputs.Controls.Add(this.label4);
            this.groupBoxSearchInputs.Controls.Add(this.txtTime);
            this.groupBoxSearchInputs.Controls.Add(this.btnSearchConnections);
            this.groupBoxSearchInputs.Controls.Add(this.label3);
            this.groupBoxSearchInputs.Controls.Add(this.dateTimePicker);
            this.groupBoxSearchInputs.Controls.Add(this.label2);
            this.groupBoxSearchInputs.Controls.Add(this.label1);
            this.groupBoxSearchInputs.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSearchInputs.Name = "groupBoxSearchInputs";
            this.groupBoxSearchInputs.Size = new System.Drawing.Size(532, 164);
            this.groupBoxSearchInputs.TabIndex = 0;
            this.groupBoxSearchInputs.TabStop = false;
            this.groupBoxSearchInputs.Text = "Verbindungen suchen";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(338, 59);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(188, 22);
            this.txtTo.TabIndex = 11;
            // 
            // txtFrom
            // 
            this.txtFrom.AllowDrop = true;
            this.txtFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtFrom.Location = new System.Drawing.Point(6, 59);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(188, 22);
            this.txtFrom.TabIndex = 10;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Uhrzeit";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(254, 121);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(54, 22);
            this.txtTime.TabIndex = 7;
            // 
            // btnSearchConnections
            // 
            this.btnSearchConnections.Location = new System.Drawing.Point(338, 108);
            this.btnSearchConnections.Name = "btnSearchConnections";
            this.btnSearchConnections.Size = new System.Drawing.Size(188, 35);
            this.btnSearchConnections.TabIndex = 6;
            this.btnSearchConnections.Text = "Verbindung Suchen";
            this.btnSearchConnections.UseVisualStyleBackColor = true;
            this.btnSearchConnections.Click += new System.EventHandler(this.btnSearchConnections_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(6, 121);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2019, 12, 12, 11, 4, 36, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nach";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Von";
            // 
            // groupBoxConnections
            // 
            this.groupBoxConnections.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxConnections.Controls.Add(this.listViewConnections);
            this.groupBoxConnections.Location = new System.Drawing.Point(12, 182);
            this.groupBoxConnections.Name = "groupBoxConnections";
            this.groupBoxConnections.Size = new System.Drawing.Size(532, 368);
            this.groupBoxConnections.TabIndex = 1;
            this.groupBoxConnections.TabStop = false;
            this.groupBoxConnections.Text = "Verbindungen";
            // 
            // listViewConnections
            // 
            this.listViewConnections.Location = new System.Drawing.Point(6, 21);
            this.listViewConnections.Name = "listViewConnections";
            this.listViewConnections.Size = new System.Drawing.Size(520, 341);
            this.listViewConnections.TabIndex = 0;
            this.listViewConnections.UseCompatibleStateImageBehavior = false;
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.listViewDetailedConnection);
            this.groupBoxDetails.Location = new System.Drawing.Point(560, 12);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(471, 538);
            this.groupBoxDetails.TabIndex = 2;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            // 
            // listViewDetailedConnection
            // 
            this.listViewDetailedConnection.Location = new System.Drawing.Point(6, 21);
            this.listViewDetailedConnection.Name = "listViewDetailedConnection";
            this.listViewDetailedConnection.Size = new System.Drawing.Size(216, 511);
            this.listViewDetailedConnection.TabIndex = 0;
            this.listViewDetailedConnection.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 565);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxConnections);
            this.Controls.Add(this.groupBoxSearchInputs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSearchInputs.ResumeLayout(false);
            this.groupBoxSearchInputs.PerformLayout();
            this.groupBoxConnections.ResumeLayout(false);
            this.groupBoxDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearchInputs;
        private System.Windows.Forms.Button btnSearchConnections;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxConnections;
        private System.Windows.Forms.Button btnChangeFromAndTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.ListView listViewConnections;
        private System.Windows.Forms.ListView listViewDetailedConnection;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
    }
}

