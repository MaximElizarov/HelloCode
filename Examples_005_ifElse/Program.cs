Console.WriteLine("Введите имя ползователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "оля")
{
    Console.WriteLine("Ура, это же Оля!!!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}
