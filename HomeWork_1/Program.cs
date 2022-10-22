// === Задача 2 ===
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Clear();
Console.WriteLine("The program that shows the grater number of two numbers.");
Console.WriteLine(" ");
Console.Write("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
    Console.Write("The numbers are equal.");
if (number1 > number2)
    Console.Write($"The number {number1} is greater than the number {number2}.");
if (number1 < number2)
    Console.Write($"The number {number2} is greater than the number {number1}.");
*/

// === Задача 4 ===
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Clear();
Console.WriteLine("The program that shows the grater number of three numbers.");
Console.WriteLine(" ");
int[] number = new int[3];
Console.Write("Input first number: ");
number[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
number[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
number[2] = Convert.ToInt32(Console.ReadLine());
int count = 0;
int g_number = number[count];
while (count < 3)
{
    if (g_number < number[count])
    g_number = number[count]; 
    count++; 
}
Console.Write($"The greater number is: {g_number}");
*/

// === Задача 6 ===
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Clear();
Console.WriteLine("The program that shows the digit is odd or even.");
Console.WriteLine(" ");
Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
    Console.Write($"The number {number} is even.");
else
    Console.Write($"The number {number} is odd.");
*/