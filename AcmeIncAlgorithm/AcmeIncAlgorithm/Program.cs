using System;
using System.Linq;
namespace AcmeIncAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert Address Shipment");
            String shipmentDestination =  Console.ReadLine();
            Console.WriteLine("Address Shipment:  " + shipmentDestination);

            Console.WriteLine("Insert Driver Name");
            String driverName = Console.ReadLine();
            Console.WriteLine("Driver Name:  " + driverName);

            AcmeIncAlgorithmOperations _operators = new AcmeIncAlgorithmOperations();
            if(shipmentDestination.Length%2 == 0)
            {
                Console.WriteLine("Number Is Even");
                int vowelCount = _operators.GetVowelNumber(driverName);
                double baseSS = vowelCount * 1.5;

                var commonNumberMatches = _operators.GetCommonFactor(shipmentDestination.Length).Intersect(_operators.GetCommonFactor(vowelCount));
                if (commonNumberMatches.Count() > 1)
                {
                    Console.WriteLine("Algorithm Bonus Activated!!");
                    baseSS = baseSS + (baseSS * 0.5);                   
                }
                Console.WriteLine("Base SS is =  " + baseSS);
            }
            else
            {
                Console.WriteLine("Number Is Odd");
                int consonantCount = _operators.GetConsonantNumber(driverName);
                double baseSS = consonantCount;

                var commonNumberMatches = _operators.GetCommonFactor(shipmentDestination.Length).Intersect(_operators.GetCommonFactor(consonantCount));
                if (commonNumberMatches.Count() > 1)
                {
                    Console.WriteLine("Algorithm Bonus Activated!!");
                    baseSS = baseSS + (baseSS * 0.5);
                }
                Console.WriteLine("Base SS is =  " + baseSS);
            }
            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }
    }
}
