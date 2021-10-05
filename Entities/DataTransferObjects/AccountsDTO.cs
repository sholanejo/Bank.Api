using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class AccountsDTO
    {
        public string Id { get; set; }
        public string AccountBalance { get; set; }
        public string AccountType { get; set; }
        public string CreatedBy { get; set; }
    }
}
