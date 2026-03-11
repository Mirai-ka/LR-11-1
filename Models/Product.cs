namespace ProductsApi.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;  // Новое поле по заданию
    public decimal Price { get; set; }
    public DateTime CreatedAt { get; set; }  // Дополнительное поле
}
