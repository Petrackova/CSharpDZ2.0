//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
if ((number1 == 7) || (number1 == 6))
{
    Console.WriteLine("Выходной");
}
else if ((number1 > 7) || (number1 < 0))
{
    Console.WriteLine("Такого дня недели нет");
}
else if ((number1 > 0) || (number1 < 7))
{
    Console.WriteLine("Будни");
}