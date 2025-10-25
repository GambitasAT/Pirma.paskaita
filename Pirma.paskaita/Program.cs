using System.Drawing;

namespace Pirma.paskaita
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Paskaita 01");
            Console.WriteLine();

            Console.WriteLine("Labas, pasauli");
            Console.WriteLine("kiek");
            int Vienas = 1;
            string Zodis = "zodis";

            Console.WriteLine(Vienas + " " + Zodis);
            Console.WriteLine();
            Console.WriteLine("užduotis 01");
            Console.WriteLine();
            Console.WriteLine(@"   /\   ");
            Console.WriteLine(@"  /  \  ");
            Console.WriteLine(@" /    \ ");
            Console.WriteLine(@"/______\");
            Console.WriteLine();
            Console.WriteLine("užduotis 02");
            Console.WriteLine();
            Console.WriteLine(@"     *****     ");
            Console.WriteLine(@"   **     **   ");
            Console.WriteLine(@" **         ** ");
            Console.WriteLine(@"**   Hello   **");
            Console.WriteLine(@"**    from   **");
            Console.WriteLine(@" **   C#    ** ");
            Console.WriteLine(@"   **     **   ");
            Console.WriteLine(@"     *****     ");
            Console.WriteLine();
            Console.WriteLine("užduotis 03");
            Console.WriteLine();
            Console.WriteLine(@"   /\   ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"  /  \  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@" /    \ ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"/______\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("užduotis 04");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"  / \     / \  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@" /   \   /   \ ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@" \    \ /    / ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"  \         /  ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"   \       /   ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"    \     /    ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"     \   /     ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"      \ /      ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"       V       ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("užduotis 05");
            Console.WriteLine();
            string preke = "Obuolys";
            int kiekis = 5;
            int kaina = 2;
            Console.WriteLine("Prekė : " + preke);
            Console.WriteLine("Kiekis: " + kiekis);
            Console.WriteLine("Kaine : " + kaina + " eur");
            Console.WriteLine();
            Console.WriteLine("užduotis 06");
            Console.WriteLine();
            string vardas = "Vardenis";
            string pavarde = "Pavardenis";
            int amzius = 28;
            string pareigos = "Software Developer";
            string eMail = "vardenis.pavardenis@example.com";
            string tel = "+1 123-456-7890";
            Console.WriteLine(@"================ Vizitinė ================");
            Console.WriteLine("Vardas   : " + vardas + " " + pavarde);
            Console.WriteLine("Amžius   : " + amzius);
            Console.WriteLine("Pareigos : " + pareigos);
            Console.WriteLine("E. Paštas: " + eMail);
            Console.WriteLine("Tel.     : " + tel);
            Console.WriteLine(@"==========================================");

        }
    }
}
