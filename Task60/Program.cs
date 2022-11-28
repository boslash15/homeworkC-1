﻿// Задача 60. 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndInt(int rows, int columns, int cell)  // создаем массив
{
    var matrix = new int[rows, columns, cell];
    for (int f = 10; f < 100;)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    matrix[i, j, k] = f;
                    f = f + 1;
                }
            }
        }

    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)    // печатаем массив
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k]},({i},{j},{k}),     ");
                else Console.Write($"{matrix[i, j, k]},({i},{j},{k})     ");
            }
        }
        Console.WriteLine("|");
    }
}


int[,,] array3 = CreateMatrixRndInt(2, 2, 2);
PrintMatrix(array3);
