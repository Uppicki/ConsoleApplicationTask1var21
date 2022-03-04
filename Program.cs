using System;

namespace ConsoleApplicationTask1var21
{
    /*21.
     Дана матрица N×M.
     Определить сумму элементов, кратных 3,
     и количество отрицательных элементов.*/
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] array1 = new int[,]
            {
                {1, 2, 3, 4, 5, 6},
                {-1, -2, -3, -4, -5, 0},
                {7, 8, 9, 9, 8, 6}
            };
            
            Console.WriteLine("Исходная матрица");

            printmatrix(array1);

            int[] result;
            
            result = solution(array1);
            
            Console.WriteLine("Сумма элементов кратных 3");
            Console.WriteLine(result[0]);
            Console.WriteLine("Количество отрицательных элементов");
            Console.WriteLine(result[1]);
        }

        static void printmatrix(int[,] array)
        {
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
        }


        static int[] solution(int[,] array)
        {
            int sum = 0;
            int amount = 0;

            int number;
            
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    number = array[i, j];
                    if (number % 3 == 0) sum+=number;
                    if (number < 0) amount++;
                }
            }
            
            return new int[] {sum, amount};
        }
    }
}