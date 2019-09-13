using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            BRuang obj = new BRuang();
            int p, l, t;
            Console.WriteLine("Panjang : ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lebar : ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tinggi : ");
            t = Convert.ToInt32(Console.ReadLine());
            obj.volume_balok(p, l, t);

            Console.WriteLine("");
            Console.WriteLine("Menghitung Volume Kubus");
            Console.WriteLine("");
            
            int s1;
            Console.Write("Sisi : ");
            s1 = Convert.ToInt32(Console.ReadLine());
            obj.volume_kubus(s1);


            BDatar objct = new BDatar();
            int s;
            Console.WriteLine("Sisi : ");
            s = Convert.ToInt32(Console.ReadLine());
            objct.luas_persegi(s);

            int t1,a;
            Console.WriteLine("Tinggi : ");
            t1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Alas : ");
            a = Convert.ToInt32(Console.ReadLine());
            objct.luas_segitiga(t1, a);

            int r;
            Console.WriteLine("Jari-Jari : ");
            r = Convert.ToInt32(Console.ReadLine());
            objct.luas_lingkaran(r);
        }
    }
}
              

      