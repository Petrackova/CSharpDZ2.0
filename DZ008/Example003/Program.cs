/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
System.Console.Write("Значение m:= ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Значение n:= ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] ar = FindArr(m, n);
PrintArr(ar);
System.Console.Write("Значение m1:= ");
int m1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Значение n1:= ");
int n1 = Convert.ToInt32(Console.ReadLine());
int[,] ar1 = FindArr(m1, n1);
PrintArr(ar1);
if (n == m1)
{
    System.Console.WriteLine("Матрицы согласованы. Продолжаем!");
    int[,] newarr = FindProz(ar, ar1);
    System.Console.WriteLine("Результат умножения");
    PrintArr(newarr);
}
else
{
    System.Console.WriteLine("Умножение невозможно. Матрицы не согласованы");
}

int[,] FindArr(int lenghti, int lenghtj)
{
    int[,] result = new int[lenghti, lenghtj];
    for (int i = 0; i < lenghti; i++)
    {
        for (int j = 0; j < lenghtj; j++)
        {
            result[i, j] = new Random().Next(0, 20);
        }
    }
    return result;
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] FindProz(int[,] arr, int[,] arr1)
{
    int[,] array = new int[arr.GetLength(0), arr1.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            int x = 0;
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                x = arr[i,k]* arr1[k,j];
                array[i, j] = array[i,j]+x;
            }
        }
    }
    return array;
}