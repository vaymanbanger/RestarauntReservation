using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarauntReservation.Models
{
    public class RestarauntContext : DbContext 
    {
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Hall> Halls { get; set; } = null!;
        public DbSet<Reservation> Reservations { get; set; } = null!;
        public DbSet<Staff> Staffs { get; set; } = null!;
        public DbSet<Table> Tables { get; set; } = null!;

        public RestarauntContext()
        {
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\587-22\\source\\repos\\RestarauntReservation\\RestarauntReservation\\RestarauntDb.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}

