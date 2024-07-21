namespace Goru.Areas.AdminPanel.Models;

public class Pagination 
{
    public int Limit { get; set; }
    public int Page { get; set; }
    public int StartPage { get; set; }
    public int EndPage { get; set; }
    public int Total { get; set; }
    public int TotalPages { get; set; }
}
