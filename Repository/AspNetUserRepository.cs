using Contracts;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class AspNetUserRepository : RepositoryBase<AspNetUser>, IAspNetUserRepository
    {
        public AspNetUserRepository(oddbContext OddbContext) : base(OddbContext)
        {

        }
        public IEnumerable<AspNetUser> GetAspNetUsers(bool trackChanges) =>
                FindAll(trackChanges)
                .OrderBy(c => c.FullName)
                .ToList();
    }
}
