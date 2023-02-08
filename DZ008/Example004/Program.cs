/*...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

System.Console.Write("Значение m:= ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Значение n:= ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Значение p:= ");
int p = Convert.ToInt32(Console.ReadLine());
int[,,] ar = FindArr(m, n, p);
System.Console.WriteLine();
PrintArr(ar);
FindNumber(ar);

int[,,] FindArr(int lenghti, int lenghtj, int lenghtz)
{
    int[,,] result = new int[lenghti, lenghtj, lenghtz];
    for (int i = 0; i < lenghti; i++)
    {
        for (int j = 0; j < lenghtj; j++)
        {
            for (int z = 0; z < lenghtz; z++)
            {
                result[i, j, z] = new Random().Next(10, 30);
            }
        }
    }
    return result;
}

void FindNumber(int[,,] arr)
{
    int[] result = new int[arr.GetLength(0) * arr.GetLength(1)*arr.GetLength(2)];
    int index = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                result[index] = arr[i, j, z];
                index++;
            }
        }  
    }
    Array.Sort(result);
    for (int k = 1; k < result.Length; k++)
    {
        if (result[k-1] == result[k])
        {
        System.Console.WriteLine($"Необходим новый массив. Повторяется число {result[k-1]}");
        Environment.Exit(0);
        }
    }
}

void PrintArr(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                System.Console.Write($"{arr[i, j, z]} [{i},{j},{z}] ");
            }
            System.Console.WriteLine("");
        }
        System.Console.Write("");
    }
}

