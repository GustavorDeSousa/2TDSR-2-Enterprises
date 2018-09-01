using _01.Fiap.HelloWorld.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um aluno
            Aluno aluno = new Aluno("Jefty");
            aluno.Nome = "Jefty"; //set
            Console.WriteLine(aluno.Nome); //get

            //Instanciar um Professor
            Professor prof = new Professor("Cabral")
            {
                Nome = "Cabral",
                Pf = "PF123"
            };

            var prof2 = new Professor("Parducci");

        }
    }
}
