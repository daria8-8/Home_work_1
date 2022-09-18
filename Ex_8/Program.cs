Console.WriteLine("Введите количество элементов массива: ");
int [] massiv = new int[999999];
int N = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i++)
massiv[i] = i+1;
Console.WriteLine("Массив из чётных чисел: ");
for (int i = 0; i < N; i++)
if((massiv[i] % 2) == 0)
Console.Write( "{0} ", massiv[i] );



