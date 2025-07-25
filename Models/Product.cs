namespace CrudMaster.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty; // <-- avoids null warning
    public decimal Price { get; set; }
}
