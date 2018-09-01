using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{
    class Professor : Pessoa, ITrabalhador
    {
        //ctor -> tab tab
        public Professor(string nome) : base(nome)
        {

        }

        public string Pf { get; set; }
        public IList<string> Disciplinas { get; set; }

        public override void FazerProva()
        {
            Console.WriteLine("Professor desenvolvendo o teste");
        }

        public void ReceberSalario()
        {
            Console.WriteLine("Ganhando dinheiro");
        }
    }
}
