using RepositoryPatternWPF.Domain.Abstractions;
using RepositoryPatternWPF.Domain.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWPF.DataAccess.SqlServer
{
    public class SqlSaleRepository : ISaleRepository
    {
        public void Add(int id)
        {
            throw new NotImplementedException();
        }

        public Sale GetSale()
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetSales()
        {
            throw new NotImplementedException();
        }
    }
}
