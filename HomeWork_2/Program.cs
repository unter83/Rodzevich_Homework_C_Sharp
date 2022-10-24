
// === Задача 10 ===
//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.Clear();
Console.WriteLine("The program that shows a second digit in the number.");
Console.WriteLine(" ");

int SecondDigit(int num)
{
    return (num / 10) % 10;
}

Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 1000 || number < 100)
        Console.Write("You entered non three-digit number");
    else
        Console.WriteLine($"The second digit in {number} is {SecondDigit(number)}");

*/

// === Задача 13 ===
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.Clear();
Console.WriteLine("The program that shows a third digit in the number or makes warning that there is no third digit.");
Console.WriteLine(" ");

int ThirdDigit(int num)
{
    while (num > 1000)
        num = num / 10;
    return num % 10;
}

Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
        Console.Write("Your number contains less than three digits");
    else
        Console.WriteLine($"The third digit in {number} is {ThirdDigit(number)}");
*/

// === Задача 15 ===
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.Clear();
Console.WriteLine("The program that shows is the day is weekend");
Console.WriteLine(" ");

void DayOfWeek(int day)
{
   switch (day)
    {
        case < 6: Console.WriteLine("Not weekend"); break;
        case 6:
        case 7:  Console.WriteLine("Weekend"); break;
        case > 7:  Console.WriteLine("You entered a day of next week. Try again."); break;
    }
}

Console.Write("Enter the number of day: ");
int number = Convert.ToInt32(Console.ReadLine());
DayOfWeek(number);

*/