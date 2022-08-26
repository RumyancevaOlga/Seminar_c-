/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

//описываем метод, который будет заполнять массив случайными числами

double [,] GetArray(int rows, int columns, int min, int max)
{
    double [,] result = new double [rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            double realNumber;
            Random rnd = new Random();
            realNumber = rnd.NextDouble();
            result[i,j] = new Random().Next(min, max) + realNumber;
            result[i,j] = Math.Round(result[i,j], 2);
        }
    }
    return result;
}

//Описываем метод для вывода массива на экран
void PrintArray(double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

//Применяем наши методы
double [,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);


