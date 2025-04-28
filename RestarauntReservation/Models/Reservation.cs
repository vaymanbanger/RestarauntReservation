namespace RestarauntReservation.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int ClientId { get; set; }

        public Client Client { get; set; }

        public int TableId { get; set; }

        public string Description { get; set; }

        public Table Table { get; set; }

        public DateTime Booking_Date { get; set; }
        public DateTime Booking_Time { get; set; }
        public int Number_Of_Guests { get; set; }
    }
}
