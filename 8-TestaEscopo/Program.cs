using System;

namespace _8_TestaEscopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais");

            int idade = 15;
            int quantidadePessoas = 3;
            bool acompanhado;
            //bool acompanhado = quantidadePessoas >= 2;

            if (quantidadePessoas >= 2)
            {
                acompanhado = true;
            }
            else
            {
                acompanhado = false;
            }

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
