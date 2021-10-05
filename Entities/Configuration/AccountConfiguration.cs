using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasData
                (
                new Account
                {
                    AccountNumber = "123456789",
                    Balance = 123456987,
                    Id = "c9d4c053-49b6-410c-bc78-2d54a9991870"
                    
                },
                 new Account
                 {
                     AccountNumber = "123456589",
                     Balance = 123456987,
                     Id = "3d490a70-94ce-4d15-9494-5248280c2ce3"
                 }
                 );
        }
    }
}
