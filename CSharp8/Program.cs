using System;
using System.Collections.Generic;

namespace CSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "cabca";

            var toCheck = string.Empty;
            List<string> lista = new List<string>();
            var count = 0;
            foreach (var item in s.ToCharArray())
            {
                toCheck = item.ToString();
                foreach (var varrr in s)
                {
                    if (toCheck == varrr.ToString() && !(lista.Contains(varrr.ToString())))
                    {                        
                        count++;
                        lista.Add(varrr.ToString());
                        toCheck = string.Empty;
                        break;
                    }
                }
            }
            Console.Write(count);
        }


        static void ObtenerTranspuesta(int[][] mat, int[,] tr, int N)
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    tr[i, j] = mat[j][i];
        }

        static bool EsSimetrico(int[][] matriz, int N)
        {
            int[,] tr = new int[N, 5];
            ObtenerTranspuesta(matriz, tr, N);
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    if (matriz[j][i] != tr[i, j])
                        return false;
            return true;
        }


        private void Sample1() {
            int[] numbers = new int[4];
            numbers[0] = 4;
            numbers[1] = 7;
            numbers[2] = 1;
            numbers[3] = 2;

            var previousNumber = 0;
            var total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0) continue;
                previousNumber = numbers[i - 1];
                total += Math.Abs(numbers[i] - (previousNumber));

            }

            Console.Write(total);
        }
    }
}
