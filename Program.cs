
using UserRegistration;

string InputData = "Raja@1234";

//if (Uc1FirstNameValidation.ValidateData(InputData))
//if (Uc2LastNameValidation.ValidateData(InputData))
//if (Uc3EmailValidation.ValidateData(InputData))
//if (Uc4MbNoValidation.ValidateData(InputData))
//if (Uc5PasswordRules.ValidateData(InputData))
//if (Uc6UpperCase.ValidateData(InputData))
//if (Uc7NumericNum.ValidateData(InputData))
if (Uc8SpecialChar.ValidateData(InputData))
{
    Console.WriteLine("Valid");
}
else
{
    Console.WriteLine("Invalid");
}
