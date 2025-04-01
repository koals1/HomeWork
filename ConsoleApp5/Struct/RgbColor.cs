using System;

struct RgbColor
{
    private byte r, g, b;

    public RgbColor(byte r, byte g, byte b)
    {
        this.r = r;
        this.g = g;
        this.b = b;
    }

    public string ToHex()
    {
        string hex = "#" + IntToHex(r) + IntToHex(g) + IntToHex(b);
        return hex;
    }

    private string IntToHex(int value)
    {
        char[] hexChars = "0123456789ABCDEF".ToCharArray();
        char[] hex = new char[] { hexChars[value / 16], hexChars[value % 16] };
        string hexString = new string(hex);
        return hexString;
    }

    public (double, double, double) ToHsl()
    {
        double rNorm = r / 255.0;
        double gNorm = g / 255.0;
        double bNorm = b / 255.0;

        double max = Math.Max(rNorm, Math.Max(gNorm, bNorm));
        double min = Math.Min(rNorm, Math.Min(gNorm, bNorm));
        double delta = max - min;

        double h = 0, s = 0, l = (max + min) / 2.0;

        if (delta > 0)
        {
            if (l > 0.5)
            {
                s = delta / (2.0 - max - min);
            }
            else
            {
                s = delta / (max + min);
            }

            if (max == rNorm)
            {
                h = (gNorm - bNorm) / delta;
                if (gNorm < bNorm)
                {
                    h += 6;
                }
            }
            else if (max == gNorm)
            {
                h = (bNorm - rNorm) / delta + 2;
            }
            else
            {
                h = (rNorm - gNorm) / delta + 4;
            }

            h *= 60;
        }

        return (h, s * 100, l * 100);
    }

    public (double, double, double, double) ToCmyk()
    {
        double rNorm = r / 255.0;
        double gNorm = g / 255.0;
        double bNorm = b / 255.0;

        double k = 1 - Math.Max(rNorm, Math.Max(gNorm, bNorm));
        double c = 0, m = 0, y = 0;

        if (k < 1)
        {
            c = (1 - rNorm - k) / (1 - k);
            m = (1 - gNorm - k) / (1 - k);
            y = (1 - bNorm - k) / (1 - k);
        }

        return (c * 100, m * 100, y * 100, k * 100);
    }

    public override string ToString()
    {
        string result = "RGB(" + r + ", " + g + ", " + b + ")";
        return result;
    }
}

class Program
{
    static void Main()
    {
        RgbColor color = new RgbColor(255, 0, 0);

        string hex = color.ToHex();
        Console.WriteLine(hex);

        var hsl = color.ToHsl();
        Console.WriteLine("HSL(" + hsl.Item1.ToString("F1") + ", " + hsl.Item2.ToString("F1") + "%, " + hsl.Item3.ToString("F1") + "%)");

        var cmyk = color.ToCmyk();
        Console.WriteLine("CMYK(" + cmyk.Item1.ToString("F1") + "%, " + cmyk.Item2.ToString("F1") + "%, " + cmyk.Item3.ToString("F1") + "%, " + cmyk.Item4.ToString("F1") + "%)");
    }
}
