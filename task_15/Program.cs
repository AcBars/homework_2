/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

using static System.Console;
Clear();
string [] wekend = {"Понедельник", "Вторник", "Среда", "Четвер", "Пятница", "Суббота", "Воскресенье"};
WriteLine("Введите день недели");
int number_day = Convert.ToInt32(ReadLine());
if (number_day<1||number_day>=8) WriteLine("Вы ввели не день недели");
else WriteLine(number_day>5 ? $"{wekend[number_day-1]}- это день выходной" : $"{wekend[number_day-1]}- этот день рабочий");

// WriteLine(wekend[number_day-1]);