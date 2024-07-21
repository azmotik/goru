namespace Goru.Areas.AdminPanel.Models
{
    public class OrdersVm
    {
        public List<global::Order> Orders = new();
        
        public Pagination Pagination = new();
        
        public string Searching { get; set; }
    }
}