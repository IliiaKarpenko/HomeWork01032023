/*ДЗ №2
Напишите смогла справиться
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

Console.Write("Введите число: ");
String test = Console.ReadLine();

  if (isPalidrom == true)
{
    Console.WriteLine ("Это палиндром");
}
  else
{
    Console.WriteLine ("Это не палиндром");
}


{
for (int i  = 0;  i < test.Length - 1; i ++);
}

int m = test.Length -1 -i;

{
palindrom = false;
}
return palindrom;
/*

*/
/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance3D(double x1, double y1, double x2, double y2, double z1, double z2)
{
double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)  );
return Math.Round(res, 2);
}

Console.Write("Введите координату по Х для первой точки ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по У для первой точки ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Х для второй точки ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Y для второй точки ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Z для второй точки ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Z для второй точки ");
double z1 = Convert.ToDouble(Console.ReadLine());

double distance = Distance3D(x1, y1, x2, y2, z1, z2);
System.Console.WriteLine($"Расстояние между точками = {distance}");
/*

/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= number; i++)
Console.Write($"{Math.Pow(i, 3)} ");
/*

_____________________________________________________________________________________________________________________________________gi
/*ДЗ 1
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1


int SecondNum (int num)

{ 
int ones = num/ 10 % 10;
int result = ones;
return result;
}

int RandNum = new Random().Next( 100, 1000);
int NewNum = SecondNum(RandNum);
Console.WriteLine($"New version { RandNum} is { NewNum } ");
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

не СПРАВИЛАСЬ С НЕЙ, ЗАПУТАЛАСЬ 

int ThirdNum(int num)
{
  while (num > 999)
    {
    num /= 10;
    }
  return num % 10;
}

bool Other(int num)
{
  if (num < 999)
}

Console.WriteLine("третьей цифры нет");
return false

int RandNum = new Random().Next( 100, 1000);

int NewNum = ThirdNum (RandNum);

Console.WriteLine($"New version { ThirdNum } is { NewNum } ");
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет


Console.Write("Введи цифру, обозначающую день недели: ");

int dayNum = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int dayNum) {

  if (dayNum == 6 || dayNum == 7) 
  {
  Console.WriteLine("этот день выходной");
  }
  else if (dayNum < 1 || dayNum > 7) 
  {
   Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("этот день не выходной");
}

CheckingTheDayOfTheWeek(dayNum);
*/






/* методы и функции- это подпрограмма, есть аргументы т.е входные данные. У Метода есть имя. 
Метод возвращает данные, если это необходимо.
Методы пишим с большой буквы
*/

/*
int CutNumber( int num)
{
    int sotny = num / 100;
    int one = num % 10;
    int result = sotny * 10 + one;
    return result;
}
//  или
*/

/*
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int CutNumber( int num)
{
    int sotny = num / 100;
    int one = num % 10;
  
    return sotny * 10 + one;
}

 int randNumber= new Random().Next(100 , 1000);
 int newNum = CutNumber(randNumber);
 Console.WriteLine ($"новая версия  {randNumber} это  {newNum} ");
 */

/*
 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно  a и b.

 Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

 */

/*
int CutNumber( int num)
{
    int ferst = num / 10;
    int second = num % 10;
  if( ferst > second)
  {
    return ferst;
  }
  else
  {
     return second;
  }
   
}


 int randNumber= new Random().Next(10 ,99);
 int newNum = CutNumber(randNumber);

Console.WriteLine($"For {randNumber} max number is {CutNumber(randNumber)}");
*/

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
Console.WriteLine("введите число первое");
int numone = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число второе");
int numsecoud = Convert.ToInt32(Console.ReadLine());

bool DublNumber( int numone, int numsecoud)

{
    return numone==numsecoud*numsecoud || numsecoud ==numone*numone;
}


Console.WriteLine ($"{DublNumber( numone, numsecoud)}");
*/

/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

/*
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("введите номер четверти");
int cvoter=Convert.ToInt32(Console.ReadLine());

if (cvoter == 1)
{
    Console.Write("Допустимый диапозон значений y > 0, x > 0");
}
else if (cvoter == 2)
{
    Console.Write("Допустимый диапозон значений y > 0, x < 0");
}
else if (cvoter == 3)
{
    Console.Write("Допустимый диапозон значений y < 0, x < 0");
}
else if (cvoter == 4)
{
    Console.Write("Допустимый диапозон значений y < 0, x < 0");
}
else {
    Console.Write("Это не четверть");
}
/*

/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
формула
l = √ (x 2 - x 1) 2+ (y 2 - y 1) 2


double FindLengh (double x1,double x2,double y1,double y2)
{
  double result = Math.Sqrt(Math.Pow(x2 - x1,2)+ Math.Pow(y2 - y1,2));
  return result; 
}

Console.WriteLine("введите координату по оси Х первой точки");
double x1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату по оси y первой точки");
double y1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату по оси x второй точки");
double x2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату по оси y второй точки");
double y2=Convert.ToInt32(Console.ReadLine());

 double FindLengh2d=FindLengh(x1, x2, y1, y2);
System.Console.WriteLine ($"расстояние между точками = {FindLengh2d}");
*/

/*
/ Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
Console.Write("Точка лежит в первой четверти");
}
else if (x < 0 && y > 0)
{
Console.Write("Точка лежит во второй четверти");
}
else if (x < 0 && y < 0)
{
Console.Write("Точка лежит в третьей четверти");
}
else if (x > 0 && y < 0)
{
Console.Write("Точка лежит в четвертой четверти");
}
else
{
Console.Write("Точка лежит на оси");
}




Задача №18 Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).




// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
string[] quarters = {"x > 0; y > 0",
"x < 0; y > 0",
"x < 0; y < 0",
"x > 0; y < 0"};

System.Console.Write("Введите номер четверти: ");
int quater = Convert.ToInt32(Console.ReadLine());

if(quater >= 1 && quater <= 4)
{
System.Console.WriteLine(quarters[quater - 1]);
}
else
{
System.Console.WriteLine("Неправильно номер четверти");
}




Задача №21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
double number = 5;

// double res = Math.Pow(number, 2); // возведение в степень
// System.Console.WriteLine(res);

double res = Math.Sqrt(number); // извлечение квадратного корня
res = Math.Round(res, 3); // округление
System.Console.WriteLine(res);




// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Distance2D(double x1, double y1, double x2, double y2)
{
double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
return Math.Round(res, 2);
}

Console.Write("Введите координату по Х для первой точки ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по У для первой точки ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Х для второй точки ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Y для второй точки ");
double y2 = Convert.ToDouble(Console.ReadLine());

double distance = Distance2D(x1, y1, x2, y2);
System.Console.WriteLine($"Расстояние между точками = {distance}");




Задача №22 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4

 




// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= number; i++)
{
Console.Write($"{Math.Pow(i, 2)} ");
 
*/
