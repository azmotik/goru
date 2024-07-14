using Microsoft.AspNetCore.Mvc;
using Goru.Areas.AdminPanel.Models;

namespace Goru.Areas.AdminPanel.Controllers
{
    
    [Area("AdminPanel")]
    public class OrdersController : Controller
    {
        private List<Order> Orders = new()
        {
            new Order() { Article = 47431, Name = "Gaming Headset", Price = 42, Size="XS", Offer = 10, Category = "Headphones"},
            new Order() { Article = 73656, Name = "VRBOX Gaming", Price = 410, Size="XS", Offer = 15, Category = "VR"},
            new Order() { Article = 16857, Name = "Gaming Mouse", Price = 20, Size="XR", Offer = 10, Category = "Gaming Mouses"},
            new Order() { Article = 34939, Name = "Gaming Controller", Price = 25, Size="XR", Offer = 10, Category = "Gamepads"},
            new Order() { Article = 27614, Name = "Gaming Headset", Price = 45, Size="XS", Offer = 10, Category = "Headphones"},
            new Order() { Article = 19898, Name = "Wireless Headset", Price = 40, Size="XS", Offer = 0, Category = "Headphones"},
            new Order() { Article = 11998, Name = "Gaming Controller", Price = 45, Size="XR", Offer = 10, Category = "Gamepads"},
            new Order() { Article = 75638, Name = "Camera Lens", Price = 300, Size="XR", Offer = 15, Category = "Cameras"},
            new Order() { Article = 81358, Name = "LED TV", Price = 1099, Size="XM", Offer = 20, Category = "TVs"},
            new Order() { Article = 82332, Name = "Wireless Headset", Price = 52, Size="XS", Offer = 0, Category = "Headphones"},
            new Order() { Article = 18475, Name = "Black Drone", Price = 200, Size="XS", Offer = 15, Category = "Drones"},
            new Order() { Article = 12793, Name = "Bluetooth Earphones", Price = 50, Size="X", Offer = 10, Category = "Headphones"},
            new Order() { Article = 23979, Name = "Gaming Headset", Price = 42, Size="XS", Offer = 10, Category = "Headphones"},
            new Order() { Article = 52112, Name = "VRBOX Gaming", Price = 410, Size="XS", Offer = 15, Category = "VR"},
            new Order() { Article = 49368, Name = "Gaming Mouse", Price = 20, Size="XR", Offer = 10, Category = "Gaming Mouses"},
            new Order() { Article = 88867, Name = "Gaming Controller", Price = 25, Size="XR", Offer = 10, Category = "Gamepads"},
            new Order() { Article = 13617, Name = "Gaming Headset", Price = 45, Size="XS", Offer = 10, Category = "Headphones"},
            new Order() { Article = 17541, Name = "Wireless Headset", Price = 40, Size="XS", Offer = 0, Category = "Headphones"},
            new Order() { Article = 31991, Name = "Gaming Controller", Price = 45, Size="XR", Offer = 10, Category = "Gamepads"},
            new Order() { Article = 51766, Name = "Camera Lens", Price = 300, Size="XR", Offer = 15, Category = "Cameras"},
            new Order() { Article = 55644, Name = "LED TV", Price = 1099, Size="XM", Offer = 20, Category = "TVs"},
            new Order() { Article = 39943, Name = "Wireless Headset", Price = 52, Size="XS", Offer = 0, Category = "Headphones"},
            new Order() { Article = 78496, Name = "Black Drone", Price = 200, Size="XS", Offer = 15, Category = "Drones"},
            new Order() { Article = 78571, Name = "Bluetooth Earphones", Price = 50, Size="X", Offer = 10, Category = "Headphones"},
            new Order() { Article = 57686, Name = "Gaming Headset", Price = 42, Size="XS", Offer = 10, Category = "Headphones"},
            new Order() { Article = 52493, Name = "VRBOX Gaming", Price = 410, Size="XS", Offer = 15, Category = "VR"},
            new Order() { Article = 71574, Name = "Gaming Mouse", Price = 20, Size="XR", Offer = 10, Category = "Gaming Mouses"},
            new Order() { Article = 98461, Name = "Gaming Controller", Price = 25, Size="XR", Offer = 10, Category = "Gamepads"},
            new Order() { Article = 16711, Name = "Gaming Headset", Price = 45, Size="XS", Offer = 10, Category = "Headphones"},
            new Order() { Article = 35837, Name = "Wireless Headset", Price = 40, Size="XS", Offer = 0, Category = "Headphones"},
            new Order() { Article = 84864, Name = "Gaming Controller", Price = 45, Size="XR", Offer = 10, Category = "Gamepads"},
            new Order() { Article = 51125, Name = "Camera Lens", Price = 300, Size="XR", Offer = 15, Category = "Cameras"},
            new Order() { Article = 95915, Name = "LED TV", Price = 1099, Size="XM", Offer = 20, Category = "TVs"},
            new Order() { Article = 74738, Name = "Wireless Headset", Price = 52, Size="XS", Offer = 0, Category = "Headphones"},
            new Order() { Article = 99448, Name = "Black Drone", Price = 200, Size="XS", Offer = 15, Category = "Drones"},
            new Order() { Article = 76174, Name = "Bluetooth Earphones", Price = 50, Size="X", Offer = 10, Category = "Headphones"},
            new Order() { Article = 19526, Name = "Gaming Headset", Price = 42, Size="XS", Offer = 10, Category = "Headphones"},
            new Order() { Article = 22961, Name = "VRBOX Gaming", Price = 410, Size="XS", Offer = 15, Category = "VR"},
            new Order() { Article = 51745, Name = "Gaming Mouse", Price = 20, Size="XR", Offer = 10, Category = "Gaming Mouses"},
            new Order() { Article = 86713, Name = "Gaming Controller", Price = 25, Size="XR", Offer = 10, Category = "Gamepads"},
            new Order() { Article = 64481, Name = "Gaming Headset", Price = 45, Size="XS", Offer = 10, Category = "Headphones"},
            new Order() { Article = 65151, Name = "Wireless Headset", Price = 40, Size="XS", Offer = 0, Category = "Headphones"},
            new Order() { Article = 85934, Name = "Gaming Controller", Price = 45, Size="XR", Offer = 10, Category = "Gamepads"},
            new Order() { Article = 69154, Name = "Camera Lens", Price = 300, Size="XR", Offer = 15, Category = "Cameras"},
            new Order() { Article = 34968, Name = "LED TV", Price = 1099, Size="XM", Offer = 20, Category = "TVs"},
            new Order() { Article = 56331, Name = "Wireless Headset", Price = 52, Size="XS", Offer = 0, Category = "Headphones"},
            new Order() { Article = 71315, Name = "Black Drone", Price = 200, Size="XS", Offer = 15, Category = "Drones"},
            new Order() { Article = 71187, Name = "Bluetooth Earphones", Price = 50, Size="X", Offer = 10, Category = "Headphones"},
            new Order() { Article = 36573, Name = "Gaming Headset", Price = 42, Size="XS", Offer = 10, Category = "Headphones"},
            new Order() { Article = 12244, Name = "VRBOX Gaming", Price = 410, Size="XS", Offer = 15, Category = "VR"},
            new Order() { Article = 21229, Name = "Gaming Mouse", Price = 20, Size="XR", Offer = 10, Category = "Gaming Mouses"},
            new Order() { Article = 53769, Name = "Gaming Controller", Price = 25, Size="XR", Offer = 10, Category = "Gamepads"},
            new Order() { Article = 12874, Name = "Gaming Headset", Price = 45, Size="XS", Offer = 10, Category = "Headphones"},
            new Order() { Article = 94514, Name = "Wireless Headset", Price = 40, Size="XS", Offer = 0, Category = "Headphones"},
            new Order() { Article = 44218, Name = "Gaming Controller", Price = 45, Size="XR", Offer = 10, Category = "Gamepads"},
            new Order() { Article = 22726, Name = "Camera Lens", Price = 300, Size="XR", Offer = 15, Category = "Cameras"},
            new Order() { Article = 33337, Name = "LED TV", Price = 1099, Size="XM", Offer = 20, Category = "TVs"},
            new Order() { Article = 13672, Name = "Wireless Headset", Price = 52, Size="XS", Offer = 0, Category = "Headphones"},
            new Order() { Article = 61311, Name = "Black Drone", Price = 200, Size="XS", Offer = 15, Category = "Drones"},
            new Order() { Article = 67895, Name = "Bluetooth Earphones", Price = 50, Size="X", Offer = 10, Category = "Headphones"},
            new Order() { Article = 15252, Name = "Gaming Headset", Price = 42, Size="XS", Offer = 10, Category = "Headphones"},
            new Order() { Article = 16364, Name = "VRBOX Gaming", Price = 410, Size="XS", Offer = 15, Category = "VR"},
            new Order() { Article = 67224, Name = "Gaming Mouse", Price = 20, Size="XR", Offer = 10, Category = "Gaming Mouses"},
            new Order() { Article = 51762, Name = "Gaming Controller", Price = 25, Size="XR", Offer = 10, Category = "Gamepads"},
            new Order() { Article = 27172, Name = "Gaming Headset", Price = 45, Size="XS", Offer = 10, Category = "Headphones"},
            new Order() { Article = 13454, Name = "Wireless Headset", Price = 40, Size="XS", Offer = 0, Category = "Headphones"},
            new Order() { Article = 59168, Name = "Gaming Controller", Price = 45, Size="XR", Offer = 10, Category = "Gamepads"},
            new Order() { Article = 24588, Name = "Camera Lens", Price = 300, Size="XR", Offer = 15, Category = "Cameras"},
            new Order() { Article = 36624, Name = "LED TV", Price = 1099, Size="XM", Offer = 20, Category = "TVs"},
            new Order() { Article = 72581, Name = "Wireless Headset", Price = 52, Size="XS", Offer = 0, Category = "Headphones"},
            new Order() { Article = 61592, Name = "Black Drone", Price = 200, Size="XS", Offer = 15, Category = "Drones"},
            new Order() { Article = 71253, Name = "Bluetooth Earphones", Price = 50, Size="X", Offer = 10, Category = "Headphones"},
            new Order() { Article = 86192, Name = "Gaming Headset", Price = 42, Size="XS", Offer = 10, Category = "Headphones"},
            new Order() { Article = 59911, Name = "VRBOX Gaming", Price = 410, Size="XS", Offer = 15, Category = "VR"},
            new Order() { Article = 59953, Name = "Gaming Mouse", Price = 20, Size="XR", Offer = 10, Category = "Gaming Mouses"},
            new Order() { Article = 78637, Name = "Gaming Controller", Price = 25, Size="XR", Offer = 10, Category = "Gamepads"},
            new Order() { Article = 32451, Name = "Gaming Headset", Price = 45, Size="XS", Offer = 10, Category = "Headphones"},
            new Order() { Article = 81827, Name = "Wireless Headset", Price = 40, Size="XS", Offer = 0, Category = "Headphones"},
            new Order() { Article = 11129, Name = "Gaming Controller", Price = 45, Size="XR", Offer = 10, Category = "Gamepads"},
            new Order() { Article = 81319, Name = "Camera Lens", Price = 300, Size="XR", Offer = 15, Category = "Cameras"},
            new Order() { Article = 39272, Name = "LED TV", Price = 1099, Size="XM", Offer = 20, Category = "TVs"},
            new Order() { Article = 17912, Name = "Wireless Headset", Price = 52, Size="XS", Offer = 0, Category = "Headphones"},
            new Order() { Article = 73444, Name = "Black Drone", Price = 200, Size="XS", Offer = 15, Category = "Drones"},
            new Order() { Article = 95622, Name = "Bluetooth Earphones", Price = 50, Size="X", Offer = 10, Category = "Headphones"},
            new Order() { Article = 82138, Name = "Gaming Headset", Price = 42, Size="XS", Offer = 10, Category = "Headphones"},
            new Order() { Article = 47166, Name = "VRBOX Gaming", Price = 410, Size="XS", Offer = 15, Category = "VR"},
            new Order() { Article = 29764, Name = "Gaming Mouse", Price = 20, Size="XR", Offer = 10, Category = "Gaming Mouses"},
            new Order() { Article = 13288, Name = "Gaming Controller", Price = 25, Size="XR", Offer = 10, Category = "Gamepads"},
            new Order() { Article = 16391, Name = "Gaming Headset", Price = 45, Size="XS", Offer = 10, Category = "Headphones"},
            new Order() { Article = 93674, Name = "Wireless Headset", Price = 40, Size="XS", Offer = 0, Category = "Headphones"},
            new Order() { Article = 61461, Name = "Gaming Controller", Price = 45, Size="XR", Offer = 10, Category = "Gamepads"},
            new Order() { Article = 11633, Name = "Camera Lens", Price = 300, Size="XR", Offer = 15, Category = "Cameras"},
            new Order() { Article = 37714, Name = "LED TV", Price = 1099, Size="XM", Offer = 20, Category = "TVs"},
            new Order() { Article = 21114, Name = "Wireless Headset", Price = 52, Size="XS", Offer = 0, Category = "Headphones"},
            new Order() { Article = 54419, Name = "Black Drone", Price = 200, Size="XS", Offer = 15, Category = "Drones"},
            new Order() { Article = 45494, Name = "Bluetooth Earphones", Price = 50, Size="X", Offer = 10, Category = "Headphones"},
            new Order() { Article = 27911, Name = "Gaming Headset", Price = 42, Size="XS", Offer = 10, Category = "Headphones"},
            new Order() { Article = 25529, Name = "VRBOX Gaming", Price = 410, Size="XS", Offer = 15, Category = "VR"},
            new Order() { Article = 51716, Name = "Gaming Mouse", Price = 20, Size="XR", Offer = 10, Category = "Gaming Mouses"},
            new Order() { Article = 14455, Name = "Gaming Controller", Price = 25, Size="XR", Offer = 10, Category = "Gamepads"},
            new Order() { Article = 18331, Name = "Gaming Headset", Price = 45, Size="XS", Offer = 10, Category = "Headphones"},
            new Order() { Article = 13871, Name = "Wireless Headset", Price = 40, Size="XS", Offer = 0, Category = "Headphones"},
        };
        
        // TODO: реализовать пагинацию (т.е. возвожмость ходить по номерам страницы)
        [HttpGet]
        public IActionResult Index(string searching, [FromQuery]int limit = 5)
        {
            OrdersVm result = new OrdersVm
            {
                Limit = limit,
                Orders = Orders.Take(limit).ToList()
            };

            if (!String.IsNullOrEmpty(searching))
            {
                OrdersVm search = new OrdersVm
                {
                    Limit = limit,
                    Orders = Orders.Where(order => order.Article.ToString().Contains(searching) || order.Name.Contains(searching) || order.Price.ToString().Contains(searching) || order.Offer.ToString().Contains(searching) || order.Size.Contains(searching) || order.Category.Contains(searching)).ToList()
                };
                
                return View(search);
            }
            return View(result);

            
        }
    }
}
