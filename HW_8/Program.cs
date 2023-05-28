void Main()
{
    bool isWork = true;

    while (isWork)
    {
        System.Console.WriteLine("Enter command: ");
        string command = Console.ReadLine();

        switch (command)
        {
            case "54":
                Task54();
                break;
            case "56":
                Task56();
                break;
            case "58":
                Task58();
                break;                
            case "exit":
                isWork = false;
                break;
        }
    }
}
Main();


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

void Task54()
{
    System.Console.WriteLine("Task 54");

    int m = ReadInt("Введите количество строк M: ");
    int n = ReadInt("Введите количество столбцов N: ");

    int[,] matrix = new int [m, n];

    CreateMatrix(matrix);
    PrintMatrix(matrix);
    System.Console.WriteLine(" ");
    SortArray(matrix);
    PrintMatrix(matrix);
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

void Task56()
{
    System.Console.WriteLine("Task 56");

    int m = ReadInt("Введите количество строк M: ");
    int n = ReadInt("Введите количество столбцов N: ");
    if (m == n)
    {
        System.Console.WriteLine("Массив должен быть прямоугольным");
    }
    else
    {
    int[,] matrix = new int [m, n];
    CreateMatrix(matrix);
    PrintMatrix(matrix);
    SumStringElements(matrix);
    FindMinSumm(SumStringElements(matrix));
    }

}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.

void Task58()
{
    System.Console.WriteLine("Task 58");

    int m = ReadInt("Введите количество строк M: ");
    int n = ReadInt("Введите количество столбцов N: ");
    if (m != n)
    {
        System.Console.WriteLine("Массив должен быть кваратным");
    }
    else
    {
    int[,] matrix1 = new int [m, n];
    int[,] matrix2 = new int [m, n];
    CreateMatrix(matrix1);
    PrintMatrix(matrix1);
    System.Console.WriteLine(" X");
    CreateMatrix(matrix2);
    PrintMatrix(matrix2);
    System.Console.WriteLine("Произведение двух матриц: ");    
    GetResult(matrix1, matrix2);
    }
}




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

void SortArray(int [,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int[] SumStringElements(int[,] array)
{
    int[] arraySum = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        arraySum[i] = sum;
    }
    return arraySum;
}

void FindMinSumm (int[] array)
{
    int index = 0;
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) index = i;
    }
    System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {index} строка");
}

int [,] GetResult(int[,] matr1, int[,] matr2)
{
    int[,] matrixResult = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            for (int k = 0; k < matrixResult.GetLength(0); k++)
            {
                matrixResult[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    PrintMatrix(matrixResult);
    return matrixResult; 
}