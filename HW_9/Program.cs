void Main()
{
    bool isWork = true;

    while (isWork)
    {
        System.Console.WriteLine("Enter command: ");
        string command = Console.ReadLine();

        switch (command)
        {
            case "64":
                Task64();
                break;
            case "66":
                Task66();
                break;
            case "68":
                Task68();
                break;                
            case "exit":
                isWork = false;
                break;
        }
    }
}
Main();


// Задача 64: Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

void Task64()
{
    System.Console.WriteLine("Task 64");

    string NumbersRec (int m, int n)
    {
        if (m <= n) return $"{m} " + NumbersRec(m + 1, n);
        else return string.Empty;
    }
    int m = ReadInt("Input M: ");
    int n = ReadInt("Input N: ");
    System.Console.WriteLine(NumbersRec(m, n));
}

// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Task66()
{
    System.Console.WriteLine("Task 66");

    int SumRec(int m, int n)
    {
        if (m == n) return m;
        else return m + SumRec(m + 1, n);
    }
    int m = ReadInt("Input M: ");
    int n = ReadInt("Input N: ");
    System.Console.WriteLine(SumRec(m, n));    
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

void Task68()
{
    System.Console.WriteLine("Task 68");

    int Akkerman(int n, int m)
    {
        if (n == 0) return m + 1;
        else if ((n != 0) && (m == 0)) return Akkerman(n - 1, 1);
        else return Akkerman(n - 1, Akkerman(n, m - 1));
    }
    int m = ReadInt("Input N: ");
    int n = ReadInt("Input M: ");    
    System.Console.WriteLine(Akkerman(n, m));
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