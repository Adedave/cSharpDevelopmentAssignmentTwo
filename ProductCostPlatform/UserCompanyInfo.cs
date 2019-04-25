using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCostPlatform
{
    class CompanyInfo
    {
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhoneNumber { get; set; }

        public CompanyInfo()
        {

        }
        public CompanyInfo(string aCompanyName, string aCompanyAddress, string aPhoneNumber)
        {
            CompanyName = aCompanyName;
            CompanyAddress = aCompanyAddress;
            CompanyPhoneNumber = aPhoneNumber;
        }

        public static int SimpleCalc(int a, int b)
        {
            return a * b;
        }
    }
}
