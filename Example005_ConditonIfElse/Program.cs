Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "люба")
{
    Console.WriteLine("Ура это Любимая");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}