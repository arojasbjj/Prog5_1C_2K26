using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prog5_1C_2K26.Data;
using Prog5_1C_2K26.Models;

namespace Prog5_1C_2K26.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObtenerSintomasController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public ObtenerSintomasController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [Route("GetSintomas")]
        [HttpGet]
        public List<Sintoma> GetSintomas(string texto)
        {
            return (from s in this._appDbContext.Sintomas.Take(10)
                    where s.Nombre.StartsWith(texto) || s.descripcion.StartsWith(texto) || string.IsNullOrEmpty(texto)
                    select s).ToList();
        }

    }
}
