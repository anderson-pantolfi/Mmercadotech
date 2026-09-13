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
        [GeneratedRegex("^(\\d{2}\\.\\d{3}\\.\\d{3}/\\d{4}-\\d{2}|\\d{14})$")] private static partial Regex CNPJRegex();
        [GeneratedRegex("^(\\d{3}\\.\\d{3}\\.\\d{3}-\\d{2}|\\d{11})$")] private static partial Regex CPFRegex();
       
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
            if (name.Length > 3 && !string.IsNullOrWhiteSpace(name))
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

        public static bool CNPJisValid(string cnpj)
        {
            if (CNPJRegex().IsMatch(cnpj))
            {
                return true;
            }
            return false;
        }

        public static bool CPFisValid(string cpf)
        {
            if (CPFRegex().IsMatch(cpf))
            {
                return true;
            }
            return false;
        }
    }
}
