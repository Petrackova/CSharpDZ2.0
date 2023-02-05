/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
System.Console.Write("Значение m:= ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Значение n:= ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] ar = FindArr(m,n);
PrintArr(ar);

double[,] FindArr(int lenghti, int lenghtj)
{
    double [,] result = new double [lenghti,lenghtj];
    for ( int i = 0; i < lenghti; i++) 
    {
        for ( int j = 0; j < lenghtj; j++) 
        {
            result[i,j] = new Random().NextDouble()*40-20;
            result[i,j] = Math.Round(result[i,j],1);
        }
    }
    return result;
}

void PrintArr(double [,] arr)
{
    for ( int i = 0; i < arr.GetLength(0); i++)
    {
        for ( int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}