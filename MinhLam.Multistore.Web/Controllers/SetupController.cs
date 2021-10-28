using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhLam.Multistore.Web.Controllers
{
    public class SetupController : Controller
    {
        public IActionResult Install()
        {
            return View();
        }
    }
}
