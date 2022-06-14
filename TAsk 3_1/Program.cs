/*  Задача 3: Напишите программу, которая принимает на вход
 число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27. 
5 -> 1, 8, 27, 64, 125
 */

Console.Write("Введите число N: ");
string string_N = Console.ReadLine();
int num_N = int.Parse(string_N);
int i = 1;

int GetCube(int j)
{
    int rezult = j * j * j;
    Console.Write($"{rezult} | ");
    return i;
}

Console.WriteLine($"Таблица кубов чисел от 1 до {num_N}:");
while (i <= num_N)
{
    GetCube(i);
    i++;
}