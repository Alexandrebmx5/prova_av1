using Microsoft.AspNetCore.Mvc;
using Projeto_Resposta_da_Prova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Resposta_da_Prova.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo(ProdutoViewsModels model)
        {
            if (ModelState.IsValid)
            {
                var cliente = model;
                return RedirectToAction("Index");
            }

            return View(model);
            ;
        }
    }
}
