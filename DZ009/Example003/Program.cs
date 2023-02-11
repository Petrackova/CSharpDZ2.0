/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
System.Console.Write("Значение m:= ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Значение n:= ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{Akker(m,n)}");   

int Akker(int number, int argument)
{
    if (number == 0)
    {
        return argument + 1;
    }
    if ((number > 0) && (argument == 0))
    {
        return FindAkk(number - 1, 1);
    }
      return FindAkk(number - 1, FindAkk(number, argument - 1));
    }