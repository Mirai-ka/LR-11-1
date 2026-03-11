using System.ComponentModel.DataAnnotations;

namespace ProductsApi.Models;

public class CreateProductRequest
{
    [Required(ErrorMessage = "Укажите название товара")]
    [StringLength(200, MinimumLength = 1, ErrorMessage = "Название от 1 до 200 символов")]
    public string Name { get; set; } = string.Empty;

    [StringLength(50, ErrorMessage = "Категория до 50 символов")]
    public string? Category { get; set; }

    [Range(0.01, 1000000, ErrorMessage = "Цена должна быть от 0.01 до 1 000 000")]
    public decimal Price { get; set; }
}
