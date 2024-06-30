namespace Goru.Areas.AdminPanel.Models;

public class OrdersVm
{
    public List<Order> Orders { get; set; } = new ();
    
    public int Limit { get; set; }
}