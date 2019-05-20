using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWPF.Domain.Abstractions
{
    public interface IUnitOfWork
    {
        void SaveChanges();


        IProductRepository ProductRepository { get; }
        IUserRepository UserRepository { get; }
        ISaleRepository SaleRepository { get; }
    }
}
