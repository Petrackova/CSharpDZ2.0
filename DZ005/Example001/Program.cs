//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] ar = Arr(10);
Console.WriteLine("Массив:");
PrintArr(ar);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве:= {FindNumber(ar)}");

int[] Arr(int lenght)
{
    int [] result = new int [lenght];
    for ( int i = 0; i < lenght; i++) 
    {
        result[i] = new Random().Next(100,1000);
    }
    return result;
}

int FindNumber (int[] arr)
{
    int kolvo = 0;
    for ( int i = 0; i < arr.Length; i++)
    {
        if ( (arr[i] % 2) == 0)
        {
            kolvo = kolvo+1;
        }
    }
    return kolvo;
}

void PrintArr(int[] arr)
{
    foreach(int item in arr)
    {
        Console.Write(item + " ");
    }
}