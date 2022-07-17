//--Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы “к” заменить большими “К”, а большие “С” заменить
//маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
                + "ежели бы вас послали вместо нашего милого "
                + "Винценгероде, вы бы взяли приступом согласие "
                + "прусского короля. Вы так красноречивы. Вы "
                + "дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

//метод принимает текст и меняет в нём символы oldValue на newValue
string Replace(string text, char oldValue, char newValue)
{
    //String.Empty - пустая строка
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
            result = result + $"{newValue}";
        else
            result = result + $"{text[i]}";
    }
    return result;
}

Console.Clear();
//аргументы метода можно указывать не по порядку, а по их имени
//'' - char, "" - string
string newText = Replace(oldValue: ' ', newValue: '|', text: text);
Console.WriteLine(newText);
Console.WriteLine();

//а можно и по порядку и без имени
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();

