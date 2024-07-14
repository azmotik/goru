namespace Goru.Areas.AdminPanel.Models
{
    public class OrdersVm
    {
        public List<Order> Orders = new();
        
        public int Limit { get; set; }
    }
}