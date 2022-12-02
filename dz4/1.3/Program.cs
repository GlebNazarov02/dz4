void Mass(string n)
{
    int l = n.Length;
    char[] mas = new char[l] ;
    Console.Write("[");
    for (int i = 0;i < l;i++)
    { 
        mas[i] = n[i];
        Console.Write($"{mas[i]}");
    }
    Console.Write("]");
}
Console.WriteLine("Массив");
string a = Console.ReadLine();
Mass(a);