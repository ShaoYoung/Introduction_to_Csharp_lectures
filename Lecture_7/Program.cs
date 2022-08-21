//Рекурсия

//Собрать строку с числами от a до b, a ≤ b
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

//Собрать строку с числами от a до b, a >= b
string NumbersRecA(int a, int b)
{
    if (a >= b) return $"{a} " + NumbersRecA(a - 1, b);
    else return String.Empty;
}

//Сумма чисел от 0 до n
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

//Факториал числа
int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

//Число Фибоначчи с порядковым номером n
int FibRec(int n)
{
    return n > 1 ? FibRec(n-1)+FibRec(n-2) : n;
}


//Вычислить а в степени n
int PowerRec(int a, int n)
{ //return n == 0 ? 1 : PowerRec(a, n - 1) * a; - аналогичная запись через тернарный оператор
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

//Вычислить а в степени n (с меньшим количеством операций умножения)
int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}


//поиск возможных слов из имеющегося алфавита. alphabet - символы алфавита, char [] word - количество букв в словах
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}


//просмотр содержимого папки. Путь - path. indent - строка с отступами (для наглядного отображения структуры)
//рекурсивно проходит по всем папкам (до самого низкого уровня, где foreach уже не даёт новых папок) и выводит все имеющиеся в них файлы 
void CatalogInfo(string path, string indent = "")
{
    //DirectoryInfo - Предоставляет методы экземпляра класса для создания, перемещения и перечисления в каталогах и подкаталогах.
    DirectoryInfo catalogs = new DirectoryInfo(path);
    //GetDirectories - Возвращает подкаталоги текущего каталога.
    foreach (var currentCatalog in catalogs.GetDirectories())
    {
        //.Name - Получает имя данного экземпляра DirectoryInfo.
        Console.WriteLine($"{indent}{currentCatalog.Name}");
        //.FullName - Возвращает полное имя типа, включая пространство имен, но не сборку.
        CatalogInfo(currentCatalog.FullName, indent + " ");
    }
    //GetFiles - Возвращает список файлов текущего каталога. Класс FileInfo - массив типа FileInfo
    foreach (var item in catalogs.GetFiles())
    {
        Console.WriteLine($"{indent}{item.Name}");
    }
}

//Игра в пирамидки. with - шпиль, с которого будем перемещать блинчики, on - шпиль, на который будем перемещать, some - вспомогательный шпиль, count - кол-во блинчиков
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

//Обход разных структур (бинарное дерево. Обходы бывают прямой, центрированный и обратный)
string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// 0 1 2 3 4 5 6 7 8 9 10 11
void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}



Console.Clear();
Console.WriteLine(NumbersRec(1, 10));
Console.WriteLine(NumbersRecA(10, 1));
Console.WriteLine($"Сумма чисел от 0 до 10 = {SumRec(10)}");
Console.WriteLine($"Факториал 10 = {FactorialRec(10)}");
Console.WriteLine(PowerRec(2, 10));
Console.WriteLine(PowerRecMath(2, 10));
// FindWords("аисв", new char[2]);

//путь к директории
string path = "C:/Users/Никита/Desktop/MikroTik_BackUp/";
// string path = @"/Users/sergejkamaneckij/Projects/HelloCode";
CatalogInfo(path);
Towers();
InOrderTraversal();

//можно использовать для определения и отображения временного интервала
DateTime dt = DateTime.Now;
Console.WriteLine($"Год-{dt.Year}, Месяц--{dt.Month}, День-{dt.Day}, Час-{dt.Hour}, Минута-{dt.Minute}, Секунда-{dt.Second}, Милисекунда-{dt.Millisecond},");
Console.WriteLine(FibRec(40));
TimeSpan interval = DateTime.Now - dt;
Console.WriteLine("Прошло: ");
Console.WriteLine($"Минут-{interval.Minutes}, Секунд-{interval.Seconds}, Милисекунд-{interval.Milliseconds}, Всего милисекунд-{interval.TotalMilliseconds}");

