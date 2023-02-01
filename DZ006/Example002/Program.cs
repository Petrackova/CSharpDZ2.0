// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.Write("Значение b1:= ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Значение k1:= ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Значение b2:= ");
double b2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Значение k2:= ");
double k2 = Convert.ToDouble(Console.ReadLine());
PrintNumber();

double FindX (double b1, double k1, double b2, double k2)
{
    double x;
    x = (b2 - b1) / (k1 - k2);
    x = Math.Round(x,2);
    return x;
}
double FindY1 (double b1, double k1, double x)
{
    double y;
    y = k1 * x + b1;
    y = Math.Round(y,2);
    return y;
}
double FindY2 (double b2, double k2, double x)
{
    double y;
    y = k2 * x + b2;
    y = Math.Round(y,2);
    return y;
}
void PrintNumber ()
{
    double x = FindX(b1, k1, b2, k2);
    double y1 = FindY1(b1, k1, x);
    // Для проверки
    double y2 = FindY2(b2, k2, x);
    System.Console.WriteLine($"Значение x=: {x}");
    System.Console.WriteLine($"Значение y1 при x=: {y1}");
    System.Console.WriteLine($"Значение y2 при x=: {y2}");
    System.Console.WriteLine($"Точка пересения двух прямых : ({x}; {y2})");
}