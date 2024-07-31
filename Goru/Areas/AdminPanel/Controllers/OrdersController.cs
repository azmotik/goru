using System.Runtime.InteropServices;
using Goru.Areas.AdminPanel.Enums;
using Microsoft.AspNetCore.Mvc;
using Goru.Areas.AdminPanel.Models;
using Goru.Areas.AdminPanel.Models.Order;

namespace Goru.Areas.AdminPanel.Controllers
{
    
    [Area("AdminPanel")]
    public class OrdersController : Controller
    {
        #region Orders
        private static List<Order> Orders = new()
        {
            new Order() { Article = 47431, Name = "Gaming Headset", Price = 42, Size=SizeEnum.XS, Offer = 10, Category = "Headphones"},
            new Order() { Article = 73656, Name = "VRBOX Gaming", Price = 410, Size=SizeEnum.XS, Offer = 15, Category = "VR"},
            new Order() { Article = 16857, Name = "Gaming Mouse", Price = 20, Size=SizeEnum.XR, Offer = 10, Category = "Gaming Mouses"},
            new Order() { Article = 34939, Name = "Gaming Controller", Price = 25, Size=SizeEnum.XR, Offer = 10, Category = "Gamepads"},
            new Order() { Article = 27614, Name = "Gaming Headset", Price = 45, Size=SizeEnum.XS, Offer = 10, Category = "Headphones"},
            new Order() { Article = 19898, Name = "Wireless Headset", Price = 40, Size=SizeEnum.XS, Offer = 0, Category = "Headphones"},
            new Order() { Article = 11998, Name = "Gaming Controller", Price = 45, Size=SizeEnum.XR, Offer = 10, Category = "Gamepads"},
            new Order() { Article = 75638, Name = "Camera Lens", Price = 300, Size=SizeEnum.XR, Offer = 15, Category = "Cameras"},
            new Order() { Article = 81358, Name = "LED TV", Price = 1099, Size=SizeEnum.XM, Offer = 20, Category = "TVs"},
            new Order() { Article = 82332, Name = "Wireless Headset", Price = 52, Size=SizeEnum.XS, Offer = 0, Category = "Headphones"},
            new Order() { Article = 18475, Name = "Black Drone", Price = 200, Size=SizeEnum.XS, Offer = 15, Category = "Drones"},
            new Order() { Article = 12793, Name = "Bluetooth Earphones", Price = 50, Size=SizeEnum.S, Offer = 10, Category = "Headphones"},
            new Order() { Article = 23979, Name = "Gaming Headset", Price = 42, Size=SizeEnum.XS, Offer = 10, Category = "Headphones"},
            new Order() { Article = 52112, Name = "VRBOX Gaming", Price = 410, Size=SizeEnum.XS, Offer = 15, Category = "VR"},
            new Order() { Article = 49368, Name = "Gaming Mouse", Price = 20, Size=SizeEnum.XR, Offer = 10, Category = "Gaming Mouses"},
            new Order() { Article = 88867, Name = "Gaming Controller", Price = 25, Size=SizeEnum.XR, Offer = 10, Category = "Gamepads"},
            new Order() { Article = 13617, Name = "Gaming Headset", Price = 45, Size=SizeEnum.XS, Offer = 10, Category = "Headphones"},
            new Order() { Article = 17541, Name = "Wireless Headset", Price = 40, Size=SizeEnum.XS, Offer = 0, Category = "Headphones"},
            new Order() { Article = 31991, Name = "Gaming Controller", Price = 45, Size=SizeEnum.XR, Offer = 10, Category = "Gamepads"},
            new Order() { Article = 51766, Name = "Camera Lens", Price = 300, Size=SizeEnum.XR, Offer = 15, Category = "Cameras"},
            new Order() { Article = 55644, Name = "LED TV", Price = 1099, Size=SizeEnum.XM, Offer = 20, Category = "TVs"},
            new Order() { Article = 39943, Name = "Wireless Headset", Price = 52, Size=SizeEnum.XS, Offer = 0, Category = "Headphones"},
            new Order() { Article = 78496, Name = "Black Drone", Price = 200, Size=SizeEnum.XS, Offer = 15, Category = "Drones"},
            new Order() { Article = 78571, Name = "Bluetooth Earphones", Price = 50, Size=SizeEnum.S, Offer = 10, Category = "Headphones"},
            new Order() { Article = 57686, Name = "Gaming Headset", Price = 42, Size=SizeEnum.XS, Offer = 10, Category = "Headphones"},
            new Order() { Article = 52493, Name = "VRBOX Gaming", Price = 410, Size=SizeEnum.XS, Offer = 15, Category = "VR"},
            new Order() { Article = 71574, Name = "Gaming Mouse", Price = 20, Size=SizeEnum.XR, Offer = 10, Category = "Gaming Mouses"},
            new Order() { Article = 98461, Name = "Gaming Controller", Price = 25, Size=SizeEnum.XR, Offer = 10, Category = "Gamepads"},
            new Order() { Article = 16711, Name = "Gaming Headset", Price = 45, Size=SizeEnum.XS, Offer = 10, Category = "Headphones"},
            new Order() { Article = 35837, Name = "Wireless Headset", Price = 40, Size=SizeEnum.XS, Offer = 0, Category = "Headphones"},
            new Order() { Article = 84864, Name = "Gaming Controller", Price = 45, Size=SizeEnum.XR, Offer = 10, Category = "Gamepads"},
            new Order() { Article = 51125, Name = "Camera Lens", Price = 300, Size=SizeEnum.XR, Offer = 15, Category = "Cameras"},
            new Order() { Article = 95915, Name = "LED TV", Price = 1099, Size=SizeEnum.XM, Offer = 20, Category = "TVs"},
            new Order() { Article = 74738, Name = "Wireless Headset", Price = 52, Size=SizeEnum.XS, Offer = 0, Category = "Headphones"},
            new Order() { Article = 99448, Name = "Black Drone", Price = 200, Size=SizeEnum.XS, Offer = 15, Category = "Drones"},
            new Order() { Article = 76174, Name = "Bluetooth Earphones", Price = 50, Size=SizeEnum.S, Offer = 10, Category = "Headphones"},
            new Order() { Article = 19526, Name = "Gaming Headset", Price = 42, Size=SizeEnum.XS, Offer = 10, Category = "Headphones"},
            new Order() { Article = 22961, Name = "VRBOX Gaming", Price = 410, Size=SizeEnum.XS, Offer = 15, Category = "VR"},
            new Order() { Article = 51745, Name = "Gaming Mouse", Price = 20, Size=SizeEnum.XR, Offer = 10, Category = "Gaming Mouses"},
            new Order() { Article = 86713, Name = "Gaming Controller", Price = 25, Size=SizeEnum.XR, Offer = 10, Category = "Gamepads"},
            new Order() { Article = 64481, Name = "Gaming Headset", Price = 45, Size=SizeEnum.XS, Offer = 10, Category = "Headphones"},
            new Order() { Article = 65151, Name = "Wireless Headset", Price = 40, Size=SizeEnum.XS, Offer = 0, Category = "Headphones"},
            new Order() { Article = 85934, Name = "Gaming Controller", Price = 45, Size=SizeEnum.XR, Offer = 10, Category = "Gamepads"},
            new Order() { Article = 69154, Name = "Camera Lens", Price = 300, Size=SizeEnum.XR, Offer = 15, Category = "Cameras"},
            new Order() { Article = 34968, Name = "LED TV", Price = 1099, Size=SizeEnum.XM, Offer = 20, Category = "TVs"},
            new Order() { Article = 56331, Name = "Wireless Headset", Price = 52, Size=SizeEnum.XS, Offer = 0, Category = "Headphones"},
            new Order() { Article = 71315, Name = "Black Drone", Price = 200, Size=SizeEnum.XS, Offer = 15, Category = "Drones"},
            new Order() { Article = 71187, Name = "Bluetooth Earphones", Price = 50, Size=SizeEnum.S, Offer = 10, Category = "Headphones"},
            new Order() { Article = 36573, Name = "Gaming Headset", Price = 42, Size=SizeEnum.XS, Offer = 10, Category = "Headphones"},
            new Order() { Article = 12244, Name = "VRBOX Gaming", Price = 410, Size=SizeEnum.XS, Offer = 15, Category = "VR"},
            new Order() { Article = 21229, Name = "Gaming Mouse", Price = 20, Size=SizeEnum.XR, Offer = 10, Category = "Gaming Mouses"},
            new Order() { Article = 53769, Name = "Gaming Controller", Price = 25, Size=SizeEnum.XR, Offer = 10, Category = "Gamepads"},
            new Order() { Article = 12874, Name = "Gaming Headset", Price = 45, Size=SizeEnum.XS, Offer = 10, Category = "Headphones"},
            new Order() { Article = 94514, Name = "Wireless Headset", Price = 40, Size=SizeEnum.XS, Offer = 0, Category = "Headphones"},
            new Order() { Article = 44218, Name = "Gaming Controller", Price = 45, Size=SizeEnum.XR, Offer = 10, Category = "Gamepads"},
            new Order() { Article = 22726, Name = "Camera Lens", Price = 300, Size=SizeEnum.XR, Offer = 15, Category = "Cameras"},
            new Order() { Article = 33337, Name = "LED TV", Price = 1099, Size=SizeEnum.XM, Offer = 20, Category = "TVs"},
            new Order() { Article = 13672, Name = "Wireless Headset", Price = 52, Size=SizeEnum.XS, Offer = 0, Category = "Headphones"},
            new Order() { Article = 61311, Name = "Black Drone", Price = 200, Size=SizeEnum.XS, Offer = 15, Category = "Drones"},
            new Order() { Article = 67895, Name = "Bluetooth Earphones", Price = 50, Size=SizeEnum.S, Offer = 10, Category = "Headphones"},
            new Order() { Article = 15252, Name = "Gaming Headset", Price = 42, Size=SizeEnum.XS, Offer = 10, Category = "Headphones"},
            new Order() { Article = 16364, Name = "VRBOX Gaming", Price = 410, Size=SizeEnum.XS, Offer = 15, Category = "VR"},
            new Order() { Article = 67224, Name = "Gaming Mouse", Price = 20, Size=SizeEnum.XR, Offer = 10, Category = "Gaming Mouses"},
            new Order() { Article = 51762, Name = "Gaming Controller", Price = 25, Size=SizeEnum.XR, Offer = 10, Category = "Gamepads"},
            new Order() { Article = 27172, Name = "Gaming Headset", Price = 45, Size=SizeEnum.XS, Offer = 10, Category = "Headphones"},
            new Order() { Article = 13454, Name = "Wireless Headset", Price = 40, Size=SizeEnum.XS, Offer = 0, Category = "Headphones"},
            new Order() { Article = 59168, Name = "Gaming Controller", Price = 45, Size=SizeEnum.XR, Offer = 10, Category = "Gamepads"},
            new Order() { Article = 24588, Name = "Camera Lens", Price = 300, Size=SizeEnum.XR, Offer = 15, Category = "Cameras"},
            new Order() { Article = 36624, Name = "LED TV", Price = 1099, Size=SizeEnum.XM, Offer = 20, Category = "TVs"},
            new Order() { Article = 72581, Name = "Wireless Headset", Price = 52, Size=SizeEnum.XS, Offer = 0, Category = "Headphones"},
            new Order() { Article = 61592, Name = "Black Drone", Price = 200, Size=SizeEnum.XS, Offer = 15, Category = "Drones"},
            new Order() { Article = 71253, Name = "Bluetooth Earphones", Price = 50, Size=SizeEnum.S, Offer = 10, Category = "Headphones"},
            new Order() { Article = 86192, Name = "Gaming Headset", Price = 42, Size=SizeEnum.XS, Offer = 10, Category = "Headphones"},
            new Order() { Article = 59911, Name = "VRBOX Gaming", Price = 410, Size=SizeEnum.XS, Offer = 15, Category = "VR"},
            new Order() { Article = 59953, Name = "Gaming Mouse", Price = 20, Size=SizeEnum.XR, Offer = 10, Category = "Gaming Mouses"},
            new Order() { Article = 78637, Name = "Gaming Controller", Price = 25, Size=SizeEnum.XR, Offer = 10, Category = "Gamepads"},
            new Order() { Article = 32451, Name = "Gaming Headset", Price = 45, Size=SizeEnum.XS, Offer = 10, Category = "Headphones"},
            new Order() { Article = 81827, Name = "Wireless Headset", Price = 40, Size=SizeEnum.XS, Offer = 0, Category = "Headphones"},
            new Order() { Article = 11129, Name = "Gaming Controller", Price = 45, Size=SizeEnum.XR, Offer = 10, Category = "Gamepads"},
            new Order() { Article = 81319, Name = "Camera Lens", Price = 300, Size=SizeEnum.XR, Offer = 15, Category = "Cameras"},
            new Order() { Article = 39272, Name = "LED TV", Price = 1099, Size=SizeEnum.XM, Offer = 20, Category = "TVs"},
            new Order() { Article = 17912, Name = "Wireless Headset", Price = 52, Size=SizeEnum.XS, Offer = 0, Category = "Headphones"},
            new Order() { Article = 73444, Name = "Black Drone", Price = 200, Size=SizeEnum.XS, Offer = 15, Category = "Drones"},
            new Order() { Article = 95622, Name = "Bluetooth Earphones", Price = 50, Size=SizeEnum.S, Offer = 10, Category = "Headphones"},
            new Order() { Article = 82138, Name = "Gaming Headset", Price = 42, Size=SizeEnum.XS, Offer = 10, Category = "Headphones"},
            new Order() { Article = 47166, Name = "VRBOX Gaming", Price = 410, Size=SizeEnum.XS, Offer = 15, Category = "VR"},
            new Order() { Article = 29764, Name = "Gaming Mouse", Price = 20, Size=SizeEnum.XR, Offer = 10, Category = "Gaming Mouses"},
            new Order() { Article = 13288, Name = "Gaming Controller", Price = 25, Size=SizeEnum.XR, Offer = 10, Category = "Gamepads"},
            new Order() { Article = 16391, Name = "Gaming Headset", Price = 45, Size=SizeEnum.XS, Offer = 10, Category = "Headphones"},
            new Order() { Article = 93674, Name = "Wireless Headset", Price = 40, Size=SizeEnum.XS, Offer = 0, Category = "Headphones"},
            new Order() { Article = 61461, Name = "Gaming Controller", Price = 45, Size=SizeEnum.XR, Offer = 10, Category = "Gamepads"},
            new Order() { Article = 11633, Name = "Camera Lens", Price = 300, Size=SizeEnum.XR, Offer = 15, Category = "Cameras"},
            new Order() { Article = 37714, Name = "LED TV", Price = 1099, Size=SizeEnum.XM, Offer = 20, Category = "TVs"},
            new Order() { Article = 21114, Name = "Wireless Headset", Price = 52, Size=SizeEnum.XS, Offer = 0, Category = "Headphones"},
            new Order() { Article = 54419, Name = "Black Drone", Price = 200, Size=SizeEnum.XS, Offer = 15, Category = "Drones"},
            new Order() { Article = 45494, Name = "Bluetooth Earphones", Price = 50, Size=SizeEnum.S, Offer = 10, Category = "Headphones"},
            new Order() { Article = 27911, Name = "Gaming Headset", Price = 42, Size=SizeEnum.XS, Offer = 10, Category = "Headphones"},
            new Order() { Article = 25529, Name = "VRBOX Gaming", Price = 410, Size=SizeEnum.XS, Offer = 15, Category = "VR"},
            new Order() { Article = 51716, Name = "Gaming Mouse", Price = 20, Size=SizeEnum.XR, Offer = 10, Category = "Gaming Mouses"},
            new Order() { Article = 14455, Name = "Gaming Controller", Price = 25, Size=SizeEnum.XR, Offer = 10, Category = "Gamepads"},
            new Order() { Article = 18331, Name = "Gaming Headset", Price = 45, Size=SizeEnum.XS, Offer = 10, Category = "Headphones"},
            new Order() { Article = 13871, Name = "Wireless Headset", Price = 40, Size=SizeEnum.XS, Offer = 0, Category = "Headphones"},
        };
        #endregion
        
