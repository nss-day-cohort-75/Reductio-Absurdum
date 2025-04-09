public class Product
{
    public string Name
    {
        get; set;
    }
    public decimal Price
    {
        get; set;
    }
    public bool Avaiable
    {
        get; set;
    }
    public DateTime DaysOnShelf
    {
        get; set;
    }
    public string ProductTypeId
    {
        get; set;
    }
}

public class ProductType
{
    public int Id
    {
        get; set;
    }
    public string Name
    {
        get; set;
    }
}
