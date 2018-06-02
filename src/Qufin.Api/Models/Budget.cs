using System;
using System.Diagnostics.CodeAnalysis;

namespace Qufin.Api.Models
{
    [Serializable]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public sealed class Budget
    {
        public Guid Id { get; set; }
        
        public User Owner { get; set; }
        
        public Account[] Accounts { get; set; }
        
        public BudgetCategory[] Categories { get; set; }
        
        public Transaction[] Transactions { get; set; }
    }
}