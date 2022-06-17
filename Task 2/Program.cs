/*  Задача 2: Напишите программу, которая принимает на 
вход координаты двух точек и находит расстояние между 
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Write("Введите координату x точки A: ");
string i_xa = Console.ReadLine();
int xa = int.Parse(i_xa);
Console.Write("Введите координату y точки A: ");
string i_ya = Console.ReadLine();
int ya = int.Parse(i_ya);
Console.Write("Введите координату z точки A: ");
string i_za = Console.ReadLine();
int za = int.Parse(i_za);
Console.Write("Введите координату x точки B: ");
string i_xb = Console.ReadLine();
int xb = int.Parse(i_xb);
Console.Write("Введите координату y точки B: ");
string i_yb = Console.ReadLine();
int yb = int.Parse(i_yb);
Console.Write("Введите координату z точки B: ");
string i_zb = Console.ReadLine();
int zb = int.Parse(i_zb);

double D = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
Console.Write($"Расстояние между точками A({xa},{ya},{za}) и B({xb},{yb},{zb}) равно {D}");