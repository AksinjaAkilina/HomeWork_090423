void Main()
{
    bool isWork = true;

    while (isWork)
    {
        System.Console.WriteLine("Enter command: ");
        string command = Console.ReadLine();

        switch (command)
        {
            case "task 47":
                Task47();
                break;
            case "task 50":
                Task50();
                break;
            case "task 52":
                Task52();
                break;                
            case "exit":
                isWork = false;
                break;
        }
    }
}
Main();

int ReadInt(string argument)
{
    Console.Write(argument);
    int i;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число!");
        Console.Write(argument);
    }
    return i;
}

double[,] CreateNewMatrix (int m, int n)
{
    Random rnd = new Random();
    double[,] array = new double[m,n];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(rnd.Next(-10,10) + rnd.NextDouble(),1);
        }
    }
    return array;
}

void PrintNewMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }    
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }    
}

void CreateMatrix (int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
        }
    }
}

void GetArithmeticMean(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        System.Console.WriteLine($"arithmetic mean col {i} = {Math.Round(sum / (double)array.GetLength(0), 1)}");
    }
}

void FindItemByLocation(int a, int b, int[,] arr)
{
    if (a >= 0 && a <= arr.GetLength(0) && b >= 0 && b<= arr.GetLength(1))
        System.Console.WriteLine($"Значение элемента массива равно {arr[a, b]}");
    else
        System.Console.WriteLine("Такого элемента в массиве не существует");
}


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Task47()
{
    System.Console.WriteLine("Task 47");

    int m = ReadInt("Введите количество строк M: ");
    int n = ReadInt("Введите количество столбцов N: ");
    double[,] matrix = CreateNewMatrix(m, n);
    PrintNewMatrix(matrix);
}


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Task50()
{
    System.Console.WriteLine("Task 50");

    int horisontal = ReadInt("Введите номер строки для поиска элемента: ");
    int vertical = ReadInt("Введите номер столбца для поиска элемента: ");
    int hor = horisontal - 1;
    int ver = vertical - 1;

    int[,] matrix = new int [5, 6];
    CreateMatrix(matrix);
    PrintMatrix(matrix);
    FindItemByLocation(hor, ver, matrix);
}


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Task52()
{
    System.Console.WriteLine("Task 52");

    int m = ReadInt("Введите количество строк M: ");
    int n = ReadInt("Введите количество столбцов N: ");
    int[,] matrix = new int [m, n];
    CreateMatrix(matrix);
    PrintMatrix(matrix);
    GetArithmeticMean(matrix);
}

