namespace Goru.Areas.AdminPanel.Models
{
    public class CategoriesVM
    {
        public List<Category.Category> Categories = new();

        public string Searching { get; set; }

        public int Limit { get; set; }
    }
}
