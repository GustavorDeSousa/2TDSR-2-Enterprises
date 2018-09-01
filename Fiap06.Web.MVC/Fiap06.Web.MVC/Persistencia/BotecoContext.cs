using Fiap06.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.Persistencia
{
    public class BotecoContext : DbContext
    {
        public DbSet<Bebida> Bebidas { get; set; }

        public DbSet<Petisco> Petiscos { get; set; }

    }
}