namespace Goru.Areas.AdminPanel.Models.Order;

public class CreateOrderVM
{
    // TODO: ДОбавить комментарии во все модельки
    
    /// <summary>
    /// Артикль товара
    /// </summary>
    public int Article { get; set; }
    
    public string Name { get; set; }
    
    public int Price { get; set; }
    
    public string Size { get; set; }
    
    public float Offer { get; set; }
    
    public string Category { get; set; }
}