using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheFinal_jacalva.Models;

namespace TheFinal_jacalva.Pages_ORS
{
    public class ORSModel : PageModel
    {
        private readonly TheFinal_jacalva.Models.AppDbContext _context;

        public ORSModel(TheFinal_jacalva.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; } = default!;
        public int Studio1AcquisitionYear { get; set; }

        public async Task OnGetAsync()
        {
                
            //Call games from Studio1
            Game = await _context.Games
            .Where(g => _context.StudioGames.Any(sg => sg.GameID == g.GameID && sg.StudioID == 1)) // Filter by StudioID = 1
            .ToListAsync();

            var studio1 = await _context.Studios
            .Where(s => s.StudioID == 1)
            .FirstOrDefaultAsync();
            if (studio1 != null)
                {
                    Studio1AcquisitionYear = studio1.acquisitionyear;
                }
                

        }
    }
}