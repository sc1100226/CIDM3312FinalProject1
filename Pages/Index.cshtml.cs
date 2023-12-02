using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM3312FinalProject1.Models;

namespace CIDM3312FinalProject1.Pages;

public class IndexModel : PageModel
{
    private readonly GameDbContext _context;
    private readonly ILogger<IndexModel> _logger;
    public List<Game> Games {get; set;} = default!;

    public IndexModel(GameDbContext context, ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        Games = _context.Games.ToList();
    }
}
