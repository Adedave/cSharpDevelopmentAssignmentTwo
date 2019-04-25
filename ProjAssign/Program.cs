using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAssign
{
    class Program
    {
        static int ans, ansTwo;
        //static string[] geoPoliticalZone, northCentral, northEast, northWest, southEast, southSouth, southWest;
        static string[] geoPoliticalZone = { "North Central", "North East", "North West", "South East", "South West", "South South" };

        static string[] northCentral = { "Benue", "Kogi", "Kwara", "Nasarawa", "Niger", "Plateau", "FCT" };

        static string[] northEast = { "Adamawa", "Bauchi", "Borno", "Gombe", "Taraba", "Yobe" };

        static string[] northWest = { "Jigawa", "Kaduna", "Kano", "Katsina", "Kebbi", "Sokoto", "Zamfara" };

        static string[] southEast = { "Abia", "Anambra", "Ebonyi", "Enugu", "Imo" };

        static string[] southSouth = { "Akwa Ibom", "Bayelsa", "Cross River", "Rivers", "Delta", "Edo" };

        static string[] southWest = { "Ekiti", "Lagos", "Ogun", "Ondo", "Osun", "Oyo" };

        static string[] kwara = {"Asa", "Baruten", "Edu", "Ekiti", "Ifelodun", "Ilorin East", "Ilorin South",
            "Ilorin West", "Irepodun", "Isin", "Kaiama", "Moro", "Offa", "Oke Ero","Oyun", "Pategi"};

        static void Main(string[] args)
        {
            
            //string[] geoPoliticalZone = { "North Central", "North East", "North West", "South East", "South West", "South South"};

            //string[] northCentral = { "Benue", "Kogi", "Kwara", "Nasarawa", "Niger", "Plateau", "FCT" };

            //string[] northEast = { "Adamawa", "Bauchi", "Borno", "Gombe", "Taraba", "Yobe" };

            //string[] northWest = { "Jigawa", "Kaduna", "Kano", "Katsina", "Kebbi", "Sokoto", "Zamfara" };

            //string[] southEast = { "Abia", "Anambra", "Ebonyi", "Enugu", "Imo" };

            //string[] southSouth = { "Akwa Ibom", "Bayelsa", "Cross River", "Rivers", "Delta", "Edo" };

            //string[] southWest = { "Ekiti", "Lagos", "Ogun", "Ondo", "Osun", "Oyo" };


            Console.WriteLine("1. North Central");
            Console.WriteLine("2. North East");
            Console.WriteLine("3. North West");
            Console.WriteLine("4. South East");
            Console.WriteLine("5. South West");
            Console.WriteLine("6. South South");

            Console.WriteLine("Enter the number of  the Geopolitical zone you want to view information about");
            bool success = int.TryParse(Console.ReadLine(), out ans);
            Console.WriteLine($"You have selected {geoPoliticalZone[ans - 1]}");
            if (geoPoliticalZone[ans - 1] == "North Central")
                NorthCentralFunction();
            else if (geoPoliticalZone[ans - 1] == "North East")
                NorthEastFunction();
            else if (geoPoliticalZone[ans - 1] == "North West")
                NorthWestFunction();
            else if (geoPoliticalZone[ans - 1] == "South East")
                SouthEastFunction();
            else if (geoPoliticalZone[ans - 1] == "South West")
                SouthWestFunction();
            else if (geoPoliticalZone[ans - 1] == "South South")
                SouthSouthFunction();

            


            Console.ReadLine();
        }

        static void NorthCentralFunction()
        {
            if (northCentral.Length > 0)
            {
                int i = 1;
                foreach (string item in northCentral)
                {
                    Console.WriteLine(i + ". " + item);
                    i++;
                }
            }

            Console.WriteLine("Enter the number of  the State you want to view information about");
            bool right = int.TryParse(Console.ReadLine(), out ansTwo);
            Console.WriteLine($"You have selected {northCentral[ansTwo - 1]}");
            Kwara();
            /*if (northCentral[ansTwo - 1] == "Benue")
                Benue();
            else if (northCentral[ansTwo - 1] == "Kogi")
                Kogi();
            else if (northCentral[ansTwo - 1] == "Kwara")
                Kwara();
            else if (northCentral[ansTwo - 1] == "Nasarawa")
                Nasarawa();
            else if (northCentral[ansTwo - 1] == "Niger")
                Niger();
            else if (northCentral[ansTwo - 1] == "Plateau")
                Plateau();
            else if (northCentral[ansTwo - 1] == "FCT")
                Fct();*/

            return;
        }
        static void NorthEastFunction()
        {
            if (northEast.Length > 0)
            {
                int i = 1;
                foreach (string item in northEast)
                {
                    Console.WriteLine(i + ". " + item);
                    i++;
                }
            }
            return;
        }
        static void NorthWestFunction()
        {
            if (northWest.Length > 0)
            {
                int i = 1;
                foreach (string item in northWest)
                {
                    Console.WriteLine(i + ". " + item);
                    i++;
                }
            }
            return;
        }
        static void SouthEastFunction()
        {
            if (southEast.Length > 0)
            {
                int i = 1;
                foreach (string item in southEast)
                {
                    Console.WriteLine(i + ". " + item);
                    i++;
                }
            }
            return;
        }
        static void SouthWestFunction()
        {
            if (southWest.Length > 0)
            {
                int i = 1;
                foreach (string item in southWest)
                {
                    Console.WriteLine(i + ". " + item);
                    i++;
                }
            }
            return;
        }
        static void SouthSouthFunction()
        {
            if (southSouth.Length > 0)
            {
                int i = 1;
                foreach (string item in southSouth)
                {
                    Console.WriteLine(i + ". " + item);
                    i++;
                }
            }
            return;
        }
        static void Kwara()
        {
            if (kwara.Length > 0)
            {
                int i = 1;
                foreach (string item in kwara)
                {
                    Console.WriteLine(i + ". " + item);
                    i++;
                }
            }
            return;
        }
        /*static void (int i)
        {
            if (NorthCentral.Length > 0)
            {
                foreach (string item in NorthCentral)
                {
                    Console.WriteLine(item);
                }

        }*/
    }

}
