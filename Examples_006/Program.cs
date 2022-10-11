Console.WriteLine("Введите имя пользователя ");
string username = Console.ReadLine();
if (username.ToLower() == "Маша")
{
    Console.WriteLine("Ура! Это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}