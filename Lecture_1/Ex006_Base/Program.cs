// 
Console.Clear();
int min = 0, max = 100;
//Случайное целое число от min до max - 1
int a = new Random().Next(min, max);
int b = new Random().Next(min, max);
int c = new Random().Next(min, max);
int d = new Random().Next(min, max);
int e = new Random().Next(min, max);
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
int maxWeight = a;
if (b > maxWeight) maxWeight = b;
if (c > maxWeight) maxWeight = c;
if (d > maxWeight) maxWeight = d;
if (e > maxWeight) maxWeight = e;

Console.WriteLine("Максимальное " + maxWeight);