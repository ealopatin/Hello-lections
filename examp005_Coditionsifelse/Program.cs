Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "витя")
{
    Console.WriteLine("Ура, это же Витька!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}