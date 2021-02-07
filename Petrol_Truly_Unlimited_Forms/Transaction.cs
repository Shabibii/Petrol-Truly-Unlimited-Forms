using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrol_Truly_Unlimited_Forms
{
    internal static class Transaction
    {
        // Transaction numbering
        public static int TransactionNumber = 1;

        // Keep track of total vehicles generated, assisted and not assisted.
        public static int TotalVehiclesGenerated = 0;
        public static int VehiclesAssisted = 0;
        public static int VehiclesNotAssisted => TotalVehiclesGenerated - VehiclesAssisted;
        
        // Give starting values to variables fuel dispence
        public static double UnleadedDispence = 0;
        public static double LpgDispence = 0;
        public static double DieselDispence = 0;

        // Calculate income per fueltype
        public static double UnleadedEarnings => UnleadedDispence * 1.36;
        public static double LpgEarnings => LpgDispence * 0.74;
        public static double DieselEarnings => DieselDispence * 1.43;

        // Keeping track of total fuel dispenced
        public static double TotalFuelDispense => UnleadedDispence + LpgDispence + DieselDispence;
        // Keeping track of total money earned
        public static double TotalEarnings => UnleadedEarnings + LpgEarnings + DieselEarnings;
           
        // Calculate fuel attendant commission
        public static double AttendantCommission => TotalEarnings * 0.01;
        public static double FullShiftEarning => AttendantCommission + 19.92;
                
        // List all transactions
        public static List<string[]> transactions = new List<string[]>();
    }
}
