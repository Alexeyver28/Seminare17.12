﻿//  Задание: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine ("Enter any number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
   Console.WriteLine ("number "+number+" is even");
}
else
{
    Console.WriteLine ("number "+number+" is not even");
}