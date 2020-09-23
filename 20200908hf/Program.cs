using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200908hf
{
    class Program
    {
        static void Main(string[] args)
        {
            ////5
            Console.WriteLine("add meg a téglalap a oldalát");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("add meg a téglalap b oldalát");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"téglalap kerülete: { 2 * (a + b) } cm ");
            Console.WriteLine($"téglalap területe: { (a * b) } m^2");




            //6


            Console.WriteLine("Add meg a kör sugarát");
            int sugar = int.Parse(Console.ReadLine());
            double pi = Math.PI;

            Console.WriteLine($" a kör kerülete: {2 * sugar * pi}");
            Console.WriteLine($" a kör területe: {sugar * sugar * pi}");


            //7

            double  befogo;
            double  masodikbefogo;
            double  c;


            Console.WriteLine("Kérem az első befogó hosszát");
            befogo = int.Parse(Console.ReadLine());

            Console.WriteLine("Kérem a második befogó hosszát");
            masodikbefogo = int.Parse(Console.ReadLine());

            c = Math.Sqrt(a * a + b * b);

            Console.WriteLine("Az átfogó hossza: {0}", c);


            //8

            double megtettut, elteltido;

            Console.WriteLine("Add meg a megtett út hosszát");

            megtettut = double.Parse(Console.ReadLine());

            Console.WriteLine("Add meg az eltelt idő hosszát");

            elteltido = double.Parse(Console.ReadLine());

            Console.WriteLine($"az átlag sebesség: {megtettut / elteltido} km/h");




            //9(nincs megoldásom)


            Console.ReadKey();
        }
    }
}
