using RestarauntReservation.Forms;
using RestarauntReservation.Models;

namespace RestarauntReservation.UserControls
{
    public partial class PersonalUserControl : UserControl
    {
        private Reservation reservation;
        public PersonalUserControl(Reservation reservation)
        {
            InitializeComponent();
            this.reservation = reservation;
            FillUserControl();
        }

        private void FillUserControl()
        {
            labelTable.Text = "Стол #" + reservation.Table?.Number.ToString();
            labelTime.Text = reservation.Booking_Time.ToString();
            labelCount.Text = reservation.Number_Of_Guests.ToString() + " гостей";
            labelDate.Text = reservation.Booking_Date.ToShortDateString();

        }

        private void guna2CircleButtonCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Удалить бронирование?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using var context = new RestarauntContext();

                var res = context.Reservations.FirstOrDefault(r => r.Id == reservation.Id);
                if (res != null)
                {
                    context.Reservations.Remove(res);
                    context.SaveChanges();

                    MessageBox.Show("Бронирование удалено.");

                    this.Parent.Controls.Remove(this);

                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is MainMenu mainMenu)
                        {
                            mainMenu.UpdateData();
                            break;
                        }
                    }
                }
            }
        }
    }
}
