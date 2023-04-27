// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

    int[] numbers = new int[5];
    FillArray(numbers);
    PrintArray(numbers);
    System.Console.WriteLine($"В данном массиве количество четных чисел равняется {CountEvenElements(numbers)}");


void FillArray(int[] numbers, int minValue = 100, int maxValue = 999)
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

int CountEvenElements(int[] numbers)
{
   int count = 0;
   for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}