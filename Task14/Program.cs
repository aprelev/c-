/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/


Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число на кратность");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число на кратность");
int number3 = Convert.ToInt32(Console.ReadLine());

bool result = MultNumbers(number1, number2, number3);
Console.WriteLine(result ? "Да" : "Нет");

bool MultNumbers(int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
}