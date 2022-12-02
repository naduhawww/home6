/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

System.Console.WriteLine(" введите количество строк..."); ///вводим данные
int linesVol = Convert.ToInt32(Console.ReadLine()); ///создаем переменные для введеных данных 
System.Console.WriteLine(" ввести количество столбцов..."); ///вводим данные
int columnsVol = Convert.ToInt32(Console.ReadLine()); /// создаем переменные для вводимых данных
double[,] array = new double[linesVol, columnsVol]; /// создаем массив
FillArrayRandomArray(array); /// метод для заполнения массива рандомными числами
PrintArray(array); ///печать массива
void FillArrayRandomArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) ///заполняем строки
    {
        for (int j = 0; j < array.GetLength(1); j++) ///заполнем столбцы
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10; ///рандомное заполнение по формуле
        }
    }
}
void PrintArray(double[,] array)
{ /// печать
    for (int i = 0; i < array.GetLength(0); i++) ///бежим по строкам
    {
        for (int j = 0; j < array.GetLength(1); j++) ///бежим по столбцам
        {
            System.Console.Write(array[i, j] + "\t"); ///вывод массива \t это для вывода табличкой
        }
        System.Console.WriteLine();
    }
}
