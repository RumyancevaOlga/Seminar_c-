﻿/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите числа. Для окончания ввода введите esq.");

int j = 0;

for(int i = 0; i < 100; i++)
{
string userNumber = Console.ReadLine();
if(Int32.TryParse(userNumber, out int numValue))//Почитала про TryPurse, использовала для остановки ввода чисел
{
  if(numValue > 0)
  {
    j++;   //Считаем числа больше нуля
  }  
}
else
{
    break; //Если ввели буквы, останавливаем цикл
}
}
Console.WriteLine($"Вы ввели {j} числа(ел) больше нуля.");
