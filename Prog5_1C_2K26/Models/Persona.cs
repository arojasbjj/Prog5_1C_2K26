using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prog5_1C_2K26.Models
{
    public class Persona
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "La cédula es obligatoria")]
        [DisplayName("Cédula")]
        [StringLength(20, ErrorMessage = "La cédula no puede exceder 20 caracteres")]
        public string cedula { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [DisplayName("Nombre Completo")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [DisplayName("Teléfono")]
        [Phone(ErrorMessage = "Formato de teléfono inválido")]
        public string telefono { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [DisplayName("Correo Electrónico")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido")]
        public string correo { get; set; }

        [DisplayName("Dirección")]
        public string? direccion { get; set; }

        public Persona()
        {
        }
    }
}