// Задача 43. Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double Numbers(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());

}

double k1 = Numbers("Введите число k1: ");
double b1 = Numbers("Введите число b1: ");
double k2 = Numbers("Введите число k2: ");
double b2 = Numbers("Введите число b2: ");


void Coordinate(double a, double b, double c, double d)

{
    if (a == c && b == d)
    {
        System.Console.WriteLine("Прямые совпадают.");
    }
    else if (a == c)
    {
        System.Console.WriteLine("Прямые параллельны.");
    }
    else
    {
        double x = (d - b) / (a - c);
        double y = a * x + b;
        System.Console.WriteLine($"Точка пересечения прямых: ({x}, {y})");
    }
}
Coordinate(k1, b1, k2, b2);