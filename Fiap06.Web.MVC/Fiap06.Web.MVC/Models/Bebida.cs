using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.Models
{
    [Table("TBebida")]
    public class Bebida
    {
        [Column("Id")]
        public int BebidaId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        public bool Destilado { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
    }
}