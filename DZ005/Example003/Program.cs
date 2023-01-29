//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] ar = Arr(10);
PrintArr(ar);
Console.WriteLine();
Console.WriteLine($"Максимальное число в массиве:= {FindMaxNumber(ar)}");
Console.WriteLine();
Console.WriteLine($"Минимальное число в массиве:= {FindMinNumber(ar)}");
Console.WriteLine();
Finddifference(FindMaxNumber(ar),FindMinNumber(ar));

double[] Arr(int lenght)
{
    double [] result = new double [lenght];
    for ( int i = 0; i < lenght; i++) 
    {
        result[i] = new Random().NextDouble()*10;
        result[i] = Math.Round(result[i],1);
    }
    return result;
}

double FindMaxNumber (double[] arr)
{
    double max = arr[0];
    for ( int i = 0; i < arr.Length; i++)
    {
        if ( max < arr[i])
        {
            max = arr[i];
        }
    }
    return max;
}

double FindMinNumber (double[] arr)
{
    double min = arr[0];
    for ( int i = 0; i < arr.Length; i++)
    {
        if ( min > arr[i])
        {
            min = arr[i];
        }
    }
    return min;
}

double Finddifference(double arg1, double arg2)
{
    double dif = arg1 - arg2;
    dif = Math.Round(dif,2);
    Console.WriteLine($"Разность максимального и минимального элемента массива:= {dif}");
    return dif;
}

void PrintArr(double[] arr)
{
    foreach(double item in arr)
    {
        System.Console.Write(item + " ");
    }
    Console.WriteLine();
}