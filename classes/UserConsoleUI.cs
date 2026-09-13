namespace mercado_tech.classes
{
    public static class UserConsoleUI
    {
        public static string LerNome()
        {
            Console.Write("Digite seu nome completo: ");
            return Console.ReadLine();
        }

        public static string LerUserName()
        {
            Console.Write("Digite seu nome de usuário: ");
            return Console.ReadLine();
        }

        public static string LerCNPJ()
        {
            Console.Write("Digite seu CNPJ (apenas números ou formatado): ");
            return Console.ReadLine();
        }

        public static string LerCpf()
        {
            Console.Write("Digite seu CPF (apenas números ou formatado): ");
            return Console.ReadLine();
        }

        public static string LerEmail()
        {
            Console.Write("Digite seu email: ");
            return Console.ReadLine();
        }

        public static string LerSenha()
        {
            Console.Write("Digite sua senha: ");
            return Console.ReadLine();
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

        public static void ExibirPerfil(User user)
        {
            Console.WriteLine($"Info do usuario {user.UserName}");
            Console.WriteLine("====================================");
            Console.WriteLine($"Nome: {user.Name}");
            Console.WriteLine($"Email: {user.Email}");

            user.ExibirDadosAdiconaisdoPerfil();
        }
    }
}
