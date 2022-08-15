/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

int lastNumber = 0; 
int firstNumber = 0;
int palindrome = userNumber;

while(palindrome > 9)
{
    lastNumber = palindrome % 10;
    firstNumber = palindrome;
    int i = 1;
    while(firstNumber > 9)
    {
        firstNumber = firstNumber / 10;
        i = i * 10;
    }
    if (firstNumber != lastNumber)
    {
        break;
    }  
    if((palindrome - firstNumber * i) / 10 < palindrome / 100 && palindrome / 10 % 10 == 0)
    {
        palindrome = (palindrome - firstNumber * i) / 10; 
        for(int j = i / 100; j > palindrome; j = j / 100)
        {
            palindrome = palindrome / 10; 
        }
    }
    else palindrome = (palindrome - firstNumber * i) / 10;
}

if(firstNumber == lastNumber && userNumber > 9)
{
    Console.WriteLine($"Ура! {userNumber} является палиндромом.");
}
else
{
   Console.WriteLine($"{userNumber} НЕ является палиндромом.");
}
