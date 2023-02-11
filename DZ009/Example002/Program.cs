/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
System.Console.Write("Значение M:= ");
int start = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Значение N:= ");
int end = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(PrintNumbers(start,end));

int PrintNumbers( int start, int end)
{
    if ( start == end)
    {
        return start;
    }
    return (start + PrintNumbers(start+1,end));
}