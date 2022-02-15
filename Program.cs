using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz Dönüşüm)
            //Bir değişkenin kendinden daha yüksek kapasiteli bir değişkene atanması

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;

            // Explicit Conversion (Bilinçli Dönüşüm)
            // parse, convert, toString
            int x = 4;
            byte y = (byte)x;

            int xx = 6;
            string yy= xx.ToString();
            
        }
    }
}
