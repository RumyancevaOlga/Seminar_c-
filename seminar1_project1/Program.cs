/*
 Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное само на себя)
Например:
4 -> 16
-3 -> 9
-7 -> 49
*/

int userNumber = new int();
Console.WriteLine("Введите число: ");
userNumber = Convert.ToInt32(Console.ReadLine());

int result = (userNumber * userNumber);

Console.WriteLine($"Квадрат числа {userNumber} = {result}");
