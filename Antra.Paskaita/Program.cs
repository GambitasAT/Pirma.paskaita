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

            char[] lettersMasyvas = {'ž','o','d','i','s'};
            string masyvas = new string(lettersMasyvas);
            Console.WriteLine(lettersMasyvas);
            Console.WriteLine(masyvas);        // nors atspausdina vienodai, bet veikia skirtingai 'masyvas' yra string, o 'lettersMasyvas' yra char[]

            string word1 = "mama";
            string word2 = word1.Replace('m', 'p');
            Console.WriteLine(word1); // mama
            Console.WriteLine(word2); // papa

            Console.WriteLine(word1.Length);

            string word3 = "1234567890"; 
            Console.WriteLine(word3.Length); //word3 turi 10 charų (simboliu)

            Console.WriteLine();
            Console.WriteLine(@"Užduotis 01");
            Console.WriteLine();
            string kintamasis = "samana";
            string keitimas = kintamasis.Replace('a', 'o');
            Console.WriteLine(kintamasis + " " + keitimas);
            Console.WriteLine(keitimas.Length);
            char[] kintamasis2 = {'s','a','m','a','n','a' };
            Console.WriteLine(kintamasis2[3]);
            Console.WriteLine(kintamasis[1]);
            Console.WriteLine(kintamasis.Length + " " + kintamasis2.Length);
            Console.WriteLine();
            Console.WriteLine(@"Užduotis 02");
            Console.WriteLine();
            string subString = "Mano vardas ...";
            Console.WriteLine(subString);
            string subs = subString.Substring(5);
            Console.WriteLine(subs);
            string subs2 = subString.Substring(0,4);
            Console.WriteLine(subs2);
            Console.WriteLine();
            Console.WriteLine(@"Užduotis 03");
            Console.WriteLine();



        }
    }
}
