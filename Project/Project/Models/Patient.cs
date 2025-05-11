using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models;

[Table("Patient")]

public class Patient {
    [Key]
    public int PatientId { get; set; }
    [Column(TypeName = "nvarchar(100)")]
    [MaxLength(100)]
    public string FirstName { get; set; }
    [Column(TypeName = "nvarchar(100)")]
    [MaxLength(100)]
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    
    public ICollection<Prescription> Prescriptions { get; set; }
}