using System;
using System.Collections.Generic;
using System.Text;

namespace mercado_tech.classes
{
    internal class Vendedor : User
    {
        public string Cnpj {  get; private set; }
        public Vendedor(string name, string userName, string password, string email, string cnpj) 
            : base(name, userName, password, email)
        {

        }
    }
}
