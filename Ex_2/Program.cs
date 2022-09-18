Console.WriteLine("Введите два числа : ");
Console.WriteLine("Число a : ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Число b : ");
int b = int.Parse(Console.ReadLine());
Console.Write(" a = " + a);
Console.Write(" b = " + b);
if(a > b)
{
     Console.Write(" max = " + a);
     Console.Write(" min = " + b);
}
else if(a < b)
{
     Console.Write(" max = " + b);
     Console.Write(" min = " + a);
}
else
{
    Console.WriteLine(" Числа a и b равны ");
}

