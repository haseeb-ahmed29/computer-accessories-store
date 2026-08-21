using Microsoft.EntityFrameworkCore;
using ComputerAccessoriesStore.Models;

namespace ComputerAccessoriesStore.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();
 public DbSet<Category> Categorys => Set<Category>();
 public DbSet<Order> Orders => Set<Order>();
}
