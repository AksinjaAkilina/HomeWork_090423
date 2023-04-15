int random = new Random().Next(100, 1000);
Console.WriteLine(random);

Console.WriteLine(FindSecond(random));
int FindSecond(int random)
{
    int result;
    result = random % 100 / 10;
    return result;
}

