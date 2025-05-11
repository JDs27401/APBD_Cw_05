using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Project.Models;

[Table(("Prescription_Medicament"))]
[PrimaryKey(nameof(MedicamentId), nameof(PrescriptionId))]

public class PrescriptionMedicament {
    [ForeignKey(nameof(Medicament))]
    public int MedicamentId{ get; set; }
    
    [ForeignKey(nameof(Prescription))]
    public int PrescriptionId{ get; set; }
    
    public int Dose { get; set; }
    
    [Column(TypeName = "nvarchar(100)")]
    [MaxLength(100)]
    public string Details { get; set; }
}