/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
int[,] ar = FindArrayij(4, 4);
Reversj(ar);
FindArrayi(ar);
Reversi(ar);
FindArrayj(ar);
Reversij(ar);
PrintArr(ar);


int[,] FindArrayij(int lenghti, int lenghtj)
{
    int n = 1;
    int[,] result = new int[lenghti, lenghtj];
    for (int i = 0; i < lenghti; i++)
    {
        for (int j = 0; j < lenghtj; j++)
        {
            if (i == 0)
            {
                result[i, j] = n++;
            }
            else if (j == (lenghtj - 1))
            {
                result[i, j] = n++;
            }
            else if (i == (lenghti - 1))
            {
                result[i, j] = n++;
            }
        }
    }
    return result;
}

int[,] Reversj(int[,] arr)
{
    int temp;
    for (int i = 3; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int a = j + 1; a < arr.GetLength(1); a++)
            {
                if (arr[i, j] < arr[i, a])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, a];
                    arr[i, a] = temp;
                }
            }

        }
    }
    return arr;
}

int[,] FindArrayi(int[,] arr)
{
    int n = 11;
    for (int i = 1; i < arr.GetLength(0)-1; i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            if (j == 0)
            {
               arr[i,j] = n++;
            }
        }
    }
    return arr;
}

int[,] Reversi(int[,] arr)
{
    int temp;
    for (int j = 0; j < 1; j++)
    {
        for (int i = 1; i < arr.GetLength(1)-1; i++)
        {
            for (int a = i + 1; a < arr.GetLength(1); a++)
            {
                if (arr[i, j] < arr[a, j])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[a, j];
                    arr[a, j] = temp;
                }
            }

        }
    }
    return arr;
}

int[,] FindArrayj(int[,] arr)
{
    int n = 13;
    for (int i = 1; i < arr.GetLength(0)-1; i++)
    {
        for (int j = 1; j < arr.GetLength(1)-1; j++)
        {
            if (i == 1)
            {
                arr[i, j] = n++;
            }
            else if (j == 2)
            {
                arr[i, j] = n++;
            }
            else if (i==2)
            {
                arr[i, j] = n++;
            }

        }
    }
    return arr;
}

int[,] Reversij(int[,] arr)
{
    int temp;
    for (int i = 2; i < arr.GetLength(1)-1; i++)
    {
        for (int j = 1; j < arr.GetLength(1)-1; j++)
        {
            for (int a = j + 1; a < arr.GetLength(1); a++)
            {
                if (arr[i, j] < arr[i, a])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, a];
                    arr[i, a] = temp;
                }
            }

        }
    }
    return arr;
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