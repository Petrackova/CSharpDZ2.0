/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

System.Console.Write("Значение N:= ");
int end = Convert.ToInt32(Console.ReadLine());
int start = 1;
System.Console.WriteLine(PrintNumbers(end,start));

string PrintNumbers(int end, int start)
{
    if ( start == end)
    {
        return end.ToString();
    }
    return (end + " " + PrintNumbers(end-1,start));
}