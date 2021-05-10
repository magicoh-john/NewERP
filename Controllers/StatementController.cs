using ERP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.Controllers
{
    public class StatementController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public StatementController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult StatementRegister()
        {
            return View();
        }
    }
}
