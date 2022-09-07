// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write ("Введите через запятую координаты точки x, y, z: ");
string[] numbers1 = Console.ReadLine(). Split(new char[]{ ',' });
int x1 = int.Parse(numbers1[0]);
int y1 = int.Parse(numbers1[1]);
int z1 = int.Parse(numbers1[2]);

Console.Write ("Введите через запятую координаты точки x, y, z: ");
string[] numbers2 = Console.ReadLine(). Split(new char[]{','});
int x2 = int.Parse(numbers2[0]);
int y2 = int.Parse(numbers2[1]);
int z2 = int.Parse(numbers2[2]);


double result = Math.Round(Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2), 2)),2);



Console.WriteLine($"Длина отрезка = {result}");

