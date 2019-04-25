using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DavidUtilityLibrary.Utility;


namespace UseOfLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] any = new int[5];
            //int[,] array1 = new int[5, 3];
            //array1[0, 0] = 20;
            //array1[1, 0] = 10;
            //int[][,] jagged = new int[5][,];

            string[] sLogic = Environment.GetLogicalDrives();
            for (int i = 0; i < sLogic.Length; i++)
            {
                Console.WriteLine(sLogic[i]);
            }
            Console.WriteLine(sLogic.Length);
            //Console.WriteLine(Environment.GetLogicalDrives().Length);

            /********************************************************
                            Base Conversion
            ********************************************************/

            Console.WriteLine("\nInput the base of the number you want to convert:");
            bool success1 = int.TryParse(Console.ReadLine(), out int baseNumber1);
            Console.WriteLine("\nInput the base you want to convert the number to:");
            bool success2 = int.TryParse(Console.ReadLine(), out int baseNumber2);
            Console.WriteLine("\nInput the number you want to convert: ");
        check:

            string responseCheck = Console.ReadLine();
            if (MappingFunctionToDecimal(responseCheck, baseNumber1, out long decimalNumber))
            {
                Console.WriteLine(decimalNumber);
            }
            else
            {
                Console.WriteLine("Please enter a valid number: ");
                goto check;
            }
            string response = responseCheck;

            //Console.WriteLine($"\n{response} converted to decimal is {MappingFunctionToDecimal(response, baseNumber1)}");
            //long decimalNumber = MappingFunctionToDecimal(response, baseNumber1);
            //Console.WriteLine($"\n{response} to base {baseNumber2} is {MappingFunctionToBase(decimalNumber, baseNumber2)}\n");

            Console.ReadLine();

            /********************************************************
                            Number to Words Conversion
            ********************************************************/

            Console.Write("Input the number you want to convert to text: ");
            bool success = int.TryParse(Console.ReadLine(), out int num);
            //WordsFunction(num);
            Console.WriteLine($"{num} is {WordsFunction(num)}");
            Console.ReadLine();
        }
    }
}
