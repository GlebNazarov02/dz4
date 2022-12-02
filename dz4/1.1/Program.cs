void Step(double a, double b)
{
    double c = a;
    if (b > 0)
    {
        for(int i = 1;i < b;i++)
        {
            a = a * c;
        }
        Console.WriteLine($"{a}");
    }
    else if (b < 0)
    {
        for(int i = 1;i <= (Math.Abs(b) + 1);i++)
        {
            a = a / c;
        }
        Console.WriteLine($"{a}");
    }
    else
    {
         Console.WriteLine("1");
    }
}
Console.WriteLine("Число");
double d = double.Parse(Console.ReadLine());
Console.WriteLine("Степень");
double f = double.Parse(Console.ReadLine());
Step(d,f);