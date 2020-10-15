namespace Tracking_Soft_v2
{
    partial class OfficeManForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnSheet = new System.Windows.Forms.Button();
            this.btnTrip = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnVehicle);
            this.panel1.Controls.Add(this.btnTrip);
            this.panel1.Controls.Add(this.btnSheet);
            this.panel1.Controls.Add(this.btnService);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 581);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(27, 46);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Administrator";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(27, 114);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(75, 23);
            this.btnService.TabIndex = 1;
            this.btnService.Text = "Service Manager";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnSheet
            // 
            this.btnSheet.Location = new System.Drawing.Point(27, 183);
            this.btnSheet.Name = "btnSheet";
            this.btnSheet.Size = new System.Drawing.Size(75, 23);
            this.btnSheet.TabIndex = 2;
            this.btnSheet.Text = "Timesheet Manager";
            this.btnSheet.UseVisualStyleBackColor = true;
            this.btnSheet.Click += new System.EventHandler(this.btnSheet_Click);
            // 
            // btnTrip
            // 
            this.btnTrip.Location = new System.Drawing.Point(27, 251);
            this.btnTrip.Name = "btnTrip";
            this.btnTrip.Size = new System.Drawing.Size(75, 23);
            this.btnTrip.TabIndex = 3;
            this.btnTrip.Text = "Trip Manager";
            this.btnTrip.UseVisualStyleBackColor = true;
            this.btnTrip.Click += new System.EventHandler(this.btnTrip_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.Location = new System.Drawing.Point(27, 316);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(75, 23);
            this.btnVehicle.TabIndex = 4;
            this.btnVehicle.Text = "Vehicle Manager";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(27, 490);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // OfficeManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 566);
            this.Controls.Add(this.panel1);
            this.Name = "OfficeManForm";
            this.Text = "OfficeManForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnTrip;
        private System.Windows.Forms.Button btnSheet;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnAdmin;
    }
}