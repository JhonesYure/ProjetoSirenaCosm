using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ATV4PI.Models;

namespace ATV4PI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            UsuariosRepository ur = new UsuariosRepository();
            ur.TestConexao();
            ProdutosRepository pr = new ProdutosRepository();
            pr.TestConexao();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult somos()
        {
            return View();
        }
        public IActionResult Produtos()
        {
            return View();
        }
        public IActionResult Parceiros()
        {
            return View();
        }
    }
}
