using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace mercado_tech.classes
{
    public static class UserConsoleUI
    {
        public static void ExibirPerfil(User user)
        {
            Console.WriteLine($"Info do usuario {user.UserName}");
            Console.WriteLine("====================================");
            Console.WriteLine($"Nome: {user.Name}");
            Console.WriteLine($"Email: {user.Email}");

            Console.WriteLine(user.ExibirDadosAdiconaisdoPerfil());
        }

        public static void AtualizarEmail(User user)
        {
            Console.Write("Digite O email: ");
            string email = Console.ReadLine();

            if (user.SetEmail(email))
            {
                Console.Write("email foi alterado com sucesso");
            }
        }

        public static void AtualizarSenha(User user)
        {
            Console.Write("Digite a senha antiga: ");
            string senhaAntiga = Console.ReadLine();

            Console.Write("Digite a nova senha: ");
            string novaSenha = Console.ReadLine();

            if (user.AlterarSenha(senhaAntiga, novaSenha))
            {
                Console.WriteLine("Senha alterada com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro: A senha antiga está incorreta ou a nova senha não atende aos requisitos mínimos.");
            }
        }
    }
}
