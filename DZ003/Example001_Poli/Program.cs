// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Решение 1
Console.WriteLine("Метод 1");
Console.WriteLine("Введите пятизначное число");
int number1 = Convert.ToInt32(Console.ReadLine());
if ((number1 > 10000) && (number1 < 100000))
{
    int firssNum = (number1 / 10000);
    int secondNum = (number1 / 1000) % 10;
    int forNum = (number1 % 100) / 10;
    int fiveNum = number1 % 10;
    if ( (firssNum == fiveNum) && (secondNum == forNum))
    {
        Console.WriteLine("Число является полиндромом");
    }
    else 
    {
        Console.WriteLine("Число не является полиндромом");
    }
}
else
{
    Console.WriteLine("Число не пятизначное");
}
// Решение 2
Console.WriteLine("Метод 2");
int num1 = new Random().Next(10000,100000);
Console.WriteLine($"Число {num1}");
int num2 = num1;
int result=0;
while (num1>0)
{
    result = result*10 + num1%10;
    num1 /= 10;
}
if (num2 == result)
{
    Console.WriteLine("Число является полиндромом");
}
else 
{
    Console.WriteLine("Число не является полиндромом");
}