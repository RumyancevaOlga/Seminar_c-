/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
/* Нужно ввести цикл, в котором через сумматор будет аккумулироваться остаток от деления на 10, 
при этом само число будет делиться на 10, столько раз, пока число больше 
нуля */

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int number = userNumber;

while(number > 0)
{
    sum = sum + number % 10;
    number = number / 10;
    Console.WriteLine(sum);
}

Console.WriteLine($"Сумма всех цифр числа {userNumber} равна {sum}");