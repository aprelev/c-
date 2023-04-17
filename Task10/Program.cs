/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int ShowSecondNumber(int number)
{
    int SecondNumber = number / 10;
    int result = SecondNumber % 10;
    return result;
}
Console.WriteLine("Введтите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 99 && number <=1000)
{
    int SecondNumber = ShowSecondNumber(number);
    Console.WriteLine($"Вторая цифра трехзначного числа {SecondNumber}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}