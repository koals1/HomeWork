using System;
//struct Vector3
//{
//    public double X { get; }
//    public double Y { get; }
//    public double Z { get; }

//    public Vector3(double x, double y, double z)
//    {
//        X = x;
//        Y = y;
//        Z = z;
//    }

//    public static Vector3 operator *(Vector3 v, double scalar)
//    {
//        return new Vector3(v.X * scalar, v.Y * scalar, v.Z * scalar);
//    }

//    public static Vector3 operator +(Vector3 v1, Vector3 v2)
//    {
//        return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
//    }

//    public static Vector3 operator -(Vector3 v1, Vector3 v2)
//    {
//        return new Vector3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
//    }

//    public override string ToString()
//    {
//        return $"({X}, {Y}, {Z})";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Vector3 v1 = new Vector3(1, 2, 3);
//        Vector3 v2 = new Vector3(4, 5, 6);

//        Console.WriteLine(v1 * 2);
//        Console.WriteLine(v1 + v2);
//        Console.WriteLine(v1 - v2);
//    }
//}
