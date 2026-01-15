using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MarkWebPrintShop.Models;
public class Service
{
    [Key]
    public int ServiceId { get; set; }

    [Required]
    [StringLength(50,MinimumLength = 5, ErrorMessage = "Must be between 5 and 50 characters.")]
    [DisplayName("Service Name")]
    public string ServiceName { get; set; }

    [StringLength(200,MinimumLength = 50, ErrorMessage = "Must be between 8 and 100 characters.")]
    [DataType(DataType.MultilineText)]
    public string Description { get; set; }

    public bool IsAvailable { get; set; }
}