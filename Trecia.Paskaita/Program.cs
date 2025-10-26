using System.ComponentModel.Design;
using System.Xml;

namespace Trecia.Paskaita
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Užduotis 01\n");
            Console.WriteLine("Įveskite skaičių: ");
            int ivestisSk = Convert.ToInt32(Console.ReadLine());
            
            if (ivestisSk > 100)
            {
                Console.WriteLine("Skaičius " + ivestisSk + " yra didesnis nei 100");
            }
            else if (ivestisSk < 100)
            {
                Console.WriteLine("Skaičius " + ivestisSk + " yra mažesnis nei 100");
            }
            else
            {
                Console.WriteLine("Skaičius yra lygus 100");
            }
            Console.WriteLine("\nUžduotis 01-2\n");

            Console.WriteLine("Įveskite dienos numerį: ");
            int ivestisDn = Convert.ToInt32(Console.ReadLine());

            if (ivestisDn == 1) { Console.WriteLine("Pirmadienis"); }
            else if (ivestisDn == 2) { Console.WriteLine("Antradienis"); }
            else if (ivestisDn == 3) { Console.WriteLine("Trečiadienis"); }
            else if (ivestisDn == 4) { Console.WriteLine("Ketvirtadienis"); }
            else if (ivestisDn == 5) { Console.WriteLine("Penktadienis"); }
            else if (ivestisDn == 6) { Console.WriteLine("Šeštadienis"); }
            else if (ivestisDn == 7) { Console.WriteLine("Sekmadienis"); }
            else { Console.WriteLine("Įvedėte klaidingą numerį"); }

            Console.WriteLine("\nUžduotis 02\n");







        }
    }
}
