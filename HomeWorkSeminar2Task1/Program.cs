/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int randomNumber = new Random().Next(100, 1000);
int remainder = randomNumber % 100;
int secondNumber = remainder / 10;

Console.WriteLine($"Вторым числом числа {randomNumber} является число {secondNumber}");