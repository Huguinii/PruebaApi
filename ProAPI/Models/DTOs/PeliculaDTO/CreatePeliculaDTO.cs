using System.ComponentModel.DataAnnotations;

namespace RestAPI.Models.DTOs.PeliculaDTO
{
    public class CreatePeliculaDTO
    {
        [Required(ErrorMessage = "Titulo is required")]
        [MaxLength(50, ErrorMessage = "Max char is 50")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "MinutosDuracion is required")]
        public int MinutosDuracion { get; set; }

        [Required(ErrorMessage = "Director is required")]
        [MaxLength(50, ErrorMessage = "Max char is 50")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Presupuesto is required")]
        public double Presupuesto { get; set; }

        [Required(ErrorMessage = "FechaDeEstreno is required")]
        public DateOnly FechaDeEstreno { get; set; }

    }
}
