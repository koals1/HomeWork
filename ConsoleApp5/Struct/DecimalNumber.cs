using System;

struct DecimalNumber
{
    private int value;

    public DecimalNumber(int value)
    {
        this.value = value;
    }

    public string ToBinary()
    {
        return Convert.ToString(value, 2);
    }

    public string ToOctal()
    {
        return Convert.ToString(value, 8);
    }

    public string ToHexadecimal()
    {
        return Convert.ToString(value, 16).ToUpper();
    }

    public override string ToString()
    {
        return value.ToString();
    }
}

class Program
{
    static void Main()
    {
        DecimalNumber num = new DecimalNumber(255);

        Console.WriteLine(num.ToBinary());
        Console.WriteLine(num.ToOctal());
        Console.WriteLine(num.ToHexadecimal());
    }
}
