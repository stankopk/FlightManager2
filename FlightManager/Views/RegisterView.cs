using FlightManager.Controllers;
using FlightManager.Models;
using FlightManager.Views;
using System;
using System.Windows.Forms;

namespace FlightManager
{
    public partial class RegisterView : Form
    {
        RegisterController controller = new RegisterController();
        public RegisterView()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtFName.Text))
            {
                MessageBox.Show("Empty First Name");
            }
            else if (String.IsNullOrWhiteSpace(txtLName.Text))
            {
                MessageBox.Show("Empty Last Name");
            }
            else if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Empty E-Mail");
            }
            else if (String.IsNullOrWhiteSpace(txtphoneNumber.Text) || txtphoneNumber.Text.Length < 7)
            {
                MessageBox.Show("Invalid phone number");
            }
            else if (String.IsNullOrWhiteSpace(txtPass.Text) || txtPass.Text.Length <= 3)
            {
                MessageBox.Show("The password is empty or It's too short");
            }
            else if (String.IsNullOrWhiteSpace(txtAdress.Text))
            {
                MessageBox.Show("Invalid Adress");
            }
            else if (String.IsNullOrWhiteSpace(txtPersonalID.Text))
            {
                MessageBox.Show("Invalid Personal ID");
            }
            else if (String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Invalid Username");
            }
            else
            {
                Account acc = new Account();

                acc.FirstName = txtFName.Text;
                acc.LastName = txtLName.Text;
                acc.Email = txtEmail.Text;
                acc.PhoneNumber = txtphoneNumber.Text;
                acc.Password = txtPass.Text;
                acc.IsAdmin = false;
                acc.Username = txtUsername.Text;
                acc.PersonalID = txtPersonalID.Text;
                acc.Adress = txtAdress.Text;

                controller.AccountCreate(acc);

                MessageBox.Show("Registered successfully!");

                //For when Login view is ready
                //LoginView login = new LoginView();
                //login.Show();
                //this.Hide();
            }
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            MainView mainView = new MainView();
            mainView.Show();
            this.Hide();
        }
    }
}
