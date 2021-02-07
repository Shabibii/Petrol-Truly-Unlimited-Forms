using System;
using System.Drawing;
using System.Windows.Forms;

namespace Petrol_Truly_Unlimited_Forms
{
    public class Vehicle : Button // Inherit 'Button'
    {
        // Fuel properties (values in liters)
        private string fuelType;
        private double initialFuel;
        private double currentFuel;
        private int maxFuel;

        private double fuelDispensed => currentFuel - initialFuel;

        /// <summary>
        /// Price calculation for each fueltype
        /// </summary>
        private double money
        {
            get
            {
                // Communicate litres dispensed for all fueltypes to Transaction class
                if (fuelType == fuel[0]) return fuelDispensed * 1.36;
                else if (fuelType == fuel[1]) return fuelDispensed * 0.74;
                else return fuelDispensed * 1.43;
            }
        }

        // Litres every second
        private double fuelRate = 1.5;

        // Vehicle properties
        private string vehicleType;

        private readonly string plateNumber = RandomPlatenumber();

        /// Create Random number generator
        private Random rnd = new Random();

        // Timer for the maximum waiting limit of a vehicle in the queue
        private Timer waitLimit = new Timer();

        // Timer for fuelling time
        public Timer fuelling = new Timer();

        // Array to hold the 3 fuel types
        public string[] fuel = new[] { "Unleaded", "LPG", "Diesel" };

        // Printing fuel details vehicle
        private string PumpValue => $" {fuelType} :: {currentFuel} / {maxFuel}";

        // Print transaction details
        public string Details => $"#{Transaction.TransactionNumber++}\n{plateNumber}\n{vehicleType}\n{fuelType}\n{fuelDispensed}L Dispensed\n£{money}";

        // Text in vehicle image
        public override string Text => PumpValue;

        // Fuel has reached it's limit
        public bool IsFuelled => currentFuel >= maxFuel;

        /// <summary>
        /// Create a random plate number / ID
        /// </summary>
        /// <returns></returns> 
        private static string RandomPlatenumber()
        {
            string aplhabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string plateNumber = "";
            Random r = new Random();
            for (int i = 0; i < 3; i++)
                plateNumber += aplhabets[r.Next(0, aplhabets.Length)];

            return plateNumber;
        }

        /// <summary>
        /// Constructor of the Vehicle class
        /// </summary>
        public Vehicle()
        {
            // Image properties
            BackColor = Color.White;
            TextAlign = ContentAlignment.TopCenter;

            GenerateVehicle();

            fuelling.Tick += Fuelling_Tick;

            // The time frame to service a vehicle (random between 1000 and 2000 milliseconds)
            waitLimit.Interval = rnd.Next(1000, 2000);
            waitLimit.Tick += WaitLimit_Tick;
            waitLimit.Start();
        }

        /// <summary>
        /// Start fuelling, vehicle is at a pump now
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fuelling_Tick(object sender, EventArgs e)
        {
            // If current fuel reaches maximum fuel, stop fueling (return)
            if (IsFuelled) return;
            currentFuel += fuelRate;

            // Communicate litres dispensed for all fueltypes to Transaction class
            if (fuelType == fuel[0]) Transaction.UnleadedDispence += fuelRate;
            else if (fuelType == fuel[1]) Transaction.LpgDispence += fuelRate;
            else Transaction.DieselDispence += fuelRate;

            // Show fuelling details on image
            Text = PumpValue;
        }

        /// <summary>
        /// Dispose the vehicle after not being serviced
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaitLimit_Tick(object sender, EventArgs e)
        {
            Dispose();            
        }

        /// <summary>
        /// Method to call up as soon as a vehicle is taken OUT of the queue
        /// </summary>
        public void StartFuelling()
        {
            // Fuel (1.5 litre) every second
            fuelling.Interval = 1000;

            // Stop timer which counts waiting limit
            waitLimit.Stop();

            // Start timer fueling time
            fuelling.Start();

            // Vehicle image
            BackColor = Color.Transparent;
            Size = new Size(194, 155);

            // Add one vehicle to VehicleAssisted count
            Transaction.VehiclesAssisted++;            
        }

        /// <summary>
        /// Method which generates vehicle
        /// </summary>
        private void GenerateVehicle()
        {
            // Array to hold the three vehicle types
            string[] vehicleTypes = new[] { "Car", "Van", "HGV" };

            // Use random to randomly switch between vehicle types
            vehicleType = vehicleTypes[rnd.Next(0, 3)];

            // Switch case to switch between vehicle types and their (possible) fueltype
            switch (vehicleType)
            {
                case "Car":

                    // Maximum fuel
                    maxFuel = 40;

                    // Get car picture from resources in properties
                    Image = Properties.Resources.CAR;

                    // Randomly go trough fueltype array to get fueltype (all types possible)
                    fuelType = fuel[rnd.Next(0, 3)];

                    break;

                case "Van":

                    // Maximum fuel
                    maxFuel = 80;

                    // get van picture from resources in properties
                    Image = Properties.Resources.VAN;

                    // Randomly go trough fueltype array to get fueltype (only LPG & diesel possible)
                    fuelType = fuel[rnd.Next(1, 3)];

                    break;

                case "HGV":

                    // Maximum fuel
                    maxFuel = 150;

                    // Get HGV picture from resources in properties
                    Image = Properties.Resources.HGV;

                    // Only one type possible, diesel
                    fuelType = fuel[2];

                    break;
            }

            // Random amount of fuel already in tank (not greater than a quarter of their total tank capacity).
            initialFuel = currentFuel = rnd.Next(0, maxFuel / 4);

            // Add one vehicle to TotalVehiclesGenerated count
            Transaction.TotalVehiclesGenerated++;
        }


    }
}
  