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
using System.Globalization;

namespace Tracking_Soft_v2
{
    public partial class TimesheetManager : UserControl
    {
        public TimesheetManager()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((tbLoginId.Text == "") || (tbName.Text == "") || (tbSurname.Text == "") || (cbRole.Text == "") || (sheetDate.Value.Date == null) || (tbWorkHour.Text == ""))
            {
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                insertTimeSheet();
                showSheetGrid();
            }
            tbLoginId.Text = null;
            tbName.Text = null;
            tbSurname.Text = null;
            cbRole.Text = null;
            sheetDate.Value = DateTime.Today;
            tbWorkHour.Text = null;
        }

        private void insertTimeSheet()
        {
            try
            {
                TalkDB_T.con.Open();

                String sqlInsert = "insert into TimeSheet(LoginId, Firstname, LastName, Role, date, work_Hours) " +
                    "Values" +
                    "(@LoginId, @Firstname, @Lastname, @Role, @date, @work_Hours)";


                SqlCommand commad = new SqlCommand(sqlInsert, TalkDB_T.con);

                commad.Parameters.AddWithValue("@LoginId", Convert.ToInt32(tbLoginId.Text));
                commad.Parameters.AddWithValue("@Firstname", tbName.Text);
                commad.Parameters.AddWithValue("@Lastname", tbSurname.Text);
                commad.Parameters.AddWithValue("@Role", cbRole.Text);
                commad.Parameters.AddWithValue("@date", sheetDate.Value.Date);
                commad.Parameters.AddWithValue("@work_Hours", Convert.ToInt32(tbWorkHour.Text));

                commad.ExecuteNonQuery();
                TalkDB_T.con.Close();

                MessageBox.Show("The Record has been added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showSheetGrid()
        {
            TalkDB_T.con.Open();

            SqlCommand cmd = TalkDB_T.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * country from Testing";
            //cmd.CommandText = "select customerFullName, customerPhoneNum, customerEmail from Customer";
            cmd.CommandText = "select * from TimeSheet";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridSheet.DataSource = dt;

            TalkDB_T.con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((tbLoginId.Text == "") || (tbName.Text == "") || (tbSurname.Text == "") || (cbRole.Text == "") || (sheetDate.Value.Date == null) || (tbWorkHour.Text == ""))
            {
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                updateTimeSheet();
                showSheetGrid();
            }
            tbLoginId.Text = null;
            tbName.Text = null;
            tbSurname.Text = null;
            cbRole.Text = null;
            sheetDate.Value = DateTime.Today;
            tbWorkHour.Text = null;
        }

        public void updateTimeSheet()
        {
            try
            {
                //open connection 
                TalkDB_T.con.Open();

                String sqlUpdate = "UPDATE TimeSheet " +
                                   "SET Firstname = @Firstname, Lastname = @Lastname, Role = @Role, date = @date, work_Hours = @work_Hours " +
                                   "WHERE LoginId = @LoginId";


                SqlCommand commad = new SqlCommand(sqlUpdate, TalkDB_T.con);

                commad.Parameters.AddWithValue("@LoginId", Convert.ToInt32(tbLoginId.Text));
                commad.Parameters.AddWithValue("@Firstname", tbName.Text);
                commad.Parameters.AddWithValue("@Lastname", tbSurname.Text);
                commad.Parameters.AddWithValue("@Role", cbRole.Text);
                commad.Parameters.AddWithValue("@date", sheetDate.Value.Date);
                commad.Parameters.AddWithValue("@work_Hours", Convert.ToInt32(tbWorkHour.Text));

                commad.ExecuteNonQuery();
                TalkDB_T.con.Close();

                MessageBox.Show("The Record has been updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (searchDate.Value.Date == null)
            {
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Timesheet ?", "Delete Timesheet", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deleteSheet();
                    showSheetGrid();
                }
            }

            tbLoginId.Text = null;
            tbName.Text = null;
            tbSurname.Text = null;
            cbRole.Text = null;
            sheetDate.Value = DateTime.Today;
            tbWorkHour.Text = null;
        }

        private void deleteSheet()
        {
            try
            {
                string DateString = String.Format("{0:yyyy/M/d}", searchDate.Value.Date);
                TalkDB_T.con.Open();
                string Delete = string.Format("delete from TimeSheet where date = '{0}' And LoginId = {1}", DateString, Convert.ToInt32(tbSearchSheetLoginId.Text));

                SqlDataAdapter cmd = new SqlDataAdapter(Delete, TalkDB_T.con);
                cmd.SelectCommand.ExecuteNonQuery();
                TalkDB_T.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TimesheetManager_Load(object sender, EventArgs e)
        {
            showSheetGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (searchDate.Value.Date == null)
            {
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                //Convert Date to yy/mm/dd
                string DateString = String.Format("{0:yyyy/M/d}", searchDate.Value.Date);
                try
                {
                    TalkDB_T.con.Open();

                    SqlCommand cmd = TalkDB_T.con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = string.Format("select * from TimeSheet Where date = '{0}' And LoginId = {1}", DateString, Convert.ToInt32(tbSearchSheetLoginId.Text));
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridSheet.DataSource = dt;

                    TalkDB_T.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainForm.switcher.Controls.Remove(MainForm.timeMan);
            MainForm.switcher.Hide();
            //MainForm.switcher.Close();
            MainForm.login.Show();
        }

        private void tbLogunId_keyPress_Number(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) )
            {
                e.Handled = true;

            }
        }

        private void tbName_keyPress_Text_White(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void tbSurname_KeyPress_Text_WhiteSpace(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void tbWorkHours_KeyPress_Number(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) )
            {
                e.Handled = true;

            }
        }

        private void tbSearchLoginId_KeyPress_Number(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;

            }
        }
    }
}
