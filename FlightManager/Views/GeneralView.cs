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
    public partial class GeneralView : Form
    {
        public GeneralView()
        {
            InitializeComponent();
        }
        private void GeneralView_Load(object sender, EventArgs e)
        {
            lblHello.Text = $"Hello, {Data.currLoggedName}";
        }

        private void lblThankYou_Click(object sender, EventArgs e)
        {

        }

        private void lblHello_Click(object sender, EventArgs e)
        {

        }
    }
}
