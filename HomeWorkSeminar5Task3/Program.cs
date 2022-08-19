/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

//Создаем массив вещественных чисел double. 5-ти элементов будет достаточно.
//Дополнительно используем метод NextDouble и с помощью Math.Round обрубаем знаки после запятой
//Создаем промежуточные переменные для максимума и минимума
//Говорим, что максимумом и минимумом является элемент с индексом ноль
//Сравниваем все элементы массива, таким образом находим максимальный и минимальный
//Выводим на экран разность максимума и минимума

double [] GetArray(int size, int minValue, int maxValue)
{
    double [] res = new double [size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        double number;
        Random rnd = new Random();
        number = rnd.NextDouble();
        res[i] = res[i] * number;
        res[i] = Math.Round(res[i], 2);
        Console.Write($"{res[i]} ");
    }
    return res;
}

double [] array = GetArray(5, 0, 100);
Console.WriteLine();

double maxNumber = array[0];
double minNumber = array[0];

for(int i = 1; i < array.Length; i++)
{
    if(array[i] > maxNumber)
    {
        maxNumber = array[i];
    }
    else if(array[i] < minNumber)
    {
        minNumber = array[i];
    }
}

Console.WriteLine($"Разность между максимальным {maxNumber} и минимальным {minNumber} элементами массива равна {maxNumber - minNumber}");
