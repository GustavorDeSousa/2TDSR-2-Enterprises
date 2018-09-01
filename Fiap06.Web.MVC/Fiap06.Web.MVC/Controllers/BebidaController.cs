using Fiap06.Web.MVC.Models;
using Fiap06.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap06.Web.MVC.Controllers
{
    public class BebidaController : Controller
    {
        private BotecoContext _context = new BotecoContext();

        [HttpGet]
        public ActionResult Pesquisar(String nome)
        {
            var busca = _context.Bebidas.Where(c => c.Nome.Contains (nome)).ToList();

            return View("Listar",busca);
        }

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            var bebida = _context.Bebidas.Find(id);
            _context.Bebidas.Remove(bebida);

            _context.SaveChanges();
            TempData["msg"] = "Bebida removida";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Atualizar(Bebida bebida)
        {
            //Atualiza o banco de dados
            _context.Entry(bebida).State = EntityState.Modified;
            _context.SaveChanges();
            //Mensagem
            TempData["msg"] = "Bebida atualizada!";
            //Redirecionar
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Atualizar(int id)
        {
            //Busca a bebida no banco de dados
            var bebida = _context.Bebidas.Find(id);
            //Retorna a view com o objeto bebida
            return View(bebida);
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Recupera todos as bebidas e envia para a tela
            return View(_context.Bebidas.ToList());
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Bebida bebida)
        {
            _context.Bebidas.Add(bebida);
            _context.SaveChanges();
            TempData["msg"] = "Bebida cadastrada";
            return RedirectToAction("Cadastrar");
        }

    }
}