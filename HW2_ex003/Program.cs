int day = ReadInt("Введите число от 1 до 7: ");
int ReadInt(string number)
{
    Console.Write(number);
    int i = 0;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        Console.WriteLine("It's not a number");
    }
    return i;
}

if (day >= 1 && day <= 7)
{
    if (day == 6 | day == 7) Console.WriteLine("Сегодня выходной");
    else Console.WriteLine("Сегодня рабочий день");
}
else Console.WriteLine("Не верное число");

