using System;

namespace Kabanova_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите количество строк:");
                int M = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество столбцов:");
                int N = int.Parse(Console.ReadLine());
                int[,] mas = new int[M, N];
                Random rnd = new Random();
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        mas[i, j] = rnd.Next(0, 100);
                        Console.Write(mas[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                int t = 0;
                for (int i = 1; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (mas[0, j] == mas[i, j])
                        {
                            t++;
                            break;
                        }
                    }
                }
                Console.WriteLine("Количество строк, похожих на первую строку данной матриц = " + t);
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

    }
}
