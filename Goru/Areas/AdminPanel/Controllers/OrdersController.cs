using Microsoft.AspNetCore.Mvc;
using Goru.Areas.AdminPanel.Models;
using Goru.Areas.AdminPanel.Models.Order;
using Goru.Data;

namespace Goru.Areas.AdminPanel.Controllers
{
    
    [Area("AdminPanel")]
    public class OrdersController : Controller
    {
        
        
        
        [HttpGet]
        public IActionResult Index([FromQuery]string searching, [FromQuery]int limit = 5, [FromQuery]int page = 1)
        {
            IEnumerable<Order> query = DataTables.Orders;
            
            if (!String.IsNullOrEmpty(searching))
            {
                query = query.Where(order => order.Article.ToString().Contains(searching) ||
                                              order.Name.Contains(searching) ||
                                              order.Price.ToString().Contains(searching) ||
                                              order.Offer.ToString().Contains(searching) ||
                                              order.Size.ToString().Contains(searching));
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
            var order = DataTables.Orders.FirstOrDefault(x => x.Article == payload.Article);

            if (order != null)
            {

                return View("Error");
            }
            
            DataTables.Orders.Add(new Order()
            {
                Offer = payload.Offer,
                Article = payload.Article,
                CategoryId = payload.CategoryId,
                Name = payload.Name,
                Price = payload.Price,
                Size = payload.Size,
            });
            
            return Redirect("Index");
        }
        
        
        [HttpGet("orders/{article}/edit")]
        public IActionResult Edit([FromRoute]int article)
        {
            
            var order = DataTables.Orders.FirstOrDefault(p => p.Article == article);
            UpdateOrderVM data = new UpdateOrderVM
            {
                Offer = order.Offer,
                Article = order.Article,
                CategoryId = order.CategoryId,
                Name = order.Name,
                Price = order.Price,
                Size = order.Size,
                
            };
            
            return View(data);
        }
        
        //  [HttpPut]
        [HttpPost]
        public IActionResult SaveChanges([FromQuery] int article, UpdateOrderVM update)
        {
            // TODO: article брать из роута [FromQuery] -> [FromRoute] 
            
            var order = DataTables.Orders.FirstOrDefault(x => x.Article == article);
            if(order == null) return Redirect("Index");
            
            order.CategoryId = update.CategoryId;
            order.Name = update.Name;
            order.Price = update.Price;
            order.Offer = update.Offer;
            order.Size = update.Size;
            
            
            return Redirect("Index");
        }
        
        [HttpGet]
        public IActionResult Delete(int article)
        {
            var order = DataTables.Orders.FirstOrDefault(p => p.Article == article);
            if (order != null)
            {
                DataTables.Orders.Remove(order);
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