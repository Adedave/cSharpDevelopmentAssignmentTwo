using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtiliyLibrary
{
    public class NumberToWords
    {
        //static string allNumbers = "0123456789";
        static string[] units = { "", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE" };
        static string[] units2 = { "TEN ", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN" };
        static string[] tens = { "", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY" };
        static string[] hundreds = { " ", "ONE HUNDRED", "TWO HUNDRED", "THREE HUNDRED", "FOUR HUNDRED", "FIVE HUNDRED", "SIX HUNDRED", "SEVEN HUNDRED", "EIGHT HUNDRED", "NINE HUNDRED" };
        static string[] thousands = { "", "ONE THOUSAND", "TWO THOUSAND", "THREE THOUSAND", "FOUR THOUSAND", "FIVE THOUSAND", "SIX THOUSAND", "SEVEN THOUSAND", "EIGHT THOUSAND", "NINE THOUSAND", "TEN THOUSAND",
                "ELEVEN THOUSAND", "TWELVE THOUSAND"};
        //static string[] units = { "", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN" };
        ////      static 
        

        static string WordsFunction(int number)
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

        static string FiveDigitsFunction(int fiveDigitNumber)
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

        static string FourDigitsFunction(int fourDigitNumber)
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

        static string ThreeDigitsFunction(int threeDigitNumber)
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

        static string TwoDigitsFunction(int twoDigitNumber)
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

        static string OneDigitFunction(int oneDigitNumber)
        {
            return units[oneDigitNumber];
        }
    }
}
