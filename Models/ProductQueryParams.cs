namespace ProductsApi.Models;

public class ProductQueryParams
{
    public decimal? MinPrice { get; set; }
    public decimal? MaxPrice { get; set; }
    public string? Category { get; set; }
    public string? SortBy { get; set; }  // price или name
    public string? SortOrder { get; set; } = "asc";
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}
