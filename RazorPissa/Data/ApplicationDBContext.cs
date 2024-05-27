using Microsoft.EntityFrameworkCore;
using RazorPissa.Models;

namespace RazorPissa.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options) 
            :base(options)
        {

        }
    }
}
