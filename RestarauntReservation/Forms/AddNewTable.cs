using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestarauntReservation.Forms;
using RestarauntReservation.Models;

namespace RestarauntReservation.Forms
{
    public partial class AddNewTable : Form
    {
        private int _TableId;
        private string _date;
        private string _time;
        private Client _client;
        private MainMenu _mainMenu;
        public AddNewTable(Client client, MainMenu mainMenu, string date, string time, int TableId)
        {
            InitializeComponent();
            TimeTextBox.Text = time;
            DateTextBox.Text = date;

            _client = client;
            _mainMenu = mainMenu;
            _TableId = TableId;
            _time = time;
            _date = date;
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            var datePart = DateTime.Parse(_date).Date;
            var timePart = TimeOnly.Parse(_time);

            using RestarauntContext dbcontext = new RestarauntContext();
            var newReservation = new Reservation
            {
                Description = DescriptionTextBox1.Text,
                Number_Of_Guests = Convert.ToInt32(GuestsNumericUpDown1.Value),
                Booking_Date = datePart,
                Booking_Time = timePart,
                TableId = _TableId,
                ClientId = _client.Id,
            };

            dbcontext.Reservations.Add(newReservation);
            dbcontext.SaveChanges();
            _mainMenu.UpdateData();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
