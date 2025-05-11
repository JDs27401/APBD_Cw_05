using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models;

public class Medicament {
    [Key]
    public int MedicamentId { get; set; }
    
    [Column(TypeName = "VARCHAR(100)")]
    [MaxLength(100)]
    public string Name { get; set; }
    
    [Column(TypeName = "VARCHAR(100)")]
    [MaxLength(100)]
    public string Description { get; set; }
    
    [Column(TypeName = "VARCHAR(100)")]
    [MaxLength(100)]
    public string Type { get; set; }
    
    public ICollection<PrescriptionMedicament> PrescriptionMedicaments { get; set; }
}