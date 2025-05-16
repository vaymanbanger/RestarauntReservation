using RestarauntReservation.Forms;
using RestarauntReservation.Models;


namespace RestarauntReservation.UserControls
{
    public partial class StaffUserControl : UserControl
    {
        private Reservation reservation;
        public StaffUserControl(Reservation reservation)
        {
            InitializeComponent();
            this.reservation = reservation;
            FillUserControl();
        }

        private void FillUserControl()
        {
            labelTable.Text = $"Стол #{reservation.TableId}";
            labelTime.Text = reservation.Booking_Time.ToString();
            labelCount.Text = $"{reservation.Number_Of_Guests.ToString()} гостей";
            labelName.Text = $"Имя  {reservation.Client.Name}";
            labelNumber.Text = reservation.Client.Phone_Number.ToString();
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
                }
            }
        }

        private void guna2CircleButtonEdit_Click(object sender, EventArgs e)
        {
            var editTable = new EditTable(reservation); // передаём текущую бронь
            if (editTable.ShowDialog() == DialogResult.OK)
            {
                // Обновим интерфейс после редактирования
                FillUserControl();
            }
        }
    }
}
