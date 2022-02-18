using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //atama ve işlemli atama
            int x = 2;
            int y = 3;
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            Console.WriteLine("**************");

            //mantıksal operatörler
            // ||,&&, |

            bool ısSuccess = true;
            bool ısCompleted = false;
            if (ısSuccess && ısCompleted)
                Console.WriteLine("Perfect");

            if (ısSuccess || ısCompleted)
                Console.WriteLine("Great");

            if (ısSuccess && !ısCompleted)
                Console.WriteLine("Fine");
            Console.WriteLine("**************");

            //İlişkisel Operatörler

            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            Console.WriteLine("**************");

            //Aritmetik Operatörler
            int sayi = 10;
            int sayi2 = 5;
            int sonuc1 = sayi / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi++;
            Console.WriteLine(sonuc1);

            // % mod alma

            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);

        }
    }
}
