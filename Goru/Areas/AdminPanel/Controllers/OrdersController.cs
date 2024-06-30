namespace Goru.Areas.AdminPanel.Controllers;
using Microsoft.AspNetCore.Mvc;
using Goru.Areas.AdminPanel.Models;

[Area("AdminPanel")]
public class OrdersController : Controller
{
    
    private List<Order> orders = new List<Order>()
    {
        new Order() { Name = "Gaming Headset", Price = 42, Size="XS", Offer = 10, Category = "Headphones"},
        new Order() { Name = "VRBOX Gaming", Price = 410, Size="XS", Offer = 15, Category = "VR"},
        new Order() { Name = "Gaming Mouse", Price = 20, Size="XR", Offer = 10, Category = "Gaming Mouses"},
        new Order() { Name = "Gaming Controller", Price = 25, Size="XR", Offer = 10, Category = "Gamepads"},
        new Order() { Name = "Gaming Headset", Price = 45, Size="XS", Offer = 10, Category = "Headphones"},
        new Order() { Name = "Wireless Headset", Price = 40, Size="XS", Offer = 0, Category = "Headphones"},
        new Order() { Name = "Gaming Controller", Price = 45, Size="XR", Offer = 10, Category = "Gamepads"},
        new Order() { Name = "Camera Lens", Price = 300, Size="XR", Offer = 15, Category = "Cameras"},
        new Order() { Name = "LED TV", Price = 1099, Size="XM", Offer = 20, Category = "TVs"},
        new Order() { Name = "Wireless Headset", Price = 52, Size="XS", Offer = 0, Category = "Headphones"},
        new Order() { Name = "Black Drone", Price = 200, Size="XS", Offer = 15, Category = "Drones"},
        new Order() { Name = "Bluetooth Earphones", Price = 50, Size="X", Offer = 10, Category = "Headphones"}
    };
    
    public IActionResult Index()
    {
        return View();
    }
    
}