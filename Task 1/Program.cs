/*  Задача 1: Напишите программу, которая принимает 
на вход пятизначное число и проверяет, является ли оно 
палиндромом.
14212 -> нет
23432 -> да
12821 -> да
 */
Console.Write("Введите пятизначное число: ");
string istring = Console.ReadLine();
int inum = int.Parse(istring);
int lenght = istring.Length;
if (lenght != 5)
{
    Console.Write($"Внимание! {inum} - {lenght}-значное число!");
}
else
{
    int[] arr = new int[lenght];
    int index = lenght - 1;
    while (index > 0 || index == 0)
    {
        arr[index] = inum % 10;
        inum = inum / 10;
        index = index - 1;
    }
    if (arr[0] == arr[4] && arr[1] == arr[3])
    {
        Console.WriteLine($"{istring} - палиндром");
    }
    else
    {
        Console.WriteLine($"{istring} - не палиндром");
    }
}
