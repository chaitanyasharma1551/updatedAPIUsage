using Microsoft.EntityFrameworkCore;
using API_Usage.Models;

namespace API_Usage.DataAccess
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Company> Companies { get; set; }
    public DbSet<Equity> Equities { get; set; }
    public DbSet<market> Market { get; set; }
    public DbSet<shortinterest> NewShortInterest { get; set; }
    public DbSet<dividends> Dividends { get; set; }
    public DbSet<history> History { get; set; }
    public DbSet<mktperformance> NewPerformance { get; set; }
    }
}