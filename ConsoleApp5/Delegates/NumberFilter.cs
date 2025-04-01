using System;

delegate bool NumberFilter(int number);

class ArrayUtils
{
    public static int[] Filter(int[] array, NumberFilter filter)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (filter(array[i]))
            {
                count++;
            }
        }

        int[] result = new int[count];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (filter(array[i]))
            {
                result[index] = array[i];
                index++;
            }
        }

        return result;
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static bool IsOdd(int number)
    {
        return number % 2 != 0;
    }

    public static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static bool IsFibonacci(int number)
    {
        if (number < 0)
        {
            return false;
        }

        int a = 0, b = 1;

        while (a < number)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }

        return a == number;
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 8, 13, 21, 34, 55, 89, 144 };

        int[] evens = ArrayUtils.Filter(numbers, ArrayUtils.IsEven);
        int[] odds = ArrayUtils.Filter(numbers, ArrayUtils.IsOdd);
        int[] primes = ArrayUtils.Filter(numbers, ArrayUtils.IsPrime);
        int[] fibonacciNumbers = ArrayUtils.Filter(numbers, ArrayUtils.IsFibonacci);

        Console.WriteLine("Четные: " + string.Join(", ", evens));
        Console.WriteLine("Нечетные: " + string.Join(", ", odds));
        Console.WriteLine("Простые: " + string.Join(", ", primes));
        Console.WriteLine("Фибоначчи: " + string.Join(", ", fibonacciNumbers));
    }
}
