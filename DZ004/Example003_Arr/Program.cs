//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] ar = FindArr(8);
PrintArr(ar);

int[] FindArr(int lenght)
{
    int [] result = new int [lenght];
    for ( int i = 0; i < lenght; i++) 
    {
        result[i] = new Random().Next(0,100);
    }
    return result;
}

void PrintArr(int[] arr)
{
    foreach(int item in arr)
    {
        Console.Write(item + " ");
    }
}