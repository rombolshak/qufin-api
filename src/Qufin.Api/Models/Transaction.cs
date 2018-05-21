using System;
using System.Diagnostics.CodeAnalysis;

namespace Qufin.Api.Models
{
    [Serializable]
    [SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "IN DEV")]
    public class Transaction
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public Account Account { get; set; }

        public BudgetCategory Category { get; set; }

        public decimal Amount { get; set; }

        public string Comment { get; set; }
    }
}
