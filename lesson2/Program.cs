// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.WriteLine("Input a three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(n / 10 % 10);
*/

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.Write("Enter a number: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("third digit -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> no third digit");
}
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.Write("Enter a number for the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("(this day is a day off) -> Yes");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("it's not a day of the week");
  }
  else Console.WriteLine("(this day is not a day off) -> No");
}
CheckingTheDayOfTheWeek(dayNumber);
*/
