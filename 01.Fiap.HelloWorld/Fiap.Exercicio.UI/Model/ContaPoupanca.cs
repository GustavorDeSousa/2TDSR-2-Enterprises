using Fiap.Exercicio.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        //propriedades
        public decimal Taxa { get; set; }

        public decimal Rendimento
        {
            get { return _rendimento; }
        }

        //campos/fields (atributos)
        private readonly decimal _rendimento;

        //construtor
        public ContaPoupanca(decimal rendimento)
        {
            _rendimento = rendimento;
        }

        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if (Saldo < valor + Taxa)
            {
                throw new Exception("Saldo insuficiente");
            }
            Saldo -= valor + Taxa;
        }
    }
}
