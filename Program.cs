using System;

public class PemrosesData
{
    public T DapatkanNilaiTerbesar<T>(T a, T b, T c)
    {
        dynamic temp1 = a;
        dynamic temp2 = b;
        dynamic temp3 = c;

        dynamic max = a;
        if (temp2 > max)
        {
            max = temp2;
        } 
        if (temp3 > max)
        {
            max = temp3;
        }

        return max;
    }
}

class Program
{
    private static void Main(string[] args)
    {
        PemrosesData nim = new PemrosesData();
        int terbesar = nim.DapatkanNilaiTerbesar(10, 30, 22);
        Console.WriteLine("Nilai terbesar: " + terbesar);
    }
}