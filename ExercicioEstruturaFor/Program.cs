using System.Drawing;

namespace ExercicioEstruturaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio2();
        }
       /* 
          1- Leia um valor inteiro X(1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
          X, se for o caso.
       */

        static void Exercicio1()
        {
            int x, a;

            Console.WriteLine("Digite um numero inteiro:");
            x = int.Parse(Console.ReadLine());

            for ( a = 1; a <= x; a++)
            {
                if (a % 2 != 0)
                {
                    Console.WriteLine(a);
                }
            }
        }

        /* 
         2- Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. 
          Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
          essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo). 
       */
        static void Exercicio2()
        {
            int n, x, a, nIn = 0, nOut = 0;

            Console.WriteLine("Digite a quantidade de numeros:");
            n = int.Parse(Console.ReadLine());

            for (x = 1; x <= n; x++) 
            {
                Console.WriteLine("Digite um numero:");
                a = int.Parse(Console.ReadLine());
                if (a >= 10 && a <= 20)
                {
                    nIn++;
                }
                else
                {
                    nOut++;
                }

            }

            Console.WriteLine(nIn + " In");
            Console.WriteLine(nOut + " Out");
        }

    }
}
