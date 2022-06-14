/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

using static System.Console;
Clear();
WriteLine("Введите трёхзначное число");
int number = int.Parse(ReadLine());
int number2 = number/10%10;
WriteLine($"Вторая цифра введенного числа: {number2}");