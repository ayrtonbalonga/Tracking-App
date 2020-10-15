﻿namespace Tracking_Soft_v2
{
    partial class TripManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridTrip = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btShowCustomer = new System.Windows.Forms.Button();
            this.tbShowTrip = new System.Windows.Forms.Button();
            this.tbSearchTrip = new System.Windows.Forms.MaskedTextBox();
            this.tbSearchCustomer = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.btnDelCust = new System.Windows.Forms.Button();
            this.btnUpdateCust = new System.Windows.Forms.Button();
            this.tbDelCustomerId = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbCustomerId = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.MaskedTextBox();
            this.tbPhoneNum = new System.Windows.Forms.MaskedTextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCustName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTripFuel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDestinationCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDepartureCity = new System.Windows.Forms.TextBox();
            this.Driver = new System.Windows.Forms.Label();
            this.cbDriver = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVehicle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tripDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearchTrip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBoxButtons = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtons)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTrip
            // 
            this.dataGridTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTrip.Location = new System.Drawing.Point(0, 11);
            this.dataGridTrip.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridTrip.Name = "dataGridTrip";
            this.dataGridTrip.RowHeadersWidth = 51;
            this.dataGridTrip.RowTemplate.Height = 24;
            this.dataGridTrip.Size = new System.Drawing.Size(953, 219);
            this.dataGridTrip.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(478, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 355);
            this.panel1.TabIndex = 103;
            // 
            // btShowCustomer
            // 
            this.btShowCustomer.Location = new System.Drawing.Point(850, 286);
            this.btShowCustomer.Name = "btShowCustomer";
            this.btShowCustomer.Size = new System.Drawing.Size(90, 23);
            this.btShowCustomer.TabIndex = 102;
            this.btShowCustomer.Text = "ShowCustomer";
            this.btShowCustomer.UseVisualStyleBackColor = true;
            this.btShowCustomer.Click += new System.EventHandler(this.btShowCustomer_Click);
            // 
            // tbShowTrip
            // 
            this.tbShowTrip.Location = new System.Drawing.Point(769, 286);
            this.tbShowTrip.Name = "tbShowTrip";
            this.tbShowTrip.Size = new System.Drawing.Size(75, 23);
            this.tbShowTrip.TabIndex = 101;
            this.tbShowTrip.Text = "ShowTrip";
            this.tbShowTrip.UseVisualStyleBackColor = true;
            this.tbShowTrip.Click += new System.EventHandler(this.tbShowTrip_Click);
            // 
            // tbSearchTrip
            // 
            this.tbSearchTrip.Location = new System.Drawing.Point(788, 367);
            this.tbSearchTrip.Mask = "LL0000";
            this.tbSearchTrip.Name = "tbSearchTrip";
            this.tbSearchTrip.Size = new System.Drawing.Size(139, 20);
            this.tbSearchTrip.TabIndex = 100;
            // 
            // tbSearchCustomer
            // 
            this.tbSearchCustomer.Location = new System.Drawing.Point(789, 473);
            this.tbSearchCustomer.Mask = "0000000000";
            this.tbSearchCustomer.Name = "tbSearchCustomer";
            this.tbSearchCustomer.Size = new System.Drawing.Size(139, 20);
            this.tbSearchCustomer.TabIndex = 99;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(200, 433);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 98;
            this.label14.Text = "Cargo Type";
            // 
            // cbCargo
            // 
            this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Light",
            "Medium",
            "Heavy"});
            this.cbCargo.Location = new System.Drawing.Point(284, 429);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(139, 21);
            this.cbCargo.TabIndex = 97;
            // 
            // btnDelCust
            // 
            this.btnDelCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelCust.Location = new System.Drawing.Point(863, 499);
            this.btnDelCust.Name = "btnDelCust";
            this.btnDelCust.Size = new System.Drawing.Size(56, 23);
            this.btnDelCust.TabIndex = 96;
            this.btnDelCust.Text = "Delete";
            this.btnDelCust.UseVisualStyleBackColor = false;
            this.btnDelCust.Click += new System.EventHandler(this.btnDelCust_Click);
            // 
            // btnUpdateCust
            // 
            this.btnUpdateCust.Location = new System.Drawing.Point(669, 384);
            this.btnUpdateCust.Name = "btnUpdateCust";
            this.btnUpdateCust.Size = new System.Drawing.Size(63, 23);
            this.btnUpdateCust.TabIndex = 95;
            this.btnUpdateCust.Text = "Update";
            this.btnUpdateCust.UseVisualStyleBackColor = true;
            this.btnUpdateCust.Click += new System.EventHandler(this.btnUpdateCust_Click);
            // 
            // tbDelCustomerId
            // 
            this.tbDelCustomerId.Location = new System.Drawing.Point(593, 470);
            this.tbDelCustomerId.Mask = "000000";
            this.tbDelCustomerId.Name = "tbDelCustomerId";
            this.tbDelCustomerId.Size = new System.Drawing.Size(139, 20);
            this.tbDelCustomerId.TabIndex = 94;
            this.tbDelCustomerId.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(499, 473);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 93;
            this.label13.Text = "Customer ID";
            this.label13.Visible = false;
            // 
            // tbCustomerId
            // 
            this.tbCustomerId.Location = new System.Drawing.Point(284, 311);
            this.tbCustomerId.Mask = "000000";
            this.tbCustomerId.Name = "tbCustomerId";
            this.tbCustomerId.Size = new System.Drawing.Size(139, 20);
            this.tbCustomerId.TabIndex = 92;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(593, 350);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(139, 20);
            this.tbEmail.TabIndex = 91;
            this.tbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEmail_KeyPress_Text_Number_At_Comma);
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Location = new System.Drawing.Point(593, 313);
            this.tbPhoneNum.Mask = "0000000000";
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(139, 20);
            this.tbPhoneNum.TabIndex = 90;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(593, 384);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(63, 23);
            this.btnAddCustomer.TabIndex = 89;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(505, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 88;
            this.label12.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(505, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 87;
            this.label11.Text = "Phone Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(505, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 86;
            this.label10.Text = "Full Name";
            // 
            // tbCustName
            // 
            this.tbCustName.Location = new System.Drawing.Point(593, 274);
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(139, 20);
            this.tbCustName.TabIndex = 85;
            this.tbCustName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress_Text_WhiteSpace);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(588, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 84;
            this.label7.Text = "Customer Details";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(789, 499);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(56, 23);
            this.btnSearchCustomer.TabIndex = 83;
            this.btnSearchCustomer.Text = "Search";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(813, 445);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 82;
            this.label9.Text = "Enter Customer ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(286, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 81;
            this.label8.Text = "Trip Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 543);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Trip Fuel";
            // 
            // tbTripFuel
            // 
            this.tbTripFuel.Location = new System.Drawing.Point(284, 539);
            this.tbTripFuel.Name = "tbTripFuel";
            this.tbTripFuel.Size = new System.Drawing.Size(139, 20);
            this.tbTripFuel.TabIndex = 79;
            this.tbTripFuel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFuel_KeyPress_Number_Commas);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "To";
            // 
            // tbDestinationCity
            // 
            this.tbDestinationCity.Location = new System.Drawing.Point(284, 502);
            this.tbDestinationCity.Name = "tbDestinationCity";
            this.tbDestinationCity.Size = new System.Drawing.Size(139, 20);
            this.tbDestinationCity.TabIndex = 77;
            this.tbDestinationCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTo_KeyPress_Text_WhiteSpace);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "From";
            // 
            // tbDepartureCity
            // 
            this.tbDepartureCity.Location = new System.Drawing.Point(284, 466);
            this.tbDepartureCity.Name = "tbDepartureCity";
            this.tbDepartureCity.Size = new System.Drawing.Size(139, 20);
            this.tbDepartureCity.TabIndex = 75;
            this.tbDepartureCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFrom_KeyPress_Text_WhiteSpace);
            // 
            // Driver
            // 
            this.Driver.AutoSize = true;
            this.Driver.Location = new System.Drawing.Point(200, 394);
            this.Driver.Name = "Driver";
            this.Driver.Size = new System.Drawing.Size(35, 13);
            this.Driver.TabIndex = 74;
            this.Driver.Text = "Driver";
            // 
            // cbDriver
            // 
            this.cbDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDriver.FormattingEnabled = true;
            this.cbDriver.Location = new System.Drawing.Point(284, 390);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Size = new System.Drawing.Size(139, 21);
            this.cbDriver.TabIndex = 73;
            this.cbDriver.DropDown += new System.EventHandler(this.cbDriver_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Vehicle";
            // 
            // cbVehicle
            // 
            this.cbVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Location = new System.Drawing.Point(284, 349);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(139, 21);
            this.cbVehicle.TabIndex = 71;
            this.cbVehicle.DropDown += new System.EventHandler(this.cbVehicle_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Customer ID";
            // 
            // tripDate
            // 
            this.tripDate.Location = new System.Drawing.Point(284, 274);
            this.tripDate.Name = "tripDate";
            this.tripDate.Size = new System.Drawing.Size(139, 20);
            this.tripDate.TabIndex = 69;
            // 
            // btnSearchTrip
            // 
            this.btnSearchTrip.Location = new System.Drawing.Point(829, 396);
            this.btnSearchTrip.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchTrip.Name = "btnSearchTrip";
            this.btnSearchTrip.Size = new System.Drawing.Size(56, 28);
            this.btnSearchTrip.TabIndex = 68;
            this.btnSearchTrip.Text = "Search";
            this.btnSearchTrip.UseVisualStyleBackColor = true;
            this.btnSearchTrip.Click += new System.EventHandler(this.btnSearchTrip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(799, 339);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Enter Order Number";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(754, 230);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 347);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(0, 489);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 33);
            this.btnExit.TabIndex = 108;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 417);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(186, 35);
            this.btnDelete.TabIndex = 107;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(0, 344);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(186, 39);
            this.btnUpdate.TabIndex = 106;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(0, 274);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(186, 35);
            this.btnAdd.TabIndex = 105;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBoxButtons
            // 
            this.pictureBoxButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.pictureBoxButtons.Location = new System.Drawing.Point(0, 230);
            this.pictureBoxButtons.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxButtons.Name = "pictureBoxButtons";
            this.pictureBoxButtons.Size = new System.Drawing.Size(186, 345);
            this.pictureBoxButtons.TabIndex = 104;
            this.pictureBoxButtons.TabStop = false;
            // 
            // TripManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBoxButtons);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btShowCustomer);
            this.Controls.Add(this.tbShowTrip);
            this.Controls.Add(this.tbSearchTrip);
            this.Controls.Add(this.tbSearchCustomer);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.btnDelCust);
            this.Controls.Add(this.btnUpdateCust);
            this.Controls.Add(this.tbDelCustomerId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbCustomerId);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhoneNum);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbCustName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTripFuel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDestinationCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDepartureCity);
            this.Controls.Add(this.Driver);
            this.Controls.Add(this.cbDriver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbVehicle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tripDate);
            this.Controls.Add(this.btnSearchTrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridTrip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TripManager";
            this.Size = new System.Drawing.Size(953, 576);
            this.Load += new System.EventHandler(this.TripManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridTrip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btShowCustomer;
        private System.Windows.Forms.Button tbShowTrip;
        private System.Windows.Forms.MaskedTextBox tbSearchTrip;
        private System.Windows.Forms.MaskedTextBox tbSearchCustomer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Button btnDelCust;
        private System.Windows.Forms.Button btnUpdateCust;
        private System.Windows.Forms.MaskedTextBox tbDelCustomerId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox tbCustomerId;
        private System.Windows.Forms.MaskedTextBox tbEmail;
        private System.Windows.Forms.MaskedTextBox tbPhoneNum;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCustName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTripFuel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDestinationCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDepartureCity;
        private System.Windows.Forms.Label Driver;
        private System.Windows.Forms.ComboBox cbDriver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVehicle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tripDate;
        private System.Windows.Forms.Button btnSearchTrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBoxButtons;
    }
}
