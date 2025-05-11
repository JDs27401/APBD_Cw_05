using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Project.Models;

[PrimaryKey(nameof(PrescriptionId))]
[Table("Prescriptions")]

public class Prescription {
    [Key]
    public int PrescriptionId { get; set; }
    
    [ForeignKey(nameof(Doctor))]
    public int DoctorId { get; set; }
    
    [ForeignKey(nameof(Patient))]
    public int PatientId { get; set; }
    
    public DateOnly Date { get; set; }
    public DateOnly DueDate { get; set; }
    
    public Doctor Doctor { get; set; }
    public Patient Patient { get; set; }
    
    public ICollection<PrescriptionMedicament> PrescriptionMedicaments { get; set; }
}