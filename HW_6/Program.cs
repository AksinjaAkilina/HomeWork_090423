void Main()
{
    bool isWork = true;

    while (isWork)
    {
        System.Console.WriteLine("Enter command: ");
        string command = Console.ReadLine();

        switch (command)
        {
            case "task 41":
                Task41();
                break;
            case "task 43":
                Task43();
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

void PrintArray(int[] num)
{
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write($"{num[i]} ");
    }
    System.Console.WriteLine();
}

int[] CreateArray(int m)
{
    int[] num = new int[m];
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = ReadInt("Введите элемент массива: ");
    }
    return num;
}

int PositiveElements(int[] num)
{  
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0)
        {
            count ++;
        }
    }
    return count;
}

bool Validate (double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            System.Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            System.Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}

double[] Intercept (double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double[] array = new double[2];
    array[0] = x;
    array[1] = y;
    return array;
}

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Task41()
{
    System.Console.WriteLine("Task 41");

    int m = ReadInt("Введите количество элементов массива: "); 
    int[] array;
    array = CreateArray(m);
    PrintArray(array);
    System.Console.WriteLine($"В заданном массиве {PositiveElements(array)} чисел(а) больше 0");
}


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Task43()
{
    System.Console.WriteLine("Task 43");

    int b1 = ReadInt("Введите значение b1: ");
    int k1 = ReadInt("Введите значение k1: ");
    int b2 = ReadInt("Введите значение b2: ");
    int k2 = ReadInt("Введите значение k2: ");

    if (Validate(b1, k1, b2, k2))
    {
        System.Console.WriteLine($"Точка пересечения двух прямых [{string.Join(", ", Intercept(b1, k1, b2, k2))}]");
    }     
}