//using System;
//using System.Collections.Generic;

//interface ICalc
//{
//    int Less(int valueToCompare);
//    int Greater(int valueToCompare);
//}

//interface IOutput2
//{
//    void ShowEven();
//    void ShowOdd();
//}

//interface ICalc2
//{
//    int CountDistinct();  
//    int EqualToValue(int valueToCompare); 
//}

//class Array : ICalc, IOutput2, ICalc2
//{
//    private int[] elements;

//    public Array(int[] elements)
//    {
//        this.elements = elements;
//    }

//    public int Less(int valueToCompare)
//    {
//        int count = 0;
//        foreach (int num in elements)
//        {
//            if (num < valueToCompare)
//                count++;
//        }
//        return count;
//    }

//    public int Greater(int valueToCompare)
//    {
//        int count = 0;
//        foreach (int num in elements)
//        {
//            if (num > valueToCompare)
//                count++;
//        }
//        return count;
//    }

//    public void ShowEven()
//    {
//        Console.Write("Четные числа: ");
//        bool found = false;
//        foreach (int num in elements)
//        {
//            if (num % 2 == 0)
//            {
//                Console.Write(num + " ");
//                found = true;
//            }
//        }
//        if (!found) Console.Write("отсутствуют");
//        Console.WriteLine();
//    }

//    public void ShowOdd()
//    {
//        Console.Write("Нечетные числа: ");
//        bool found = false;
//        foreach (int num in elements)
//        {
//            if (num % 2 != 0)
//            {
//                Console.Write(num + " ");
//                found = true;
//            }
//        }
//        if (!found) Console.Write("отсутствуют");
//        Console.WriteLine();
//    }

//    public int CountDistinct()
//    {
//        HashSet<int> uniqueNumbers = new HashSet<int>(elements);
//        return uniqueNumbers.Count;
//    }

//    public int EqualToValue(int valueToCompare)
//    {
//        int count = 0;
//        foreach (int num in elements)
//        {
//            if (num == valueToCompare)
//                count++;
//        }
//        return count;
//    }

//    public void ShowArray()
//    {
//        Console.Write("Массив: ");
//        for (int i = 0; i < elements.Length; i++)
//        {
//            Console.Write(elements[i]);
//            if (i < elements.Length - 1)
//                Console.Write(", ");
//        }
//        Console.WriteLine();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] data = { 3, 7, 2, 9, 4, 6, 1, 3, 2, 4, 9 };
//        Array myArray = new Array(data);

//        myArray.ShowArray();
//        myArray.ShowEven();
//        myArray.ShowOdd();

//        int compareValue = 5;
//        Console.WriteLine($"Количество элементов меньше {compareValue}: {myArray.Less(compareValue)}");
//        Console.WriteLine($"Количество элементов больше {compareValue}: {myArray.Greater(compareValue)}");

//        Console.WriteLine($"Количество уникальных значений в массиве: {myArray.CountDistinct()}");

//        int valueToFind = 3;
//        Console.WriteLine($"Количество элементов, равных {valueToFind}: {myArray.EqualToValue(valueToFind)}");
//    }
//}
