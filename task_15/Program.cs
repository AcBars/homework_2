/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

using static System.Console;
Clear();
string [] wekend = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
WriteLine("Введите день недели");
//string number_day = ReadLine();
string input = ReadLine();
if (decimal.TryParse(input, out decimal number_day))
{
    int day = int.Parse(input);
    WriteLine(day > 5 ? $"{wekend[day - 1]}- это выходной день" : $"{wekend[day - 1]}- это рабочий день");
    WriteLine();
}
 
//else
//WriteLine("Вам же сказали: ввести ЧИСЛО!");

//WriteLine(number_day);



// {
//     number_day = int.TryParse(number_day);
//     WriteLine(number_day > 5 ? $"{wekend[number_day - 1]}- это выходной день" : $"{wekend[number_day - 1]}- это рабочий день");
//     WriteLine();
// }
if (number_day==wekend[0]) WriteLine("Понедельник - рабочий день недели.");
else if (number_day==wekend[1]) WriteLine("Вторник - рабочий день недели.");
else if (number_day==wekend[2]) WriteLine("Среда - рабочий день недели.");
else if (number_day==wekend[3]) WriteLine("Четверг - рабочий день недели.");
else if (number_day==wekend[4]) WriteLine("Пятница - рабочий день недели.");
else if (number_day==wekend[5]) WriteLine("Суббота - выходной день недели.");
else if (number_day==wekend[6]) WriteLine("Воскресенье - выходной день недели.");
else WriteLine("Неправильный ввод.");


//Clear();

// if (number_day < 1 || number_day >= 8)
// {
//     WriteLine("Вы ввели не день недели");
//     WriteLine();
// }
// else
// {
//     WriteLine(number_day > 5 ? $"{wekend[number_day - 1]}- это выходной день" : $"{wekend[number_day - 1]}- это рабочий день");
//     WriteLine();
// }


// WriteLine(wekend[number_day-1]);

