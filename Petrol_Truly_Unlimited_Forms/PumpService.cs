using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Petrol_Truly_Unlimited_Forms
{
    public partial class PumpService : UserControl 
    {      
        /// <summary>
        /// Constructor of this class
        /// </summary>
        public PumpService()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to find available pump (if any). Lane numbering goes horizontally.
        /// If pump 3 (last pump on a lane) is available but pump 2 or pump 1 are not, 
        /// a vehicle can not be added to pump 3.
        /// </summary>
        /// <returns></returns>
        public Pump AvailablePump()
        {
            if (pump3.isAvailable && pump2.isAvailable && pump1.isAvailable) return pump3;
            else if (pump2.isAvailable && pump1.isAvailable) return pump2;
            else if (pump1.isAvailable) return pump1;

            else if (pump6.isAvailable && pump5.isAvailable && pump4.isAvailable) return pump6;
            else if (pump5.isAvailable && pump4.isAvailable) return pump5;
            else if (pump4.isAvailable) return pump4;

            else if (pump9.isAvailable && pump8.isAvailable && pump7.isAvailable) return pump9;
            else if (pump8.isAvailable && pump7.isAvailable) return pump8;
            else if (pump7.isAvailable) return pump7;

            return null;
        }

        /// <summary>
        /// Make sure the pictureboxes stay in the same place 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PumpStation_SizeChanged(object sender, EventArgs e)
        {
            int gapSize = 10;
            pump2.Left = ((Width - pump2.Width) / 2) - gapSize;        
            pump8.Left = ((Width - pump8.Width)) / 2 - gapSize;;            
            pump5.Left = ((Width - pump5.Width)) / 2 - gapSize; ; 
            pump5.Top = ((Height - pump5.Height)) / 2;           
        }
    }
}
