using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jacky.api.power
{
    [Route("jacky/api")]
    [ApiController]
    public class powerInfoController : Controller
    {
        [HttpPost("get-power")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
