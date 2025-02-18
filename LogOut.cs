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
    public partial class LogOut : Form
    {
        public LogOut()
        {
            InitializeComponent();
        }

        private void BTNMainMenu_Click(object sender, EventArgs e)
        {
            Form MainMenuForm = new MainMenu();
            MainMenuForm.Show();
            this.Close();
        }

        private void BTNSignOut_Click(object sender, EventArgs e)
        {
            Form LogInForm = new LogIn();
            LogInForm.Show();
            this.Close();
        }
    }
}
