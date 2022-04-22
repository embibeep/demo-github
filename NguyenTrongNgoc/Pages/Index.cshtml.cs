using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace NguyenTrongNgoc.Pages;

public class IndexModel : PageModel
{
    // private readonly ILogger<IndexModel> _logger;

    // public IndexModel(ILogger<IndexModel> logger)
    // {
    //     _logger = logger;
    // }

    private readonly Data _context;

    public IndexModel(Data context)
    {
        _context = context;
    }

    public IList<NguyenTrongNgoc.Models.News> News { get; set; }

    public async Task OnGetAsync()
    {
        News = await _context.News.ToListAsync();
    }

}
