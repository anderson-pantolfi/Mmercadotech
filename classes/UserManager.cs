using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace mercado_tech.classes
{
    public static class UserManager
    {
        static List<User> UsersList = new List<User>();

        public static void CreateVendedor() 
        {
            Console.WriteLine("Cadastrando um novo Vendedor \n\n\n");
            string Name = UserConsoleUI.LerNome();
            string Username = UserConsoleUI.LerUserName();
            string Password = UserConsoleUI.LerSenha();
            string Email = UserConsoleUI.LerEmail();
            string Cnpj = UserConsoleUI.LerCNPJ();

            try
            {
                User user = new Vendedor(Name, Username, Password, Email, Cnpj);
                UsersList.Add(user);
                Console.WriteLine($"\n[SUCESSO] Vendedor {user.Name}, criado com sucesso!");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            } catch (Exception ex) { Console.WriteLine("Ocorreu um erro, pro favor tente novamente mais tarde"); }
        }

        public static void CreateCliente()
        {
            Console.WriteLine("Cadastrando um novo Vendedor \n\n\n");
            string Name = UserConsoleUI.LerNome();
            string Username = UserConsoleUI.LerUserName();
            string Password = UserConsoleUI.LerSenha();
            string Email = UserConsoleUI.LerEmail();
            string Cpf = UserConsoleUI.LerCpf();

            try
            {
                User user = new Vendedor(Name, Username, Password, Email, Cpf);
                UsersList.Add(user);
                Console.WriteLine($"\n[SUCESSO] Cliente {user.Name}, criado com sucesso!");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) { Console.WriteLine("Ocorreu um erro, pro favor tente novamente mais tarde"); }
        }

        public static void ExibirTodosOsPerfies()
        {
            Console.WriteLine($"\nTotal de usuários: {UsersList.Count}");
            foreach (var user in UsersList)
            {
                Console.WriteLine("\n============================================================\n\n");

                UserConsoleUI.ExibirPerfil(user);

                Console.WriteLine("\n\n============================================================\n");
            }
        }

        public static void ExibirTodosOsVendedores()
        {
            Console.WriteLine($"\nTotal de usuários: {UsersList.Count}");
            foreach (var user in UsersList)
            {
                if (user is Vendedor)
                {
                    Console.WriteLine("\n============================================================\n\n");

                    UserConsoleUI.ExibirPerfil(user);

                    Console.WriteLine("\n\n============================================================\n");
                }
            }
        }

        public static void ExibirTodosOsClientes()
        {
            Console.WriteLine($"\nTotal de usuários: {UsersList.Count}");
            foreach (var user in UsersList)
            {
                if(user is Cliente) 
                {
                    Console.WriteLine("\n============================================================\n\n");

                    UserConsoleUI.ExibirPerfil(user);

                    Console.WriteLine("\n\n============================================================\n");
                }
            }
        }
    }
}
