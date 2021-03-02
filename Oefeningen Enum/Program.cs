using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_Enum
{
    class Program
    {
        enum BMI { Ondergewicht, Normaal, Overgewicht, Zwaarlijvig, Obesitas }
        static void Main(string[] args)
        {
            Console.Write("Oefening: ");
            string oefening = Console.ReadLine();
            switch (oefening)
            {
                case "1":
                    //OEFENING 1
                    Console.Write("Geef uw gewicht (in kg): ");
                    double gewicht = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Geef uw lengte in (in cm): ");
                    double lengte = Convert.ToDouble(Console.ReadLine()) / 100;
                    double berekening = gewicht / (lengte * lengte);
                    Console.WriteLine(berekening);
                    BMI bmi = 0;
                    if (berekening < 18.5) bmi = BMI.Ondergewicht;
                    if (berekening >= 18.5 && berekening < 25) bmi = BMI.Normaal;
                    if (berekening >= 25 && berekening < 30) bmi = BMI.Overgewicht;
                    if (berekening >= 30 && berekening < 40) bmi = BMI.Zwaarlijvig;
                    if (berekening >= 40) bmi = BMI.Obesitas;
                    Console.Write("U bent ");
                    switch (bmi)
                    {
                        case BMI.Ondergewicht:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ondergewicht.");
                            break;
                        case BMI.Normaal:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("normaal.");
                            break;
                        case BMI.Overgewicht:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("overgewicht.");
                            break;
                        case BMI.Zwaarlijvig:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("zwaarlijvig");
                            break;
                        case BMI.Obesitas:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("ernstig zwaarlijvig");
                            break;
                        default:
                            break;
                    }
                    break;
                case "2":
                    //OEFENING 2
                    {
                        Console.Write("Hoeveel paar schoenen schik jij zoal te kopen?? ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        int aantal = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.White;
                        int prijs = aantal * 20;
                        if (aantal > 9)
                        {
                            prijs = 180 + (aantal - 9) * 10;
                        }
                        Console.WriteLine($"{aantal} schoenen = {prijs} euro.");
                    break;
                    }

            }
            Console.ReadLine();



        }
    }
}
