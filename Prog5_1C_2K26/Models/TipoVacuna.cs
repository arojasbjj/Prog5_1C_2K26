using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prog5_1C_2K26.Models
{
    public class TipoVacuna
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [DisplayName("Tipo de Vacuna")]
        public string descripcion { get; set; }

        [Required(ErrorMessage = "El código es obligatorio")]
        [DisplayName("Código")]
        [StringLength(10, ErrorMessage = "El código no puede exceder 10 caracteres")]
        public string codigo { get; set; }

        public TipoVacuna()
        {
        }
    }
}