using System;
using Microsoft.EntityFrameworkCore;

namespace cSharpWebAP.Database
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Entities.Test> TestRecords { get; set; }
  }
}
