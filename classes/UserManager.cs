using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace mercado_tech.classes
{
    public class UserManager
    {

        private readonly UserService _Userservice;

        public UserManager(UserService userService)
        {
            this._Userservice = userService;
        }

        public void CadastrarVendedor()
        {
            Console.WriteLine("Cadastrando um novo Vendedor \n\n\n");
            string Name = UserConsoleUI.LerNome();
            string Username = UserConsoleUI.LerUserName();
            string Password = UserConsoleUI.LerSenha();
            string Email = UserConsoleUI.LerEmail();
            string Cnpj = UserConsoleUI.LerCNPJ();

            try
            {
                var user = _Userservice.CriarVendedor(Name, Username, Password, Email, Cnpj);
                Console.WriteLine($"\n[SUCESSO] Vendedor {user.Name}, criado com sucesso!");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) { Console.WriteLine("Ocorreu um erro, pro favor tente novamente mais tarde"); }
        }

        public void CadastrarCliente()
        {
            Console.WriteLine("Cadastrando um novo Vendedor \n\n\n");
            string Name = UserConsoleUI.LerNome();
            string Username = UserConsoleUI.LerUserName();
            string Password = UserConsoleUI.LerSenha();
            string Email = UserConsoleUI.LerEmail();
            string Cpf = UserConsoleUI.LerCpf();

            try
            {
                var user = _Userservice.CriarCliente(Name, Username, Password, Email, Cpf);
                Console.WriteLine($"\n[SUCESSO] Cliente {user.Name}, criado com sucesso!");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) { Console.WriteLine("Ocorreu um erro, por favor tente novamente mais tarde"); }
        }

        public void ExibirTodosOsPerfies()
        {
            var UsersList = _Userservice.ObterTodosUser();
            Console.WriteLine($"\nTotal de usuários: {UsersList.Count()}");
            foreach (var user in UsersList)
            {
                Console.WriteLine("\n============================================================\n\n");

                UserConsoleUI.ExibirPerfil(user);

                Console.WriteLine("\n\n============================================================\n");
            }
        }

        public void ExibirTodosOsVendedores()
        {
            var UsersList = _Userservice.ObterTodosVendedor();
            Console.WriteLine($"\nTotal de usuários: {UsersList.Count()}");
            foreach (var user in UsersList)
            {
                    Console.WriteLine("\n============================================================\n\n");

                    UserConsoleUI.ExibirPerfil(user);

                    Console.WriteLine("\n\n============================================================\n");
            }
        }

        public void ExibirTodosOsClientes()
        {
            var UsersList = _Userservice.ObterTodosClintes();
            Console.WriteLine($"\nTotal de usuários: {UsersList.Count()}");
            foreach (var user in UsersList)
            {
                    Console.WriteLine("\n============================================================\n\n");

                    UserConsoleUI.ExibirPerfil(user);

                    Console.WriteLine("\n\n============================================================\n");
            }
        }
    }
}
