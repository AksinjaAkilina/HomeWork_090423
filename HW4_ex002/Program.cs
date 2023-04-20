// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int n = ReadInt("Введите число A");

int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");

	int i;

	while (!int.TryParse(Console.ReadLine(), out i))
	{
		Console.WriteLine("It's not a number");
	}
	return i;
}

int SumDigit(int n)
{
    n = Math.Abs(n);
    int sum = 0;
    while (n > 0)

    {
        sum += n % 10;
        n = n / 10;
    }
    return sum;
}
System.Console.WriteLine(SumDigit(n));