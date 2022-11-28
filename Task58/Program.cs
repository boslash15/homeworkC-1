// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)  // создаем массив
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)    // печатаем массив
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)    // считаем произведение 2 матриц
{
    int[,] matrixProduct = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(0) == matrix2.GetLength(1))
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int l = 0; l < matrix1.GetLength(0); l++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrixProduct[i, l] += matrix1[i, j] * matrix2[j, l];
                }
            }
        }
    }
    return matrixProduct;
}

int[,] array2A = CreateMatrixRndInt(3, 3, 1, 10);
int[,] array2B = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(array2A);
Console.WriteLine();
PrintMatrix(array2B);

if (array2A.GetLength(0) == array2B.GetLength(1))
{
    int[,] array2AB = MatrixProduct(array2A, array2B);
    Console.WriteLine();
    PrintMatrix(array2AB);
}
else Console.WriteLine("Перемножить матрицы невозможно");

