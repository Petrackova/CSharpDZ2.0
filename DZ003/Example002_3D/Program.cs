//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21
Random rnd = new Random();
int XA = rnd.Next(1,20);
int YA = rnd.Next(1,30);
int ZA = rnd.Next(1,40);
Console.WriteLine($"Кородинаты точки A: {XA} {YA} {ZA}");
int XB = rnd.Next(1,20);
int YB = rnd.Next(1,30);
int ZB = rnd.Next(1,40);
Console.WriteLine($"Кородинаты точки B: {XB} {YB} {ZB}");
double x = Math.Pow((XB - XA), 2);
double y = Math.Pow((YB - YA), 2);
double z = Math.Pow((ZB - ZA), 2);
double AB = Math.Sqrt(x + y + z);
Console.WriteLine($"Расстояние между точками: {AB}");