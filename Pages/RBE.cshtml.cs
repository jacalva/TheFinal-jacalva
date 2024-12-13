using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheFinal_jacalva.Models;

namespace TheFinal_jacalva.Pages_RBE
{
    public class RBEModel : PageModel
    {
        private readonly TheFinal_jacalva.Models.AppDbContext _context;

        public RBEModel(TheFinal_jacalva.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; } = default!;
        public int Studio2AcquisitionYear { get; set; }

        public async Task OnGetAsync()
        {
                
            //Call games from only Studio2
            Game = await _context.Games
            .Where(g => _context.StudioGames.Any(sg => sg.GameID == g.GameID && sg.StudioID == 2)) 
            .ToListAsync();

            //Call Acquisition year from Studio2
            var studio2 = await _context.Studios
            .Where(s => s.StudioID == 2)
            .FirstOrDefaultAsync();
            if (studio2 != null)
                {
                    Studio2AcquisitionYear = studio2.acquisitionyear;
                }
                

        }
    }
}