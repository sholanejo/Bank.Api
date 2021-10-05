using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private oddbContext _oddbContext;

        private IAspNetUserRepository _aspNetUserRepository;
        private IAccountRepository _account;

        public RepositoryManager(oddbContext OddbContext)
        {
            _oddbContext = OddbContext;
        }
        public IAspNetUserRepository AspNetUser
        {
            get
            {
                if (_aspNetUserRepository == null)
                    _aspNetUserRepository = new AspNetUserRepository(_oddbContext);
                return _aspNetUserRepository;
            }
        }

        public IAccountRepository Account
        {
            get
            {
                if (_account == null)
                    _account = new AccountRepository(_oddbContext);
                return _account;
            }
        }

        public void Save() => _oddbContext.SaveChanges();
        
    }
}
