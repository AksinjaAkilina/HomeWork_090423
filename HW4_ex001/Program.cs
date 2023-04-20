// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int a = ReadInt("Введите число A");
int b = ReadInt("Введите число B");

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

int DegreeNumber(int a, int b)
{
int deg = 1;
for (int i = 0; i < b; i++)
deg *= a;
return deg;
}

bool NegativeNumber(int b)
{
    if (b < 0)
    {
        System.Console.WriteLine("Значение B не может быть меньше нуля");
        return false;
    }
    return true;
}
if (NegativeNumber(b))
{
    System.Console.WriteLine($"Число {a} в степени {b} равняется {DegreeNumber(a, b)}");
}


