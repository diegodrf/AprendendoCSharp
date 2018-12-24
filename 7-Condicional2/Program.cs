using System;

namespace _7_Condicional2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais");

            int idade = 15;
            int quantidadePessoas = 3;
            bool acompanhado = quantidadePessoas >= 2;

            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("Seja bem vindo!");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar");
            }

        }
    }
}
