using System;

public class PemrosesData
{
    public T DapatkanNilaiTerbesar<T>(T a, T b, T c)
    {
        //menampung nilai sementara
        dynamic temp1 = a;
        dynamic temp2 = b;
        dynamic temp3 = c;

        dynamic max = a;
        //membandingkan nilai terbesar
        if (temp2 > max)
        {
            max = temp2;
        } 
        if (temp3 > max)
        {
            max = temp3;
        }
        //mengembalikan nilai
        return max;
    }
}

class Program
{
    private static void Main(string[] args)
    {
        PemrosesData nim = new PemrosesData();
        //memanggil method DapatkanNilaiTerbesar
        int terbesar = nim.DapatkanNilaiTerbesar(10, 30, 22);
        Console.WriteLine("Nilai terbesar: " + terbesar);
    }
}