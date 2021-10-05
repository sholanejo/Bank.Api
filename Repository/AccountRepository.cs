using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AccountRepository : RepositoryBase<Account> , IAccountRepository
    {
        public AccountRepository(oddbContext repositorycontext) : base(repositorycontext)
        {

        }

        public IEnumerable<Account> GetAccounts(string UserId, bool trackChanges) =>
            FindByCondition(a => a.Id.Equals(UserId), trackChanges)
            .OrderBy(b => b.Balance);
    }
}
