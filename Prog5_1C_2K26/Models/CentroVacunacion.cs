using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Prog5_1C_2K26.Models
{
    public class CentroVacunacion
    {
        [Key]

        public int id { get; set; }

        [Required]

        public string descripcion { get; set; }

        [Required]
        [DisplayName("Provincia")]
        [Range(1, 7, ErrorMessage = "Los valores de las provincias deben de estar entre 1 y 7")]

        public int ProvincialId { get; set; }

        public CentroVacunacion()
        {

        }
    }
}
