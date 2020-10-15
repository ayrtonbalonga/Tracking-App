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
    public partial class VehicleInfoManager : UserControl
    {
        public VehicleInfoManager()
        {
            InitializeComponent();
        }

        private void dataGridVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                TalkDB_T.con.Open();
                String updateQuery = "UPDATE VehicleInfo SET RegistrationNumber='" + txtRegistrationNo.Text + "', Type='" + txtType.Text + "', Manufacturer='" + txtManufacturer.Text + "', EngineSize='" + txtEngineSize.Text + "', CurrentOdometerReading='" + txtOdometerRead + "' WHERE RegistrationNumber='" + txtRegistrationNo.Text + "'";
                SqlDataAdapter uSDA = new SqlDataAdapter(updateQuery, TalkDB_T.con);
                uSDA.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Information updated successfully.");

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                TalkDB_T.con.Open();
                String query = "INSERT INTO VehicleInfo (RegistrationNumber, Type, Manufacturer, EngineSize, CurrentOdometerReading) VALUES('" + txtRegistrationNo.Text + "','" + txtType.Text + "','" + txtManufacturer.Text + "','" + txtEngineSize.Text + "','" + txtOdometerRead.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, TalkDB_T.con);
                SDA.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Vehicle information added successfully");
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

            TalkDB_T.con.Open();
            String gridQuery = "SELECT * FROM VehicleInfo";
            SqlDataAdapter nSDA = new SqlDataAdapter(gridQuery, TalkDB_T.con);
            DataTable dt = new DataTable();
            nSDA.Fill(dt);
            dataGridVehicles.DataSource = dt;
            TalkDB_T.con.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            try
            {
                TalkDB_T.con.Open();
                String deleteQuery = "DELETE * FROM VehicleInfo WHERE RegistrationNumber='" + txtSearch.Text + "'";
                SqlDataAdapter dSDA = new SqlDataAdapter(deleteQuery, TalkDB_T.con);
                dSDA.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Information successfully deleted.");
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainForm.switcher.Controls.Remove(MainForm.VehicleInfoManager);
            MainForm.switcher.Hide();
            //MainForm.switcher.Close();
            MainForm.login.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                TalkDB_T.con.Open();
                String searchData = "SELECT * FROM VehicleInfo WHERE RegistrationNumber='" + txtSearch.Text + "'";

                SqlDataAdapter sSDA = new SqlDataAdapter(searchData, TalkDB_T.con);
                DataTable sdt = new DataTable();
                sSDA.Fill(sdt);
                dataGridVehicles.DataSource = sdt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TalkDB_T.con.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            TalkDB_T.con.Open();
            String gridQuery = "SELECT * FROM VehicleInfo";
            SqlDataAdapter nSDA = new SqlDataAdapter(gridQuery, TalkDB_T.con);
            DataTable dt = new DataTable();
            nSDA.Fill(dt);
            dataGridVehicles.DataSource = dt;
            TalkDB_T.con.Close();
        }

        private void VehicleInfoManager_Load(object sender, EventArgs e)
        {
            TalkDB_T.con.Open();
            String gridQuery = "SELECT * FROM VehicleInfo";
            SqlDataAdapter nSDA = new SqlDataAdapter(gridQuery, TalkDB_T.con);
            DataTable dt = new DataTable();
            nSDA.Fill(dt);
            dataGridVehicles.DataSource = dt;
            TalkDB_T.con.Close();

        }

        private void tbRegNum_KeyPress_Num(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) )
            {
                e.Handled = true;

            }
        }

        private void tbType_KeyPress_Text_WhiteSpace(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;

            }

        }

        private void tbManufacture_keyPress_Text_Number_WhtteSpace(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void tbEngineSize_KeyPress_Digit_Commas(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&( e.KeyChar != '.') &&( e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void tbCurrOdimeter_KeyPress_Digit(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;

            }
        }
    }
}
