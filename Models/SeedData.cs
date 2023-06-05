using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Portfolio;
using System;
using System.Linq;

namespace Portfolio.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new PortfolioDbContext(serviceProvider.GetRequiredService<DbContextOptions<PortfolioDbContext>>()))
        {
            context.Add(new Project{Name = "Asp project"});
            context.SaveChanges();
        }
    }
}