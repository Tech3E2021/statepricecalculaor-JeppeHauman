using System;

namespace StatePriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Instance fields
            double totalPriceDiscounted = 0;
            double totalPriceTaxed = 0;
            //En velkommen besked til brugeren
            Console.WriteLine("Welcome to 'THE BEST CALCULATOR EVER'");

            //Brugeren taster antallet af varer
            Console.WriteLine("Skriv antallet af varer");
            double numberOfItems = Convert.ToInt32(Console.ReadLine());

            //Brugeren taster prisen på varen
            Console.WriteLine("Skriv prisen på varen");
            double priceOfItems = Convert.ToInt32(Console.ReadLine());

            //Giv brugeren besked om samlet pris
            var TotalPrice = numberOfItems * priceOfItems;
            Console.WriteLine($"Den samlede pris uden discount og tax er: {TotalPrice}");

            //Udregn samlet pris med discount
            if (TotalPrice <= 999)
            {
                Console.WriteLine("Der er ingen discount");
            }
            else if (TotalPrice >=1000 && TotalPrice < 4999)
            {
                totalPriceDiscounted = TotalPrice * 0.97;
                Console.WriteLine("Discount: 3%");
            }
            else if (TotalPrice >=5000 && TotalPrice < 6999)
            {
                totalPriceDiscounted = TotalPrice * 0.95;
                Console.WriteLine("Discount: 5%");
            }
            else if (TotalPrice >= 7000 && TotalPrice < 9999)
            {
                totalPriceDiscounted = TotalPrice * 0.93;
                Console.WriteLine("Discount: 7%");
            }
            else if (TotalPrice >= 10000 && TotalPrice < 49999)
            {
                totalPriceDiscounted = TotalPrice * 0.90;
                Console.WriteLine("Discount: 10%");
            }
            else
            {
                totalPriceDiscounted = TotalPrice * 0.85;
                Console.WriteLine("Discount: 15%");
            }


            //Besked om samlet pris med discount
            Console.WriteLine($"Den samlede pris med discount er: {totalPriceDiscounted} ");

            //Besked: Statecode på 2 bogstaver
            Console.WriteLine("Skriv din state code(UT, NV, TX, AL, CA)");

            //Brugeren taster State-Code, 2 bogstaver
            var stateCode = Console.ReadLine();

            //udregn pris udfra statens tax
            switch (stateCode)
            {
                case "UT":
                    totalPriceTaxed = totalPriceDiscounted * 1.0685;
                    Console.WriteLine("Din state tax: 6,85%");
                    break;
                case "NV":
                    totalPriceTaxed = totalPriceDiscounted * 1.08;
                    Console.WriteLine("Din state tax: 8%");
                    break;
                case "TX":
                    totalPriceTaxed = totalPriceDiscounted * 1.0625;
                    Console.WriteLine("Din state tax: 6,25%");
                    break;
                case "AL":
                    totalPriceTaxed = totalPriceDiscounted * 1.04;
                    Console.WriteLine("Din state tax: 4%");
                    break;
                case "CA":
                    totalPriceTaxed = totalPriceDiscounted * 1.0825;
                    Console.WriteLine("Din state tax: 8,25%");
                    break;
                default:
                    Console.WriteLine("Du er enten idiot eller har lavet en stavefejl: Pisse ærgeligt");
                    break;
            }

            //Besked til brugeren om samlet pris efter tax og discount

            Console.WriteLine($"Din samlede pris efter tax: {totalPriceTaxed}");








            //Brugeren skal vælge om de er færdige eller ej; Are you done? YES/NO

            //Hvis brugeren IKKE er færdig køres "brugeren taster antallet af varer" igen. Hvis brugeren er færdig går vi videre
        }
    }
}
