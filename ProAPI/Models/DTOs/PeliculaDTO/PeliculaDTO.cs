namespace RestAPI.Models.DTOs.PeliculaDTO
{
    public class PeliculaDTO : CreatePeliculaDTO
    {
        public string Titulo {  get; set; }
        public int MinutosDuracion {  get; set; }
        public string Director {  get; set; }
        public double Presupuesto { get; set; }
        public DateOnly FechaDeEstreno { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
