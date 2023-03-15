/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите три числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2){
    if (num1 > num3){
        Console.WriteLine("Первое больше");
    }else{
        Console.WriteLine("Третье больше");
    }
}
else{
    if (num2 > num3){
        Console.WriteLine("Второе больше");
    }else{
        Console.WriteLine("Третье больше");
    }
}