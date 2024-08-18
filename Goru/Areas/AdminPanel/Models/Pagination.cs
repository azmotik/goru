namespace Goru.Areas.AdminPanel.Models;

public class Pagination 
{
    /// <summary>
    /// Лимит
    /// </summary>
    public int Limit { get; set; }
    
    /// <summary>
    /// Текущая страница
    /// </summary>
    public int Page { get; set; }
    
    /// <summary>
    /// Начальная страница
    /// </summary>
    public int StartPage { get; set; }
    
    /// <summary>
    /// Конечная страница
    /// </summary>
    public int EndPage { get; set; }
    
    /// <summary>
    /// Всего элементов
    /// </summary>
    public int Total { get; set; }
    
    /// <summary>
    /// Всего страниц
    /// </summary>
    public int TotalPages { get; set; }
}
