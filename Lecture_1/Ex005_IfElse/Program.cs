// комментарий
Console.Clear();
Console.Write("Who are you? ");
string? userName = Console.ReadLine();
if (userName != null)
{
    if (userName.ToLower() == "маша")
    {
        Console.Write("Привет, " + userName + "!");
    }
    else
    {
        Console.Write("Слушай, " + userName + ", отвали от компьютера!!!");
    }
}
//Console.Write(userName);