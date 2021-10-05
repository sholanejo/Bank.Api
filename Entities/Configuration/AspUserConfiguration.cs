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
    public class AspUserConfiguration : IEntityTypeConfiguration<AspNetUser>
    {
        public void Configure(EntityTypeBuilder<AspNetUser> builder)
        {
            builder.HasData
                (
                new AspNetUser
                {
                    Id = "80abbca8-664d-4b20-b5de-024705497d4a",
                    Email = "sholanejo@live.com",
                    AccountId = "c9d4c053-49b6-410c-bc78-2d54a9991870",
                },
                 new AspNetUser
                 {
                     Id = "86dba8c0-d178-41e7-938c-ed49778fb52a",
                     Email = "kanyewest@live.com",
                     AccountId = "3d490a70-94ce-4d15-9494-5248280c2ce3",
                 }
                 );
        }
    }
}
