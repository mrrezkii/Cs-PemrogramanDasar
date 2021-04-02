using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UH01_25_XRPL5
{
    class Program
    {
        static void Main(string[] args)
        {
            double panjang, luas, jari, d1, d2, lebar;
            string pilihan;

            Console.WriteLine("A untuk luas persengi panjang");
            Console.WriteLine("B untuk luas lingkaran");
            Console.WriteLine("C untuk luas belah ketupat");
            Console.WriteLine("Masukkan pilihan anda :");
            pilihan = Console.ReadLine();

            if (pilihan == "A" || pilihan == "a")
            {
                Console.Write("Masukkan panjang : ");
                panjang = double.Parse(Console.ReadLine());
                Console.Write("Masukkan lebar :");
                lebar = double.Parse(Console.ReadLine());

                luas = panjang * lebar;
                Console.Write(luas);
            }
            else if (pilihan == "B" || pilihan == "b")
            {
       
                Console.Write("Masukkan jari :");
                jari = double.Parse(Console.ReadLine());

                luas = 22 * jari * jari / 7;
                Console.Write(luas);
            }
            else if (pilihan == "C" || pilihan == "c") 
            {
                Console.Write("Masukkan d1 : ");
                d1 = double.Parse(Console.ReadLine());
                Console.Write("Masukkan d2 :");
                d2 = double.Parse(Console.ReadLine());

                luas = d1 * d2 / 2;
                Console.Write(luas);
            }
            else
            {
                Console.Write("Pastikan jawaban anda benar"); }


            Console.ReadKey();

        }
    }
}

