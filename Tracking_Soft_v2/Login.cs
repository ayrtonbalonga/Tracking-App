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
using System.Windows;
using System.IO;


namespace Tracking_Soft_v2
{

    public partial class Login : Form
    {
        TalkDB_T db = new TalkDB_T();


        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {   
            System.Data.DataTable dt = db.LoginT(tbUsername.Text, tbPassword.Text);
            //Main_Switch tm = new Main_Switch();
            //tm.Visible = false;
            MainForm.switcher.Visible = false;
            MainForm.officeForm.Visible = false;



            if (dt.Rows.Count == 1)
            {
                
                switch (dt.Rows[0]["Role"] as string)
                {
                    case "Administrator":
                        {
                            this.Hide();
                            String ID = dt.Rows[0]["LoginID"].ToString();
                            //Administrator tm = new Administrator();
                            MainForm.switcher.Visible = true;
                            Administrater admin = new Administrater();
                            MainForm.switcher.Controls.Add(admin);
                            MainForm.switcher.Show();
                            break;
                        }

                    case "Trip Manager":
                        {
                            this.Hide();
                            String ID = dt.Rows[0]["LoginID"].ToString();
                            //Administrator tm = new Administrator();
                            MainForm.switcher.Visible = true;
                            TripManager admin = new TripManager();
                            MainForm.switcher.Controls.Add(admin);
                            MainForm.switcher.Show();
                            break;
                        }
                    case "Timesheet Manager":
                        {
                            this.Hide();
                            String ID = dt.Rows[0]["LoginID"].ToString();
                            //Administrator tm = new Administrator();
                            MainForm.switcher.Visible = true;
                            TimesheetManager admin = new TimesheetManager();
                            MainForm.switcher.Controls.Add(admin);
                            MainForm.switcher.Show();
                            break;
                        }
                    case "Service Manager":
                        {
                            this.Hide();
                            String ID = dt.Rows[0]["LoginID"].ToString();
                            //Administrator tm = new Administrator();
                            MainForm.switcher.Visible = true;
                            ServiceManager admin = new ServiceManager();
                            MainForm.switcher.Controls.Add(admin);
                            MainForm.switcher.Show();
                            break;
                        }
                    case "Vehicle Info Manager":

                        {
                            this.Hide();
                            String ID = dt.Rows[0]["LoginID"].ToString();
                            //Administrator tm = new Administrator();
                            MainForm.switcher.Visible = true;
                            VehicleInfoManager admin = new VehicleInfoManager();
                            MainForm.switcher.Controls.Add(admin);
                            MainForm.switcher.Show();
                            break;

                        }
                    case "Office Manager":

                        {
                           // MessageBox.Show("am in");
                            this.Hide();
                            String ID = dt.Rows[0]["LoginID"].ToString();
                            //Administrator tm = new Administrator();
                            MainForm.officeForm.Visible = true;
                            //Administrater admin = new Administrater();

                            MainForm.administrater.Location = new Point(186, 0);
                            MainForm.officeForm.Controls.Add(MainForm.administrater);
                            MainForm.officeForm.Show();
                            break;

                        }
                }
            }


            tbUsername.Clear();
            tbPassword.Clear();
        }
    }
}
    

    

