using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestAPI.Models.Entity
{
    public class PeliculaEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Titulo { get; set; }
        [Required]
        public int MinutosDuracion { get; set; }
        [Required, MaxLength(50)]
        public string Director { get; set; }
        [Required]
        public DateOnly FechaDeEstreno { get; set; }
        public double Presupuesto { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
