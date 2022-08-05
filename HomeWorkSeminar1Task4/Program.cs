/*
 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int userNumber = new int();
Console.WriteLine("Введите число: ");
userNumber = Convert.ToInt32(Console.ReadLine());

int i = 2;

while(i <= userNumber)
{
    Console.Write($"{i}, ");
     i += 2;
}

