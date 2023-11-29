using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace LoginMvvmApp.Validations
{
    public class PasswordValidationRule : ValidationRule
    {
        /// <summary>
        /// This is a validation rule which allows AlphaNumeric Characters with a minimum of 5 
        /// and a maximum of 10 characters that are specified in the Regex.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="cultureInfo"></param>
        /// <returns></returns>
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Regex regex = new Regex(@"^[A-Za-z0-9!@#$%^&]{5,10}$");

            string? val = value.ToString();
            if (val == null) return ValidationResult.ValidResult;

            if (!regex.IsMatch(val))
            {
                return new ValidationResult(false, "Please enter valid password");
            }
            else
            {
                return ValidationResult.ValidResult;
            }
        }
    }
}
