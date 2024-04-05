using Microsoft.AspNetCore.Mvc;
using Task_Esa.Services;

namespace Task_Esa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OggettoCelesteController : Controller
    {
        private readonly OggettoCelesteService _service;


        public OggettoCelesteController(OggettoCelesteService service)
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
