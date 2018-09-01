using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    //Classe abstrata:
    //1- Não pode ser instanciada
    //2- Pode ter métodos abstratos (sem implementação)
    abstract class Conta
    {
        //propriedades (gets e sets)
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public DateTime DataAbertura { get; set; }
        public decimal Saldo { get; set; }

        //métodos
        public abstract void Depositar(decimal valor);
        public abstract void Retirar(decimal valor);

    }
}
