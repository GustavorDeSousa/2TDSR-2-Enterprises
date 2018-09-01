using _05.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05.Fiap.Web.MVC.Controllers
{
    public class OficinaController : Controller
    {
        private static List<Oficina> _lista = new List<Oficina>();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            List<string> tipos = new List<string>();
            tipos.Add("Elétrica");
            tipos.Add("Mecanica");
            tipos.Add("Funilaria");
            //Envia a lista de tipos para a tela exibir o select
            ViewBag.listaTipo = new SelectList(tipos);
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Oficina oficina)
        {
            _lista.Add(oficina);
            TempData["msg"] = "Oficina resgistrada!";
            return RedirectToAction("Cadastrar");
        }
    }
}