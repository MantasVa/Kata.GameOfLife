using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.GameOfLife.Infrastructure
{
    public static class ArrayExtensions
    {
        public static void Print2DArray(this char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
