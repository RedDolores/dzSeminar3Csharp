// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите x точки A: ");
double Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y точки A: ");
double Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z точки A: ");
double Az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x точки B: ");
double Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y точки B: ");
double By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z точки B: ");
double Bz = Convert.ToInt32(Console.ReadLine());


double dis = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));

Console.WriteLine($"Расстояние между точками: {dis:f3}");