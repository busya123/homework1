//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int size = int.Parse(Console.ReadLine());
int[] array = new int [size];
int index = 0;
int countChet = 0;

while (index < size)
{
    array[index] = new Random().Next(99,1000);
    index++;  
}
Console.WriteLine("Ваш массив ");
Console.WriteLine();
index = 0;

while(index < size)
{   
    Console.WriteLine($"{array[index]}");
    index++;
}
Console.WriteLine();
index = 0;

while (index < size)
{
    if (array[index] %2 == 0)
    countChet = countChet + 1;
    index++;
}
Console.WriteLine();
Console.WriteLine($"Четных чисел {countChet} ");
Console.WriteLine();
*/
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] array = new int [4];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,4);
    Console.Write(array[i] + ", ");
    {
        sum = sum + array[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов одномерного массива стоящих на не четных позициях = {sum}");
*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
int size = 5; // задаём 5, как в  д.з №38
double[] b = new double[size];
Random rand = new Random();
Console.WriteLine("Массив: ");
for (int i = 0; i < b.Length; ++i)
{
    b[i] = Math.Round((rand.NextDouble() * 10), 2);
    Console.Write(string.Join(".", b[i], " "));
}
double maxValue = b[0];
double minValue = b[0];
for (int i = 0; i < b.Length; ++i)
{
    if (maxValue < b[i]) maxValue = b[i];
    if (minValue > b[i]) minValue = b[i];
}
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементов массива:");
Console.Write($"{maxValue} - {minValue} = {(maxValue - minValue)}");
*/