﻿// === Задача 19 ===
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*

Console.Clear();

Console.WriteLine("The program that shows is the 5-digit number is palindrome.");
Console.WriteLine();

void IsPalindrome(int number)
{
    if ((number / 10000 == number % 10) && ((number / 1000) % 10 == (number % 100) / 10))
         Console.Write(number + " is palindrome");
    else
        Console.Write(number + " is not palindrome");
}

Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100000 && number > 10000)
    IsPalindrome(number);
else
    Console.WriteLine("The number is not 5-digit");

*/

// === Задача 21 ===
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

double Delta(int[] va, int[] vb)
{
   double distance = Math.Sqrt(
    Math.Pow(vb[0] - va[0], 2)
    + Math.Pow(vb[1] - va[1], 2) 
    + Math.Pow(vb[2] - va[2], 2));
   return Math.Round(distance, 2);

}

Console.WriteLine("The program that calculate the distanse between two points in 3D.");
Console.WriteLine();

Console.WriteLine("Input coordinate of the first point (X, Y, Z): ");
int[] va = new int[3];
int[] vb = new int[3];
char[] xyz = {'X', 'Y', 'Z'};
for (int i = 0; i < 3; i++)
 {
    Console.Write($"Input {xyz[i]}1:");
    va[i] = Convert.ToInt32(Console.ReadLine());
 }

 Console.WriteLine("Input coordinate of the second point (X, Y, Z): ");
 for (int i = 0; i < 3; i++)
 {
    Console.Write($"Input {xyz[i]}2:");
    vb[i] = Convert.ToInt32(Console.ReadLine());
 }
 
Console.WriteLine ($"The distance between the first point ({va[0]}, {va[1]}, {va[2]}) and the second point({vb[0]}, {vb[1]}, {vb[2]}) is {Delta(va, vb)}");