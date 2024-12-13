using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheFinal_jacalva.Models;

namespace TheFinal_jacalva.Pages_NSI
{
    public class NSIModel : PageModel
    {
        private readonly TheFinal_jacalva.Models.AppDbContext _context;

        public NSIModel(TheFinal_jacalva.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; } = default!;
        public int Studio3AcquisitionYear { get; set; }

        public async Task OnGetAsync()
        {
                
            //Call games from only Studio3
            Game = await _context.Games
            .Where(g => _context.StudioGames.Any(sg => sg.GameID == g.GameID && sg.StudioID == 3))
            .ToListAsync();

            //Call Acquisition Year for Specific Studio
            var studio3 = await _context.Studios
            .Where(s => s.StudioID == 3)
            .FirstOrDefaultAsync();
            if (studio3 != null)
                {
                    Studio3AcquisitionYear = studio3.acquisitionyear;
                }
                

        }
    }
}