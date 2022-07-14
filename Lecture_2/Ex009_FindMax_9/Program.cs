// Поиск максимального значения из 9 при помощи функций

Console.Clear();

// решение с помощью функции

// проверка на наличие символов в строке s, отличных от цифр. возвращает false, если строка пустая или
// содержит символы - не цифры
bool DigitsOnly(string s)
{
    // проверка на пустую строку    
    if (s.Length == 0) return false;
    // foreach - цикл для каждого из
    foreach (char c in s)
    {
        if (c < '0' || c > '9')
            return false;
    }
    return true;
}

// ввод значения. запрашивает ввод, конвертирует в int32 и возвращает это число
int GetData()
{
    bool testDigits = false;
    string? inputString = "";
    while (!testDigits)
    {
        Console.Write("Введите значение: ");
        inputString = Console.ReadLine();
        testDigits = DigitsOnly(inputString);
    }
    return Convert.ToInt32(inputString);
}

// поиск максимального значения из трёх int
int Max(int num1, int num2, int num3)
{
    int max = 0;
    if (num1 > max) max = num1;
    if (num2 > max) max = num2;
    if (num3 > max) max = num3;
    return max;
}

int result = Max(
                Max(GetData(), GetData(), GetData()),
                Max(GetData(), GetData(), GetData()),
                Max(GetData(), GetData(), GetData())
                );
Console.WriteLine("Максимальное число: " + result);



// лобовое решение (лапша)
// Console.Write("Введите значение: ");
// // Convert.ToInt32(string) - преобразование строки в Int32 (float, double, Int16 и т.д.)
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение: ");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение: ");
// int d = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение: ");
// int e = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение: ");
// int f = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение: ");
// int g = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение: ");
// int h = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение: ");
// int i = Convert.ToInt32(Console.ReadLine());

// int max = 0;

// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// if (e > max) max = e;
// if (f > max) max = f;
// if (g > max) max = g;
// if (h > max) max = h;
// if (i > max) max = i;

// Console.WriteLine("Максимальное значение: " + max);





