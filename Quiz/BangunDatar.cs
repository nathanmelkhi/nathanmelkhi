using System;

namespace Quiz
{
    class BDatar
    {
        public void luas_persegi(int sisi)
        {
            Console.WriteLine("Luas Persegi : "+sisi*sisi);
        }
        public void luas_segitiga(int tinggi, int alas)
        {
            Console.WriteLine("Luas Segitiga : "+tinggi*alas/2);
        }
        public void luas_lingkaran(int jari)
        {
            Console.WriteLine("Luas Lingkaran : "+22/7*jari*jari);
        }
    }
}