using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_Truly_Unlimited_Forms
{
    public class Pump : Button 
    {
        // Object created from vehicle class
        private Vehicle currentVehicle;

        // Bool to check if there is a vehicle being fuelled
        public bool isAvailable => currentVehicle == null;

        // Pump image    
        private Image pumpImg = Properties.Resources.PUMP;

        // Fuelling time limit
        private Timer fuelLimit = new Timer();

        /// <summary>
        /// Assign a vehicle to pump
        /// </summary>
        /// <param Vehicle class object="v"></param>
        public void AssignVehicle(Vehicle v)
        {
            // Check if pump is available
            if (!isAvailable) return;

            // Dispose vehicle from queue
            v.Dispose();

            // Pass object into method parameter
            currentVehicle = v;

            // Replace the pump image by the vehicle image
            Image = v.Image;

            // Start fuelling
            currentVehicle.fuelling.Tick += Fuelling_Tick;
            currentVehicle.StartFuelling();
        }

        /// <summary>
        /// Activity when vehicle is fuelled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fuelling_Tick(object sender, EventArgs e)
        {
            if (currentVehicle == null) return;

            if (currentVehicle.IsFuelled) 
            {
                // Record Transactions
                string[] transactionDetails = currentVehicle.Details.Split('\n');
                Transaction.transactions.Add(transactionDetails);

                // Stop fuelling & release date
                currentVehicle.Dispose(); 
                currentVehicle = null;
                
                // Set image back to pump image and string to null
                Image = pumpImg;
                Text = "";
            }
            // Image text when fuelling vehicle
            if (!isAvailable) Text = currentVehicle.Text;
        }
       

        /// <summary>
        /// Constructor of this class
        /// </summary>
        public Pump()
        {
            int x = (Width + pumpImg.Width) /2;
            int y = (Height + pumpImg.Height) / 2;
            pumpImg = pumpImg.GetThumbnailImage(x, y, null, IntPtr.Zero);

            Image = pumpImg;

            BackgroundImageLayout = ImageLayout.Stretch | ImageLayout.Center;

            // Make mouse hover colour and button on click the same
            BackColor = Color.White;
            TextAlign = ContentAlignment.TopCenter;
            
            // Remove sense of being a button
            FlatAppearance.MouseDownBackColor = FlatAppearance.MouseOverBackColor = BackColor;
        
        }

    }
}
