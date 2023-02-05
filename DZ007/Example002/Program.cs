/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
System.Console.Write("Значение m:= ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Значение n:= ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] ar = FindArr(m,n);
System.Console.Write("Значение i1:= ");
int i1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Значение j1:= ");
int j1 = Convert.ToInt32(Console.ReadLine());
PrintArr(ar);
Indexof(ar,i1,j1);

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

void Indexof(int[,] arr, int  i1, int j1)
{   
    if ((i1 > arr.GetLength(0)) || (j1 > arr.GetLength(1)))
    {
        System.Console.WriteLine($"Элемент в массиве с интексами [{i1}, {j1}] не существует");
        Environment.Exit(0);
    }
    int x = arr[i1,j1];
    for ( int i = 0; i < arr.GetLength(0); i++) 
    {
        for ( int j = 0; j < arr.GetLength(1); j++) 
        {
            if(arr[i,j]==x)
            {
                Console.WriteLine($"Элемент в массиве с интексами [{i1}, {j1}]:= {arr[i1,j1]}");
                Environment.Exit(0);
            } 
        } 
    }
}