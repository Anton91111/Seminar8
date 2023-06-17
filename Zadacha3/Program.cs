/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

using System;

class Program {
    static void Main() {
        int[,] matrix1 = {{2, 4}, {2, 2}};
        int[,] matrix2 = {{3, 4}, {3, 3}};

        int[,] product = MatrixProduct(matrix1, matrix2);

        PrintMatrix(product);
    }

    static int[,] MatrixProduct(int[,] a, int[,] b) {
        if (a.GetLength(1) != b.GetLength(0)) {
            throw new ArgumentException("Матрицы имеют неверный размер.");
        }

        int[,] product = new int[a.GetLength(0), b.GetLength(1)];

        for (int i = 0; i < a.GetLength(0); i++) {
            for (int j = 0; j < b.GetLength(1); j++) {
                int sum = 0;
                for (int k = 0; k < a.GetLength(1); k++) {
                    sum += a[i, k] * b[k, j];
                }
                product[i, j] = sum;
            }
        }

        return product;
    }

    static void PrintMatrix(int[,] matrix) {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}