using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DavidUtilityLibrary
{
    public class Utility
    {
        /********************************************************
                            Base Conversion
         ********************************************************/

        static string allNumbers = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static bool ValidityCheck(string number, int baseValue)
        {
            //long bigNumber = 458_899_000_776_888;
            int value = 0;
            bool right = true;
            int determinant = 0;
            string val = number.ToUpper();

            for (int i = 0; i < val.Length; i++)
            {
                // value equals the index position of each character in the string val
                value = allNumbers.IndexOf(val.Substring(i, 1));
                if (value >= baseValue)
                {
                    determinant++;
                    break;
                }
            }

            if (determinant == 1)
            {
                right = false;
            }
            return right;
        }

        // this method converts a number of a particular base between 2 and 36 to decimal
        public static long MappingFunctionToDecimal(string number, int baseValue)
        {
            // I used the long data type because the result of this conversion might exceed the length of an int data type
            //For example if I parse abcdef123456789 through this function with decNumber as an int data type, the app would crash.
            long decNumber = 0;
            int value = 0;
            int length = number.Length - 1;
            //test = "2abcd";
            string val = number.ToUpper();

            for (int i = 0; i < val.Length; i++)
            {
                // value equals the index position of each character in the string val
                value = allNumbers.IndexOf(val.Substring(i, 1));

                //decNumber = decNumber + ........;
                decNumber += (long)(Math.Pow(baseValue, length) * value);
                length--;
            }
            return decNumber;
        }

        public static bool MappingFunctionToDecimal(string number, int baseValue, out long result)
        {
            result = 0;
            bool valid = ValidityCheck(number, baseValue);
            if (valid)
            {
                result = MappingFunctionToDecimal(number, baseValue);
            }
            return valid;
        }
        // this method converts a decimal number to any base between 2 and 36
        public static string MappingFunctionToBase(long decNumber, int baseValue)
        {
            //declared the finalBaseNumberValue because I would use it later in the function. 
            //Also, i had to intialize it because i cant use an unassigned variable
            string finalBaseNumberValue = "";

            //Once decNumber becomes zero(0) the function breaks out of the loop. 
            //This work because 1 % baseValue is the last operation for our conversion
            while (decNumber > 0)
            {
                //  I casted the modulus operation because, innately, its result will be a long data type which the allNumbers[i] operation would not recognize
                //  And I used a char data type for modulus because allNumbers[i] operation returns a character since allNumbers is an array of characters
                char modulus = allNumbers[(int)(decNumber % baseValue)];

                //The below is different from finalBaseNumberValue += ......; 
                //For the above it means finalBaseNumberValue = finalBaseNumberValue + ......; 
                //which will make the first result of the modulus to be the first character 
                //in our string. This is the reverse of what we want. 
                //modulus.ToString() helps convert char modulus to string as char and string cannot be concatenated
                finalBaseNumberValue = modulus.ToString() + finalBaseNumberValue;

                //decNumber = decNumber / baseValue;
                decNumber /= baseValue;
            }
            return finalBaseNumberValue;
        }


        /********************************************************
                            Number to Words Conversion
         ********************************************************/


        //static string allNumbers = "0123456789";
        static string[] units = { "", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE" };
        static string[] units2 = { "TEN ", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN" };
        static string[] tens = { "", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY" };
        static string[] hundreds = { " ", "ONE HUNDRED", "TWO HUNDRED", "THREE HUNDRED", "FOUR HUNDRED", "FIVE HUNDRED", "SIX HUNDRED", "SEVEN HUNDRED", "EIGHT HUNDRED", "NINE HUNDRED" };
        static string[] thousands = { "", "ONE THOUSAND", "TWO THOUSAND", "THREE THOUSAND", "FOUR THOUSAND", "FIVE THOUSAND", "SIX THOUSAND", "SEVEN THOUSAND", "EIGHT THOUSAND", "NINE THOUSAND", "TEN THOUSAND",
                "ELEVEN THOUSAND", "TWELVE THOUSAND"};
        //static string[] units = { "", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN" };
        ////      static 


        public static string WordsFunction(int number)
        {
            string words = "";
            if (number == 0)
            {
                words = "ZERO";
            }
            else if (number < 100)
            {
                words = TwoDigitsFunction(number);
            }
            else if (number < 1000)
            {
                words = ThreeDigitsFunction(number);
            }
            else if (number < 10000)
            {
                words = FourDigitsFunction(number);
            }
            else if (number < 100000)
            {
                words = FiveDigitsFunction(number);
            }

            return words;
        }
        
        public static string FiveDigitsFunction(int fiveDigitNumber)
        {
            string fiveDigitsWord = "";
            int tenThousandsDigit = (fiveDigitNumber / 1000);
            int fourDigit = fiveDigitNumber % 10000;
            int threeDigit = fourDigit % 100;
            int thousandsDigit = fourDigit / 1000;
            int hundredsDigit = fourDigit / 100;
            if (fourDigit == 0)
            {
                //CHECK FOR 10 - 19
                if (tenThousandsDigit < 20)
                {
                    fiveDigitsWord = units2[tenThousandsDigit % 10] + " THOUSAND";

                }
                //ELSE RUN THIS FOR 20 - 99
                else
                {
                    //int tensDigit = tenThousandsDigit / 10;
                    fiveDigitsWord = tens[tenThousandsDigit / 10] + " " + OneDigitFunction(tenThousandsDigit % 10) + " THOUSAND";
                }
            }
            else if (threeDigit == 0)
            {
                //CHECK FOR 10 - 19
                if (tenThousandsDigit < 20)
                {
                    fiveDigitsWord = units2[tenThousandsDigit % 10] + " THOUSAND " + FourDigitsFunction(threeDigit);

                }
                //ELSE RUN THIS FOR 20 - 99
                else
                {
                    //int tensDigit = tenThousandsDigit / 10;
                    fiveDigitsWord = tens[tenThousandsDigit / 10] + " " + OneDigitFunction(tenThousandsDigit % 10) + " THOUSAND " + FourDigitsFunction(threeDigit);
                }
            }
            return fiveDigitsWord;
        }
        
        public static string FourDigitsFunction(int fourDigitNumber)
        {
            string fourDigitsWord = "";
            int threeDigit = fourDigitNumber % 1000;
            int twoDigit = threeDigit % 100;
            int thousandsDigit = fourDigitNumber / 1000;
            int hundredsDigit = threeDigit / 100;
            if (threeDigit == 0)
            {
                fourDigitsWord = units[thousandsDigit] + " THOUSAND";
            }
            else
            {
                if (twoDigit == 0)
                {
                    fourDigitsWord = units[thousandsDigit] + " THOUSAND " + hundreds[hundredsDigit];
                }
                else if (hundredsDigit == 0)
                {
                    fourDigitsWord = units[thousandsDigit] + " THOUSAND AND " + TwoDigitsFunction(twoDigit);
                }
                else
                {
                    fourDigitsWord = units[thousandsDigit] + " THOUSAND " + ThreeDigitsFunction(threeDigit);
                }
            }
            return fourDigitsWord;
        }
        
        public static string ThreeDigitsFunction(int threeDigitNumber)
        {
            string threeDigitsWord = "";
            int twoDigit = threeDigitNumber % 100;
            int hundredsDigit = threeDigitNumber / 100;
            if (twoDigit == 0)
            {
                threeDigitsWord = hundreds[hundredsDigit];
            }
            else
            {
                threeDigitsWord = hundreds[hundredsDigit] + " AND " + TwoDigitsFunction(twoDigit);
            }
            return threeDigitsWord;
        }
        
        public static string TwoDigitsFunction(int twoDigitNumber)
        {
            string twoDigitsWord = "";
            int tensDigit = 0;
            int digit = twoDigitNumber % 10;
            tensDigit = (twoDigitNumber % 100) / 10;

            if (twoDigitNumber < 10)
            {
                twoDigitsWord = OneDigitFunction(digit);
                goto endTwoDigit;
            }
            //CHECK FOR 10 - 19
            if (twoDigitNumber < 20)
            {
                twoDigitsWord = units2[twoDigitNumber % 10];
            }
            //ELSE RUN THIS FOR 20 - 99
            else
            {
                twoDigitsWord = tens[tensDigit] + " " + OneDigitFunction(digit);
            }
        endTwoDigit:
            return twoDigitsWord;
        }

        public static string OneDigitFunction(int oneDigitNumber)
        {
            return units[oneDigitNumber];
        }
    }
}
