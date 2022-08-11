/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 100 && number > -100)
{
    Console.WriteLine($"У числа {number} нет третьей цифры");
}
else 
{
    int devision = Math.Abs(number) / 100;
    int score = 0;
    while(devision > 1)
    {
       score++;
       devision = devision / 10;
    }
     int thirdNumber = 0;
     if(score > 1)
     {
        int degree = 10;
        int i = 1;
       while(i < score)  
       {
        thirdNumber = number / degree % 10;
        degree = degree * 10;
        i++;
       }
     }
       else
       {
        thirdNumber = number % 10;
       }
        Console.WriteLine($"Третей цифрой числа {number} является {thirdNumber}");
}
