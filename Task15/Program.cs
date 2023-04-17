/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 1 && number <= 5)
{
    Console.WriteLine("Не выходной");
}
else if (number >= 6 && number <= 7)
{
    Console.WriteLine("Выходной");
}
else Console.WriteLine("В неделе всего семь дней");