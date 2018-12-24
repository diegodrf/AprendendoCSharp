using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _Exercicio_AlicotaComIfs
{
    class Programa
    {
        public static void Main(string[] args)
        {
            double impostoDeRenda = 0;
            double deducao = 0;
            double salario = 3300.0;


            if (salario >= 1900.0 && salario <= 2800.0)
            {
                impostoDeRenda = 7.5;
                deducao = 142;
            }

            else if (salario >= 2800.01 && salario <= 3751.0)
            {
                impostoDeRenda = 15;
                deducao = 350;
            }

            else if (salario >= 3751.01 && salario <= 4664.00)
            {
                impostoDeRenda = 22.5;
                deducao = 636;
            }

            Console.WriteLine("Imposto de Renda: " + impostoDeRenda + "%");
            Console.WriteLine("Dedução de até R$ " + deducao);
        }
    }
}