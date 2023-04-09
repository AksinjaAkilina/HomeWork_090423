Console.Write("Введите число a: ");
int i = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int j = int.Parse(Console.ReadLine());
Console.Write("Введите число c: ");
int k = int.Parse(Console.ReadLine());

int max = i;

if(i > max) max = i;
if(j > max) max = j;
if(k > max) max = k;

Console.Write("max = ");
Console.WriteLine(max);