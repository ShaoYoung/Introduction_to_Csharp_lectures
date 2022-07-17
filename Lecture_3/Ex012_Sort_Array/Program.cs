//Сортировка массива

int[] arr = { 1, 3, 5, 8, 9, 2, 73, 3, 44, 55 };

//метод печатает массив в строку
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//метод сортирует от min до max массив, передаваемый в качестве аргумента. возвращает сортированный массив
int[] SortMinMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPozition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPozition])
                minPozition = j;
        }
        //swap (обмен)
        int temp = array[i];
        array[i] = array[minPozition];
        array[minPozition] = temp;
    }
    return (array);
}

//метод сортирует от max до min массив, передаваемый в качестве аргумента. возвращает сортированный массив
int[] SortMaxMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPozition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPozition])
                maxPozition = j;
        }
        //swap (обмен)
        int temp = array[i];
        array[i] = array[maxPozition];
        array[maxPozition] = temp;
    }
    return (array);
}

//метод ищет максимум в массиве. возвращает значение максимального элемента
int FindMax(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        //swap (обмен)
    }
    return (max);
}

//метод ищет минимум в массиве. возвращает значение минимального элемента
int FindMin(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        //swap (обмен)
    }
    return (min);
}

//метод считает сумму цифр вводимого целого положительного числа
int SumNumbers(int number)
{
    int sumNum = 0;
    //int в string
    string numberString = Convert.ToString(number);
    //string в массив char
    char[] numberChar = numberString.ToCharArray();
    for (int i = 0; i < numberChar.Length; i++)
    {
        //char -> String -> int
        sumNum = sumNum + Convert.ToInt32(Convert.ToString(numberChar[i]));
    }
    return sumNum;
}

Console.Clear();
PrintArray(arr);

int[] minMaxArray = SortMinMax(arr);
PrintArray(minMaxArray);

int[] maxMinArray = SortMaxMin(arr);
PrintArray(maxMinArray);

int maxInArray = FindMax(arr);
Console.WriteLine("Максимальное значение в массиве: " + maxInArray);

int minInArray = FindMin(arr);
Console.WriteLine("Минимальное значение в массиве: " + minInArray);

Console.Write("Введите положительное целое число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа: {number} равна {SumNumbers(number)}");


