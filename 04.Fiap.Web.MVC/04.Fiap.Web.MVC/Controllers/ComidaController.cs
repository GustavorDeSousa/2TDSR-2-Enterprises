using _04.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04.Fiap.Web.MVC.Controllers
{
    public class ComidaController : Controller
    {
        //Simular um banco de dados
        private static List<Comida> _banco = new List<Comida>();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_banco); //envia a lista para a tela
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Comida comida)
        {
            _banco.Add(comida); //cadastra no "banco"
            //enviar msg de sucesso para a página
            TempData["msg"] = "Comida cadastrada!";
            //redirect para evitar o cadastro novamente no F5
            return RedirectToAction("Cadastrar");
        }
    }
}