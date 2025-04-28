namespace RestarauntReservation.Models
{
    public class Table
    {
        public int Id { get; set; }
        public int Number {  get; set; }
        public int Capacity { get; set; }
        public int HallId { get; set; }

        public Hall Hall { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
