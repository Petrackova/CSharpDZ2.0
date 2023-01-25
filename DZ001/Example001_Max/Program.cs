//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2>number1)
{
    max = number2;
    Console.WriteLine("Второе число больше := " + number2 + " Первое число меньше := " + number1);
}
else 
{
    Console.WriteLine("Первое число больше := " + number1 + " Второе число меньше := " + number2);
}