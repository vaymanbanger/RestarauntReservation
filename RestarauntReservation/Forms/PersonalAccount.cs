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
    public partial class PersonalAccount : Form
    {
        private Client _client;
        public PersonalAccount(Client client)
        {
            _client = client;
            InitializeComponent();
            LoadReservations();
        }

        private void LoadReservations()
        {
            using var context = new RestarauntContext();

            var reservations = context.Reservations
                .Include(r => r.Table)
                .Where(r => r.ClientId == _client.Id &&
                r.Booking_Date >= DateTime.Today)
                .ToList();

            flowLayoutPanel1.Controls.Clear();

            foreach (var res in reservations)
            {
                var control = new PersonalUserControl(res);
                flowLayoutPanel1.Controls.Add(control);
            }
        }

        private void PersonalAccount_Load(object sender, EventArgs e)
        {
           
        }
    }
}
