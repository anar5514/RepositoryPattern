using RepositoryPatternWPF.Domain.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWPF.Domain.Abstractions
{
    public interface IUserRepository
    {
        void Add(int id);
        List<User> GetUsers();
        User GetUser();
    }
}
