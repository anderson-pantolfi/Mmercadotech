using System;
using System.Collections.Generic;
using System.Text;

namespace mercado_tech.classes
{
    public static class UserConsoleUI
    {
        public static void ExibirPerfil(User user)
        {
            Console.WriteLine($"INFO Do usuario {user.UserName}");
            Console.WriteLine("====================================");
            Console.WriteLine($"Nome: {user.Name}");
            Console.WriteLine($"Email: {user.Email}");
        }

        public static void SolicitarEmail(User user)
        {
            Console.WriteLine("Digite O email: ");
            string email = Console.ReadLine();

            if (user.SetEmail(email))
            {
                Console.WriteLine("email foi alterado com sucesso");
            }
        }

        public static void SolicitarName(User user)
        {

        }
    }
}
