// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int x = ReadInt("Введите число: ");
System.Console.WriteLine(string.Join(" ", Cube(x)));

int ReadInt(string argument)
{
  Console.Write(argument);

  int i;

  while (!int.TryParse(Console.ReadLine(), out i))
  {
    Console.WriteLine("It's not a number");
  }

  return i;
}

int [] Cube(int x)
{
        int [] Positive = new int [x];
        for (int i = 0; i < x; i++)
        {
            Positive[i] = (int)Math.Pow(i + 1, 3); 
        }
    
        return Positive;   
}
