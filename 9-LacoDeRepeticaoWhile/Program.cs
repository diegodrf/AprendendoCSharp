using System;

namespace _9_LacoDeRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while(contador <= 10)
            {
                Console.WriteLine(contador);

                // Diferentes formas de incremento.
                // contador = contador + 1
                // contador += 1
                contador++;
            }
        }
    }
}
