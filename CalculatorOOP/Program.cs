using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Pertambahan a1 = new Pertambahan(1, 2);
            Console.WriteLine("Hasil Pertambahan adalah : " + a1.Proccess());
            a1.Display();
            //encapsulation
            Pengurangan p1 = new Pengurangan(10,5);
            Console.WriteLine("Hasil Pengurangan adalah : " + p1.Proccess());

            //Inheritance
            Perkalian p2 = new Perkalian();
            p2.angka1 = 4;
            p2.angka2 = 6;
            Console.WriteLine("Hasil Perkalian adalah : " + p2.Kali(p2.angka1, p2.angka2));

            //Inheritance & Constructor
            Pembagian p3 = new Pembagian(8,9);
            p3.angka1 = 5;
            p3.angka2 = 6;

            //polymorphism
            Console.WriteLine("Hasil Pembagian kedua angka adalah : " + p3.Bagi(p3.angka1, p3.angka2));

            //overloading
            Console.WriteLine("Hasil Pembagian ketiga angka  adalah : "+ p3.Kali(p2.angka1, p2.angka2, p2.angka2));

            a1.Display();
            Console.Read();

        }
    }


    abstract class DemoAbstract
    {
        public void Display()
        {
            Console.WriteLine("Perhitungan Selesai");
        }
        public abstract int Proccess();
    }
    class Pertambahan : DemoAbstract
        {
            public Pertambahan(int a, int b)
            {
                A = a;
                B = b;
            }

            public int A { get; private set; }
            public int B { get; private set; }

            public override int Proccess()
            {
                return A + B;
            }
        }
    //Encapsulation
    class Pengurangan : DemoAbstract
    {
        public int Angka1 { get; private set; }
        public int Angka2 { get; private set; }
        public Pengurangan(int angka1, int angka2)
        {
            Angka1 = angka1;
            Angka2 = angka2;
        }
        public override int Proccess()
        {
            return Angka1 - Angka2;
        }
        
    }

    class Angka
    {
        public int angka1;
        public int angka2;
    }

    //Inheritance
    interface Operasi
    {
        int Kali(int angka1, int angka2);
    }
    class Perkalian : Angka, Operasi
    {
        public int Kali(int angka1,int angka2)
        {
            return angka1 * angka2;
        }
        public virtual int Kali(int angka1, int angka2, int angka3)
        {
            return angka1 * angka2* angka3;
        }

    }
    class Pembagian : Perkalian
    {
        public int Satu;
        public int Dua;
        public Pembagian(int satu, int dua)
        {
            Satu = satu;
            Dua = dua;
        }
        //Overriding then Overloading
        public override int Kali(int angka1, int angka2, int angka3)
        {
            return angka1 / angka2 / angka3;
        }
        public int Bagi(int angka1, int angka2)
        {
            return angka1/angka2;
        }
    }

   
}