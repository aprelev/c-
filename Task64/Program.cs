/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


Console.WriteLine("Введите число n");
 int n = Convert.ToInt32(Console.ReadLine());
 int num = 1;
 NaturalToLow(n, num);

 void NaturalToLow(int n, int num)
 {
     if (num > n)
     {
         return;
     }
     else
     {
         NaturalToLow(n, num + 1);
         Console.Write(num + " ");
     }
 }