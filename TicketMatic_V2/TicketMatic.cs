using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketMatic_V2.Models;
using TicketMatic_V2.UserControls;

namespace TicketMatic_V2
{
    public partial class TicketMatic : Form
    {
        private void Reservation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        public TicketMatic()
        {
            InitializeComponent();
            UC_Home uc = new UC_Home();
            //UC_Movie uc = new UC_Movie();
            //UC_Session uc = new UC_Session();
            //UC_Theater uc = new UC_Theater();
            addUserControl(uc);

            lb_userName.Text = Login.userName ?? Register.userName ?? "Guest";
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnl_container.Controls.Clear();
            pnl_container.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login.userName = Register.userName = null;
            new Login().Show();
            this.Hide();
        }

        public void tab_Home_Click(object sender, EventArgs e)
        {
            if (!pnl_container.Controls.Contains(UC_Home.Instance))
            {
                pnl_container.Controls.Add(UC_Home.Instance);
                UC_Home.Instance.Dock = DockStyle.Fill;
                UC_Home.Instance.BringToFront();
            }
            else
            {
                UC_Home.Instance.BringToFront();
            }
        }

        public void tab_Movie_Click(object sender, EventArgs e)
        {
            if (!pnl_container.Controls.Contains(UC_Movie.Instance))
            {
                pnl_container.Controls.Add(UC_Movie.Instance);
                UC_Movie.Instance.Dock = DockStyle.Fill;
                UC_Movie.Instance.BringToFront();
            }
            else
            {
                UC_Movie.Instance.BringToFront();
            }
        }

        public void tab_Session_Click(object sender, EventArgs e)
        {
            if (!pnl_container.Controls.Contains(UC_Session.Instance))
            {
                pnl_container.Controls.Add(UC_Session.Instance);
                UC_Session.Instance.Dock = DockStyle.Fill;
                UC_Session.Instance.BringToFront();
            }
            else
            {
                UC_Session.Instance.BringToFront();
            }
        }

        public void tab_Theater_Click(object sender, EventArgs e)
        {
            if (!pnl_container.Controls.Contains(UC_Theater.Instance))
            {
                pnl_container.Controls.Add(UC_Theater.Instance);
                UC_Theater.Instance.Dock = DockStyle.Fill;
                UC_Theater.Instance.BringToFront();
            }
            else
            {
                UC_Theater.Instance.BringToFront();
            }
        }

        public void tab_Reservation_Click(object sender, EventArgs e)
        {
            if (!pnl_container.Controls.Contains(UC_Reservation.Instance))
            {
                pnl_container.Controls.Add(UC_Reservation.Instance);
                UC_Reservation.Instance.Dock = DockStyle.Fill;
                UC_Reservation.Instance.BringToFront();
            }
            else
            {
                UC_Reservation.Instance.BringToFront();
            }
        }
    }
}
