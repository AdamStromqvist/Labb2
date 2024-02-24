using Microsoft.EntityFrameworkCore;
using ProjektOOSU2_Test.EntetiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOSU2_Test.DataLayer
{
    public class PatientManagementContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<DoctorAppointment> DoctorAppointments { get; set; }
        public DbSet<MedicinePrescription> MedicinePrescriptions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=sqlutb2-db.hb.se,56077;Database=oosu2408;User ID=oosu2408;Password=UKB987;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeda en test-anställd
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1, // Sätt ett unikt ID
                    Username = "testuser",
                    NameEmployee = "Test User",
                    Profession = "Tester",
                    Password = "testpassword", // OBS: Det är starkt rekommenderat att hash:a lösenord i en produktionsmiljö
                    Specialization = "Testing"
                }
            );
        }

        public PatientManagementContext(DbContextOptions<PatientManagementContext> options) : base(options)
        {
        }
    }
}
