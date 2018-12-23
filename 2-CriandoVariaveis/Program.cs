using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ola novo teste");

            int idade1;
            idade1 = 37;

            int idade2 = 29;

            int soma;
            soma = idade1 + idade2;

            Console.WriteLine("Idade1 = " + idade1 + "\nIdade2 = " + idade2 + "\nsoma da duas idades = " + soma);

            Console.ReadLine();
        }
    }
}
