using Microsoft.AspNetCore.Mvc;
using Goru.Areas.AdminPanel.Models;
using Goru.Areas.AdminPanel.Models.Category;
using Goru.Data;

namespace Goru.Areas.AdminPanel.Controllers;

[Area("AdminPanel")]
public class CategoriesController : Controller
{
    public IActionResult Index([FromQuery]string searching, [FromQuery]int limit = 5)
    {
        IEnumerable<Category> query = DataTables.Categories;
        
        CategoriesVM result = new CategoriesVM
        {
            Searching = searching,
            Limit = limit,
            Categories = query.ToList()
        };
        return View(result);
    }
    // TODO: Выводить таблицу со всеми категориями (без пагинации)
    // TODO: Возможность Добавить категорию
    // TODO: Возможность Изменить информацию о категории
    // TODO: Возможность Удалить категорию
    
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(CreateCategoryVM payload)
    {
        var category = DataTables.Categories.FirstOrDefault(x => x.Id == payload.Id);

        if (category != null)
        {

            return View("Error");
        }
        
        DataTables.Categories.Add(new Category()
        {
            Id = payload.Id,
            Name = payload.Name,
            ParentId = payload.ParentId,
        });
        
        return Redirect("Index");
    }
    
    
    [HttpGet("categories/{id}/edit")]
    public IActionResult Edit([FromRoute]int id)
    {
        
        var category = DataTables.Categories.FirstOrDefault(p => p.Id == id);
        UpdateCategoryVM data = new UpdateCategoryVM
        {
            Id = category.Id,
            Name = category.Name,
            ParentId = category.ParentId,
            
        };
        
        return View(data);
    }
    
    //  [HttpPut]
    [HttpPost]
    public IActionResult SaveChanges([FromQuery] int id, UpdateCategoryVM update)
    {
        // TODO: article брать из роута [FromQuery] -> [FromRoute] 
        
        var category = DataTables.Categories.FirstOrDefault(x => x.Id == id);
        if(category == null) return Redirect("Index");
        
        category.Id = update.Id;
        category.Name = update.Name;
        category.ParentId = update.ParentId;
        
        
        return Redirect("Index");
    }
    
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var category = DataTables.Categories.FirstOrDefault(p => p.Id == id);
        if (category != null)
        {
            DataTables.Categories.Remove(category);
        }
        
        return Redirect("Index");
    }
}