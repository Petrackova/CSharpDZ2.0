//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите числа A и B");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"число A в натуральную степень B := {FindSqrt(number1, number2)}");

int FindSqrt ( int arg1, int arg2)
{
    int number3 = Convert.ToInt32(Math.Pow(arg1, arg2));
    return number3;
}
