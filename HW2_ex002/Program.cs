// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int num = 0;
while (!int.TryParse(Console.ReadLine(), out num))
{ System.Console.WriteLine("Это не число!"); }

int numDigit = 0;
numDigit = NumberDigit(num);

int NumberDigit(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

if (numDigit <= 2)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    if (numDigit > 3)
    {
        num = num / Convert.ToInt32(Math.Pow(10, numDigit - 3));
    }
    num = num % 10;
    Console.WriteLine($"Третья цифра введённого числа: {num}");
}


