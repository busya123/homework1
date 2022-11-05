
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
 /*
Console.Write("Введите индекс строки: ");
int x = Convert.ToInt32(Console.ReadLine());
 
Console.Write("Введите индекс столбца: ");
int y = Convert.ToInt32(Console.ReadLine());
 
int[,] numbers = new int[3, 4];
FillArray(numbers);
PrintArray(numbers);
 
if (x < numbers.GetLength(0) && y < numbers.GetLength(1)) Console.WriteLine(numbers[x, y]);
else Console.WriteLine($"{x}, {y} -> такого числа в массиве нет");
 
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
 
void PrintArray(int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
*/
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
 /*
 void FillArray(double[,] array)
{
    for (int i = 0; i <  array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) /10.0;
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i, j] + " ");
        }
        Console.WriteLine();
    }
      Console.WriteLine();
}
Console.WriteLine("Задайте размерность массива m x n:");
Console.Write("Введите  m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m,n];
 
 FillArray(matrix);
 PrintArray (matrix);
 */
 //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

Console.WriteLine("Введите количество строк");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = int.Parse(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + " ; ");
}

Console.WriteLine();
PrintArray(numbers);


