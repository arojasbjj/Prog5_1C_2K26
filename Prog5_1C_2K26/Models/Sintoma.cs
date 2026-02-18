using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prog5_1C_2K26.Models
{
    public class Sintoma
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [DisplayName("Descripción del Síntoma")]
        public string descripcion { get; set; }

        public Sintoma()
        {
        }
    }
}