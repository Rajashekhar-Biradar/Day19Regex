using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Uc4MbNoValidation
    {
        public static string RegexRule = "^([0-9]{2}[ ])?[1-9]{1}[0-9]{9}$";

        public static bool ValidateData(string sample)
        {
            return Regex.IsMatch(sample, RegexRule);
        }
    }
}
