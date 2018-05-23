using Microsoft.EntityFrameworkCore;
using Qufin.Api.Models;

namespace Qufin.Api.Data
{
    public class BudgetContext : DbContext
    {
        public BudgetContext(DbContextOptions options) : base(options)
        {
        }

        // ReSharper disable once UnusedMember.Global IN DEV
        public DbSet<Account> Accounts { get; set; }

        // ReSharper disable once UnusedMember.Global IN DEV
        public DbSet<BudgetCategory> Categories { get; set; }

        // ReSharper disable once UnusedMember.Global IN DEV
        public DbSet<Transaction> Transactions { get; set; }
    }
}
