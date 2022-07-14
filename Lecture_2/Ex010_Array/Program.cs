// работа с массивами при помощи функций
Console.Clear();

// проверка на наличие символов в строке s, отличных от цифр. возвращает false, если строка пустая или
// содержит символы - не цифры
// bool DigitsOnly(string s)
// {
//     // проверка на пустую строку    
//     if (s.Length == 0) return false;
//     // foreach - цикл для каждого из
//     foreach (char c in s)
//     {
//         if (c < '0' || c > '9')
//             return false;
//     }
//     return true;
// }

// ввод значения. запрашивает ввод, конвертирует в int32 и возвращает это число
// int GetData()
// {
//     bool testDigits = false;
//     string inputString = "";
//     while (!testDigits)
//     {
//         Console.Write("Введите значение: ");
//         inputString = Console.ReadLine();
//         testDigits = DigitsOnly(inputString);
//     }
//     return Convert.ToInt32(inputString);
// }

// поиск максимального значения из массива
int Max(int[] array)
{
    int n = array.Length;
    int max = 0;
    int index = 0;
    while (index < n)
    {
        if (array[index] > max) max = array[index];
        index++;
    }
    return max;
}

// поиск номера элемента массива по его значению. если элемента в массиве нет, то возвращает -1
int IndexOf(int[] array, int find)
{
    int n = array.Length;
    int position = -1;
    int index = 0;
    while (index < n)
    {
        if (array[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

// заполнение массива случайными числами от 1 до 9. void - ничего не возвращающий метод. в этом случае return не нужен
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// печать массива
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}



// новый int массив из 10 элементов
int[] array = new int[10];

FillArray(array);
PrintArray(array);

int result = Max(array);
Console.WriteLine("Максимальное число: " + result);

int pos = IndexOf(array, result);
Console.WriteLine("Номер элемента в массиве: " + pos);
