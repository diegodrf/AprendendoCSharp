using System;

namespace _6_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais");

            int idade = 15;
            int quantidadePessoas = 1;

            if (idade >= 18)
            {
                Console.WriteLine("Você tem mais de 18 anos");
                Console.WriteLine("Seja bem vindo!");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Você não tem 18, mas pode entrar, " +
                    	"pois está companhado");
                }
                else
                {
                    Console.WriteLine("Infelizmente você não pode entrar");
                }

            }

        }
    }
}
