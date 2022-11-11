namespace FlightManager.Views
{
    partial class GeneralView
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
            this.btnFlights = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.lblThankYou = new System.Windows.Forms.Label();
            this.lblHello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFlights
            // 
            this.btnFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFlights.Location = new System.Drawing.Point(441, 289);
            this.btnFlights.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFlights.Name = "btnFlights";
            this.btnFlights.Size = new System.Drawing.Size(150, 79);
            this.btnFlights.TabIndex = 4;
            this.btnFlights.Text = "Flights";
            this.btnFlights.UseVisualStyleBackColor = true;
            // 
            // btnBookings
            // 
            this.btnBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBookings.Location = new System.Drawing.Point(223, 289);
            this.btnBookings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(150, 79);
            this.btnBookings.TabIndex = 5;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = true;
            // 
            // lblThankYou
            // 
            this.lblThankYou.AutoSize = true;
            this.lblThankYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThankYou.Location = new System.Drawing.Point(180, 198);
            this.lblThankYou.Name = "lblThankYou";
            this.lblThankYou.Size = new System.Drawing.Size(499, 39);
            this.lblThankYou.TabIndex = 6;
            this.lblThankYou.Text = "Thank you for using our service!";
            // 
            // lblHello
            // 
            this.lblHello.AutoEllipsis = true;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(48, 81);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(777, 63);
            this.lblHello.TabIndex = 7;
            this.lblHello.Text = "Hello, ...";
            this.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GeneralView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 477);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.lblThankYou);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnFlights);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GeneralView";
            this.Text = "GeneralView";
            this.Load += new System.EventHandler(this.GeneralView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFlights;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Label lblThankYou;
        private System.Windows.Forms.Label lblHello;
    }
}