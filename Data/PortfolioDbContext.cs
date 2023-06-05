using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio
{
  public class PortfolioDbContext : DbContext{
    public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options): base(options){

    }

    public DbSet<Project> Projects{get; set;}
  }
    
}
