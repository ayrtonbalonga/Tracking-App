﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracking_Soft_v2
{
    public partial class OfficeManForm : Form
    {
        public OfficeManForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            
            MainForm.VehicleInfoManager.Visible = false;
            MainForm.tripManager.Visible = false;
            MainForm.ServiceManager.Visible = false;
            MainForm.timeMan.Visible = false;
            MainForm.administrater.Visible = true;

            MainForm.administrater.Location = new Point(186, 0);
            MainForm.officeForm.Controls.Add(MainForm.administrater);
            MainForm.officeForm.Show();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            MainForm.administrater.Visible = false;
            MainForm.VehicleInfoManager.Visible = false;
            MainForm.tripManager.Visible = false;
            
            MainForm.timeMan.Visible = false;
            MainForm.ServiceManager.Visible = true;

            MainForm.ServiceManager.Location = new Point(186, 0);
            MainForm.officeForm.Controls.Add(MainForm.ServiceManager);
            MainForm.officeForm.Show();
        }

        private void btnSheet_Click(object sender, EventArgs e)
        {
            MainForm.administrater.Visible = false;
            MainForm.VehicleInfoManager.Visible = false;
            MainForm.tripManager.Visible = false;
            MainForm.ServiceManager.Visible = false;
            MainForm.timeMan.Visible = true;

            MainForm.timeMan.Location = new Point(186, 0);
            MainForm.officeForm.Controls.Add(MainForm.timeMan);
            MainForm.officeForm.Show();
        }

        private void btnTrip_Click(object sender, EventArgs e)
        {
            MainForm.administrater.Visible = false;
            MainForm.VehicleInfoManager.Visible = false;
            
            MainForm.ServiceManager.Visible = false;
            MainForm.timeMan.Visible = false;
            MainForm.tripManager.Visible = true;

            MainForm.tripManager.Location = new Point(186, 0);
            MainForm.officeForm.Controls.Add(MainForm.tripManager);
            MainForm.officeForm.Show();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            MainForm.administrater.Visible = false;
            MainForm.tripManager.Visible = false;
            MainForm.ServiceManager.Visible = false;
            MainForm.timeMan.Visible = false;
            MainForm.VehicleInfoManager.Visible = true;

            MainForm.VehicleInfoManager.Location = new Point(186, 0);
            MainForm.officeForm.Controls.Add(MainForm.VehicleInfoManager);
            MainForm.officeForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm.officeForm.Controls.Remove(MainForm.timeMan);
            MainForm.officeForm.Controls.Remove(MainForm.ServiceManager);
            MainForm.officeForm.Controls.Remove(MainForm.VehicleInfoManager);
            MainForm.officeForm.Controls.Remove(MainForm.administrater);
            MainForm.officeForm.Controls.Remove(MainForm.timeMan);
            MainForm.officeForm.Hide();
            //MainForm.switcher.Close();
            MainForm.login.Show();
        }
    }
}
