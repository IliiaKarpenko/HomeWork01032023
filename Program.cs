/*
ДЗ
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

