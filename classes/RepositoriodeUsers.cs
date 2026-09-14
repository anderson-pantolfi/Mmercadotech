using mercado_tech.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace mercado_tech.classes
{
    public class RepositoriodeUsers : IUserRespositorio
    {
        private readonly List<User> _UsersList = new List<User>();

        public void Add(User user)
        {
            _UsersList.Add(user);
        }

        public IEnumerable<User> GetAll()
        {
            return _UsersList;
        }
    }
}
