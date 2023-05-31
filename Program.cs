Console.Write("Введите номер задачи (47, 50 или 52): ");
string? task = Console.ReadLine();
switch (task)
{
    case "47":
    Task47 (task);
    break;
    case "50":
  //  Task50 (task);
    break;
    case "52":
 //   Task52 (task);
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

double [,] FillPrintArray (int m, int n)
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
double [,] array = FillPrintArray(m, n);
}

