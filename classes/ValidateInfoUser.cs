using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace mercado_tech.classes
{
    public static partial class ValidateInfoUser
    {
        [GeneratedRegex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")] private static partial Regex EmailRegex();
        [GeneratedRegex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{12,}$")] private static partial Regex PasswordRegex();

        public static bool EmailIsvalid(string email)
        {
            if (EmailRegex().IsMatch(email))
            {
                return true;
            }
            return false;
        }

        public static bool Nameisvalid(string name)
        {
            if (name.Length > 10 && !string.IsNullOrWhiteSpace(name))
            {
                return true;
            }

            return false;
        }

        public static bool Passwordisvalid(string password) {

            if (PasswordRegex().IsMatch(password))
            {
                return true;
            }

            return false;
        }

        public static bool Usernameisvalid(string username)
        {
            if (!string.IsNullOrWhiteSpace(username))
            {
                return true;
            }

            return false;
        }
    }
}
