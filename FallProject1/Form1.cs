using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FallProject1
{
    public partial class Form1 : Form
    {
                                                                       // change the connection string if prog37721 is in the D: drive
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private SqlDataAdapter da = null;
        private DataSet ds = null;
        private string sql = "";
        //string connStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\prog37721\\FallProject1\\FallProject1\\Flight.mdf;Integrated Security=True";
        string connStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=D:\\prog37721\\FallProject1\\FallProject1\\Flight.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            setControlState("add");
            getFlightList(txtFlightList, bsFlightList);
            getFlightList(txtFlightNumber, bsFlight);
            getFlightList(removeFlightList, bsRemove);
            dataGridView1.Click += dataGridView1_Click;
            txtFName.KeyDown += txtFName_KeyDown;
            txtLName.KeyDown += txtLName_KeyDown;
            txtSeatNumber.KeyDown += txtSeatNumber_KeyDown;
            txtFlightList.KeyDown += txtFlightList_KeyDown;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            changeCustomerSeat.KeyDown += changeCustomerSeat_KeyDown;
            removeCustomer.KeyDown += removeCustomer_KeyDown;
            txtFName.KeyPress += txtFName_KeyPress;
            txtLName.KeyPress += txtLName_KeyPress;
            txtCreateFlight.KeyPress += txtCreateFlight_KeyPress;
            txtFName.ContextMenuStrip = new ContextMenuStrip();
            txtLName.ContextMenuStrip = new ContextMenuStrip();
            txtCreateFlight.ContextMenuStrip = new ContextMenuStrip();
            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[0].HeaderText = "Seat";
            dataGridView1.Columns[1].HeaderText = "First Name";
            dataGridView1.Columns[2].HeaderText = "Last Name";

            
        }

        private void getFlightList(ComboBox box, BindingSource bs)     // populates the flight combo boxes with flight numbers
        {
            try
            {
                conn = new SqlConnection(connStr);
                cmd = new SqlCommand();
                sql = "SELECT name FROM [sysobjects] WHERE xtype = 'u' ORDER BY crdate ASC";
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                da = new SqlDataAdapter(sql, conn);    
                ds = new DataSet();
                da.Fill(ds, "sysobjects");
                conn.Close();
                bs.DataSource = ds;
                bs.DataMember = "sysobjects";
                box.DataSource = bs;
                box.DisplayMember = "name";
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Reading Data",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getSeatList(string flight) // populates the seats combo box with the seats of the flight selected
        {
            if (flight != "" && flight != "System.Data.DataRowView")
            {
                try
                {
                    conn = new SqlConnection(connStr);
                    cmd = new SqlCommand();
                    sql = "SELECT seat FROM [" + flight + "]";
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    da = new SqlDataAdapter(sql, conn);       
                    ds = new DataSet();
                    da.Fill(ds, flight);
                    conn.Close();
                    bsSeat.DataSource = ds;
                    bsSeat.DataMember = flight;
                    txtSeatNumber.DataSource = bsSeat;
                    txtSeatNumber.DisplayMember = "seat";
                }
                catch (SqlException ex)
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                    MessageBox.Show(ex.Message, "Error Reading Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void getFlightData(string flight)  // populates the grid view with details of the flight selected
        {
            if (flight != "" && flight != "System.Data.DataRowView")
            {
                try
                {
                    conn = new SqlConnection(connStr);
                    cmd = new SqlCommand();
                    sql = "SELECT * FROM [" + flight + "]";
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    da = new SqlDataAdapter(sql, conn);      
                    ds = new DataSet();
                    da.Fill(ds, flight);
                    conn.Close();
                    bsGrid.DataSource = ds;
                    bsGrid.DataMember = flight;
                    dataGridView1.DataSource = bsGrid;
                    dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dataGridView1.Columns[0].HeaderText = "Seat";
                    dataGridView1.Columns[1].HeaderText = "First Name";
                    dataGridView1.Columns[2].HeaderText = "Last Name";
                }
                catch (SqlException ex)
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                    MessageBox.Show(ex.Message, "Error Reading Data");
                }
            }              
        }

        private void addCustomer_Click(object sender, EventArgs e)          //assigns customer to selected seat in the selected flight
        {
            string table = txtFlightNumber.GetItemText(txtFlightNumber.SelectedItem);
            if (customerDataGood())
            {
                if (customerNotRegistered(table))
                {
                    if (seatNotRegistered(table))
                    {
                        try
                        {
                            sql = "UPDATE [" + table + "] SET [firstname] = '" + txtFName.Text + "', [lastname] = '" + txtLName.Text + "'  WHERE [seat] = '" + txtSeatNumber.GetItemText(txtSeatNumber.SelectedItem) + "'";
                            conn = new SqlConnection(connStr);
                            cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = sql;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            clearText();
                            getFlightData(txtFlightList.GetItemText(txtFlightList.SelectedItem));
                            MessageBox.Show("Customer successfully assigned to seat " + txtSeatNumber.GetItemText(txtSeatNumber.SelectedItem), "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message, "Error Inserting Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seat already taken, please choose another one", "Seat Already Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Customer already registered in this flight", "Customer Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addCustomerFirst_Click(object sender, EventArgs e)  //assigns customer to first available seat in the selected flight
        {
            string table = txtFlightNumber.GetItemText(txtFlightNumber.SelectedItem);
            string seat = "";
            if(customerDataGood())
            {
                if (customerNotRegistered(table))
                {
                    try
                    {
                        sql = "SELECT * FROM [" + table + "]";
                        conn = new SqlConnection(connStr);
                        cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = sql;
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                if (dr.SafeGetString(1) == "" && dr.SafeGetString(2) == "")
                                {
                                    seat = dr.SafeGetString(0);
                                    break;
                                }
                            }
                        }
                        conn.Close();
                        if (seat == "")
                        {
                            MessageBox.Show("All seats in this flight are already taken. Please choose another flight.", "All Seats Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            sql = "UPDATE [" + table + "] SET [firstname] = '" + txtFName.Text + "', [lastname] = '" + txtLName.Text + "'  WHERE [seat] = '" + seat + "'";
                            conn = new SqlConnection(connStr);
                            cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = sql;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            clearText();
                            getFlightData(txtFlightList.GetItemText(txtFlightList.SelectedItem));
                            MessageBox.Show("Customer successfully assigned to seat " + seat, "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error Inserting Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Customer already registered in this flight", "Customer Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }

        private void changeCustomerSeat_Click(object sender, EventArgs e)    // changes the selected customer's seat selection
        {
            string table = txtFlightList.GetItemText(txtFlightList.SelectedItem);
            if (customerDataGood())
            {
                if (txtSeatNumber.GetItemText(txtSeatNumber.SelectedItem) != dataGridView1.CurrentRow.Cells[0].Value.ToString())
                {
                    if (seatNotRegistered(table))
                    {
                        try
                        {
                            string origCell = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                            sql = "UPDATE [" + table + "] SET [firstname] = '', [lastname] = ''  WHERE [firstname] = '" + txtFName.Text + "' AND [lastname] = '" + txtLName.Text + "'; UPDATE [" + table + "] SET [firstname] = '" + txtFName.Text + "', [lastname] = '" + txtLName.Text + "' WHERE [seat]= '" + txtSeatNumber.GetItemText(txtSeatNumber.SelectedItem) + "'";
                            conn = new SqlConnection(connStr);
                            cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = sql;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            getFlightData(txtFlightList.GetItemText(txtFlightList.SelectedItem));
                            dataGridView1.CurrentCell = dataGridView1.Rows[txtSeatNumber.SelectedIndex].Cells[0]; 
                            MessageBox.Show("Customer successfully reassigned from seat " + origCell + " to seat " + txtSeatNumber.GetItemText(txtSeatNumber.SelectedItem), "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message, "Error Inserting Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seat already taken, please choose another one", "Seat Already Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This is the same seat!", "Same Seat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void removeCustomer_Click(object sender, EventArgs e)    // remove the selected customer
        {
            string table = txtFlightList.GetItemText(txtFlightList.SelectedItem);
            try
            {
                sql = "UPDATE [" + table + "] SET [firstname] = '', [lastname] = ''  WHERE [firstname] = '" + txtFName.Text + "' AND [lastname] = '" + txtLName.Text + "'";
                conn = new SqlConnection(connStr);
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                clearText();
                getFlightData(txtFlightList.GetItemText(txtFlightList.SelectedItem));
                MessageBox.Show("Customer successfully removed", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setControlState("add");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error Inserting Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addFlight_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(passengerRows.Value.ToString());
            int cols = Convert.ToInt32(passengerColumns.Value.ToString());
            if (flightDataGood())
            {
                if (txtFlightList.Items.Count < 10)
                {
                    if (checkRowColSize())
                    {
                        if (flightNotRegistered())
                        {
                            try
                            {
                                sql = "CREATE TABLE [" + txtCreateFlight.Text + "] ([seat] VARCHAR (2)  NOT NULL, [firstname] VARCHAR (15) NULL, [lastname]  VARCHAR (15) NULL, PRIMARY KEY CLUSTERED ([seat]ASC));";
                                conn = new SqlConnection(connStr);
                                cmd = new SqlCommand();
                                cmd.Connection = conn;
                                cmd.CommandText = sql;
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                for (char c = 'A'; c < 65 + Convert.ToInt32(passengerRows.Value.ToString()); c++)
                                {
                                    for (int i = 1; i < 1 + Convert.ToInt32(passengerColumns.Value.ToString()); i++)
                                    {
                                        string sql2 = "INSERT INTO [" + txtCreateFlight.Text + "] ([seat], [firstname], [lastname]) VALUES ('" + c + i + "', '', '')";
                                        cmd.CommandText = sql2;
                                        conn.Open();
                                        cmd.ExecuteNonQuery();
                                        conn.Close();
                                    }
                                }
                                clearText();
                                getFlightList(txtFlightList, bsFlightList);
                                getFlightList(txtFlightNumber, bsFlight);
                                getFlightList(removeFlightList, bsRemove);
                                getSeatList(txtFlightNumber.Text);
                                getFlightData(txtFlightList.Text);
                                MessageBox.Show("Flight added to the list", "Flight Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.Message, "Error Creating Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Flight already exists. Please choose another name", "Error Creating Flight", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Too many flights in the list. Remove flights if you want to add more", "Too Many Flights", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void removeFlight_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to remove the flight from the list? You'll also lose the customer list attached to it.", "Remove Flight from List", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                if (removeFlightList.Items.Count > 1)
                {
                    try
                    {
                        sql = "DROP TABLE [" + removeFlightList.GetItemText(removeFlightList.SelectedItem) + "]";
                        conn = new SqlConnection(connStr);
                        cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = sql;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        clearText();
                        getFlightList(txtFlightList, bsFlightList);
                        getFlightList(txtFlightNumber, bsFlight);
                        getFlightList(removeFlightList, bsRemove);
                        getSeatList(txtFlightNumber.Text);
                        getFlightData(txtFlightList.Text);
                        MessageBox.Show("Flight removed from the list", "Flight Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error Deleting Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You can't delete all flights. Please create another flight so you can delete this one", "Error Deleting Flight", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void manageCustomers_Click(object sender, EventArgs e)
        {
            setControlState("add");
            clearText();
        }

        private void manageFlights_Click(object sender, EventArgs e)
        {
            setControlState("manageF");
            clearText();
        }

        void dataGridView1_Click(object sender, EventArgs e)
        {
            txtFlightNumber.SelectedIndex = txtFlightList.SelectedIndex;
            txtSeatNumber.SelectedIndex = dataGridView1.CurrentRow.Index;
            if (dataGridView1.CurrentRow.Cells[1].Value.ToString() != "" && dataGridView1.CurrentRow.Cells[2].Value.ToString() != "")
            {
                setControlState("change");
                txtFName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtLName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            else if (txtFName.Enabled == false)
            {
                setControlState("add");
            }
        }

        private void clearText()
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtCreateFlight.Text = "";
            if (txtFName.Enabled)
            {
                txtFName.Focus();
            }
            if (txtCreateFlight.Enabled)
            {
                txtCreateFlight.Focus();
            }
            txtFName.Focus();
            dataGridView1.ClearSelection();
        }

        private void setControlState(string state)
        {
            if (state.Equals("add"))
            {
                clearText();
                statusLabel.Text = "Click on an existing passenger to be able to change seats or remove passengers";
                addCustomer.Enabled = true;
                addCustomerFirst.Enabled = true;
                changeCustomerSeat.Enabled = false;
                removeCustomer.Enabled = false;
                txtFlightNumber.Enabled = true;
                txtSeatNumber.Enabled = true;
                txtFName.Enabled = true;
                txtLName.Enabled = true;
                txtFName.Select();
                txtCreateFlight.Enabled = false;
                passengerRows.Enabled = false;
                passengerColumns.Enabled = false;
                manageCustomers.Enabled = false;
                manageFlights.Enabled = true;
                removeFlight.Enabled = false;
                removeFlightList.Enabled = false;
                addFlight.Enabled = false;
            }
            else if (state.Equals("change"))
            {
                statusLabel.Text = "Press ESC or click on an empty cell to be able to add a passenger again";
                addCustomer.Enabled = false;
                addCustomerFirst.Enabled = false;
                changeCustomerSeat.Enabled = true;
                removeCustomer.Enabled = true;
                txtFName.Enabled = false;
                txtLName.Enabled = false;
                txtFlightNumber.Enabled = false;
                txtSeatNumber.Enabled = true;
                txtCreateFlight.Enabled = false;
                passengerRows.Enabled = false;
                passengerColumns.Enabled = false;
                manageFlights.Enabled = true;
                manageCustomers.Enabled = false;
                removeFlight.Enabled = false;
                removeFlightList.Enabled = false;
                addFlight.Enabled = false;
            }
            else if (state.Equals("manageF"))
            {
                statusLabel.Text = "Click on Manage Customers or click on an empty cell to be able to add passengers again";
                txtCreateFlight.Enabled = true;
                passengerRows.Enabled = true;
                passengerColumns.Enabled = true;
                manageFlights.Enabled = false;
                removeFlight.Enabled = true;
                removeFlightList.Enabled = true;
                addFlight.Enabled = true;
                manageCustomers.Enabled = true;
                addCustomer.Enabled = false;
                addCustomerFirst.Enabled = false;
                changeCustomerSeat.Enabled = false;
                removeCustomer.Enabled = false;
                txtFName.Enabled = false;
                txtLName.Enabled = false;
                txtFlightNumber.Enabled = false;
                txtSeatNumber.Enabled = false;
            }
        }

        void txtLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int len = ((TextBox)sender).Text.Length;
            ((TextBox)sender).SelectionStart = len;
            if (c != 8)
            {
                if ((c < 65 || c > 90) && (c < 97 || c > 122))
                {
                    e.Handled = true;
                }
                else if (len == 0 && (c > 96 && c < 123))
                {
                    e.KeyChar = (char)(c - 32); 
                }
                else if (len > 0 && (c > 64 && c < 90))
                {
                    e.KeyChar = (char)(c + 32); 
                }
            }
        }

        void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int len = ((TextBox)sender).Text.Length;
            ((TextBox)sender).SelectionStart = len;
            if (c != 8)
            {
                if ((c < 65 || c > 90) && (c < 97 || c > 122))
                {
                    e.Handled = true;
                }
                else if (len == 0 && (c > 96 && c < 123))
                {
                    e.KeyChar = (char)(c - 32);
                }
                else if (len > 0 && (c > 64 && c < 90))
                {
                    e.KeyChar = (char)(c + 32);
                }
            }
        }


        void txtCreateFlight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int len = ((TextBox)sender).Text.Length;
            ((TextBox)sender).SelectionStart = len;
            if (c != 8)
            {
                if (len < 2)
                {
                    if (c < 65 || c > 90)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (c < 48 || c > 57)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                setControlState("add");
            }
        }

        void txtLName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                setControlState("add");
            }
        }

        void txtFName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                setControlState("add");
            }
        }

        void txtSeatNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                setControlState("add");
            }
        }

        void txtFlightList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                setControlState("add");
            }
        }

        void removeCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                setControlState("add");
            }
        }

        void changeCustomerSeat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                setControlState("add");
            }
        }

        private void txtFlightNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            getSeatList(txtFlightNumber.GetItemText(txtFlightNumber.SelectedItem));
        }

        private void txtFlightList_SelectedIndexChanged(object sender, EventArgs e)
        {
            getFlightData(txtFlightList.GetItemText(txtFlightList.SelectedItem));
        }

        private void txtFlightNumber_SelectedValueChanged(object sender, EventArgs e)
        {
            getSeatList(txtFlightNumber.GetItemText(txtFlightNumber.SelectedItem));
        }

        private void txtFlightList_SelectedValueChanged(object sender, EventArgs e)
        {
            getFlightData(txtFlightList.GetItemText(txtFlightList.SelectedItem));
        }

        private bool customerDataGood()
        {
            if (txtFName.Text.Length < 1)
            {
                MessageBox.Show("First name required", "First Name Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtFName.Text.Length < 2)
            {
                MessageBox.Show("First name must be at least two characters", "First Name Too Short", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtLName.Text.Length < 1)
            {
                MessageBox.Show("Last name required", "Last Name Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtLName.Text.Length < 2)
            {
                MessageBox.Show("Last name must be at least two characters", "Last Name Too Short", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtFlightNumber.GetItemText(txtFlightNumber.SelectedItem).Length < 1)
            {
                MessageBox.Show("Select a valid flight", "Invalid Flight", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtSeatNumber.GetItemText(txtSeatNumber.SelectedItem).Length < 1)
            {
                MessageBox.Show("Select a valid seat", "Invalid Seat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool flightDataGood()
        {
            if (txtCreateFlight.Text.Length < 1)
            {
                MessageBox.Show("Flight name required", "Flight Name Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtCreateFlight.Text.Length < 5)
            {
                MessageBox.Show("Flight name must be 5 characters long", "Flight Name Too Short", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool customerNotRegistered(string table)
        {
            sql = "SELECT * FROM [" + table + "]";
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                  //  if(txtSeatNumber.GetItemText(txtSeatNumber.SelectedItem) == dr.SafeGetString)
                    if (txtFName.Text == dr.SafeGetString(1) && txtLName.Text == dr.SafeGetString(2))
                    {
                        conn.Close();
                        return false;
                    }
                }
            }
            conn.Close();
            return true;
        }

        private bool seatNotRegistered(string table)
        {
            sql = "SELECT * FROM [" + table + "]";
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if(txtSeatNumber.GetItemText(txtSeatNumber.SelectedItem) == dr.SafeGetString(0) && dr.SafeGetString(1) != "" && dr.SafeGetString(2) != "")
                    {
                        conn.Close();
                        return false;
                    }
                }
            }
            conn.Close();
            return true;
        }

        private bool flightNotRegistered()
        {
            sql = "SELECT name FROM [sysobjects] WHERE xtype = 'u'";
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (txtCreateFlight.Text == dr.SafeGetString(0))
                    {
                        conn.Close();
                        return false;
                    }
                }
            }
            conn.Close();
            return true;
        }

        private bool checkRowColSize()
        {
            if (Convert.ToInt32(passengerRows.Value.ToString()) < 3)
            {
                MessageBox.Show("There must be at least 3 passenger rows", "Too Few Rows", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Convert.ToInt32(passengerColumns.Value.ToString()) < 2)
            {
                MessageBox.Show("There must be at least 2 passenger rows", "Too Few Columns", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }

    static class customExtension                // this one turns null database entries into empty fields. Not really necessary, just a precaution, as the                                                                              sqldatareader.getstring method hates null entries 
    {
        public static string SafeGetString(this SqlDataReader reader, int columnIndex)
        {
            if (!reader.IsDBNull(columnIndex))
            {
                return reader.GetString(columnIndex);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
