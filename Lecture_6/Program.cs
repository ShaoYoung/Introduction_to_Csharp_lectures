
Console.Clear();


string text = "(1,2) (2,3) (4,5) (9,7)"              //возьмите текст
                .Replace("(", "")                    //замените в нём все скобки на "" (по сути удалите скобки)    
                .Replace(")", "");                   //на выходе строка "1,2 2,3 4,5 9,7"
Console.WriteLine(text);

var data = text.Split(" ")                           //разбейте текст с учётом разделителя (в нашем случае — пробела) -> массив строк 1,2; 2,3; 4,5; 9,7
               .Select(item => item.Split(','))    //сделайте выборку item, для которых нужно взять отдельную подстроку
                                                   // и разбить её на несколько элементов с учётом разделителя-запятой
                                                   // .ToArray();
               .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))   //сделайте выборку из текущего массива, 
//                                                                         //чтобы первой координатой был первый элемент массива
//                                                                         // (сразу конвертированный в число). То же — со второй
//                .Where(e => e.x % 2 == 0)             //дайте такие пары, для которых первая координата — чётная
//                .Select(point => (point.x * 10, point.y))                //дайте набор, который мы получили на предыдущем этапе, и увеличьте первую координату
               .ToArray();                           //превратите в явный массив

for (int i = 0; i < data.Length; i++)
    Console.WriteLine(data[i]);                      //используйте в цикле с известными вам свойствами и функционалом


//печать двумерного int массива (через for)
void PrintMatrix(int[,] matrix)
{
    //GetLength(0) - кол-во строк, GetLength(1) - кол-во столбцов. Для двумерного массива. Далее GetLength(2) и т.д.
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}


//альтернативный вариант на основании текущих знаний

Console.Write("Введите строку в формате (1,2) (2,3) (4,5) (9,7) ");
// text = Console.ReadLine() ?? "";
text = "(1,2) (2,3) (4,5) (9,7)";
text = text.Replace("(", "").Replace(")", "");
Console.WriteLine(text);

string[] textArray = text.Split(" ");
for (int i = 0; i < textArray.Length; i++)
    Console.Write(textArray[i] + " ");

int[,] numberArray = new int[4, 2];
string[] array = new string[2];
for (int i = 0; i < textArray.Length; i++)
{
    array = textArray[i].Split(",");
    numberArray[i, 0] = int.Parse(array[0]);
    numberArray[i, 1] = int.Parse(array[1]);
}
Console.WriteLine();
PrintMatrix(numberArray);

//Metanit.com
//Делегаты представляют такие объекты, которые указывают на методы. То есть делегаты - это указатели на методы и с помощью делегатов мы можем вызвать данные методы.
//Определение делегатов
//Для объявления делегата используется ключевое слово delegate, после которого идет возвращаемый тип, название и параметры. Например:
//delegate void Message();
//Делегат Message в качестве возвращаемого типа имеет тип void (то есть ничего не возвращает) и не принимает никаких параметров.
//Это значит, что этот делегат может указывать на любой метод, который не принимает никаких параметров и ничего не возвращает.

//Рассмотрим примение этого делегата:

// Message mes;            // 2. Создаем переменную делегата. Для использования делегата объявляется переменная этого делегата.
// mes = Hello;            // 3. Присваиваем этой переменной адрес метода. Далее в делегат передается адрес определенного метода (в нашем случае метода Hello).
//                         //    Обратите внимание, что данный метод имеет тот же возвращаемый тип и тот же набор параметров (в данном случае отсутствие параметров), что и делегат.
// mes();                  // 4. Вызываем метод. Затем через делегат вызываем метод, на который ссылается данный делегат. Вызов делегата производится подобно вызову метода.
 
// void Hello() => Console.WriteLine("Hello METANIT.COM");
 
// delegate void Message(); // 1. Объявляем делегат. Прежде всего сначала необходимо определить сам делегат:

Operation operation = Add;      // делегат указывает на метод Add
int result = operation(4, 5);   // фактически Add(4, 5)
Console.WriteLine(result);      // 9
     
operation = Multiply;           // теперь делегат указывает на метод Multiply
result = operation(4, 5);       // фактически Multiply(4, 5)
Console.WriteLine(result);      // 20

operation = Minus;           // теперь делегат указывает на метод Minus
result = operation(4, 5);       // фактически Multiply(4, 5)
Console.WriteLine(result);      // 20

int Minus(int x, int y)
{
    return x-y;
}

int Add(int x, int y) => x + y;
 
int Multiply(int x, int y) => x * y;
 
delegate int Operation(int x, int y);

