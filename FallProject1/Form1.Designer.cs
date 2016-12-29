namespace FallProject1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addCustomer = new System.Windows.Forms.Button();
            this.changeCustomerSeat = new System.Windows.Forms.Button();
            this.removeCustomer = new System.Windows.Forms.Button();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFlightNumber = new System.Windows.Forms.ComboBox();
            this.txtSeatNumber = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFlightList = new System.Windows.Forms.ComboBox();
            this.bsFlight = new System.Windows.Forms.BindingSource(this.components);
            this.bsSeat = new System.Windows.Forms.BindingSource(this.components);
            this.bsFlightList = new System.Windows.Forms.BindingSource(this.components);
            this.bsGrid = new System.Windows.Forms.BindingSource(this.components);
            this.statusLabel = new System.Windows.Forms.Label();
            this.addCustomerFirst = new System.Windows.Forms.Button();
            this.manageCustomers = new System.Windows.Forms.Button();
            this.manageFlights = new System.Windows.Forms.Button();
            this.txtCreateFlight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passengerRows = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.passengerColumns = new System.Windows.Forms.NumericUpDown();
            this.addFlight = new System.Windows.Forms.Button();
            this.removeFlightList = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.removeFlight = new System.Windows.Forms.Button();
            this.bsRemove = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFlightList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Flight";
            // 
            // addCustomer
            // 
            this.addCustomer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer.Location = new System.Drawing.Point(35, 298);
            this.addCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(158, 44);
            this.addCustomer.TabIndex = 3;
            this.addCustomer.Text = "Add Customer";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // changeCustomerSeat
            // 
            this.changeCustomerSeat.Enabled = false;
            this.changeCustomerSeat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeCustomerSeat.Location = new System.Drawing.Point(35, 398);
            this.changeCustomerSeat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.changeCustomerSeat.Name = "changeCustomerSeat";
            this.changeCustomerSeat.Size = new System.Drawing.Size(158, 44);
            this.changeCustomerSeat.TabIndex = 5;
            this.changeCustomerSeat.Text = "Change Customer Seat";
            this.changeCustomerSeat.UseVisualStyleBackColor = true;
            this.changeCustomerSeat.Click += new System.EventHandler(this.changeCustomerSeat_Click);
            // 
            // removeCustomer
            // 
            this.removeCustomer.Enabled = false;
            this.removeCustomer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCustomer.Location = new System.Drawing.Point(35, 448);
            this.removeCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.removeCustomer.Name = "removeCustomer";
            this.removeCustomer.Size = new System.Drawing.Size(158, 44);
            this.removeCustomer.TabIndex = 6;
            this.removeCustomer.Text = "Remove Customer";
            this.removeCustomer.UseVisualStyleBackColor = true;
            this.removeCustomer.Click += new System.EventHandler(this.removeCustomer_Click);
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(35, 93);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFName.MaxLength = 15;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(157, 21);
            this.txtFName.TabIndex = 7;
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(35, 151);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLName.MaxLength = 15;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(157, 21);
            this.txtLName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seat";
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFlightNumber.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightNumber.FormattingEnabled = true;
            this.txtFlightNumber.IntegralHeight = false;
            this.txtFlightNumber.Location = new System.Drawing.Point(35, 202);
            this.txtFlightNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(157, 21);
            this.txtFlightNumber.TabIndex = 10;
            this.txtFlightNumber.SelectedIndexChanged += new System.EventHandler(this.txtFlightNumber_SelectedIndexChanged);
            // 
            // txtSeatNumber
            // 
            this.txtSeatNumber.DropDownHeight = 80;
            this.txtSeatNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSeatNumber.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeatNumber.FormattingEnabled = true;
            this.txtSeatNumber.IntegralHeight = false;
            this.txtSeatNumber.Location = new System.Drawing.Point(35, 254);
            this.txtSeatNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSeatNumber.Name = "txtSeatNumber";
            this.txtSeatNumber.Size = new System.Drawing.Size(157, 21);
            this.txtSeatNumber.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(551, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(362, 373);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(542, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Flight List";
            // 
            // txtFlightList
            // 
            this.txtFlightList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFlightList.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightList.FormattingEnabled = true;
            this.txtFlightList.Location = new System.Drawing.Point(608, 74);
            this.txtFlightList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFlightList.Name = "txtFlightList";
            this.txtFlightList.Size = new System.Drawing.Size(182, 21);
            this.txtFlightList.TabIndex = 14;
            this.txtFlightList.SelectedIndexChanged += new System.EventHandler(this.txtFlightList_SelectedIndexChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(545, 499);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.MaximumSize = new System.Drawing.Size(370, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 15;
            // 
            // addCustomerFirst
            // 
            this.addCustomerFirst.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerFirst.Location = new System.Drawing.Point(35, 348);
            this.addCustomerFirst.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addCustomerFirst.Name = "addCustomerFirst";
            this.addCustomerFirst.Size = new System.Drawing.Size(158, 44);
            this.addCustomerFirst.TabIndex = 16;
            this.addCustomerFirst.Text = "Add Customer to First Available Seat";
            this.addCustomerFirst.UseVisualStyleBackColor = true;
            this.addCustomerFirst.Click += new System.EventHandler(this.addCustomerFirst_Click);
            // 
            // manageCustomers
            // 
            this.manageCustomers.Enabled = false;
            this.manageCustomers.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCustomers.Location = new System.Drawing.Point(35, 499);
            this.manageCustomers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.manageCustomers.Name = "manageCustomers";
            this.manageCustomers.Size = new System.Drawing.Size(158, 44);
            this.manageCustomers.TabIndex = 17;
            this.manageCustomers.Text = "Manage Customers";
            this.manageCustomers.UseVisualStyleBackColor = true;
            this.manageCustomers.Click += new System.EventHandler(this.manageCustomers_Click);
            // 
            // manageFlights
            // 
            this.manageFlights.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageFlights.Location = new System.Drawing.Point(285, 499);
            this.manageFlights.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.manageFlights.Name = "manageFlights";
            this.manageFlights.Size = new System.Drawing.Size(158, 44);
            this.manageFlights.TabIndex = 18;
            this.manageFlights.Text = "Manage Flights";
            this.manageFlights.UseVisualStyleBackColor = true;
            this.manageFlights.Click += new System.EventHandler(this.manageFlights_Click);
            // 
            // txtCreateFlight
            // 
            this.txtCreateFlight.Enabled = false;
            this.txtCreateFlight.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateFlight.Location = new System.Drawing.Point(285, 93);
            this.txtCreateFlight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCreateFlight.MaxLength = 5;
            this.txtCreateFlight.Name = "txtCreateFlight";
            this.txtCreateFlight.Size = new System.Drawing.Size(140, 21);
            this.txtCreateFlight.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(282, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Flight # ( 2 A-Z and 3 numbers)";
            // 
            // passengerRows
            // 
            this.passengerRows.Enabled = false;
            this.passengerRows.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerRows.Location = new System.Drawing.Point(285, 151);
            this.passengerRows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passengerRows.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.passengerRows.Name = "passengerRows";
            this.passengerRows.ReadOnly = true;
            this.passengerRows.Size = new System.Drawing.Size(140, 21);
            this.passengerRows.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(282, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Passenger Rows";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(282, 186);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Passenger Columns";
            // 
            // passengerColumns
            // 
            this.passengerColumns.Enabled = false;
            this.passengerColumns.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerColumns.Location = new System.Drawing.Point(285, 203);
            this.passengerColumns.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passengerColumns.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.passengerColumns.Name = "passengerColumns";
            this.passengerColumns.ReadOnly = true;
            this.passengerColumns.Size = new System.Drawing.Size(140, 21);
            this.passengerColumns.TabIndex = 24;
            // 
            // addFlight
            // 
            this.addFlight.Enabled = false;
            this.addFlight.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFlight.Location = new System.Drawing.Point(285, 254);
            this.addFlight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addFlight.Name = "addFlight";
            this.addFlight.Size = new System.Drawing.Size(158, 42);
            this.addFlight.TabIndex = 25;
            this.addFlight.Text = "Add Flight";
            this.addFlight.UseVisualStyleBackColor = true;
            this.addFlight.Click += new System.EventHandler(this.addFlight_Click);
            // 
            // removeFlightList
            // 
            this.removeFlightList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.removeFlightList.Enabled = false;
            this.removeFlightList.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFlightList.FormattingEnabled = true;
            this.removeFlightList.Location = new System.Drawing.Point(285, 337);
            this.removeFlightList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.removeFlightList.Name = "removeFlightList";
            this.removeFlightList.Size = new System.Drawing.Size(157, 21);
            this.removeFlightList.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(285, 318);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Remove Flight";
            // 
            // removeFlight
            // 
            this.removeFlight.Enabled = false;
            this.removeFlight.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFlight.Location = new System.Drawing.Point(285, 365);
            this.removeFlight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.removeFlight.Name = "removeFlight";
            this.removeFlight.Size = new System.Drawing.Size(158, 40);
            this.removeFlight.TabIndex = 28;
            this.removeFlight.Text = "Remove";
            this.removeFlight.UseVisualStyleBackColor = true;
            this.removeFlight.Click += new System.EventHandler(this.removeFlight_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "Customers";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(311, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Flights";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 569);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.removeFlight);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.removeFlightList);
            this.Controls.Add(this.addFlight);
            this.Controls.Add(this.passengerColumns);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.passengerRows);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCreateFlight);
            this.Controls.Add(this.manageFlights);
            this.Controls.Add(this.manageCustomers);
            this.Controls.Add(this.addCustomerFirst);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.txtFlightList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSeatNumber);
            this.Controls.Add(this.txtFlightNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.removeCustomer);
            this.Controls.Add(this.changeCustomerSeat);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Airline Seat Reservation System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFlightList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Button changeCustomerSeat;
        private System.Windows.Forms.Button removeCustomer;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtFlightNumber;
        private System.Windows.Forms.ComboBox txtSeatNumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtFlightList;
        private System.Windows.Forms.BindingSource bsFlight;
        private System.Windows.Forms.BindingSource bsSeat;
        private System.Windows.Forms.BindingSource bsFlightList;
        private System.Windows.Forms.BindingSource bsGrid;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button addCustomerFirst;
        private System.Windows.Forms.Button manageCustomers;
        private System.Windows.Forms.Button manageFlights;
        private System.Windows.Forms.TextBox txtCreateFlight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown passengerRows;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown passengerColumns;
        private System.Windows.Forms.Button addFlight;
        private System.Windows.Forms.ComboBox removeFlightList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button removeFlight;
        private System.Windows.Forms.BindingSource bsRemove;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

