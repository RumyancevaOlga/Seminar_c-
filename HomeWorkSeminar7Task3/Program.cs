/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

//Задаем случайное количество строк и столбцов (для интереса)
int rows = new Random().Next(1,10);
int columns = new Random().Next(1,10);

//Применяем методы по созданию и печати массива, чтобы его было сразу видно
int[,] array = GetArray(rows, columns, 0, 20);
PrintArray(array);
Console.WriteLine();

//Применяем метод по нахождению среднего арифметического и выводим получившийся одномерный массив на экран
double[] arithmeticMean = ArithmeticMeanByColumns(array);
PrintArrayDouble(arithmeticMean);

//Задаем метод для заполнения массива случайными числами 
int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] result = new int [rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result[i,j] = new Random().Next(min,max);
        }
    }
    return result;
}

//Задаем метод для вывода массива на экран

void PrintArray(int [,] array)
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

//Задаем метод для вывода одномерного массива с вещественными числами на экран

void PrintArrayDouble(double[] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} ");
    }
}

//Описываем метод для нахождения среднего арифметического по столбцам
double[] ArithmeticMeanByColumns(int [,] array)
{
    double[] result = new double [array.GetLength(1)];
    double sum = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j,i];//Находим сумму элементов в столбце
        }
        result[i] = sum / array.GetLength(0);//Находим среднее арифметическое
        result[i] = Math.Round(result[i], 2);//Округляем до двух знаков после запятой
        sum = 0;//Обнуляем сумму для следующего цикла
    }
    return result;
}
