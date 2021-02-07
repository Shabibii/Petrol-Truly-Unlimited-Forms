namespace Petrol_Truly_Unlimited_Forms
{
    partial class VehicleQueue
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing"> True if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            this.Queue = new System.Windows.Forms.FlowLayoutPanel();
            this.CreateVehicle = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Queue
            // 
            this.Queue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Queue.Location = new System.Drawing.Point(0, 51);
            this.Queue.Name = "Queue";
            this.Queue.Size = new System.Drawing.Size(642, 445);
            this.Queue.TabIndex = 0;
            // 
            // CreateVehicle
            // 
            this.CreateVehicle.Interval = 1500;
            this.CreateVehicle.Tick += new System.EventHandler(this.CreateVehicle_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(268, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(77, 26);
            this.label.TabIndex = 1;
            this.label.Text = "Queue";
            // 
            // VehicleQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label);
            this.Controls.Add(this.Queue);
            this.Name = "VehicleQueue";
            this.Size = new System.Drawing.Size(642, 496);
            this.Resize += new System.EventHandler(this.VehicleQueue_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Use FlowLayoutPanel to control and arrange its contents in a horizontal or vertical flow direction
        private System.Windows.Forms.FlowLayoutPanel Queue; 
        private System.Windows.Forms.Timer CreateVehicle; 
        private System.Windows.Forms.Label label;
    }
}
