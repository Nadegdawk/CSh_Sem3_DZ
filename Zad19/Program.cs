﻿// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
//            является ли оно палиндромом.
//              14212 -> нет
//              12821 -> да
//              23432 -> да

Console.WriteLine("Является ли пятизначное число палиндромом");
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

if (num > 9999 & num < 100000)
{
    if (num / 10000 == num % 10)
    {
        if ((num / 1000) % 10 == (num / 10) % 10)
        {
            System.Console.WriteLine("Число палиндром");
        }
        else System.Console.WriteLine("Число НЕ палиндром");
    }
    else System.Console.WriteLine("Число НЕ палиндром");
    }
else System.Console.WriteLine("Число не пятизначное");