using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int TransactionMode { get; set; }
        public int TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool IsSuccessful { get; set; }
        public string SenderAccount { get; set; }
        public string ReceiverAccount { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
