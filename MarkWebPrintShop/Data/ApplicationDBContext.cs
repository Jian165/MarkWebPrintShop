
using MarkWebPrintShop.Models;
using Microsoft.EntityFrameworkCore;
namespace MarkWebPrintShop.Data;
public class ApplicationDBContext:DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
    {
    }
    public DbSet<Service> Services {get; set;}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Service>().HasData(
                new Service
                {
                    ServiceId = 1,
                    ServiceName = "Document Printing",
                    Description = "We handle all print jobs, from personal assignments and government requirements to corporate documents, accepting only PDF and Word file formats. Simply upload your documents to our portal, select your printing options, and pick up your crisp, clear prints at your convenience.",
                    IsAvailable = true
                },

                new Service
                {
                    ServiceId = 2,
                    ServiceName = "Photo Copy/Xerox",
                    Description = "Our high-speed photocopy services specialize in handling sensitive official documents, including all government and corporate requirements. We guarantee crisp, compliant reproductions on demand, with bulk services available for large volume needs.",
                    IsAvailable = true
                },

                new Service
                {
                    ServiceId = 3,
                    ServiceName = "Photo Develop",
                    Description = "Develop photos straight from your smartphone in minutes using our seamless online photo portal. We offer a range of sizes and finishes to ensure your digital memories are captured with exceptional color clarity and quality.",
                    IsAvailable = true
                },

                new Service
                {
                    ServiceId = 4,
                    ServiceName = "Photo ID",
                    Description = "We provide fast and accurate printing services for government and corporate ID photos, offering common dimensions like 1x1, 2x2, and passport sizes. Upload your image to receive a perfectly sized sheet of photos that meet all official specifications.",
                    IsAvailable = true
                },

                new Service
                {
                    ServiceId = 5,
                    ServiceName = "Lamination",
                    Description = "We offer secure plastic lamination services ideal for government IDs, licenses, and official documents that require protection. Ensure your essential paperwork is sealed, secure, and resilient against spills or bending.",
                    IsAvailable = true
                },

                new Service
                {
                    ServiceId = 6,
                    ServiceName = "Lamination",
                    Description = "We offer plastic lamination services ideal for government IDs, licenses, and official documents that require protection. Ensure your essential paperwork is sealed, secure, and resilient against spills or bending.",
                    IsAvailable = true
                },

                new Service
                {
                    ServiceId = 7,
                    ServiceName = "Resume Writing Services",
                    Description = "Land your next job with a professional, tailored resume or Curriculum Vitae (CV) created by our experts. We design clean, impactful documents that highlight your experience and help you stand out to employers.",
                    IsAvailable = true
                },

                new Service
                {
                    ServiceId = 8,
                    ServiceName = "Graphic Design Services",
                    Description = "Utilize our graphic design expertise for all your digital needs, creating professional logos, infographics, and custom graphics using the Canva platform. We bring your vision to life with modern, engaging designs tailored specifically for your brand or project.",
                    IsAvailable = true
                }
        );
    }
    
}
