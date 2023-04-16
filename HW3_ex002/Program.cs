// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int x1 = ReadInt("Введите X первой точки");
int y1 = ReadInt("Введите Y первой точки");
int z1 = ReadInt("Введите Z первой точки");

int x2 = ReadInt("Введите X второй точки");
int y2 = ReadInt("Введите Y второй точки");
int z2 = ReadInt("Введите Z второй точки");

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

Console.WriteLine(FindLehgth(x1, x2, y1, y2, z1, z2));
double FindLehgth(int x1, int x2, int y1, int y2, int z1, int z2)
{
double result;
result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

return result;
}
