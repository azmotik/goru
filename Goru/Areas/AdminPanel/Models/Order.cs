using System.ComponentModel.DataAnnotations;

public class Order
{
    public int Article { get; set; }
    
    public string Name { get; set; }
    
    public int Price { get; set; }
    
    public string Size { get; set; }
    
    public float Offer { get; set; }
    
    public string Category { get; set; }
}

