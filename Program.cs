// === Задача 19 ===
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
/*
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
*/

// === Задача 23 ===
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.Clear();

Console.WriteLine("The program that shows tables of cubes from 1 to N");
Console.WriteLine();

void cube_Array(int num)
{
    
    for (int i = 1; i <= num; i++)
    {
        Console.Write(Math.Pow(i, 3) + " ");
        if (i % 6 == 0)
           Console.WriteLine(); 
    }
}

Console.Write("Input N:");
int num = Convert.ToInt32(Console.ReadLine());
cube_Array(num);

*/
/*
Console.Clear();

int[] Array = new int[100];

for (int i = 0; i < 100; i++)

    Array[i] = new Random().Next(0, 100);
   
for (int i = 0; i < 100; i++)
{
    Console.Write(Array[i] + " ");
    if ((i + 1) % 10 == 0) Console.WriteLine();
}

int max = Array[0], max2 = Array[0];

for (int i = 0; i < 100; i++)
    if (Array[i] > max)
    {
        if (max > max2)
            max2 = max; 
        max = Array[i];
    }
/*
for (int i = 0; i < 100; i++)
  if (Array[i] > max2 && Array[i] != max)
  {
    max2 = Array[i];
  }
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < 100; i++)
{
    if (Array[i] == max)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Array[i] + " ");
            Console.ResetColor();
        }
        else
            if (Array[i] == max2)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(Array[i] + " ");
                Console.ResetColor(); 
            }
            else
                Console.Write(Array[i] + " ");
    if ((i + 1) % 10 == 0) Console.WriteLine();
}
*/
//Console.WriteLine(max);
//Console.WriteLine(max2);

// === Задача 19 ===
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.Clear();

Console.WriteLine("The program that shows is the 5-digit number is palindrome.");
Console.WriteLine();

bool IsPalindrome(int number)
{
    int dozen = 1, capacity = 0;

    while (Math.Abs(number / dozen) >= 1)
    {
        dozen = dozen * 10;
        capacity++;
    //   Console.WriteLine(dozen);
    }

    int digit = 0, digit2 = 0, count = 0, ten2 = 1;
    while (count < capacity / 2)
    {
        digit = (number / (dozen / (ten2 * 10))) % 10; // выделяем левую крайнюю цифру
        digit2 = (number % (ten2 * 10)) / ten2; // выделяем правую крайнюю цифру

        if (digit != digit2)
          return false;
         count++;
        ten2 = ten2 * 10;
    }
    return true;
    // if ((number / 10000 == number % 10) && ((number / 1000) % 10 == (number % 100) / 10))
    //      Console.Write(number + " is palindrome");
    // else
    //     Console.Write(number + " is not palindrome");
}

Console.Write("Input the number: ");
//int number = -12;
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(IsPalindrome(number));

