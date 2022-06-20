/*  Задача 2: Напишите программу, которая принимает на 
вход координаты двух точек и находит расстояние между 
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координаты x, y, z точки A (ввод - клавиша Enter): ");
int i = 0;
int[] arrA = new int[3];
int[] arrB = new int[3];
for (i = 0; i < 3; i++)
{
    string i_a = Console.ReadLine();
    int xa = int.Parse(i_a);
    arrA[i] = xa;

}

Console.WriteLine("Введите координаты x, y, z точки B (ввод - клавиша Enter): ");
for (i = 0; i < 3; i++)
{
    string i_b = Console.ReadLine();
    int xb = int.Parse(i_b);
    arrB[i] = xb;

}

double D = Math.Sqrt((arrB[0] - arrA[0]) * (arrB[0] - arrA[0]) + (arrB[1] - arrA[1]) * (arrB[1] - arrA[1]) + (arrB[2] - arrA[2])*(arrB[2] - arrA[2]));
Console.Write($"Расстояние между точками A и B равно {D}");