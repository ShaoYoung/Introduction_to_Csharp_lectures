int min = 0, max = 100;
//Случайное целое число от min до max - 1
int numberA = new Random().Next(min, max);
int numberB = new Random().Next(min, max);
int result = numberA + numberB;
Console.Clear();
Console.WriteLine("Number A " + numberA);
Console.WriteLine("Number B " + numberB);
Console.WriteLine("A + B = " + result);
