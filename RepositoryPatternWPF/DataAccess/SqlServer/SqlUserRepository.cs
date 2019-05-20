using RepositoryPatternWPF.Domain.Abstractions;
using RepositoryPatternWPF.Domain.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWPF.DataAccess.SqlServer
{
    public class SqlUserRepository : IUserRepository
    {
        public void Add(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUser()
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
