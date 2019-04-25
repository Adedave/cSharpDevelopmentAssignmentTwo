using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAssign
{
    class Program
    {


        static void Main(string[] args)
        {
            int i;
            string[] GeoPoliticalZone = { "North Central", "North East", "North West", "South East", "South West", "South South"};
            Console.WriteLine("1. North Central");
            Console.WriteLine("2. North East");
            Console.WriteLine("3. North West");
            Console.WriteLine("4. South East");
            Console.WriteLine("5. South West");
            Console.WriteLine("6. South South");

            Console.WriteLine("Enter the number of  the Geopolitical zone you want to view information about");
            bool success = int.TryParse(Console.ReadLine(), out i);
        }

        readonly string[] NorthCentral = { "Benue", "Kogi", "Kwara", "Nasarawa", "Niger", "Plateau", "FCT" };

        readonly string[] NorthEast = { "Adamawa", "Bauchi", "Borno", "Gombe", "Taraba", "Yobe" };

        readonly string[] NorthWest = { "Jigawa", "Kaduna", "Kano", "Katsina", "Kebbi", "Sokoto", "Zamfara" };

        readonly string[] SouthEast = { "Abia", "Anambra", "Ebonyi", "Enugu", "Imo" };

        readonly string[] SouthSouth = { "Akwa Ibom", "Bayelsa", "Cross River", "Rivers", "Delta", "Edo" };

        readonly string[] SouthWest = { "Ekiti", "Lagos", "Ogun", "Ondo", "Osun", "Oyo" };

        static int (int FirstResponse)
        {}
    }
    
}
