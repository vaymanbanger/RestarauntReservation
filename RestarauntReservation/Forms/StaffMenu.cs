using Microsoft.EntityFrameworkCore;
using RestarauntReservation.Models;
using RestarauntReservation.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestarauntReservation.Forms
{
    public partial class StaffMenu : Form
    {
        public StaffMenu()
        {
            InitializeComponent();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void LoadReservations()
        {
            flowLayoutPanel1.Controls.Clear();

            using var context = new RestarauntContext();

            var reservations = context.Reservations
                .Include(r => r.Table)
                .Include(r => r.Client)
                .ToList();

            foreach (var res in reservations)
            {
                var control = new StaffUserControl(res);
                control.Margin = new Padding(10);
                flowLayoutPanel1.Controls.Add(control);
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaffMenu_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }

        public void ReloadReservations()
        {
            LoadReservations();
        }
    }
}
