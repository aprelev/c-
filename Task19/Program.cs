/* 
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

14212 -> нет

12821 -> да

23432 -> да
*/



int n, remind, sum = 0, temp;
Console.WriteLine("Введите пятизначное число ");
n = Convert.ToInt32(Console.ReadLine());
temp = n ;


    while(n>0){
        remind = n % 10 ;
        n = n / 10;
        sum = sum * 10 + remind;
    }
    if(temp==sum){
        Console.WriteLine("Введенное число Палидром");
    }
    else{
        Console.WriteLine("Введенное число не Полидром");
    }