// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 < 100)
{
    Console.WriteLine("третьего числа нет");
}
else if ((number1 > 99)&& (number1 < 1000))
{
    int number4 = number1 % 10;
    Console.WriteLine(number4);
}
else if (number1 > 1000)
{
    while (number1 > 1000)
    {
        number1 = number1 / 10;
    }
    int number2 = number1 % 10;
    Console.WriteLine(number2);
}