using e_Restaurant.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace e_Restaurant.DAL.Configurations;

public class DbContextApp : DbContext
{
    public DbContextApp(DbContextOptions<DbContextApp> options)
            : base(options)
    {

    }
    public DbSet<User> Users { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Food> Foods { get; set; }
    public DbSet<SoldFood> SoldFoods { get; set; }
}