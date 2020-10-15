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
    public partial class Administrater : UserControl
    {

        TalkDB_T db = new TalkDB_T();
        public String[,] Data = new string[100, 6];
        public String[,] UsersId = new string[100, 0];
        public Administrater()
        {
            InitializeComponent();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            {
                string LoginId;


                LoginId = tbSearch.Text;

                for (int a = 0; a < 100; a++)
                {
                    if (LoginId == Data[a, 0])
                    {
                        tb_Username.Text = Data[a, 1];
                        tb_Password.Text = Data[a, 2];
                        cb_Role.Text = Data[a, 3];
                        tb_Firstname.Text = Data[a, 4];
                        tb_Lastname.Text = Data[a, 5];
                    }
                }



            }
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            updateUsers();
        }

        public void updateUsers()
        {
            try
            {


                using (SqlCommand command = TalkDB_T.con.CreateCommand())
                {
                    command.CommandText = "UPDATE LoginT SET Username = @Username, Password = @Password, Role = @Role, Firstname = @Firstname, Lastname = @Lastname Where LoginId = @LoginId ";

                    //command.Parameters.AddWithValue("@LoginId", Int32.Parse(cbUsersId.Text));
                    command.Parameters.AddWithValue("@Username", tb_Username.Text);
                    command.Parameters.AddWithValue("@Password", tb_Password.Text);
                    command.Parameters.AddWithValue("@Role", cb_Role.Text);
                    command.Parameters.AddWithValue("@Firstname", tb_Firstname.Text);
                    command.Parameters.AddWithValue("@Lastname", tb_Lastname.Text);

                    TalkDB_T.con.Open();

                    command.ExecuteNonQuery();
                    MessageBox.Show("The User has been updated Successfully");
                    TalkDB_T.con.Close();
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void bt_Add_Click_1(object sender, EventArgs e)
        {
            try
            {
                db.closeConnection();

                SqlCommand cmd = db.AddUser();
                cmd.Parameters.Add("@Username", tb_Username.Text);
                cmd.Parameters.Add("@Password", tb_Password.Text);
                cmd.Parameters.Add("@Role", cb_Role.Text);
                cmd.Parameters.Add("@Firstname", tb_Firstname.Text);
                cmd.Parameters.Add("@Lastname", tb_Lastname.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully added the User.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TalkDB_T.con.Close();
            diplaydbgrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TalkDB_T.con.Open();
                String searchData = "SELECT * FROM LoginT WHERE LoginId='" + tbSearch.Text + "'";

                SqlDataAdapter sSDA = new SqlDataAdapter(searchData, TalkDB_T.con);
                DataTable sdt = new DataTable();
                sSDA.Fill(sdt);
                dGride.DataSource = sdt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TalkDB_T.con.Close();
        }

        private void Bt_Delete_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    TalkDB_T.con.Open();
                    string Delete = String.Format("delete from LoginT Where LoginId = {0}", Convert.ToInt32(tbSearch.Text));

                    SqlDataAdapter cmd = new SqlDataAdapter(Delete, TalkDB_T.con);
                    cmd.SelectCommand.ExecuteNonQuery();
                    TalkDB_T.con.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                TalkDB_T.con.Close();
                diplaydbgrid();

            }
        }

        public void diplaydbgrid()
        {
            TalkDB_T.con.Open();
            string getData = "SELECT * FROM LoginT";

            SqlDataAdapter cmd = new SqlDataAdapter(getData, TalkDB_T.con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);

            dGride.DataSource = dt;

            TalkDB_T.con.Close();

        }

        private void Administrater_Load(object sender, EventArgs e)
        {
            CollectUsersId();
            diplaydbgrid();

        }

        public void CollectUsersId()
        {

            TalkDB_T.con.Open();
            string getLoginId = "SELECT * FROM LoginT";

            SqlDataAdapter cmd = new SqlDataAdapter(getLoginId, TalkDB_T.con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);

            TalkDB_T.con.Close();

            int a = 0;

            foreach (DataRow row in dt.Rows)
            {

                Data[a, 0] = row["LoginId"].ToString();
                Data[a, 1] = row["Username"].ToString();
                Data[a, 2] = row["Password"].ToString();
                Data[a, 3] = row["Role"].ToString();
                Data[a, 4] = row["Firstname"].ToString();
                Data[a, 5] = row["Lastname"].ToString();
                a++;

            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            MainForm.switcher.Controls.Remove(MainForm.administrater);
            MainForm.switcher.Hide();
            //MainForm.switcher.Close();
            MainForm.login.Show();
        }

        private void tbFirstName_KeyPress_Text(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void tbLastName_KeyPress_Text(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void tbUserId_KeyPress_Number(object sender, KeyPressEventArgs e)
        {

            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;

            }

        }
    }
}
