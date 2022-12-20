// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
//            и находит расстояние между ними в 3D пространстве.
//             A (3,6,8); B (2,1,-7), -> 15.84
//             A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Вычисление расстояния между двумя тосками в 3D пространстве");
Console.Write("Введите X точки A: ");
int xA = int.Parse(Console.ReadLine());
Console.Write("Введите Y точки A: ");
int yA = int.Parse(Console.ReadLine());
Console.Write("Введите Z точки A: ");
int zA = int.Parse(Console.ReadLine());
Console.Write("Введите X точки B: ");
int xB = int.Parse(Console.ReadLine());
Console.Write("Введите Y точки B: ");
int yB = int.Parse(Console.ReadLine());
Console.Write("Введите Z точки B: ");
int zB = int.Parse(Console.ReadLine());

double distAB = Math.Sqrt(Math.Pow((xB-xA),2) + Math.Pow((yB-yA),2) + Math.Pow((zB-zA),2));
System.Console.WriteLine($"Расстояние между точками: {Math.Round(distAB, 2)}");