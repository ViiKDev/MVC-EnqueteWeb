using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EnqueteWeb.Models;

namespace EnqueteWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public IActionResult Responder()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Responder(Resposta resposta)
        {
            if (ModelState.IsValid) {
                Repositorio.AdicionarResposta(resposta);
                return View("Obrigado");
            } else {
                return View(resposta);
            }
        }

        public IActionResult Resultado()
        {
            return View(Repositorio.Respostas);
        }
    }
}
