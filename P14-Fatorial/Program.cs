using System;

namespace P14_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado;

            for (int fatorial = 1; fatorial <= 10; fatorial++)
            {
                resultado = fatorial;

                Console.Write("!{0} -> ", fatorial);

                for (int n = 1; n < fatorial; n++)
                { 
                    if (n == 1)
                    {
                        Console.Write("{0}", n);
                    }
                    else
                    {
                        Console.Write(" x {0}", n);
                    }

                    resultado *= n;
                }
                if (fatorial == 1)
                {
                    Console.WriteLine("{0} x {1} = {2}", fatorial, fatorial, resultado);
                }
                else
                {
                    Console.WriteLine(" x {0} = {1}", fatorial, resultado);
                }
            }

        }
    }
}
