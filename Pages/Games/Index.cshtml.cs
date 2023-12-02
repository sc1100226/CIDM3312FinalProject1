using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM3312FinalProject1.Models;
using SQLitePCL;

namespace CIDM3312FinalProject1.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly CIDM3312FinalProject1.Models.GameDbContext _context;

        public IndexModel(CIDM3312FinalProject1.Models.GameDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get;set;}


        public async Task OnGetAsync()
        {
            if (_context.Games != null)
            {
                var query = _context.Games.Select(p =>p);

                switch (CurrentSort)
                {
                    case "first_asc" :
                        query = query.OrderBy(p => p.GameGenre);
                        break;
                    case "first.desc" :
                        query = query.OrderByDescending(p => p.GameGenre);
                        break;
                }

                Game = await query.ToListAsync();
            }
        }
    }
}
