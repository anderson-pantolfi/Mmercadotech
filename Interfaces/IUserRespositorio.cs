using mercado_tech.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace mercado_tech.Interfaces
{
    public interface IUserRespositorio
    {
        void Add(User user);
        IEnumerable<User> GetAll();
    }
}
