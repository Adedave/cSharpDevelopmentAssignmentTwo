using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCostPlatform
{
    class UserInfo
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public CompanyInfo UserCompanyInfo { get; set; }

        public UserInfo()
        {

        }
        public UserInfo(string aUserName, string aFirstName, string aLastName, string aEmailAddress, string aPhoneNumber)
        {
            Username = aUserName;
            FirstName = aFirstName;
            LastName = aLastName;
            EmailAddress = aEmailAddress;
            PhoneNumber = aPhoneNumber;

        }
    }
}
