// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();

Console.WriteLine("ВВедите день недели от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int day) 
{
  if (day == 6 || day == 7) 
  {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (day < 1 || day > 7) 
  {
    Console.WriteLine("неправильно");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

CheckingTheDayOfTheWeek(day);