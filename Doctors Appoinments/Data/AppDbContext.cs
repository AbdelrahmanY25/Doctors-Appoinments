using ContactDoctor.Models;
using Doctors_Appoinments.Models;
using Microsoft.EntityFrameworkCore;

namespace Doctors_Appoinments.Data
{
    public class AppDbContext : DbContext
    {
       public DbSet<Doctor> Doctors { get; set; }
       public DbSet<Appoinment> Appoinments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true).Build();

            var connection = builder.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Doctor>()
                .Property(x => x.Id)
                .UseIdentityColumn(1, 1);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.Name)
                .HasColumnType("Varchar(50)");

            modelBuilder.Entity<Doctor>()
                .Property(d => d.Specialization)
                .HasColumnType("Varchar(50)");

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { Id = 1, Name = "Dr. John Smith", Specialization = "Cardiology", Img = "doctor1.jpg" },
                new Doctor { Id = 2, Name = "Dr. Sarah Johnson", Specialization = "Pediatrics", Img = "doctor2.jpg" },
                new Doctor { Id = 3, Name = "Dr. Emily Davis", Specialization = "Dermatology", Img = "doctor3.jpg" },
                new Doctor { Id = 4, Name = "Dr. Michael Lee", Specialization = "Orthopedics", Img = "doctor4.jpg" },
                new Doctor { Id = 5, Name = "Dr. William Clark", Specialization = "Neurology", Img = "doctor5.jpg" }
            );

            modelBuilder.Entity<Appoinment>()
                .Property(p => p.Id)
                .UseIdentityColumn(1, 1);

            modelBuilder.Entity<Appoinment>()
                .Property(p => p.PatientName)
                .IsRequired(false);

            modelBuilder.Entity<Appoinment>()
                .Property(p => p.PatientName)
                .HasColumnType("Varchar(50)");

        }

    }
}
