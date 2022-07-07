//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

string numString = num.ToString();
int[] arrayNumbers = new int[numString.Length];

for(int i=0; i < numString.Length; i++)
{
    arrayNumbers[i] = int.Parse(numString[i]+ "");
}
for(int j=0; j<arrayNumbers.Length; j++)
{
    sum = sum + arrayNumbers[j];
}
Console.WriteLine($"Сумма цифр в числе равна {sum}.");