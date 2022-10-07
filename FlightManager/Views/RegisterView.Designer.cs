namespace FlightManager
{
    partial class RegisterView
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
            this.lblRegister = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtphoneNumber = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(278, 29);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(229, 63);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Register";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(289, 122);
            this.txtFName.Multiline = true;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(218, 37);
            this.txtFName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(289, 243);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(218, 37);
            this.txtEmail.TabIndex = 2;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(289, 182);
            this.txtLName.Multiline = true;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(218, 37);
            this.txtLName.TabIndex = 3;
            // 
            // txtphoneNumber
            // 
            this.txtphoneNumber.Location = new System.Drawing.Point(289, 308);
            this.txtphoneNumber.Multiline = true;
            this.txtphoneNumber.Name = "txtphoneNumber";
            this.txtphoneNumber.Size = new System.Drawing.Size(218, 37);
            this.txtphoneNumber.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(289, 370);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(218, 37);
            this.txtPass.TabIndex = 5;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(177, 122);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(106, 25);
            this.lblFName.TabIndex = 6;
            this.lblFName.Text = "First Name";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(177, 182);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(106, 25);
            this.lblLName.TabIndex = 7;
            this.lblLName.Text = "Last Name";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEMail.Location = new System.Drawing.Point(215, 243);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(68, 25);
            this.lblEMail.TabIndex = 8;
            this.lblEMail.Text = "E-Mail";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(140, 308);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(143, 25);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(177, 370);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 25);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEMail);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtphoneNumber);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblRegister);
            this.Name = "RegisterView";
            this.Text = "RegisterView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtphoneNumber;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPassword;
    }
}