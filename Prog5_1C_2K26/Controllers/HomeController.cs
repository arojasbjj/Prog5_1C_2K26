using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Prog5_1C_2K26.ActionFilters;// Se agrega el namespace donde se encuentra el Action Filter personalizado, para cumplir con el action filter
using Prog5_1C_2K26.Models;
using Prog5_1C_2K26.Data;

namespace Prog5_1C_2K26.Controllers
{
    [LogActionFilter]
    // Action Filter se aplica a todo el controlador
    // Se ejecuta antes y después de cada acción.
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Calculadora basica

        public IActionResult BCalc()
        {
            return View();
        }
        // Acción GET que muestra la vista inicial de la calculadora

        [HttpPost]
        [ActionName("Sumar")]
        // ActionName permite usar "Sumar" como nombre público de la acción
        public IActionResult Suma()
        {
            try
            {
                int num1 = ObtenerNumero("n1");
                int num2 = ObtenerNumero("n2");
                // Se utiliza un método auxiliar marcado como NonAction
                ViewBag.Result = "Resultado de la suma: " + (num1 + num2);
            }
            catch
            {
                ViewBag.Result = "Datos erroneos ingresados.";
            }

            return View("bCalc");
        }

        
        [HttpPost]
        [ActionName("Restar")]
        public IActionResult Resta()
        {
            try
            {
                int num1 = ObtenerNumero("n1");
                int num2 = ObtenerNumero("n2");
                ViewBag.Result = "Resultado de la resta: " + (num1 - num2);
            }
            catch
            {
                ViewBag.Result = "Datos erroneos ingresados.";
            }

            return View("bCalc");
        }

        
        [HttpPost]
        [ActionName("Multiplicacion")]
        public IActionResult Multiplicacion()
        {
            try
            {
                int num1 = ObtenerNumero("n1");
                int num2 = ObtenerNumero("n2");
                ViewBag.Result = "Resultado de la multiplicación: " + (num1 * num2);
            }
            catch
            {
                ViewBag.Result = "Datos erroneos ingresados.";
            }

            return View("bCalc");
        }

        
        [HttpPost]
        [ActionName("Division")]
        public IActionResult Division()
        {
            try
            {
                decimal num1 = Convert.ToDecimal(HttpContext.Request.Form["n1"]);
                decimal num2 = Convert.ToDecimal(HttpContext.Request.Form["n2"]);

                if (num2 == 0)
                {
                    ViewBag.Result = "No se puede dividir entre cero.";
                }
                //Se agrega validacion para evitar erroresn tiempo de ejecución
                else
                {
                    ViewBag.Result = "Resultado de la división: " + (num1 / num2);
                }
            }
            catch
            {
                ViewBag.Result = "Datos erroneos ingresados.";
            }

            return View("bCalc");
        }

        
        [HttpPost]
        [ActionName("RaizCuadrada")]
        public IActionResult RaizCuadrada()
        {
            try
            {
                ViewBag.Action = "RaizCuadrada";
                // envía información a la vista para deshabilitar el segundo campo
                double num1 = Convert.ToDouble(HttpContext.Request.Form["n1"]);
                double resultado = Math.Sqrt(num1);
                ViewBag.Result = "Resultado de la raíz cuadrada: " + resultado;
            }
            catch
            {
                ViewBag.Result = "Datos erroneos ingresados.";
            }

            return View("bCalc");
        }

        
        [HttpPost]
        [ActionName("Modulo")]
        public IActionResult Modulo()
        {
            try
            {
                int num1 = ObtenerNumero("n1");
                int num2 = ObtenerNumero("n2");
                ViewBag.Result = "Resultado del módulo: " + (num1 % num2);
            }
            catch
            {
                ViewBag.Result = "Datos erroneos ingresados.";
            }

            return View("bCalc");
        }

        
        [HttpPost]
        [ActionName("Potencia")]
        public IActionResult Potencia()
        {
            try
            {
                double num1 = Convert.ToDouble(HttpContext.Request.Form["n1"]);
                double num2 = Convert.ToDouble(HttpContext.Request.Form["n2"]);
                double resultado = Math.Pow(num1, num2);
                ViewBag.Result = "Resultado de la potencia: " + resultado;
            }
            catch
            {
                ViewBag.Result = "Datos erroneos ingresados.";
            }

            return View("bCalc");
        }

        
        [NonAction]
        // NonAction indica que este método NO es accesible por URL
        // Se utiliza solo como apoyo interno del controlador
        public int ObtenerNumero(string campo)
        {
            return Convert.ToInt32(HttpContext.Request.Form[campo]);
        }

        [Route("calculadora")]
        // permite acceder a la vista usando /calculadora
        public IActionResult bCalc()
        {
            return View();
        }


        #endregion Calculadora basica

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}

