using System;

namespace Quiz
{
    class BRuang
    {
        public void volume_balok(int panjang, int lebar, int tinggi)
        {
            Console.WriteLine("volume Balok : "+panjang*lebar*tinggi);
        }

        public void volume_kubus(int sisi)
        {
            Console.WriteLine("volume Kubus : "+sisi*sisi*sisi);
        }
    }
}
        