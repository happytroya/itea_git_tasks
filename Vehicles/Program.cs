using System.Globalization;
using System.Text.RegularExpressions;

namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            string vehicleOwner;
            string vehicleBrand;
            string vehicleNumber;
            string vehicleYear;

            Regex numberPattern = new Regex("^[A-Z]{2}[0-9]{4}[A-Z]{2}$");
            Regex ownerPattern = new Regex("^([A-Z])[a-z]+\\s([A-Z])[a-z]+$");
            Regex brandPattern = new Regex("^[A-Za-z]+$");
            Regex yearPattern = new Regex("^[0-9]{4}$");

            string[] vehiclePassport;
            string[][] allPassports = new string[1][];

            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Enter vehicle owner in Surename/Name format");
                    vehicleOwner = Console.ReadLine();

                    if (ownerPattern.Matches(vehicleOwner).Count > 0)
                    {
                        break;
                    }

                    Console.WriteLine("Try again");
                }

                while (true)
                {
                    Console.WriteLine("Enter vehicle brand");
                    vehicleBrand = Console.ReadLine();

                    if (brandPattern.Matches(vehicleBrand).Count > 0)
                    {
                        break;
                    }

                    Console.WriteLine("Try again");
                }

                while (true)
                {
                    Console.WriteLine("Enter vehicle number in AA0000AA format");
                    vehicleNumber = Console.ReadLine();

                    if (numberPattern.Matches(vehicleNumber).Count > 0)
                    {
                        break;
                    }

                    Console.WriteLine("Try again");
                }

                while (true)
                {
                    Console.WriteLine("Enter registration year");
                    vehicleYear = Console.ReadLine();

                    if (yearPattern.Matches(vehicleYear).Count > 0)
                    {
                        break;
                    }

                    Console.WriteLine("Try again");
                }

                vehiclePassport = new string[] { vehicleOwner, vehicleBrand, vehicleNumber, vehicleYear };
                count++;

                if (allPassports.Length < count)
                {
                    string[][] tmp = allPassports;
                    allPassports = new string[tmp.Length * 2][];
                    Array.Copy(tmp, 0, allPassports, 0, count - 1);
                }

                allPassports[count - 1] = vehiclePassport;

                Console.WriteLine("Do you want to enter new passport? y/n");
                char answear = char.Parse(Console.ReadLine());
                if (answear == 'n')
                {
                    break;
                }
            }

            for(int a = 0; a < count; a++)
            {
                string[] arr = allPassports[a];
                Console.WriteLine("Owner: {0} Brand: {1} Number: {2} Year: {3}", arr[0], arr[1], arr[2], arr[3]);
            }
        }
    }
}
