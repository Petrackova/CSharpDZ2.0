/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
System.Console.Write("Значение m:= ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Значение n:= ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = FindArr(m,n);
PrintArray(arr);
System.Console.WriteLine();
int[,] a = Reversi(arr);
PrintArray(arr);

int[,] FindArr(int a, int b)
{
    int[,] result = new int [a,b];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j< result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(0,20);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j< arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine(" ");
    }
}

int[,] Reversi(int[,] arr)
{   
    int temp;
    for ( int i = 0; i < arr.GetLength(0); i++) 
    {   
        for ( int j = 0; j < arr.GetLength(1); j++) 
        {
            for (int a = j + 1; a < arr.GetLength(1); a++)
            {
                if ( arr[i,j] < arr[i,a])
                {
                    temp = arr[i,j];
                    arr[i,j] = arr[i,a];
                    arr[i,a]= temp;
                }
            }

        }
    }
    return arr;
}