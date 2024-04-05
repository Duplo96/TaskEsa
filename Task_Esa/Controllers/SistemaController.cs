
using Microsoft.AspNetCore.Mvc;
using Task_Esa.Services;

namespace Task_Esa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SistemaController : Controller
    {
        private readonly SistemaService _service;


        public SistemaController(SistemaService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult PrendiTutti()
        {
            return Ok(_service.PrendiliTutti());
        }



    }
}
