using FlightManager.Global_Data;
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
    public partial class AdminGeneralView : Form
    {
        public AdminGeneralView()
        {
            InitializeComponent();
        }

        private void AdminGeneralView_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome back, {Data.currLoggedName}";
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            BookingsView generalView = new BookingsView();
            generalView.Show();
            this.Hide();
        }
    }
}
