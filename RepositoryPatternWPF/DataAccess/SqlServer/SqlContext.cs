using RepositoryPatternWPF.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWPF.DataAccess.SqlServer
{
    public class SqlContext
    {
        public IUnitOfWork UnitOfWork { get; set; }

        public SqlContext(IUnitOfWork unitOfWork)
        {

        }
    }
}
