//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void FillArray(int[,]array1, int[,]array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array1[i, j] = new Random().Next(1, 10);
        }
    }
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,]array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write($"{array2[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Multiplication(int[,]array1, int[,]array2, int[,]mult)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            mult[i, j] = array1[i, j] * array2[i, j];
        }
    }
}

void PrintMultArray(int[,]mult)
{
    for (int i = 0; i < mult.GetLength(0); i++)
    {
        for (int j = 0; j < mult.GetLength(1); j++)
        {
            Console.Write($"{mult[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,]array1 = new int[2, 2];
int[,]array2 = new int[2, 2];
int[,]mult = new int[2, 2];
FillArray(array1, array2);
PrintArray(array1, array2);
Console.WriteLine();
Multiplication(array1, array2, mult);
PrintMultArray(mult);