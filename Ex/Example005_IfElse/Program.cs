Console.WriteLine("Введите имя пользователя: ");
string usermane = Console.ReadLine();

if(usermane.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша");
}

else
{
    Console.Write("Привет, ");
    Console.WriteLine(usermane);
}