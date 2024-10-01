using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            decimal nota1,nota2,nota3,nota4;

            Console.WriteLine("digite seu nome: ");

            Nome = Console.ReadLine();

            Console.WriteLine(" Seja bem vindo "+Nome);

            Console.WriteLine(" digite as notas do aluno "+Nome);

            nota1 = decimal.Parse(Console.ReadLine());
            nota2 = decimal.Parse(Console.ReadLine());
            nota3 = decimal.Parse(Console.ReadLine());
            nota4 = decimal.Parse(Console.ReadLine());






            Console.ReadKey();
        }
    }
}
