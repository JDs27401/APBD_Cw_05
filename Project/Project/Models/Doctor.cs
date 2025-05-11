using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models;

[Table("Doctor")]

public class Doctor {
    [Key]
    public int DoctorId { get; set; }
    [Column(TypeName = "nvarchar(100)")]
    [MaxLength(100)]
    public string FirstName { get; set; }
    [Column(TypeName = "nvarchar(100)")]
    [MaxLength(100)]
    public string LastName { get; set; }
    [Column(TypeName = "nvarchar(100)")]
    [MaxLength(100)]
    public string Email { get; set; }
    
    public ICollection<Prescription> Prescriptions { get; set; }
}