using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheFinal_jacalva.Models;

namespace TheFinal_jacalva.Pages_Directory
{
    public class DetailsModel : PageModel
    {
        private readonly TheFinal_jacalva.Models.AppDbContext _context;

        public DetailsModel(TheFinal_jacalva.Models.AppDbContext context)
        {
            _context = context;
        }

        public Game Game { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Games.FirstOrDefaultAsync(m => m.GameID == id);

            if (game is not null)
            {
                Game = game;

                return Page();
            }

            return NotFound();
        }
    }
}
