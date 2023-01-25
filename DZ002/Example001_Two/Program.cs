// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int number1 = Convert.ToInt32(Console.ReadLine());
if ((number1 > 99) && (number1 < 1000))
{
    int number2 = (number1 / 10) % 10;
    Console.WriteLine(number2);
}
else
{
    Console.WriteLine("Число не трехзначное");
}