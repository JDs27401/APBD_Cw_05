using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Data;

public class DatabaseContext : DbContext{
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<Medicament> Medicaments { get; set; }
    public DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlServer("");
    }

    protected DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {
    }

    public DatabaseContext(DbContextOptions options) : base(options) {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Doctor>(a => {
            a.ToTable("Doctors");
            
            a.HasKey(x => x.DoctorId);
            a.Property(x => x.FirstName).HasMaxLength(100);
            a.Property(x => x.LastName).HasMaxLength(100);
        });

        modelBuilder.Entity<Patient>(a => {
            a.ToTable("Patients");
            
            a.HasKey(x => x.PatientId);
            a.Property(x => x.FirstName).HasMaxLength(100);
            a.Property(x => x.LastName).HasMaxLength(100);
        });

        modelBuilder.Entity<Prescription>(a => {
            a.ToTable("Prescriptions");

            a.HasKey(x => x.PrescriptionId);
            a.HasKey(x => x.PatientId);
            a.Property(x => x.DoctorId);
            a.Property(x => x.Patient);
            a.Property(x => x.Doctor);
            a.Property(x => x.Date);
            a.Property(x => x.DueDate);
        });

        modelBuilder.Entity<Medicament>(a => {
            a.ToTable("Medicaments");

            a.HasKey(x => x.MedicamentId);
            a.Property(x => x.Name).HasMaxLength(100);
            a.Property(x => x.Description).HasMaxLength(100);
            a.Property(x => x.Type).HasMaxLength(100);
        });

        modelBuilder.Entity<PrescriptionMedicament>(a => {
            a.ToTable("Prescription_Medicaments");

            a.HasKey(x => x.MedicamentId);
            a.HasKey(x => x.PrescriptionId);

            a.Property(x => x.Dose);
            a.Property(x => x.Details).HasMaxLength(100);
        });
    }
}