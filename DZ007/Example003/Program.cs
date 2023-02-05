/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
System.Console.Write("Значение m:= ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Значение n:= ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] ar = FindArr(m,n);
PrintArr(ar);
System.Console.WriteLine("Cреднее арифметическое в каждом столбце");
FindSumm(ar);

int[,] FindArr(int lenghti, int lenghtj)
{
    int [,] result = new int [lenghti,lenghtj];
    for ( int i = 0; i < lenghti; i++) 
    {
        for ( int j = 0; j < lenghtj; j++) 
        {
            result[i,j] = new Random().Next(1,10);
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

void FindSumm(int[,] arr)
{ 
    double summ;
    for ( int i = 0; i < arr.GetLength(0); i++) 
    {
        summ = 0;
        for ( int j = 0; j < arr.GetLength(1); j++) 
        {
            summ = summ + arr[j,i]; 
        }
        summ = summ/arr.GetLength(1);
        summ = Math.Round(summ,2);
        System.Console.Write($"{summ} ");
    } 
}