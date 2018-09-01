using _03.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03.Fiap.Web.MVC.Controllers
{
    public class MultaController : Controller
    {
        [HttpGet] //abrir a página de formulário
        public ActionResult Cadastrar()
        {
            return View();
        }
        
        [HttpPost] //recuperar os dados e cadastra no bd
        public ActionResult Cadastrar(Multa multa)
        {
            //Enviar valores para a tela
            ViewBag.churros = multa.Placa;
            TempData["msg"] = "Multa cadastrada!";
            return View(multa);
            //exibe a placa no browser
            //return Content(multa.Placa);
        }
    }
}