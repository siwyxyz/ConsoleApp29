using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        class samochod
        {
            public string marka;
            public string kolor;
            public int cena;
            public int data;

            public samochod(string marka, int cena)
            {
                this.marka = marka;
                this.cena = cena;
            }
            public samochod(string kolor, string marka, int cena, int data)
            {
                this.kolor = kolor;
                this.marka = marka;
                this.cena = cena;
                this.data = data;
            }
            
            

            



        }
    }
}
