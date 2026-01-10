
using MarkWebPrintShop.Models;
using Microsoft.EntityFrameworkCore;
namespace MarkWebPrintShop.Data;
public class ApplicationDBContext:DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
    {
    }
    public DbSet<Service> Services {get; set;}
}
