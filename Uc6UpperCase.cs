using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Uc6UpperCase
    {
        public static string RegexRule = "^(?=.*\\d)(?=.*[A-Z]).{8,}$";
        public static bool ValidateData(string sample)
        {
            return Regex.IsMatch(sample, RegexRule);
        }
    }
}
