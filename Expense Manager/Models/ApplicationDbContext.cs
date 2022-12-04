using Microsoft.EntityFrameworkCore;

namespace Expense_Manager.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options) { }

        public DbSet<Transaction> Transactios { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
