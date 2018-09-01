using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _05.Fiap.Web.MVC.Models
{
    public class Oficina
    {
        public string Nome { get; set; }
        public bool DiaNoite { get; set; }
        public string Endereco { get; set; }
        public string Tipo { get; set; }
    }
}