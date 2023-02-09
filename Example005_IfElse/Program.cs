Console.WriteLine("Ввидите имя пользователя: ");
string username = Console.ReadLine();

if( username.ToLower() == "максим")
{
    Console.WriteLine("Ура, это же МАКСИМ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}