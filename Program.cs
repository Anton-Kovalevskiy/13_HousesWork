Console.Write("Введите номер задачи (47, 50 или 52): ");
string? task = Console.ReadLine();
switch (task)
{
    case "47":
    Task47 (task);
    break;
    case "50":
    Task50 (task);
    break;
    case "52":
    Task52 (task);
    break;
    default:
    break;

}

/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9

*/

// Решение

int size (string message)
{
    Console.Write(message);
    int s = Convert.ToInt32(Console.ReadLine());
    return (s);
}

double [,] FillPrintDoubleArray (int m, int n)
{
    double [,] array = new double [m, n]; 
    Console.WriteLine($"Получен массив {m}x{n}:");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array [i, j] = new Random().Next(-99, 100) / 10.0;

            Console.Write($"[{array[i, j]}] ");
        }
        Console.WriteLine();
    }
    return (array);
}

void Task47(string task)
{
string mes = "Введите размер m: ";
int m = size (mes);
mes = "Введите размер n: ";
int n = size (mes);
double [,] array = FillPrintDoubleArray(m, n);
}

/*
Задача 50. Напишите программу, 
которая на вход принимает значение элемента в двумерном массиве, 
и возвращает позицию этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет

*/

// Решение

int [,] FillPrintIntArray (int m, int n)
{
    int [,] array = new int [m, n]; 
    Console.WriteLine($"Получен массив {m}x{n}:");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array [i, j] = new Random().Next(0, 10);

            Console.Write($"[{array[i, j]}] ");
        }
        Console.WriteLine();
    }
    return (array);
}

string FindNumberInArray (int [,] array, int f)
{
    string result = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array [i, j] == f)
            {
                result = $"Искомый элемент {f} находится в массиве на позиции [{i}; {j}]";
                break;
            }          
        }
    }
    if (result == String.Empty) result = $"Искомый элемент {f} в массиве отсутствует!";
    return (result);
}

void Task50(string task)
{
string mes = "Введите размер m: ";
int m = size (mes);
mes = "Введите размер n: ";
int n = size (mes);
int [,] array = FillPrintIntArray(m, n);
mes = "Введите искомый элемент массива: ";
int findNumber = size (mes);
string position = FindNumberInArray(array, findNumber);
Console.Write(position);
}

/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

double [] FindAverageColumns (int [,] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    double [] average = new double [array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            average [i] += array [j, i];
            if (j == array.GetLength(0) - 1) average [i] /= array.GetLength(0);
        }
        Console.Write($"[{Math.Round(average [i], 1)}] ");
    }
    return (average);
}

void Task52 (string task)
{
    string mes = "Введите размер m: ";
    int m = size (mes);
    mes = "Введите размер n: ";
    int n = size (mes);
    int [,] array = FillPrintIntArray(m, n);
    double [] average = FindAverageColumns(array);
}