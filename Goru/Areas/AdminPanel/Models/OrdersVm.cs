namespace Goru.Areas.AdminPanel.Models
{
    public class OrdersVm
    {
        public List<Order> Orders = new();
        
        public Pagination Pagination = new();
        
        public string Searching { get; set; }
    }
}