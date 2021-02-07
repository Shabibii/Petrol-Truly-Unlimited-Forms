namespace Petrol_Truly_Unlimited_Forms
{
    partial class PetrolStation
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
            this.components = new System.ComponentModel.Container();
            this.AssignVehicle = new System.Windows.Forms.Timer(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.transactionNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plateNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fuelType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fuelDispensed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.income = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transactionCheck = new System.Windows.Forms.Timer(this.components);
            this.totalLiters = new System.Windows.Forms.Label();
            this.totalEarnings = new System.Windows.Forms.Label();
            this.vehiclesAssisted = new System.Windows.Forms.Label();
            this.vehiclesNotAssisted = new System.Windows.Forms.Label();
            this.totalVehicles = new System.Windows.Forms.Label();
            this.totalUnleadedLiters = new System.Windows.Forms.Label();
            this.totalLpgLiters = new System.Windows.Forms.Label();
            this.totalDieselLiters = new System.Windows.Forms.Label();
            this.totalEarningsDiesel = new System.Windows.Forms.Label();
            this.totalEarningsLpg = new System.Windows.Forms.Label();
            this.totalEarningsUnleaded = new System.Windows.Forms.Label();
            this.commission = new System.Windows.Forms.Label();
            this.shiftCommision = new System.Windows.Forms.Label();
            this.pumpStation = new Petrol_Truly_Unlimited_Forms.PumpService();
            this.VehicleQueue = new Petrol_Truly_Unlimited_Forms.VehicleQueue();
            this.SuspendLayout();
            // 
            // AssignVehicle
            // 
            this.AssignVehicle.Interval = 500;
            this.AssignVehicle.Tick += new System.EventHandler(this.AssignVehicle_Tick);
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.transactionNumber,
            this.plateNumber,
            this.vehicleType,
            this.fuelType,
            this.fuelDispensed,
            this.income});
            this.listView1.Location = new System.Drawing.Point(857, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(384, 256);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // transactionNumber
            // 
            this.transactionNumber.Text = "Nr.";
            this.transactionNumber.Width = 36;
            // 
            // plateNumber
            // 
            this.plateNumber.Text = "ID";
            this.plateNumber.Width = 59;
            // 
            // vehicleType
            // 
            this.vehicleType.Text = "Type";
            this.vehicleType.Width = 61;
            // 
            // fuelType
            // 
            this.fuelType.Text = "Fuel Type";
            this.fuelType.Width = 78;
            // 
            // fuelDispensed
            // 
            this.fuelDispensed.Text = "Fuel Dispensed";
            this.fuelDispensed.Width = 94;
            // 
            // income
            // 
            this.income.Text = "Income";
            this.income.Width = 53;
            // 
            // transactionCheck
            // 
            this.transactionCheck.Tick += new System.EventHandler(this.transactionCheck_Tick);
            // 
            // totalLiters
            // 
            this.totalLiters.AutoSize = true;
            this.totalLiters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLiters.Location = new System.Drawing.Point(854, 275);
            this.totalLiters.Name = "totalLiters";
            this.totalLiters.Size = new System.Drawing.Size(71, 13);
            this.totalLiters.TabIndex = 3;
            this.totalLiters.Text = "Total Liters";
            // 
            // totalEarnings
            // 
            this.totalEarnings.AutoSize = true;
            this.totalEarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEarnings.Location = new System.Drawing.Point(854, 353);
            this.totalEarnings.Name = "totalEarnings";
            this.totalEarnings.Size = new System.Drawing.Size(89, 13);
            this.totalEarnings.TabIndex = 4;
            this.totalEarnings.Text = "Total Earnings";
            // 
            // vehiclesAssisted
            // 
            this.vehiclesAssisted.AutoSize = true;
            this.vehiclesAssisted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiclesAssisted.Location = new System.Drawing.Point(876, 455);
            this.vehiclesAssisted.Name = "vehiclesAssisted";
            this.vehiclesAssisted.Size = new System.Drawing.Size(110, 13);
            this.vehiclesAssisted.TabIndex = 5;
            this.vehiclesAssisted.Text = "Vehicles Assisted:";
            // 
            // vehiclesNotAssisted
            // 
            this.vehiclesNotAssisted.AutoSize = true;
            this.vehiclesNotAssisted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiclesNotAssisted.Location = new System.Drawing.Point(854, 472);
            this.vehiclesNotAssisted.Name = "vehiclesNotAssisted";
            this.vehiclesNotAssisted.Size = new System.Drawing.Size(134, 13);
            this.vehiclesNotAssisted.TabIndex = 6;
            this.vehiclesNotAssisted.Text = "Vehicles Not Assisted:";
            // 
            // totalVehicles
            // 
            this.totalVehicles.AutoSize = true;
            this.totalVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVehicles.Location = new System.Drawing.Point(870, 490);
            this.totalVehicles.Name = "totalVehicles";
            this.totalVehicles.Size = new System.Drawing.Size(92, 13);
            this.totalVehicles.TabIndex = 7;
            this.totalVehicles.Text = "Total Vehicles:";
            // 
            // totalUnleadedLiters
            // 
            this.totalUnleadedLiters.AutoSize = true;
            this.totalUnleadedLiters.Location = new System.Drawing.Point(887, 293);
            this.totalUnleadedLiters.Name = "totalUnleadedLiters";
            this.totalUnleadedLiters.Size = new System.Drawing.Size(114, 13);
            this.totalUnleadedLiters.TabIndex = 9;
            this.totalUnleadedLiters.Text = "Total Liters (Unleaded)";
            // 
            // totalLpgLiters
            // 
            this.totalLpgLiters.AutoSize = true;
            this.totalLpgLiters.Location = new System.Drawing.Point(911, 309);
            this.totalLpgLiters.Name = "totalLpgLiters";
            this.totalLpgLiters.Size = new System.Drawing.Size(89, 13);
            this.totalLpgLiters.TabIndex = 10;
            this.totalLpgLiters.Text = "Total Liters (LPG)";
            // 
            // totalDieselLiters
            // 
            this.totalDieselLiters.AutoSize = true;
            this.totalDieselLiters.Location = new System.Drawing.Point(903, 327);
            this.totalDieselLiters.Name = "totalDieselLiters";
            this.totalDieselLiters.Size = new System.Drawing.Size(97, 13);
            this.totalDieselLiters.TabIndex = 11;
            this.totalDieselLiters.Text = "Total Liters (Diesel)";
            // 
            // totalEarningsDiesel
            // 
            this.totalEarningsDiesel.AutoSize = true;
            this.totalEarningsDiesel.Location = new System.Drawing.Point(905, 406);
            this.totalEarningsDiesel.Name = "totalEarningsDiesel";
            this.totalEarningsDiesel.Size = new System.Drawing.Size(113, 13);
            this.totalEarningsDiesel.TabIndex = 14;
            this.totalEarningsDiesel.Text = "Total Earnings (Diesel)";
            // 
            // totalEarningsLpg
            // 
            this.totalEarningsLpg.AutoSize = true;
            this.totalEarningsLpg.Location = new System.Drawing.Point(911, 388);
            this.totalEarningsLpg.Name = "totalEarningsLpg";
            this.totalEarningsLpg.Size = new System.Drawing.Size(105, 13);
            this.totalEarningsLpg.TabIndex = 13;
            this.totalEarningsLpg.Text = "Total Earnings (LPG)";
            // 
            // totalEarningsUnleaded
            // 
            this.totalEarningsUnleaded.AutoSize = true;
            this.totalEarningsUnleaded.Location = new System.Drawing.Point(887, 372);
            this.totalEarningsUnleaded.Name = "totalEarningsUnleaded";
            this.totalEarningsUnleaded.Size = new System.Drawing.Size(130, 13);
            this.totalEarningsUnleaded.TabIndex = 12;
            this.totalEarningsUnleaded.Text = "Total Earnings (Unleaded)";
            // 
            // commission
            // 
            this.commission.AutoSize = true;
            this.commission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commission.Location = new System.Drawing.Point(859, 430);
            this.commission.Name = "commission";
            this.commission.Size = new System.Drawing.Size(96, 13);
            this.commission.TabIndex = 15;
            this.commission.Text = "1% Commission:";
            // 
            // shiftCommision
            // 
            this.shiftCommision.AutoSize = true;
            this.shiftCommision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftCommision.Location = new System.Drawing.Point(1048, 430);
            this.shiftCommision.Name = "shiftCommision";
            this.shiftCommision.Size = new System.Drawing.Size(143, 13);
            this.shiftCommision.TabIndex = 16;
            this.shiftCommision.Text = "Attendant Shift Earning:";
            // 
            // pumpStation
            // 
            this.pumpStation.Location = new System.Drawing.Point(208, 3);
            this.pumpStation.Name = "pumpStation";
            this.pumpStation.Size = new System.Drawing.Size(655, 496);
            this.pumpStation.TabIndex = 1;
            // 
            // VehicleQueue
            // 
            this.VehicleQueue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VehicleQueue.Location = new System.Drawing.Point(1, 3);
            this.VehicleQueue.Name = "VehicleQueue";
            this.VehicleQueue.Size = new System.Drawing.Size(200, 496);
            this.VehicleQueue.TabIndex = 0;
            // 
            // PetrolStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 511);
            this.Controls.Add(this.shiftCommision);
            this.Controls.Add(this.commission);
            this.Controls.Add(this.totalEarningsDiesel);
            this.Controls.Add(this.totalEarningsLpg);
            this.Controls.Add(this.totalEarningsUnleaded);
            this.Controls.Add(this.totalDieselLiters);
            this.Controls.Add(this.totalLpgLiters);
            this.Controls.Add(this.totalUnleadedLiters);
            this.Controls.Add(this.totalVehicles);
            this.Controls.Add(this.vehiclesNotAssisted);
            this.Controls.Add(this.vehiclesAssisted);
            this.Controls.Add(this.totalEarnings);
            this.Controls.Add(this.totalLiters);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pumpStation);
            this.Controls.Add(this.VehicleQueue);
            this.Name = "PetrolStation";
            this.Text = "PetrolStation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VehicleQueue VehicleQueue;
        private PumpService pumpStation;
        private System.Windows.Forms.Timer AssignVehicle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader transactionNumber;
        private System.Windows.Forms.ColumnHeader plateNumber;
        private System.Windows.Forms.ColumnHeader vehicleType;
        private System.Windows.Forms.ColumnHeader fuelType;
        private System.Windows.Forms.ColumnHeader fuelDispensed;
        private System.Windows.Forms.Timer transactionCheck;
        private System.Windows.Forms.ColumnHeader income;
        private System.Windows.Forms.Label totalLiters;
        private System.Windows.Forms.Label totalEarnings;
        private System.Windows.Forms.Label vehiclesAssisted;
        private System.Windows.Forms.Label vehiclesNotAssisted;
        private System.Windows.Forms.Label totalVehicles;
        private System.Windows.Forms.Label totalUnleadedLiters;
        private System.Windows.Forms.Label totalLpgLiters;
        private System.Windows.Forms.Label totalDieselLiters;
        private System.Windows.Forms.Label totalEarningsDiesel;
        private System.Windows.Forms.Label totalEarningsLpg;
        private System.Windows.Forms.Label totalEarningsUnleaded;
        private System.Windows.Forms.Label commission;
        private System.Windows.Forms.Label shiftCommision;        
    }
}

