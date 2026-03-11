using System.ComponentModel.DataAnnotations;

namespace ProductsApi.Models;

public class UpdateProductRequest
{
    [Required(ErrorMessage = "Укажите название товара")]
    [StringLength(200, MinimumLength = 1)]
    public string Name { get; set; } = string.Empty;

    [StringLength(50)]
    public string? Category { get; set; }

    [Range(0.01, 1000000)]
    public decimal Price { get; set; }
}
