using System;

namespace Exercice-2
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, B, A;

            Console.WriteLine("Donner le dimension de tableau:");
            N = int.Parse(Console.ReadLine());
            int[] T = new int[N + 1];
            Console.WriteLine("Donner les nombres par ordre");
            for (int i = 0; i < N; i++)
            {
                T[i] = int.Parse(Console.ReadLine());


            }

            Console.WriteLine("Entrer un nombre");
            B = int.Parse(Console.ReadLine());
            //cas croissante
            if (T[1] > T[0])
            {
                T[N] = B;
                for (int i = N; i > 0; i--)
                {
                    if (T[i - 1] > T[i])
                    {
                        A = T[i];
                        T[i] = T[i - 1];
                        T[i - 1] = A;
                    }
                }
            }
            //cas décroissante
            else if (T[1] < T[0])

            {
                T[N] = B;
                for (int i = N; i > 0; i--)
                {
                    if (T[i - 1] < T[i])
                    {
                        A = T[i];
                        T[i] = T[i - 1];
                        T[i - 1] = A;
                    }
                }

            }

            foreach (int t in T)
            {
                Console.Write(t + "\t");


            }

        }



    }
}
