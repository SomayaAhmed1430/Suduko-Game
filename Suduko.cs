using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suduko
{
    internal class SudukoGame
    {
        private int[,] matrix;

        public SudukoGame(int[,] matrix)
        {
            this.matrix = matrix;
        }

        public bool IsComplete()
        {
            for (int i = 0; i < 9; i ++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (matrix[i, j] == 0)
                    return false;
                }
            }
            return true;
        }

        public void PrintGrid()
        {
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine("-------------------------");

                for (int j = 0; j < 9; j++)
                {
                    if (j % 3 == 0)
                        Console.Write("| ");

                    Console.Write(matrix[i, j] == 0 ? ". " : $"{matrix[i, j]} ");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("-------------------------");
        }

        public void MakeMove(int row, int col, int num)
        {
            matrix[row, col] = num;
        }

        public bool IsValidMove(int row, int col, int num)
        {
            for (int i = 0; i < 9; i++)
            {
                if (matrix[row, i] == num || matrix[i, col] == num)
                    return false;
            }

            int startRow = row / 3 * 3;
            int startCol = col / 3 * 3;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[startRow + i, startCol + j] == num)
                        return false;
                }
            }

            return true;
        }

    }
}
