using Microsoft.EntityFrameworkCore;
using RestarauntReservation.Models;
using System.Data;

namespace RestarauntReservation.Forms
{
    public partial class MainMenu : Form
    {
        private Client _client;
        public MainMenu(Client client)
        {

            InitializeComponent();
            _client = client;

            ComboBoxTime.SelectedIndex = 0;
            DateTimePicker1.MinDate = DateTime.Now;
            DateTimePicker1.Value = DateTime.Now;
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            UpdateData();
        }
        /// <summary>
        /// обновление столов ( забронирован / не забронирован )
        /// </summary>
        public async void UpdateData()
        {
            using var context = new RestarauntContext();

            var selectedDate = DateTimePicker1.Value.Date;
            var selectedTime = TimeSpan.Parse(ComboBoxTime.SelectedItem.ToString());

            var reservations = await context.Reservations
                .Include(r => r.Table)
                .Include(r => r.Client)
                .Where(r =>
                    r.Booking_Date.Date == selectedDate &&
                    r.Booking_Time.TimeOfDay == selectedTime)
                .ToListAsync();

            UpdateTableColors(reservations, selectedDate.Add(selectedTime));

        }

        /// <summary>
        /// покраска стола красным либо зеленым
        /// </summary>
        /// <param name="tableNumber"></param>
        /// <param name="isOccupied"></param>
        private void UpdateTableColor(int tableNumber, bool isOccupied)
        {
            var control = Controls.Find("TableShapes" + tableNumber, true).FirstOrDefault();

            if (control is Guna.UI2.WinForms.Guna2Shapes TableShapes)
            {
                TableShapes.FillColor = isOccupied ? Color.Red : Color.Lime
                    ;
            }
        }
        /// <summary>
        /// обновление цвета стола
        /// </summary>
        /// <param name="reservations"></param>
        /// <param name="selectedDateTime"></param>
        private void UpdateTableColors(List<Reservation> reservations, DateTime selectedDateTime)
        {
            using var context = new RestarauntContext();
            var tables = context.Tables.ToList();

            foreach (var table in tables)
            {
                bool isOccupied = reservations.Any(r => r.TableId == table.Id);
                UpdateTableColor(table.Number, isOccupied);
            }
        }


        private void TableShapes1_Click(object sender, EventArgs e)
        {
            NewTable(1);
        }

        private void TableShapes4_Click(object sender, EventArgs e)
        {
            NewTable(4);
        }

        private void TableShapes2_Click(object sender, EventArgs e)
        {
            NewTable(2);
        }

        private void TableShapes3_Click(object sender, EventArgs e)
        {
            NewTable(3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void ComboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
        /// <summary>
        /// открытие окна с бронированием стола
        /// </summary>
        /// <param name="num"></param>
        private void NewTable(int num)
        {
            var date = DateTimePicker1.Value.ToString();
            var time = ComboBoxTime.SelectedItem.ToString();

            using var context = new RestarauntContext();
            var TableId = context.Tables.FirstOrDefault(x => x.Number == num)?.Id;
            if (TableId == null)
            {
                MessageBox.Show("Ошибка.Повторите еще раз");
            }

            AddNewTable addNewTable = new AddNewTable(_client, this, date, time, TableId!.Value);
            addNewTable.Show();
        }

        private void TableShapes5_Click(object sender, EventArgs e)
        {
            NewTable(5);
        }

        private void TableShapes6_Click(object sender, EventArgs e)
        {
            NewTable(6);
        }

        private void TableShapes7_Click(object sender, EventArgs e)
        {
            NewTable(7);
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            PersonalAccount personalAccount = new PersonalAccount(_client);
            personalAccount.ShowDialog();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
