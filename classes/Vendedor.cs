using System;
using System.Collections.Generic;
using System.Text;

namespace mercado_tech.classes
{
    public class Vendedor : User
    {
        public string Cnpj {  get; private set; }
        public Vendedor(string name, string userName, string password, string email, string cnpj) 
            : base(name, userName, password, email)
        {
            if (!SetCnpj(cnpj))
            {
                throw new ArgumentException("Não foi possivel criar o Usuario: o seu cnpj nao é valido");
            }
        }

        public bool SetCnpj(string cnpj)
        {
            if (ValidateInfoUser.CNPJisValid(cnpj)) { 
                this.Cnpj = cnpj;
                return true;
            }
            return false;
        }

        public override void ExibirDadosAdiconaisdoPerfil()
        {
            Console.WriteLine($"CNPJ: {this.Cnpj}");
        }
    }
}
