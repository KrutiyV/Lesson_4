
int x = 7;
int y = 10;
int z = 12;

int sum;

static int MaxValue(int x, int y)
{
    return Math.Max(x, y);
}
Console.WriteLine(MaxValue(x, y));

static int MinValue(int x, int y)
{
    return Math.Min(x, y);
}
Console.WriteLine(MinValue(x, y));


static bool TrySumIfOdd(int x, int y, out int sum)
{
    sum = x + y;
    bool isTrue = (sum % 2 == 0);
    return isTrue;
}
Console.WriteLine(TrySumIfOdd(x, y, out sum));


static void Repeat(string w, int z)
{
    string result = "";
    for (int i = 0; i < z; i++)
    {
        result += w;
        Console.WriteLine(result);
    }
}
Repeat("Word", 3);


class Overload
{
    static int MaxValue(int x, int y)
    {
        return Math.Max(x, y);
    }

    static double MaxValue(double x, double y)
    {
        return Math.Max(x,y);
    }

    static int MinValue(int x, int y)
    {
        return Math.Min(x, y);
    }

    static double MinValue(double x, double y)
    {
        return Math.Min(x, y);
    }
}