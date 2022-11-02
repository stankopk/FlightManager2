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
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnFlights = new System.Windows.Forms.Button();
            this.lblThankYou = new System.Windows.Forms.Label();
            this.lblHello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBookings
            // 
            this.btnBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBookings.Location = new System.Drawing.Point(147, 304);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(188, 93);
            this.btnBookings.TabIndex = 0;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = true;
            // 
            // btnFlights
            // 
            this.btnFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFlights.Location = new System.Drawing.Point(465, 304);
            this.btnFlights.Name = "btnFlights";
            this.btnFlights.Size = new System.Drawing.Size(188, 93);
            this.btnFlights.TabIndex = 1;
            this.btnFlights.Text = "Flights";
            this.btnFlights.UseVisualStyleBackColor = true;
            // 
            // lblThankYou
            // 
            this.lblThankYou.AutoSize = true;
            this.lblThankYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThankYou.Location = new System.Drawing.Point(104, 182);
            this.lblThankYou.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThankYou.Name = "lblThankYou";
            this.lblThankYou.Size = new System.Drawing.Size(612, 48);
            this.lblThankYou.TabIndex = 2;
            this.lblThankYou.Text = "Thank you for using our service!";
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(266, 69);
            this.lblHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(278, 76);
            this.lblHello.TabIndex = 3;
            this.lblHello.Text = "Hello ***";
            this.lblHello.Click += new System.EventHandler(this.lblHello_Click);
            // 
            // GeneralView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.lblThankYou);
            this.Controls.Add(this.btnFlights);
            this.Controls.Add(this.btnBookings);
            this.Name = "GeneralView";
            this.Text = "GeneralView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnFlights;
        private System.Windows.Forms.Label lblThankYou;
        private System.Windows.Forms.Label lblHello;
    }
}