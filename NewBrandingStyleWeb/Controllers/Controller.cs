using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NewBrandingStyleWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Controller : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Post()
        {
            return View();
        }
    }
}
