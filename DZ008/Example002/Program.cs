/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

System.Console.Write("Значение m:= ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Значение n:= ");
int n = Convert.ToInt32(Console.ReadLine());
if ( m != n)
{
    int[,] ar = FindArr(m,n);
    PrintArr(ar);
    int[] newarr = FindSumm(ar,m);
    FindMin(newarr);
}
else
{
    System.Console.WriteLine("Массив не прямоугольный!");
}


int[,] FindArr(int lenghti, int lenghtj)
{
    int [,] result = new int [lenghti,lenghtj];
    for ( int i = 0; i < lenghti; i++) 
    {
        for ( int j = 0; j < lenghtj; j++) 
        {
            result[i,j] = new Random().Next(0,100);
        }
    }
    return result;
}

void PrintArr(int [,] arr)
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

int[] FindSumm(int[,] arr, int m)
{   
    int[] newarr = new int [m];
    for ( int i = 0; i < arr.GetLength(0); i++) 
    {   
        int summ = 0;
        for ( int j = 0; j < arr.GetLength(1); j++) 
        {
            summ = summ + arr[i,j];
            newarr[i] = summ; 
        }
        System.Console.WriteLine($"Cумма строки {i}:= {newarr[i]}");
    }
    return newarr;
}

void FindMin (int[] arr)
{
    int min = arr[0];
    int a = 0;
    for ( int i = 0; i < arr.Length; i++)
    {
        if ( min > arr[i])
        {
            min = arr[i];
            a = i;
        }
    }
    System.Console.WriteLine($"Номер строки с наименьшей суммой:= {a}");
}