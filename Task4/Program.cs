// Найти расстояние между точками в пространстве 2D/3D
Console.Clear();
Console.WriteLine("Введите координату x первой точки" ?? "0");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки" ?? "0");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки" ?? "0");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки" ?? "0");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки" ?? "0");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z третьей точки" ?? "0");
int z2 = int.Parse(Console.ReadLine());


double distanse = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));
Console.WriteLine($"Расстояние между точками с заданными координатами равно {distanse}");

//Для варианта с плоскостью вводим только координаты (x1, y1) и (x2, y2) и используем double distanse = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1))