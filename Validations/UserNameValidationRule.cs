using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace LoginMvvmApp.Validations
{
    internal class UserNameValidationRule : ValidationRule
    {
        /// <summary>
        /// This is a validation rule which allows AlphaNumeric Characters with a minimum of 2 
        /// and maximum of 10 characters that are specified in the Regex.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="cultureInfo"></param>
        /// <returns></returns>
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Regex regex = new Regex(@"" /*TODO: regex Ausdruck siehe oben*/);

            string? val = value.ToString();
            if(val == null) return ValidationResult.ValidResult;

            if (!regex.IsMatch(val))
            {
                return new ValidationResult(false, "Please enter valid email or username");
            }
            else
            {
                return ValidationResult.ValidResult;
            }
        }
    }
}
