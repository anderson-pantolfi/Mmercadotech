using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace mercado_tech.classes
{
    public abstract class User
    {
        public int Id { get; protected set; }
        public string Name { get; private set; }
        public string UserName { get; private set; }
        protected string Password { get;private set; }
        public string Email { get; private set; }
        public mercado_tech.Enum.StatusPerfil Status { get; private set; } = mercado_tech.Enum.StatusPerfil.Ativo;


        public User(string name, string userName, string password, string email)
        {
            if (!SetName(name))
            {
                throw new ArgumentException("Não foi possivel criar o Usuario: Este Nome nao é valido , Nome não pode ser nulo e tem que ser maior que 10");
            }

            if (!SetUsername(userName))
            {
                throw new ArgumentException("Não foi possivel criar o usuario: nome de usario nao pode ser nulo");
            }


            if (!SetPassword(password)) 
            {
                throw new ArgumentException("Não foi possivel criar o Usuario, senha não atende os requistos minimos");
            }


            if (!SetEmail(email)) {
                throw new ArgumentException("Não foi possivel criar o Usuario: Este email é invalido por favor digite um emial valido");
            }
        }

        public abstract void ExibirDadosAdiconaisdoPerfil();

        public bool SetEmail(string email)
        {
            if (ValidateInfoUser.EmailIsvalid(email)) 
            {
                this.Email = email;
                return true;
            }
            return false;
        }

        public bool SetName(string name) 
        {
            if (ValidateInfoUser.Nameisvalid(name))
            {
                this.Name = name;
                return true;
            }
            return false;
        }

        public bool SetPassword(string password) 
        {
            if (ValidateInfoUser.Passwordisvalid(password))
            {
                this.Password = password;
                return true;
            }
            return false;
        }

        public bool VerificarSenha(string password)
        {
            return this.Password == password;
        }

        public bool AlterarSenha(string oldPassword , string newPassword)
        {
            if (VerificarSenha(oldPassword))
            {
                return SetPassword(newPassword);
            }
            return false;
        }


        public bool SetUsername( string username)
        {
            if (ValidateInfoUser.Usernameisvalid(username))
            {
                this.UserName = username;
                return true;
            }
            return false;
        }

        public void SuspenderConta()
        {
            this.Status = mercado_tech.Enum.StatusPerfil.Suspenso;
        }

        public void AtivarConta()
        {
            this.Status = mercado_tech.Enum.StatusPerfil.Ativo;
        }
    }
}
