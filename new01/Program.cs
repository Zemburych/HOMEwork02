// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

int[] array = new int[3];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
   array[i] = rand.Next(0,9);
//Вывод массива 
            Console.WriteLine();
            Console.Write("Исходное число ");
            for (int i = 0; i < array.Length; i++)
            Console.Write(array[i]);
Console.WriteLine();
Console.WriteLine("вторая цифра - " + array[1]);