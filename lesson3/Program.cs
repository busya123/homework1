//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
Console.Write("Enter the number: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] && number[1]==number[3])
  {
    Console.WriteLine($"Your number: {number} - palindrome.");
  }
  else Console.WriteLine($"Your number: {number} - No palindrome.");
}
if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Enter the correct number");
*/


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double Distance(double  x1, double  x2, double  y1, double  y2, double  z1, double z2)
{
    double a = ((x2-x1)*(x2-x1));
    double b = ((y2-y1)*(y2-y1));
    double c = ((z2-z1)*(z2-z1));
    double d = Math.Sqrt(a+b+c);
    double result = Math.Round(d,2);
    return result;
}

Console.WriteLine("coordinates of the first point x1 ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("coordinates of the first point y1 ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("coordinates of the first point z1 ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("coordinates of the second poin x2 ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("coordinates of the second poin y2 ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("coordinates of the second poin z2 ");
double z2 = Convert.ToDouble(Console.ReadLine());

double dis = Distance(x1, x2, y1, y2, z1, z2);
Console.WriteLine($"distance {dis}");
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int number = 1;
  int length = cube.Length;
  while (number <  length)
  {
    cube[number] = Convert.ToInt32(Math.Pow(number, 3));
    number++;
  }
}

void PrintArray(int[] coll)
{
  int count = coll.Length;
  int index = 1;
  while(index < count)
  {
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] array = new int[cube+1];
Cube(array);
PrintArray(array);

*/