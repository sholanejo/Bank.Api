using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime Birthday { get; set; }
        public int Gender { get; set; }
        public string AccountId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Account Account { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
