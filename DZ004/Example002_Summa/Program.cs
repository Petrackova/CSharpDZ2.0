//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int a1 = new Random().Next(1,100);
Console.WriteLine($"Число:= {a1}");
Console.WriteLine($"Сумма цифр:= {FindSumm(a1)}");

int FindSumm (int arg1)
{
    int num = 0;
    int result = 0;
        while (arg1 > 0)
        {
        result = arg1 % 10;
        num = result + num;
        arg1 = arg1 / 10;
        }
        
    return num;
}