        // TODO: Стелизовать страницы редактирования и создания
        // TODO: теория. HTML. знать тэг <form>, <input> (все типы аттрибута type)
        // TODO: теория. Cтруктуры данных. знать наизусть все 10 ( https://practicum.yandex.ru/blog/10-osnovnyh-struktur-dannyh/ )
        // TODO: теория. с#. прочитай и готовым быть к вопросам статический класс, статический конструктор, статические методы
        // TODO: теория. с#. Enum
        
        [HttpGet]
        public IActionResult Index([FromQuery]string searching, [FromQuery]int limit = 5, [FromQuery]int page = 1)
        {
            IEnumerable<Order> query = Orders;
            
            if (!String.IsNullOrEmpty(searching))
            {
                query = query.Where(order => order.Article.ToString().Contains(searching) ||
                                              order.Name.Contains(searching) ||
                                              order.Price.ToString().Contains(searching) ||
                                              order.Offer.ToString().Contains(searching) ||
                                              order.Size.ToString().Contains(searching) || order.Category.Contains(searching));
            }
            
            OrdersVm result = new OrdersVm
            {
                Pagination = new Pagination()
                {
                    
                    Limit = limit,
                    Page = page,
                    StartPage = page - 2,
                    EndPage = page + 2,
                    Total = query.Count(),
                    TotalPages = query.Count() % limit == 0 ? query.Count() / limit : query.Count() / limit + 1,
                },
                Searching = searching,
                Orders = query.Skip((page - 1) * limit).Take(limit).ToList()
            };
            
            if (result.Pagination.StartPage <= 0)
            {
                result.Pagination.EndPage -= (result.Pagination.StartPage - 1);
                result.Pagination.StartPage = 1;
            }

            if (result.Pagination.EndPage > result.Pagination.TotalPages)
            {
                if (result.Pagination.Total % result.Pagination.Limit == 0)
                {
                    result.Pagination.EndPage = result.Pagination.TotalPages;
                }
                else
                {
                    result.Pagination.EndPage = result.Pagination.TotalPages + 1;
                }

                if (result.Pagination.EndPage > 5)
                {
                    result.Pagination.StartPage = result.Pagination.EndPage - 4;
                }
            }
            
            
            Dictionary<string, PaginationLink> dictionary = new();
            dictionary.Add("Previous", new PaginationLink()
            {
                Href= $"?searching={result.Searching}&limit={result.Pagination.Limit}&page={result.Pagination.Page - 1}",
                IsEnabled = page != 1 ? " enabled" : " disabled",
            });
            if (result.Pagination.Page >= 4)
            {
                dictionary.Add("ToStart", new PaginationLink()
                {
                    Href = $"?searching={result.Searching}&limit={limit}&page={1}",
                    IsEnabled = page != 1 ? " enabled" : " disabled",
                });
                dictionary.Add("...", new PaginationLink()
                {
                    Href = $"?searching={result.Searching}&limit={limit}&page={result.Pagination.Page - 5}"
                });

            }
            for (var i = result.Pagination.StartPage; i < result.Pagination.EndPage; i++)
            {
                dictionary.Add(i.ToString(), new PaginationLink()
                {
                    Href= $"?searching={result.Searching}&limit={result.Pagination.Limit}&page={i}",
                    IsActive = i == result.Pagination.Page ? " active" : ""
                });
            }
            dictionary.Add("ToEnd", new PaginationLink()
            {
                Href= $"?searching={result.Searching}&limit={result.Pagination.Limit}&page={result.Pagination.TotalPages}",
                IsEnabled = page != result.Pagination.TotalPages ? " enabled" : " disabled",
            });
            dictionary.Add("Next", new PaginationLink()
            {
                Href= $"?searching={result.Searching}&limit={result.Pagination.Limit}&page={result.Pagination.Page + 1}",
                IsEnabled = page != result.Pagination.TotalPages ? " enabled" : " disabled",
            });

            ViewBag.dictionary = dictionary;
            return View(result);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(CreateOrderVM payload)
        {
            Orders.Add(new Order()
            {
                Offer = payload.Offer,
                Article = payload.Article,
                Category = payload.Category,
                Name = payload.Name,
                Price = payload.Price,
                Size = payload.Size,
            });
            
            return View("Index");
        }
        
        
        // GET: AdminPanel/Orders/23424/edit
        [HttpGet("{article}/edit")]
        public IActionResult Edit([FromRoute]int article)
        {
            // TODO: Логика получения данных о товаре для заполнения формы
            
            // return View( updateOrderVM );
            return View();
        }
        
        [HttpPut]
        public IActionResult SaveChanges()
        {
            // TODO: Написать логику изменения о товаре Артикль брать из роута
            
            return View();
        }
        
        [HttpGet]
        public IActionResult Delete(int article)
        {
            var order = Orders.FirstOrDefault(p => p.Article == article);
            if (order != null)
            {
                Orders.Remove(order);
            }
            
            return Redirect("Index");
        }

    }
}



    
public class PaginationLink{
    public string Href { get; set; }
    public string IsActive { get; set; }
    public string IsEnabled { get; set; }
}