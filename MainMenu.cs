using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyTickets
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.Load += MainMenu_Load;
        }
        private void ChangeBackGroundFormColorForMainMenu()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.FromArgb(0, 0, 64);
                    break;
                }
            }
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            BTNNewBooking.Focus();
            ChangeBackGroundFormColorForMainMenu();
        }
        private void BTNNewBooking_Click(object sender, EventArgs e)
        {
            Form newBookingForm = new NewBooking();
            newBookingForm.Show();
        }

        private void BTNFindBooking_Click(object sender, EventArgs e)
        {
            Form FindBookingForm = new FindPreviousBooking();
            FindBookingForm.Show();
        }

        private void BTNEditBooking_Click(object sender, EventArgs e)
        {
            Form EditBookingForm = new EditBooking();
            EditBookingForm.Show();
        }

        private void BTNCancelBooking_Click(object sender, EventArgs e)
        {
            Form CancelBookingForm = new CancelBooking();
            CancelBookingForm.Show();
        }

        private void BTNCheckCountries_Click(object sender, EventArgs e)
        {
            Form AvailableCountriesForm = new AvailableCountries();
            AvailableCountriesForm.Show();
        }

        private void BTNLogOut_Click(object sender, EventArgs e)
        {
            Form LogOutForm = new LogOut();
            LogOutForm.Show();
            this.Close();
        }
    }
}
