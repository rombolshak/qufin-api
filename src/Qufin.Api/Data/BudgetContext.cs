using Microsoft.EntityFrameworkCore;
using Qufin.Api.Models;

namespace Qufin.Api.Data
{
    public class BudgetContext : DbContext
    {
        public BudgetContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<BudgetCategory> Categories { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
