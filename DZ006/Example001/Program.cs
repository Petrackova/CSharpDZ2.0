// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// c клавиатуры все числа
Console.WriteLine("Введите c клавиатуры числа через пробел");
string text = Console.ReadLine();
string[] number= text.Split(' ');
Console.WriteLine($" Чисел больше ноля:= {FindNumber(number)}");

int FindNumber (string[] arr)
{
    int kolvo = 0;
    int[] intarr= Array.ConvertAll(arr, int.Parse);
    for ( int i= 0; i < arr.Length; i++)
    {
        if ( intarr[i] > 0)
        {
            kolvo = kolvo+1;
        }
    }
    return kolvo;
}