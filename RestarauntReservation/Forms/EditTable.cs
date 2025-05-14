using Guna.UI2.WinForms.Suite;
using RestarauntReservation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RestarauntReservation.Forms
{
    public partial class EditTable : Form
    {
        private Reservation _reservation;
        public EditTable(Reservation reservation)
        {
            InitializeComponent();
            _reservation = reservation;
            LoadReservationData();
        }

        private void LoadReservationData()
        {
            DescriptionTextBox1.Text = _reservation.Description;
            GuestsNumericUpDown1.Value = _reservation.Number_Of_Guests;
            DateTextBox.Text = _reservation.Booking_Date.ToString();
            TimeTextBox.Text = _reservation.Booking_Time.ToString();
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            using var context = new RestarauntContext();
            var res = context.Reservations.FirstOrDefault(r => r.Id == _reservation.Id);

            if (res != null)
            {
                res.Description = DescriptionTextBox1.Text;
                res.Number_Of_Guests = (int)GuestsNumericUpDown1.Value;

                if (DateTime.TryParse(DateTextBox.Text, out var date) &&
                    TimeSpan.TryParse(TimeTextBox.Text, out var time))
                {
                    res.Booking_Date = date.Date;
                    res.Booking_Time = date.Date.Add(time);
                }
                else
                {
                    MessageBox.Show("Неверный формат даты или времени");
                    return;
                }

                context.SaveChanges();
                MessageBox.Show("Бронирование успешно обновлено");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка: бронирование не найдено");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
