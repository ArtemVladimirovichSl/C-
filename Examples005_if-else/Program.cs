Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Привет, Маша! Очень рады Вам!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}