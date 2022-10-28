using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Uc7NumericNum
    {
        public static string RegexRule = "^(?=.*\\d)(?=.*[0-9]).{8,}$";

        public static bool ValidateData(string sample)
        {
            return Regex.IsMatch(sample, RegexRule);
        }
    }
}
