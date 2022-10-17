 /*
 //Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Exponentiation(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }  
    return result;
}
Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());
  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Ответ: " + exponentiation);
*/
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int SumNumber (int num)
{
    int result = 0;
    int sum = 0;
    while (num > 0)
    {
        sum = num % 10  ;
        num /= 10;
        result = result + sum;
    }
    return result;
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int n = SumNumber(a);
Console.WriteLine($"Сумма цифр в числе {a}: {n}");
*/
/*
//Напишите программу, которая задаёт массив из m элементов и выводит их на экран
Console.WriteLine($"\nЗадача 29. Ряд чисел преобразует в массив");
Console.Write("Введите ряд чисел, разделенных запятой : ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для обозначения конца строки

// функция удаления пробелов из строки  

string RemovingSpaces (string series)
{
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}
*/

Console.WriteLine("Введите размер массива ");
int m = int.Parse(Console.ReadLine());
int[] array = new int [m];
int index = 0;
while (index < m)
{
    array[index] = new Random().Next();
    index++;
}
Console.WriteLine("Ваш массив ");
