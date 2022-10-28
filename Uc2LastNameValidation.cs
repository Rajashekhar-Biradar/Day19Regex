using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Uc2LastNameValidation
    {
        public static string RegexRule = "^[A-Z]{1}[a-zA-Z]{2,}";
        public static bool ValidateData(string sample)
        {
            return Regex.IsMatch(sample, RegexRule);

        }
    }
}
