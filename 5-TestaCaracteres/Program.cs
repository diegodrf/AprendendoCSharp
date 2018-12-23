using System;

namespace _5_TestaCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra = 'a';
            Console.WriteLine(letra);

            // 65 é a posiçaõ de "A" na tabela ASCII
            char valor = (char)65;
            Console.WriteLine(valor);

            // Casting para converter 66 em char
            valor = (char)(valor + 1);
            Console.WriteLine(valor);

            string palavra = "Alura Cursos Online de Tecnologia ";
            Console.WriteLine(palavra);

            //  2020 é convertido para string automaticamente e concatenado
            palavra = palavra + 2020;
            Console.WriteLine(palavra);
        }
    }
}
