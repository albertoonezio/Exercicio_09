using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Parte2_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroA = 0;
            int numeroB = 0;

            Console.Write("Digite um valor para A: ");
            numeroA = int.Parse(Console.ReadLine());

            Console.Write("Digite um valor para B: ");
            numeroB = int.Parse(Console.ReadLine());

            if (numeroA == numeroB)
            {
                Console.WriteLine("A igual a B");
            }

            else if (numeroA > numeroB)
            {
                Console.WriteLine("A maior do que B");
            }

            else
            {
                Console.WriteLine("B maior do que A");
            }
        }
    }
}
