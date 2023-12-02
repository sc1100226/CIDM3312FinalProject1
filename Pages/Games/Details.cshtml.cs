using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM3312FinalProject1.Models;

namespace CIDM3312FinalProject1.Pages.Games
{
    public class DetailsModel : PageModel
    {
        private readonly CIDM3312FinalProject1.Models.GameDbContext _context;

        public DetailsModel(CIDM3312FinalProject1.Models.GameDbContext context)
        {
            _context = context;
        }

      public Game Game { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Games == null)
            {
                return NotFound();
            }

            var game = await _context.Games.Include(m => m.Availabilities).FirstOrDefaultAsync(m => m.GameId == id);
            if (game == null)
            {
                return NotFound();
            }
            else 
            {
                Game = game;
            }
            return Page();
        }
    }
}
