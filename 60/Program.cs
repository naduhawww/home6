//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
//
//

void FillArray(int[,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int number = new Random().Next(10, 99);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = number;
                number +=1;

            }

        }
        
    }

}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("страница №" + (i + 1));
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"a[{i}, {j}, {k}] = {array[i, j, k],3}   ");
            }
            Console.WriteLine();

        }
    }
}


int[,,] array = new int[2, 2, 3];
FillArray(array);
PrintArray(array);

