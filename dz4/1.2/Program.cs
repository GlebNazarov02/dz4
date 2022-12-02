void Kolvo(string b)
{
    int sum = 0;
    int l = b.Length;
    int chisl = int.Parse(b);
    for (int i = 0; i < l; i++)
    {
        sum = sum + chisl%10;
        chisl = chisl / 10;
    }
    Console.WriteLine($"{sum}");
}
Console.WriteLine("Число");
string a = Console.ReadLine();
Kolvo(a);