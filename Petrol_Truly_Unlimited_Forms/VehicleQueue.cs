using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_Truly_Unlimited_Forms
{
    // Inherit blank windows control
    public partial class VehicleQueue : UserControl 
    {
        // Random number generator
        Random rnd = new Random();

        /// <summary>
        /// Constructor for this class
        /// </summary>
        public VehicleQueue()
        {
            InitializeComponent();
            CreateVehicle.Start();
        }

        /// <summary>
        /// Check if there is a vehicle generated and add in queue
        /// </summary>
        public Vehicle firstVehicle
        {
            get
            {
                if (Queue.Controls.Count < 1) return null; // No vehicle, return
                else return (Vehicle)Queue.Controls[0]; // Vehicle, add
            }
            
        }
 
        /// <summary>
        /// Private Forms Timer Method to add the vehicle in Forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateVehicle_Tick(object sender, EventArgs e)
        {
            // Vehicle image properties
            Vehicle v = new Vehicle();
            v.Size = new Size(194, 155);

            // Add vehicle and display vehicle image (v)
            Queue.Controls.Add(v);

            // Create a vehicle randomly between 1500 and 2200 milliseconds
            CreateVehicle.Interval = rnd.Next(1500, 2200); 
        }

        /// <summary>
        /// Method to run private method CreateVehicle
        /// </summary>
        public void StartGenerateVehicle()
        {
            CreateVehicle.Start();
        }

        /// <summary>
        /// Image properties vehicle in queue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VehicleQueue_Resize(object sender, EventArgs e)
        {
            label.Left = (Width - label.Width) / 2;
        }
    }
}
