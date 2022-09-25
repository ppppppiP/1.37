Console.Write("Введите первый и второй катеты");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = Math.Sqrt((a*a)+(b*b));
Console.WriteLine("Периметр треугольника равен: {0}", c);// задание 1.37, найти периметр треугольника по его катетам

