Console.Write("Введите координату X точки А: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
int zB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Расстояние между точками A и B = {Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA))}");
