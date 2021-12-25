namespace Infrastructur.Data;

using Core.Entities;
using Microsoft.EntityFrameworkCore;

public class StorContext : DbContext
{
    public StorContext(DbContextOptions<StorContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

}
