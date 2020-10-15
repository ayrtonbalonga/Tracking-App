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
    public partial class ServiceManager : UserControl
    {
        TalkDB_T db = new TalkDB_T();
        public String ServiceId = "";
        public ServiceManager()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((cbServiceType.Text == "") || (dtDate.Text == "") || (cbVehicleId.Text == "") || (cbMechanicId.Text == "") || (rtDescription.Text == ""))
            {
                MessageBox.Show("Please make sure that all the fields are not empty");
            }
            else
            {

                insertService();
                CollectData();

            }

        }

        public void insertService()
        {

            try
            {
                TalkDB_T.con.Open();


                String sqlInsert = "insert into Service (VehicleId,Date,MechanicId,serviceType, ServiceDescription) " +
                    "Values" +
                    "(@vehicleId,@Date,@MechanicId,@serviceType,@ServiceDescription)";

                SqlCommand commad = new SqlCommand(sqlInsert, TalkDB_T.con);

                commad.Parameters.AddWithValue("@vehicleId", cbVehicleId.Text);

                commad.Parameters.AddWithValue("@Date", dtDate.Text);
                commad.Parameters.AddWithValue("@MechanicId", cbMechanicId.Text);

                commad.Parameters.AddWithValue("@serviceType", cbServiceType.Text);
                commad.Parameters.AddWithValue("@serviceDescription", rtDescription.Text);

                commad.ExecuteNonQuery();


                MessageBox.Show("Service have been added successfully");


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (TalkDB_T.con != null)
                {
                    TalkDB_T.con.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((cbVehicleId.Text == "") || (cbServiceType.Text == "") || (cbMechanicId.Text == "") || (rtDescription.Text == ""))
            {
                MessageBox.Show("Make sure that correct information where in put");
            }
            else
            {
                updateService();
                CollectData();
            }

        }
        public void updateService()
        {

            try
            {

                using (SqlCommand command = TalkDB_T.con.CreateCommand())
                {
                    string sqlUpdate = "UPDATE Service SET VehicleId=@VehicleId,Date=@Date,MechanicId=@MechanicId, Where serviceId =" + ServiceId + "";

                    SqlCommand commad = new SqlCommand(sqlUpdate, TalkDB_T.con);

                    commad.Parameters.AddWithValue("@VehicleId", cbVehicleId.Text);

                    commad.Parameters.AddWithValue("@Date", dtDate.Text);
                    commad.Parameters.AddWithValue("@MechanicId", cbMechanicId.Text);

                    commad.Parameters.AddWithValue("@serviceType", cbServiceType.Text);
                    commad.Parameters.AddWithValue("@serviceDescription", rtDescription.Text);


                    commad.ExecuteNonQuery();



                    TalkDB_T.con.Open();

                    command.ExecuteNonQuery();

                    TalkDB_T.con.Close();


                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void displayMechanicId()
        {
            TalkDB_T.con.Open();
            string getMechanicId = "SELECT MechanicId FROM Mechanics";

            SqlCommand cmd = new SqlCommand(getMechanicId, TalkDB_T.con);
            SqlDataReader myReader;
            myReader = cmd.ExecuteReader();

            try
            {
                // conn.Close();
                // myReader = dbt.DisplayQuestionList(cbVehicleId.SelectedItem.ToString()); // only display question that match test  *****

                while (myReader.Read())
                {
                    int MechanicId = myReader.GetInt32(0); // index number

                    cbMechanicId.Items.Add(MechanicId.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            TalkDB_T.con.Close();
        }

        public void displayMechanic()
        {
            TalkDB_T.con.Open();
            string getMechanicId = "SELECT MechanicId FROM Mechanics";

            SqlCommand cmd = new SqlCommand(getMechanicId, TalkDB_T.con);
            SqlDataReader myReader;
            myReader = cmd.ExecuteReader();

            try
            {
                // conn.Close();
                // myReader = dbt.DisplayQuestionList(cbVehicleId.SelectedItem.ToString()); // only display question that match test  *****

                while (myReader.Read())
                {
                    int MechanicId = myReader.GetInt32(0); // index number

                    cbMechanicId.Items.Add(MechanicId.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            TalkDB_T.con.Close();
        }

        public void CollectData()
        {

            TalkDB_T.con.Open();
            string getData = "SELECT * FROM Service";

            SqlDataAdapter cmd = new SqlDataAdapter(getData, TalkDB_T.con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);




            dbgridDisplay.DataSource = dt;

            TalkDB_T.con.Close();

        }


        public void search(string Search)
        {
            try
            {
                TalkDB_T.con.Open();
                string getData = "SELECT * FROM Service WHERE ServiceId== " + Search + "" +
                    "VehicleId== " + Search + "Date== " + Search + "MechanicId== " + Search + "" +
                    "ServiceType== " + Search + "ServiceDescription== " + Search + "";

                SqlDataAdapter cmd = new SqlDataAdapter(getData, TalkDB_T.con);
                DataTable dt = new DataTable();
                cmd.Fill(dt);

                //TalkDB_T.con.Close();


                dbgridDisplay.DataSource = dt;
                //   int a = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            TalkDB_T.con.Close();



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the service for VehicleId: " + cbVehicleId.Text + "", "Delete Service", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                deleteService(ServiceId);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }


        }

        public void deleteService(string search)
        {
            try
            {
                // int id = Int32.Parse(IdtextBox.Text);
                TalkDB_T.con.Open();
                string deleteService = "delete from Service where ServiceId = '" + Int32.Parse(ServiceId) + "'";

                SqlDataAdapter cmd = new SqlDataAdapter(deleteService, TalkDB_T.con);
                cmd.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Service have been deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            TalkDB_T.con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainForm.switcher.Controls.Remove(MainForm.ServiceManager);
            MainForm.switcher.Hide();
            //MainForm.switcher.Close();
            MainForm.login.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           // cbServiceType.Enabled = false;

            string Search = tbSearch.Text;


            if (tbSearch.Text == "")
            {
                MessageBox.Show("Please insert searchable value");
            }
            else
            {
                search(Search);
                CollectData();

            }



        }

        private void ServiceManager_Load(object sender, EventArgs e)
        {
            CollectData();
        }

        private void rtDescription_KeyPress_Text_Number(object sender, KeyPressEventArgs e)
        {

            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;

            }

        }

        private void dbgridDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
