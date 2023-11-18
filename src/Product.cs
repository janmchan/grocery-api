namespace grocery_backend;

public class Product
{
    public Product(int id, string productName, string productDescription = null)
    {
        Id = id;
        ProductName = productName;
        ProductDescription = productDescription;
    }
    public int Id { get; set; }

    public string ProductName { get; set; }

    public string? ProductDescription { get; set; }
}
