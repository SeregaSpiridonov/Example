﻿int number1 = new Random().Next(1, 10); //1,2,3,4,5...10
Console.WriteLine(number1);
int number2 = new Random().Next(1, 10);
Console.WriteLine(number2);
int result = number1 + number2;
Console.Write("Сумма двух случайных чисел: ");
Console.WriteLine(result);