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
            this.GeneralViewLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralViewLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFlights
            // 
            this.btnFlights.BackColor = System.Drawing.Color.Transparent;
            this.btnFlights.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFlights.FlatAppearance.BorderSize = 4;
            this.btnFlights.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFlights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFlights.Location = new System.Drawing.Point(209, 350);
            this.btnFlights.Margin = new System.Windows.Forms.Padding(2);
            this.btnFlights.Name = "btnFlights";
            this.btnFlights.Size = new System.Drawing.Size(190, 74);
            this.btnFlights.TabIndex = 4;
            this.btnFlights.Text = "Flights";
            this.btnFlights.UseVisualStyleBackColor = false;
            // 
            // btnBookings
            // 
            this.btnBookings.BackColor = System.Drawing.Color.Transparent;
            this.btnBookings.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnBookings.FlatAppearance.BorderSize = 4;
            this.btnBookings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBookings.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBookings.Location = new System.Drawing.Point(209, 252);
            this.btnBookings.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(190, 72);
            this.btnBookings.TabIndex = 5;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = false;
            // 
            // lblThankYou
            // 
            this.lblThankYou.AutoSize = true;
            this.lblThankYou.BackColor = System.Drawing.Color.Transparent;
            this.lblThankYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblThankYou.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblThankYou.Location = new System.Drawing.Point(50, 183);
            this.lblThankYou.Name = "lblThankYou";
            this.lblThankYou.Size = new System.Drawing.Size(505, 37);
            this.lblThankYou.TabIndex = 6;
            this.lblThankYou.Text = "Thank you for using our service!";
            this.lblThankYou.Click += new System.EventHandler(this.lblThankYou_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoEllipsis = true;
            this.lblHello.BackColor = System.Drawing.Color.Transparent;
            this.lblHello.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHello.ForeColor = System.Drawing.Color.Red;
            this.lblHello.Location = new System.Drawing.Point(137, 130);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(325, 65);
            this.lblHello.TabIndex = 7;
            this.lblHello.Text = "Welcome!";
            this.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHello.Click += new System.EventHandler(this.lblHello_Click);
            // 
            // GeneralViewLogo
            // 
            this.GeneralViewLogo.BackColor = System.Drawing.Color.Transparent;
            this.GeneralViewLogo.BackgroundImage = global::FlightManager.Properties.Resources.flightmanagerlogo;
            this.GeneralViewLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GeneralViewLogo.Location = new System.Drawing.Point(198, -39);
            this.GeneralViewLogo.Name = "GeneralViewLogo";
            this.GeneralViewLogo.Size = new System.Drawing.Size(214, 206);
            this.GeneralViewLogo.TabIndex = 8;
            this.GeneralViewLogo.TabStop = false;
            // 
            // GeneralView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlightManager.Properties.Resources.ariportbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 470);
            this.Controls.Add(this.lblThankYou);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.GeneralViewLogo);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnFlights);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GeneralView";
            this.Text = "GeneralView";
            this.Load += new System.EventHandler(this.GeneralView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GeneralViewLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFlights;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Label lblThankYou;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.PictureBox GeneralViewLogo;
    }
}