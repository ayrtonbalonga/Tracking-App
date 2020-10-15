using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tracking_Soft_v2
{
    public partial class TripManager : UserControl
    {
        public TripManager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((tripDate.Value.Date == null) || (tbCustomerId.Text == "") || (cbVehicle.Text == "") || (cbDriver.Text == "") || (tbDestinationCity.Text == "") || (tbDepartureCity.Text == "") || (tbTripFuel.Text == "") || (cbCargo.Text == ""))
            {
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                insertTrip();
                showTripGrid();
            }
            cbCargo.Text = null;
            tbTripFuel.Text = null;
            tbDepartureCity.Text = null;
            tbDestinationCity.Text = null;
            cbDriver.Text = null;
            cbVehicle.Text = null;
            tbCustomerId.Text = null;
            tripDate.Value = DateTime.Today;
        }

        private void insertTrip()
        {
            string orderNum = "";
            int tripId = 0;
            try
            {
                orderNum = generateOrder();
                TalkDB_T.con.Open();

                String sqlInsert = "insert into Trip(tripDate, orderNum, vehicle, driver, departureCity, destinationCity, tripFuel, customerId, cargoType) " +
                    "Values" +
                    "(@tripDate, @orderNum, @vehicle, @driver, @departureCity, @destinationCity, @tripFuel, @customerId, @cargoType)";


                SqlCommand commad = new SqlCommand(sqlInsert, TalkDB_T.con);

                commad.Parameters.AddWithValue("@tripDate", tripDate.Value.Date);
                commad.Parameters.AddWithValue("@orderNum", orderNum);
                commad.Parameters.AddWithValue("@vehicle", cbVehicle.Text);
                commad.Parameters.AddWithValue("@driver", cbDriver.Text);
                commad.Parameters.AddWithValue("@departureCity", tbDepartureCity.Text);
                commad.Parameters.AddWithValue("@destinationCity", tbDestinationCity.Text);
                commad.Parameters.AddWithValue("@tripFuel", tbTripFuel.Text);
                commad.Parameters.AddWithValue("@customerId", tbCustomerId.Text);
                commad.Parameters.AddWithValue("@cargoType", cbCargo.Text);

                commad.ExecuteNonQuery();
                TalkDB_T.con.Close();

                MessageBox.Show("The trip have been saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





            //INSERT INTO Customer_Order ==================================================================
            try
            {
                tripId = getTripId();

                TalkDB_T.con.Open();

                String sqlInsert = "insert into Customer_Order(customerId, orderNum, tripId) " +
                    "Values" +
                    "(@customerId, @orderNum, @tripId)";


                SqlCommand commad = new SqlCommand(sqlInsert, TalkDB_T.con);

                commad.Parameters.AddWithValue("@customerId", tbCustomerId.Text);
                commad.Parameters.AddWithValue("@orderNum", orderNum);
                commad.Parameters.AddWithValue("@tripId", tripId);

                commad.ExecuteNonQuery();
                TalkDB_T.con.Close();

                //MessageBox.Show("The Customer has been saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string generateOrder()
        {
            string orderNum = "";

            //count number of record
            string command = "SELECT COUNT(tripId) FROM Trip";
            SqlCommand cmd = new SqlCommand(command, TalkDB_T.con);

            TalkDB_T.con.Open();
            string count = cmd.ExecuteScalar().ToString();
            TalkDB_T.con.Close();

            int numOfRecord = Convert.ToInt32(count);
            numOfRecord += 1;

            //OrderNUm Dynamicly generated
            if (numOfRecord < 10)
            {
                orderNum = "CM000" + numOfRecord;
            }
            else
            {
                if (numOfRecord >= 10)
                {
                    orderNum = "CM00" + numOfRecord;
                }
                else
                {
                    if (numOfRecord >= 100)
                    {
                        orderNum = "CM0" + numOfRecord;
                    }
                    else
                    {
                        if (numOfRecord >= 1000)
                        {
                            orderNum = "CM" + numOfRecord;
                        }
                    }
                }
            }
            return orderNum;
        }

        private int getTripId()
        {
            int tripId = 0;
            int numOfRecord = 0;

            //count number of record and Get the last row
            string command = "SELECT COUNT(tripId) FROM Trip";
            SqlCommand cmd = new SqlCommand(command, TalkDB_T.con);

            TalkDB_T.con.Open();
            string count = cmd.ExecuteScalar().ToString();
            TalkDB_T.con.Close();

            //Last row of the Table
            numOfRecord = Convert.ToInt32(count);
            //numOfRecord += 1;



            #region DeadCode
            //WITH TABLE1 AS
            //(
            //SELECT LECT_NAME, LECT_ID, ROW_NUMBER() OVER(ORDER BY LECT_ID) AS ROWNUM
            //FROM LECTURERS
            //)
            //SELECT* FROM TABLE1 WHERE ROWNUM = 2;



            //string cmm = string.Format("WITH TABLE1 AS " +
            //                           "(" +
            //                           "SELECT TripId, ROW_NUMBER() OVER(ORDER BY TripId) AS ROWNUM " +
            //                           "FROM TRIP" +
            //                           ")" +
            //                           "SELECT* FROM TABLE1 WHERE ROWNUM = {0}",
            //                           numOfRecord);
            #endregion



            //-->>  get ID at a specific row
            //command = string.Format("SELECT tripId FROM Trip WHERE tripId = {0}", numOfRecord);
            command = string.Format("WITH TABLE1 AS " +
                                       "(" +
                                       "SELECT TripId, ROW_NUMBER() OVER(ORDER BY TripId) AS ROWNUM " +
                                       "FROM TRIP" +
                                       ")" +
                                       "SELECT* FROM TABLE1 WHERE ROWNUM = {0}",
                                       numOfRecord);
            cmd = new SqlCommand(command, TalkDB_T.con);

            TalkDB_T.con.Open();
            string myId = cmd.ExecuteScalar().ToString();
            TalkDB_T.con.Close();

            tripId = Convert.ToInt32(myId);

            return tripId;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if ((tbCustName.Text == "") || (tbEmail.Text == "") || (tbPhoneNum.Text == ""))
            {
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                insertCustomer();
                showCustomerGrid();
            }
            tbCustName.Text = null;
            tbEmail.Text = null;
            tbPhoneNum.Text = null;
        }

        private void insertCustomer()
        {
            try
            {
                TalkDB_T.con.Open();

                String sqlInsert = "insert into Customer(customerFullName, customerPhoneNum, customerEmail) " +
                    "Values" +
                    "(@customerFullName, @customerPhoneNum, @customerEmail)";


                SqlCommand commad = new SqlCommand(sqlInsert, TalkDB_T.con);

                commad.Parameters.AddWithValue("@customerFullName", tbCustName.Text);
                commad.Parameters.AddWithValue("@customerPhoneNum", tbPhoneNum.Text);
                commad.Parameters.AddWithValue("@customerEmail", tbEmail.Text);

                commad.ExecuteNonQuery();
                TalkDB_T.con.Close();

                MessageBox.Show("The Customer has been saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showCustomerGrid()
        {
            TalkDB_T.con.Open();

            SqlCommand cmd = TalkDB_T.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * country from Testing";
            //cmd.CommandText = "select customerFullName, customerPhoneNum, customerEmail from Customer";
            cmd.CommandText = "select * from Customer";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridTrip.DataSource = dt;

            TalkDB_T.con.Close();
        }

        private void showTripGrid()
        {
            TalkDB_T.con.Open();

            SqlCommand cmd = TalkDB_T.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * country from Testing";

            //cmd.CommandText = "select orderNum, tripDate, vehicle, driver, departureCity, destinationCity, tripFuel, customerId, cargoType from Trip " +
            //                    "ORDER BY tripDate DESC";

            cmd.CommandText = "select * from Trip ORDER BY tripDate DESC";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridTrip.DataSource = dt;

            TalkDB_T.con.Close();
        }

        private void TripManager_Load(object sender, EventArgs e)
        {
            showTripGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((tripDate.Value.Date == null) || (tbCustomerId.Text == "") || (cbVehicle.Text == "") || (cbDriver.Text == "") || (tbDestinationCity.Text == "") || (tbDepartureCity.Text == "") || (tbTripFuel.Text == "") || (cbCargo.Text == "") || (tbSearchTrip.Text == ""))
            {
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                updateTrip();
                showTripGrid();
            }
            cbCargo.Text = null;
            tbTripFuel.Text = null;
            tbDepartureCity.Text = null;
            tbDestinationCity.Text = null;
            cbDriver.Text = null;
            cbVehicle.Text = null;
            tbCustomerId.Text = null;
            tripDate.Value = DateTime.Today;
            tbSearchTrip.Text = null;
        }

        private void updateTrip()
        {
            try
            {
                //open connection 
                TalkDB_T.con.Open();

                String sqlUpdate = "UPDATE Trip " +
                                   "SET tripDate = @tripDate, vehicle = @vehicle, driver = @driver, departureCity = @departureCity, destinationCity = @destinationCity, tripFuel = @tripFuel, customerId = @customerId, cargoType = @cargoType " +
                                   "WHERE orderNum = @orderNum";


                SqlCommand commad = new SqlCommand(sqlUpdate, TalkDB_T.con);

                commad.Parameters.AddWithValue("@orderNum", tbSearchTrip.Text);
                commad.Parameters.AddWithValue("@tripDate", tripDate.Value.Date);
                commad.Parameters.AddWithValue("@vehicle", cbVehicle.Text);
                commad.Parameters.AddWithValue("@driver", cbDriver.Text);
                commad.Parameters.AddWithValue("@departureCity", tbDepartureCity.Text);
                commad.Parameters.AddWithValue("@destinationCity", tbDestinationCity.Text);
                commad.Parameters.AddWithValue("@tripFuel", tbTripFuel.Text);
                commad.Parameters.AddWithValue("@customerId", tbCustomerId.Text);
                commad.Parameters.AddWithValue("@cargoType", cbCargo.Text);

                commad.ExecuteNonQuery();
                TalkDB_T.con.Close();

                MessageBox.Show("The Trip has been updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateCust_Click(object sender, EventArgs e)
        {
            if ((tbCustName.Text == "") || (tbEmail.Text == "") || (tbPhoneNum.Text == "") || (tbSearchCustomer.Text == ""))
            {
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                updateCustomer();
                showCustomerGrid();
            }
            tbCustName.Text = null;
            tbEmail.Text = null;
            tbPhoneNum.Text = null;
            tbSearchCustomer.Text = null;
        }

        public void updateCustomer()
        {
            try
            {
                //open connection 
                TalkDB_T.con.Open();

                String sqlUpdate = "UPDATE Customer " +
                                   "SET customerFullName = @customerFullName, customerPhoneNum = @customerPhoneNum, customerEmail = @customerEmail " +
                                   "WHERE customerId = @customerId";


                SqlCommand commad = new SqlCommand(sqlUpdate, TalkDB_T.con);

                commad.Parameters.AddWithValue("@customerId", Convert.ToInt32(tbSearchCustomer.Text));
                commad.Parameters.AddWithValue("@customerFullName", tbCustName.Text);
                commad.Parameters.AddWithValue("@customerPhoneNum", tbPhoneNum.Text);
                commad.Parameters.AddWithValue("@customerEmail", tbEmail.Text);

                commad.ExecuteNonQuery();
                TalkDB_T.con.Close();

                MessageBox.Show("The Customer has been updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelCust_Click(object sender, EventArgs e)
        {
            if (tbSearchCustomer.Text == "")
            {
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                delCustomer();
                showCustomerGrid();
            }

            tbCustName.Text = null;
            tbEmail.Text = null;
            tbPhoneNum.Text = null;
            tbSearchCustomer.Text = null;
        }

        public void delCustomer()
        {
            try
            {
                TalkDB_T.con.Open();
                string Delete = string.Format("delete from Customer where customerId = {0}", Convert.ToInt32(tbSearchCustomer.Text));

                SqlDataAdapter cmd = new SqlDataAdapter(Delete, TalkDB_T.con);
                cmd.SelectCommand.ExecuteNonQuery();
                TalkDB_T.con.Close();




                TalkDB_T.con.Open();
                Delete = string.Format("delete from Customer_Order where customerId = {0}", Convert.ToInt32(tbSearchCustomer.Text));

                cmd = new SqlDataAdapter(Delete, TalkDB_T.con);
                cmd.SelectCommand.ExecuteNonQuery();
                TalkDB_T.con.Close();





                TalkDB_T.con.Open();
                Delete = string.Format("delete from Trip where customerId = {0}", Convert.ToInt32(tbSearchCustomer.Text));

                cmd = new SqlDataAdapter(Delete, TalkDB_T.con);
                cmd.SelectCommand.ExecuteNonQuery();
                TalkDB_T.con.Close();

                MessageBox.Show("Record deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void delTrip()
        {
            try
            {
                // int id = Int32.Parse(IdtextBox.Text);
                TalkDB_T.con.Open();
                string Delete = string.Format("delete from Customer_Order where orderNum = '{0}'", tbSearchTrip.Text);

                SqlDataAdapter cmd = new SqlDataAdapter(Delete, TalkDB_T.con);
                cmd.SelectCommand.ExecuteNonQuery();
                TalkDB_T.con.Close();




                TalkDB_T.con.Open();
                Delete = string.Format("delete from trip where orderNum = '{0}'", tbSearchTrip.Text);

                cmd = new SqlDataAdapter(Delete, TalkDB_T.con);
                cmd.SelectCommand.ExecuteNonQuery();
                TalkDB_T.con.Close();

                MessageBox.Show("The Trip has been Deleted Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbSearchTrip.Text == "")
            {
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                delTrip();
                showTripGrid();
            }
            cbCargo.Text = null;
            tbTripFuel.Text = null;
            tbDepartureCity.Text = null;
            tbDestinationCity.Text = null;
            cbDriver.Text = null;
            cbVehicle.Text = null;
            tbCustomerId.Text = null;
            tripDate.Value = DateTime.Today;
            tbSearchTrip.Text = null;
        }

        private void btnSearchTrip_Click(object sender, EventArgs e)
        {
            if (tbSearchTrip.Text == "")
            {
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                TalkDB_T.con.Open();

                SqlCommand cmd = TalkDB_T.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "select * country from Testing";

                //cmd.CommandText = "select orderNum, tripDate, vehicle, driver, departureCity, destinationCity, tripFuel, customerId, cargoType from Trip " +
                //                    "ORDER BY tripDate DESC";

                //cmd.CommandText = string.Format("select * from Trip Where TripId = {0}", Convert.ToInt32(tbSearchTrip.Text)); 
                cmd.CommandText = string.Format("select * from Trip Where orderNum = '{0}'", tbSearchTrip.Text);
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridTrip.DataSource = dt;

                TalkDB_T.con.Close();
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            if (tbSearchCustomer.Text == "")
            {
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                TalkDB_T.con.Open();

                SqlCommand cmd = TalkDB_T.con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = string.Format("select * from Customer Where customerId = {0}", Convert.ToInt32(tbSearchCustomer.Text));
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridTrip.DataSource = dt;

                TalkDB_T.con.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainForm.switcher.Controls.Remove(MainForm.tripManager);
            MainForm.switcher.Hide();
            //MainForm.switcher.Close();
            MainForm.login.Show();
        }

        private void cbVehicle_DropDown(object sender, EventArgs e)
        {
            try
            {
                //  --->>>  Getting all records on the comboBox
                string command = "SELECT * FROM VehicleInfo";
                SqlDataAdapter da = new SqlDataAdapter(command, TalkDB_T.con);//    --->>>  DataAdapter connect & fills the DataSet with the Db
                DataSet ds = new DataSet();
                da.Fill(ds, "dsVehicle");

                cbVehicle.DataSource = ds.Tables["dsVehicle"].DefaultView;
                cbVehicle.DisplayMember = ds.Tables["dsVehicle"].Columns["Manufacturer"].ToString();
                cbVehicle.ValueMember = ds.Tables["dsVehicle"].Columns["VehicleID"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbDriver_DropDown(object sender, EventArgs e)
        {
            try
            {
                //  --->>>  Getting all records on the comboBox
                string command = "SELECT * FROM LoginT Where role = 'Drivers'";
                SqlDataAdapter da = new SqlDataAdapter(command, TalkDB_T.con);//    --->>>  DataAdapter connect & fills the DataSet with the Db
                DataSet ds = new DataSet();
                da.Fill(ds, "dsDriver");

                cbDriver.DataSource = ds.Tables["dsDriver"].DefaultView;
                cbDriver.DisplayMember = ds.Tables["dsDriver"].Columns["Firstname"].ToString();
                cbDriver.ValueMember = ds.Tables["dsDriver"].Columns["LoginId"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbShowTrip_Click(object sender, EventArgs e)
        {
            showTripGrid();
        }

        private void btShowCustomer_Click(object sender, EventArgs e)
        {
            TalkDB_T.con.Open();

            SqlCommand cmd = TalkDB_T.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * country from Testing";

            //cmd.CommandText = "select orderNum, tripDate, vehicle, driver, departureCity, destinationCity, tripFuel, customerId, cargoType from Trip " +
            //                    "ORDER BY tripDate DESC";

            cmd.CommandText = "select * from Customer";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridTrip.DataSource = dt;

            TalkDB_T.con.Close();
        }

        private void tbFrom_KeyPress_Text_WhiteSpace(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void tbTo_KeyPress_Text_WhiteSpace(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;

            }

        }

        private void tbFuel_KeyPress_Number_Commas(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;

            }
        }

        private void tbName_KeyPress_Text_WhiteSpace(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;

            }

        }

        private void tbEmail_KeyPress_Text_Number_At_Comma(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != '@') && (e.KeyChar != ','))
            {
                e.Handled = true;

            }



        }
    }
}
