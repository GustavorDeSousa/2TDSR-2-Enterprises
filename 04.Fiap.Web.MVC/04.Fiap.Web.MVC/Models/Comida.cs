using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _04.Fiap.Web.MVC.Models
{
    public class Comida
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public bool Salgado { get; set; }
        public string Descricao { get; set; }
        public bool Vegetariano { get; set; }
        public double Calorias { get; set; }
    }
}