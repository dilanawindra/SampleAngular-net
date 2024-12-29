using Microsoft.EntityFrameworkCore;
using MyApi.Entities;

namespace MyApi.Data;


public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}
    
