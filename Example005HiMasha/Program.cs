Console.WriteLine("Введите ваше имя: ");
String username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine("Приветствую вас госпожа Мария");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}