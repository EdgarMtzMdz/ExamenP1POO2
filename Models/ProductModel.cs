namespace ExamenParcial1POO2;

public class ProductModel : EntityBase
{
    public ProductModel()
    {
    }

    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public DateTime LastMovement { get; set; }
    
}