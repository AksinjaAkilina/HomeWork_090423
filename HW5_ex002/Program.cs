// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] numbers = new int[6];
    FillArray(numbers);
    PrintArray(numbers);
    System.Console.WriteLine($"Сумма элементов с нечётными индексами равна {FindSumOddIndex(numbers)}");


void FillArray(int[] numbers, int minValue = -20, int maxValue = 20)
{
    maxValue++;
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(minValue, maxValue);
    }
}

void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    System.Console.WriteLine();
}

int FindSumOddIndex(int[] numbers) 
{
    int sum = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(i % 2 == 1)
        {
            sum += numbers[i];
        } 
    }
    return sum;
}