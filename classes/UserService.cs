using System.Linq;
using mercado_tech.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;

namespace mercado_tech.classes
{
    public class UserService
    {
        private readonly IUserRespositorio _RepositoriodeUsers;

        public UserService(IUserRespositorio repositoriodeUsers) 
        { 
            _RepositoriodeUsers = repositoriodeUsers;
        }

        public User CriarVendedor(string name, string username, string password, string email, string cnpj)
        {
            User Vendedor = new Vendedor(name, username, password, email, cnpj);
            _RepositoriodeUsers.Add(Vendedor);
            return Vendedor;
        }

        public User CriarCliente(string name, string username, string password, string email, string cpf)
        {
            User cliente = new Cliente(name, username, password, email, cpf);
            _RepositoriodeUsers.Add(cliente);
            return cliente;
        }

        public IEnumerable<User> ObterTodosUser() => _RepositoriodeUsers.GetAll();

        public IEnumerable<User> ObterTodosVendedor() => _RepositoriodeUsers.GetAll().OfType<Vendedor>();

        public IEnumerable<User> ObterTodosClintes() => _RepositoriodeUsers.GetAll().OfType<Cliente>();
    }
}
