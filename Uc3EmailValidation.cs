using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Uc3EmailValidation
    {
        public static string RegexRule = "^[A-Za-z0-9]+([.][A-Za-z0-9]+)*[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-z]{2})*$";
        public static bool ValidateData(string sample)
        {
            return Regex.IsMatch(sample, RegexRule);
        }
    }
}
