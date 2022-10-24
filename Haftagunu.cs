using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_HaftaGunu
{
    public class Haftagunu
    {
        private static int deger; // değişkene static tanımı uygulandı //

        public Haftagunu()
        {
            Console.WriteLine("Uygulamamıza Hoşgeldiniz....");

        }
        public static void GunBelirle()   // metoda static tanımı uygulandı //
        {
            Console.Write("Hesabı haftanın kaçıncı gününden yapmak istiyorsunuz : ");
            deger = Convert.ToInt16(Console.ReadLine());

            switch (deger)
            {
                case 1: Console.WriteLine("Hesap Günü : Pazartesi"); break;
                case 2: Console.WriteLine("Hesap Günü : Salı"); break;
                case 3: Console.WriteLine("Hesap Günü : Çarşamba"); break;
                case 4: Console.WriteLine("Hesap Günü : Perşembe"); break;
                case 5: Console.WriteLine("Hesap Günü : Cuma"); break;
                case 6: Console.WriteLine("Hesap Günü : Cumartesi"); break;
                case 7: Console.WriteLine("Hesap Günü : Pazar"); break;
                default: Console.WriteLine("Girilen değeri kontrol ediniz!"); break;

            }

        }
        public static int GetGun()
        {
            return deger;

        }
    }
}
