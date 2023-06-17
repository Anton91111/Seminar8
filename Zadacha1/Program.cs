/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

using System;
using static System.Console;

class Program
{
   static void Main(string[] args)
    {
        int[,] arr = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
        };

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = j + 1; k < arr.GetLength(1); k++)
                {
                    if (arr[i,j] < arr[i,k])
                    {
                        int temp = arr[i,j];
                        arr[i,j] = arr[i,k];
                        arr[i,k] = temp;
                    }
                }
            }
        }

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Write(arr[i,j] + " ");
            }
            WriteLine();
        }
    }
}