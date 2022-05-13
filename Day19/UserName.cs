using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19
{
     class UserName
    {
        public static string REG_USERNAME = "^[A-Z]{1}[a-zA-Z]{2,}$";

        public static string REG_LASTNAME = "^[A-Z]{1}[a-zA-Z]{2,}$";

        public static string REG_EMAILID = "^[0-9a-zA-Z]+([+#$%&@._][a-zA-Z0-9]+)*[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-z]{2})?$";

        public static string REG_PHONENUM = "^[/+91]*[ ]*[/-]*[0-9]{10}$";

        public static string REG_PASSWORD = "^[A-Za-z]{8,}$";

        public static string REG_PASSWORD2 = "^[A-Z]+[A-Za-z]{7,}$";

        public static string REG_PASSWORD3 = "^[A-Z0-9]+[A-Za-z0-9]{7,}$";

        public static string REG_PASSWORD4 = "^[A-Z0-9]+[A-Za-z0-9]{7,}[!@#$%^&_-]$";

        public bool ValidateUserName(String username)
        {
            return Regex.IsMatch(username, REG_USERNAME);

        }
        public bool ValidateLastName(String lastname)
        {
            return Regex.IsMatch(lastname, REG_LASTNAME);

        }
        public bool ValidateEmailId(String emailid)
        {
            return Regex.IsMatch(emailid, REG_EMAILID);

        }
        public bool ValidatePhoneNum(String phone)
        {
            return Regex.IsMatch(phone, REG_PHONENUM);
        }
        public bool ValidatePassword(String password)
        {
            return Regex.IsMatch(password, REG_PASSWORD);
        }
        public bool ValidatePassword2(String password2)
        {
            return Regex.IsMatch(password2, REG_PASSWORD2);
        }
        public bool ValidatePassword3(String password3)
        {
            return Regex.IsMatch(password3, REG_PASSWORD3);
        }
        public bool ValidatePassword4(String password4)
        {
            return Regex.IsMatch(password4, REG_PASSWORD4);
        }
    }
}
