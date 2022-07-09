// Друзья идут навстречу друг другу, собака бегает между ними.
//результатом работы программы будет количество пробегов собаки за то время, пока друзья не встретятся (расстояние будет меньше 1)
Console.Clear();
Console.WriteLine("Сейчас: " + DateTime.Now);
int count = 0;
Console.Write("Введите расстояние между друзьями: ");
double distance = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите скорость движения первого друга: ");
int firstFriendSpeed = Convert.ToInt16(Console.ReadLine());

Console.Write("Введите скорость движения второго друга: ");
int secondFriendSpeed = Convert.ToInt16(Console.ReadLine());

Console.Write("Введите скорость движения собаки: ");
int dogSpeed = Convert.ToInt16(Console.ReadLine());

double time;
bool firstFriendToSecond = true;

while (distance > 1)
{
    if (firstFriendToSecond)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        firstFriendToSecond = !firstFriendToSecond;
    }
    else
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        firstFriendToSecond = !firstFriendToSecond;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
//    Console.WriteLine("Расстояние между друзьями после " + count + " пробега собаки = " + distance);    
}

Console.WriteLine("Пока друзья не встретятся, собака пробежит между ними " + count + " раз.");