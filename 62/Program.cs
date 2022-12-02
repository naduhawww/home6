﻿//Заполните спирально массив 4 на 4.

int a = 4;

int[,] array = new int[a, a];
int num = 1;
int i = 0;
int j = 0;
while (num <= a * a)
{
    array[i, j] = num;
    if (i <= j + 1 && i + j < a - 1)
        ++j;
    else if (i < j && i + j >= a - 1)
        ++i;
    else if (i >= j && i + j > a - 1)
        --j;
    else
        --i;
    num++;
}
for (i = 0; i < array.GetLength(0); i++)
{
    for (j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j],4}");
    }
    Console.WriteLine();
}
