using System.ComponentModel.DataAnnotations;

namespace MarkWebPrintShop.Models;
public class Service
{
    [Key]
    public int ServiceId { get; set; }

    [Required]
    public string ServiceName { get; set; } = string.Empty;

    [DataType(DataType.MultilineText)]
    public string Description { get; set; } = string.Empty;

    public bool IsAvailable { get; set; }
}