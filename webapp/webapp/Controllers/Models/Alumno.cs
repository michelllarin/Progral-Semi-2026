using System.ComponentModel.DataAnnotations;
namespace webapp.Controllers.Models
{
    public class Alumno
    {
        [ Key ]
        public int idAlumno { get; set; }

        public string codigo { get; set; } = string.Empty;

        public string nombre { get; set; } = string.Empty;

        public string direccion { get; set; } = string.Empty;

        public string? telefono { get; set; }

        public string? email { get; set; }
    }
}
