using System;

namespace P11_LacoDeRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int numero = 1; numero < 11; numero++)
            {
                for (int multiplicador = 0; multiplicador < 11; multiplicador++)
                {
                    Console.WriteLine("{0} x {1} = {2}", numero, multiplicador,
                    numero * multiplicador);
                }
                Console.WriteLine();
            }
        }
    }
}
