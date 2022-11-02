﻿using FlightManager.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManager.Views
{
    public partial class LoginView : Form
    {
        LoginController controller = new LoginController(); 
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            MainView main = new MainView();
            main.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var message = controller.ShowMessage(txtUsername.Text, txtPass.Text);
            if (message != null)
            {
                MessageBox.Show(message);
            }
            else if (message == "Admin")
            {
                //To General Normal View
            }
            else
            {
                //To General Admin View
            }
        }
    }
}
