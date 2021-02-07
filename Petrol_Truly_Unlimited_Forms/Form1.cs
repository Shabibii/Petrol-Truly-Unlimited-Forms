using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_Truly_Unlimited_Forms
{
    public partial class PetrolStation : Form
    {
        /// <summary>
        /// Constructor, run code
        /// </summary>
        public PetrolStation()
        {
            InitializeComponent();
            VehicleQueue.StartGenerateVehicle();
            AssignVehicle.Start();

            transactionCheck.Start();
            
        }

        /// <summary>
        /// Assign vehicle to a available pump
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssignVehicle_Tick(object sender, EventArgs e)
        {
            Pump freePump = pumpStation.AvailablePump();
            Vehicle firstVehicle = VehicleQueue.firstVehicle;

            if (freePump != null && firstVehicle != null)
            {
                freePump.AssignVehicle(firstVehicle);
            }
        }

        /// <summary>
        /// Add transactions to listview1
        /// </summary>
        public void RefreshTransactionList()
        {
            foreach (string[] transaction in Transaction.transactions)
                listView1.Items.Add(new ListViewItem(transaction));

            // Clear transcations to prevent re-adding old vehciles 
            Transaction.transactions.Clear();
        }

        /// <summary>
        /// Show user details when running the code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void transactionCheck_Tick(object sender, EventArgs e)
        {
            RefreshTransactionList();

            totalLiters.Text = $"Total Liters Dispensed: {Transaction.TotalFuelDispense} L";
            totalUnleadedLiters.Text = $"(Unleaded): {Transaction.UnleadedDispence} L";
            totalLpgLiters.Text = $"(LPG): {Transaction.LpgDispence} L";
            totalDieselLiters.Text = $"(Diesel): {Transaction.DieselDispence} L";

            totalEarnings.Text = $"Total Earnings: £{Transaction.TotalEarnings}";
            totalEarningsUnleaded.Text = $"(Unleaded): £{Transaction.UnleadedEarnings}";
            totalEarningsLpg.Text = $"(LPG): £{Transaction.LpgEarnings}";
            totalEarningsDiesel.Text = $"(Diesel): £{Transaction.DieselEarnings}";

            commission.Text = $"1% Comission: £{Math.Round(Transaction.AttendantCommission, 2)}";
            shiftCommision.Text = $"Attendant Shift Earning: £{Math.Round(Transaction.FullShiftEarning, 2)}";

            vehiclesAssisted.Text = $"Vehicles Assisted: {Transaction.VehiclesAssisted}";
            vehiclesNotAssisted.Text = $"Vehicles Not Assisted: {Transaction.VehiclesNotAssisted}";

            totalVehicles.Text = $"Total Vehicles: {Transaction.TotalVehiclesGenerated}";
        }
        
    }
}
