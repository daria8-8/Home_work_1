Console.WriteLine("Введите три числа : ");
Console.WriteLine("Число a : ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Число b : ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Число c : ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
