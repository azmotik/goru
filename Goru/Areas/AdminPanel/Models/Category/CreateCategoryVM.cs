namespace Goru.Areas.AdminPanel.Models.Category;

public class CreateCategoryVM
{
    /// <summary>
    /// Id категории
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Название категории
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Id родителя категории
    /// </summary>
    public int ParentId { get; set; }

    public bool IsError { get; set; } = false;
}