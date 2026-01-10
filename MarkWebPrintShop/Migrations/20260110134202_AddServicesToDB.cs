using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarkWebPrintShop.Migrations
{
    /// <inheritdoc />
    public partial class AddServicesToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "services",
                columns: table => new
                {
                    service_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    service_name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    is_available = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_services", x => x.service_id);
                });

            migrationBuilder.InsertData(
                table: "services",
                columns: new[] { "service_id", "description", "is_available", "service_name" },
                values: new object[,]
                {
                    { 1, "We handle all print jobs, from personal assignments and government requirements to corporate documents, accepting only PDF and Word file formats. Simply upload your documents to our portal, select your printing options, and pick up your crisp, clear prints at your convenience.", true, "Document Printing" },
                    { 2, "Our high-speed photocopy services specialize in handling sensitive official documents, including all government and corporate requirements. We guarantee crisp, compliant reproductions on demand, with bulk services available for large volume needs.", true, "Photo Copy/Xerox" },
                    { 3, "Develop photos straight from your smartphone in minutes using our seamless online photo portal. We offer a range of sizes and finishes to ensure your digital memories are captured with exceptional color clarity and quality.", true, "Photo Develop" },
                    { 4, "We provide fast and accurate printing services for government and corporate ID photos, offering common dimensions like 1x1, 2x2, and passport sizes. Upload your image to receive a perfectly sized sheet of photos that meet all official specifications.", true, "Photo ID" },
                    { 5, "We offer secure plastic lamination services ideal for government IDs, licenses, and official documents that require protection. Ensure your essential paperwork is sealed, secure, and resilient against spills or bending.", true, "Lamination" },
                    { 6, "We offer plastic lamination services ideal for government IDs, licenses, and official documents that require protection. Ensure your essential paperwork is sealed, secure, and resilient against spills or bending.", true, "Lamination" },
                    { 7, "Land your next job with a professional, tailored resume or Curriculum Vitae (CV) created by our experts. We design clean, impactful documents that highlight your experience and help you stand out to employers.", true, "Resume Writing Services" },
                    { 8, "Utilize our graphic design expertise for all your digital needs, creating professional logos, infographics, and custom graphics using the Canva platform. We bring your vision to life with modern, engaging designs tailored specifically for your brand or project.", true, "Graphic Design Services" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "services");
        }
    }
}
