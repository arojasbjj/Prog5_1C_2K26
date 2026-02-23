using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prog5_1C_2K26.Models
{
    public class Sintoma
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="El nombre es obligatorio")]
        [StringLength(64, MinimumLength = 8, ErrorMessage = "El nombre debe tener entre 8 y 64 caracteres")]
        [DisplayName("Nombre del síntoma")]
        public string Nombre { get;set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [StringLength(255, MinimumLength = 8, ErrorMessage = "La descripción debe tener entre 8 y 255 caracteres")]
        [DisplayName("Descripción del Síntoma")]
        public string descripcion { get; set; }

        public Sintoma()
        {
        }
    }
}