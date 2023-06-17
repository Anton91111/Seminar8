/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

using System;
class SpiralArray
{
    static void Main()
    {
        int[,] arr = new int[4, 4];

        int value = 1;
        int row = 0, col = 0;
        int lastRow = 3, lastCol = 3;

        while (row <= lastRow && col <= lastCol)
        {
            for (int i = col; i <= lastCol; i++)
            {
                arr[row, i] = value++;
            }
            row++;
            for (int i = row; i <= lastRow; i++)
            {
                arr[i, lastCol] = value++;
            }
            lastCol--;
            if (row <= lastRow)
            {
                for (int i = lastCol; i >= col; i--)
                {
                    arr[lastRow, i] = value++;
                }
                lastRow--;
            }
            if (col <= lastCol)
            {
                for (int i = lastRow; i >= row; i--)
                {
                    arr[i, col] = value++;
                }
                col++;
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"{arr[i, j]:D2} ");
            }
            Console.WriteLine();
        }
    }
}