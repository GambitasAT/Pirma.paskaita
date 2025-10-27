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
            Console.WriteLine("Įveskite skaičių: ");
            int ivestisCk = Convert.ToInt32(Console.ReadLine());
            int reminder = ivestisCk % 2;
            int reminder2 = ivestisCk % 5;

            if (reminder == 0) { Console.WriteLine("Skaičius yra lyginis"); }
            else if (reminder2 == 0) { Console.WriteLine("Skaičius dalijasi iš penkių"); }
            else Console.WriteLine("Skaičius neatitinka jokių salygų");

            Console.WriteLine("\nUžduotis 02-2\n");

            Console.WriteLine("Įveskite temperatūros rodmenis: ");
            int ivestisTemp = Convert.ToInt32(Console.ReadLine());

            if (ivestisTemp >= -100 && ivestisTemp < 0) { Console.WriteLine("Šalta"); }
            else if (ivestisTemp >= 0 && ivestisTemp <= 20) { Console.WriteLine("Vėsu"); }
            else if (ivestisTemp > 20 && ivestisTemp < 100) { Console.WriteLine("Karšta"); }
            else Console.WriteLine("Temperatūra esanti žemesnė nei -100 ar aukštesnė nei 100, yra netinkama");

            Console.WriteLine("\nUžduotis 03\n");

            Console.WriteLine("Kokią valandą pakilote?: ");
            int ivestisVal = Convert.ToInt32(Console.ReadLine());

            if (ivestisVal > 0 && ivestisVal < 12) { Console.WriteLine("Geros dienos!"); }
            else if (ivestisVal >= 12 && ivestisVal < 18) { Console.WriteLine("Geros popietės!"); }
            else if (ivestisVal >= 18 && ivestisVal < 24) { Console.WriteLine("Gero vakaro!"); }
            else { Console.WriteLine("klaidingai nurodyta valanda!"); }

            Console.WriteLine("\nUžduotis 03-2\n");

            Console.WriteLine("Enrer Password: ");
            string ivestisPsw = Console.ReadLine();
            string password = "5imp#s0n-s";
            string hack = "01101001 01101110";

            if (ivestisPsw == "Mellon")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Access Granted");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (ivestisPsw == password)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Access Granted");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (ivestisPsw == hack)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("HACKED!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Wrong password, please try again!");
            }

            Console.WriteLine("\nUžduotis 04\n");

            Console.WriteLine("Please, enter your age: ");
            int ivestisAge = Convert.ToInt32(Console.ReadLine());

            if (ivestisAge == 0 && ivestisAge < 18) { Console.WriteLine("You have teenage discount!"); }
            else if (ivestisAge >= 18 && ivestisAge <= 65) { Console.WriteLine("You have mature discount!"); }
            else if (ivestisAge >= 65) { Console.WriteLine("You have senior discount!"); }
            else { Console.WriteLine("Wrong age, please try again"); }

            Console.WriteLine("\nUžduotis 05\n");

            Console.WriteLine("Please enter years, to check if its leap year: ");
            int insertYear = Convert.ToInt32(Console.ReadLine());
            int reminderYear = insertYear % 4;
            int reminderYear2 = insertYear! % 100;
            int reminderYear3 = insertYear % 400;

            if (reminderYear == 0 && reminderYear2 != 0)
            {
                Console.WriteLine("It's leap year");
            }
            else if (reminderYear3 == 0)
            {
                Console.WriteLine("It's leap year");
            }
            else { Console.WriteLine("It's not leap year"); }

            Console.WriteLine("\nUžduotis 06\n");

            Console.WriteLine("Please enter number: ");
            int insertNumb = Convert.ToInt32(Console.ReadLine());
            int reminderNumb = insertNumb % 3;
            int reminderNumb2 = insertNumb % 5;

            if (reminderNumb == 0 && reminderNumb2 == 0)
            {
                Console.WriteLine("BazingaPop");
            }
            else if (reminderNumb == 0 && reminderNumb2 != 0)
            {
                Console.WriteLine("Bazinga");
            }
            else if (reminderNumb2 == 0 && reminderNumb != 0)
            {
                Console.WriteLine("Pop");
            }
            else { Console.WriteLine("Number is not Bazinga or Pop"); }

            Console.WriteLine("\nUžduotis 07\n");

            Console.WriteLine("Please enter two numbers: ");
            int insertPossitive = Convert.ToInt32(Console.ReadLine());
            int insertPossitive2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered: " + insertPossitive + " " + insertPossitive2);

            if (insertPossitive >= 0 && insertPossitive2 >= 0)
            {
                Console.WriteLine("Both numbers are possitive");
            }
            else if (insertPossitive >= 0 && insertPossitive2 <= 0 || insertPossitive <= 0 && insertPossitive2 >= 0)
            {
                Console.WriteLine("Only one number is possitive");
            }
            else if (insertPossitive <= 0 && insertPossitive2 <= 0)
            {
                Console.WriteLine("Both numbers are negative");
            }
            else { Console.WriteLine("Wrong number, please try again"); }

            Console.WriteLine("\nUžduotis 07-2\n");

            Console.WriteLine("Please enter 3 numbers: ");
            int insertEven = Convert.ToInt32(Console.ReadLine());
            int insertEven2 = Convert.ToInt32(Console.ReadLine());
            int insertEven3 = Convert.ToInt32(Console.ReadLine());

            if (insertEven == insertEven2 && insertEven == insertEven3)
            {
                Console.WriteLine("All numbers are even");
            }
            else if (insertEven == insertEven2 && insertEven != insertEven3
                  || insertEven == insertEven3 && insertEven != insertEven2
                  || insertEven2 == insertEven3 && insertEven != insertEven2)
            {
                Console.WriteLine("Only two numbers are even");
            }
            else { Console.WriteLine("Non of numbers are even"); }

            Console.WriteLine("\nUžduotis 08\n");

            Console.WriteLine("Please enter 3 numbers: ");
            int insertA = Convert.ToInt32(Console.ReadLine());
            int insertB = Convert.ToInt32(Console.ReadLine());
            int insertC = Convert.ToInt32(Console.ReadLine());

            if (insertA >= 0 && insertB >= 0 && insertC >= 0)
            {
                int sumA = insertA + insertB + insertC;
                Console.WriteLine(insertA + " + " + insertB + " + " + insertC + " = " + sumA);
                Console.WriteLine("OR");
                Console.WriteLine(insertA + insertB + insertC); // or like this if you want it look simple (tik reikia prisiminti, jog ikelus teksto elementa gausim ne sum, o is eiles surasytus skaicius. Tiksliai neprisimenu gal padetu {0}, reiks patestuoti )
            }
            else if (insertA >= 0 && insertB >= 0 && insertC < 0)
            {
                Console.WriteLine(insertA + insertB);
            }
            else if (insertA >= 0 && insertB < 0 && insertC >= 0)
            {
                Console.WriteLine(insertA + insertC);
            }
            else if (insertA < 0 && insertB >= 0 && insertC >= 0)
            {
                Console.WriteLine(insertB + insertC);
            }
            else { Console.WriteLine("to many negative numbers"); }

            Console.WriteLine("\nUžduotis 08-2\n");










        }
    }
}
