using Fiap.Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar uma conta corrente e poupança
            var cc = new ContaCorrente()
            {
                Agencia = 1,
                Numero = 2,
                Saldo = 100,
                Tipo = Model.TipoConta.Comum,
                DataAbertura = DateTime.Now
            };

            var cp = new ContaPoupanca(0.06m)
            {
                Agencia = 1,
                Numero = 3,
                Saldo = 500,
                Taxa = 2,
                DataAbertura = new DateTime(2018, 1, 1)
            };

            try
            {
                cc.Retirar(200);
                Console.WriteLine(cc.Saldo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
