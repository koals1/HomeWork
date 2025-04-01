using System;

class GeometryUtils
{
    public static void ShowTime()
    {
        Console.WriteLine("Текущее время: " + DateTime.Now.ToString("HH:mm:ss"));
    }

    public static void ShowDate()
    {
        Console.WriteLine("Текущая дата: " + DateTime.Now.ToString("dd.MM.yyyy"));
    }

    public static void ShowDayOfWeek()
    {
        Console.WriteLine("День недели: " + DateTime.Now.DayOfWeek);
    }

    public static double TriangleArea(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return area;
    }

    public static double RectangleArea(double width, double height)
    {
        double area = width * height;
        return area;
    }
}

class Program
{
    static void Main()
    {
        Action showTime = GeometryUtils.ShowTime;
        Action showDate = GeometryUtils.ShowDate;
        Action showDayOfWeek = GeometryUtils.ShowDayOfWeek;

        Func<double, double, double, double> triangleArea = GeometryUtils.TriangleArea;
        Func<double, double, double> rectangleArea = GeometryUtils.RectangleArea;

        showTime();
        showDate();
        showDayOfWeek();

        double triangle = triangleArea(3, 4, 5);
        Console.WriteLine("Площадь треугольника (3, 4, 5): " + triangle);

        double rectangle = rectangleArea(5, 10);
        Console.WriteLine("Площадь прямоугольника (5, 10): " + rectangle);
    }
}
