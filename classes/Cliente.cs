using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace mercado_tech.classes
{
    public class Cliente : User
    {
        public string CPF {  get; private set; }

        public Cliente(string name, string userName, string password, string email, string cpf) 
            : base(name, userName, password, email)
        {
            if (!SetCpf(cpf))
            {
                throw new ArgumentException("Não foi possivel criar o Usuario: o seu cpf nao é valido");
            }
        }

        public bool SetCpf(string cpf)
        {
            if(ValidateInfoUser.CPFisValid(cpf))
            {
                this.CPF = cpf;
                return true;
            } 
            return false;
        }

        public override void ExibirDadosAdiconaisdoPerfil()
        {
            Console.WriteLine($"CNPJ: {this.CPF}");
        }
    }
}
