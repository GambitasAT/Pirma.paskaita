namespace Antra.Paskaita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Paskaita 02");
            Console.WriteLine();

            string firstLine = "vienas";
            string secondLine = "du";
            firstLine = firstLine + " " + secondLine;
            Console.WriteLine(firstLine);
            secondLine += firstLine;
            Console.WriteLine(secondLine);     //awoiding due string name conflicts
            Console.WriteLine();
            string city = "Vilnius";           // string priskyrimas
            int wordLenght = "Vilnius".Length; // priskiriame tikrinti žodžio ilgį
            int wordLenght2 = city.Length;     // priskiriame tikrinti 'string' žodžio ilgį
                                               // pastaba prisiminti skaičiavimas vyksta nuo 0 o ne nuo 1

            string emptyStringExample = "";
            string emptyStringExample2 = string.Empty;
            string emptyStringExample3;        // tik tokiu atveju jis nėra tuščias, greičiau atlieka kaip 'null' reikšmę.









            Console.WriteLine();
            Console.WriteLine(@"Užduotis 01");
            Console.WriteLine();


        }
    }
}
