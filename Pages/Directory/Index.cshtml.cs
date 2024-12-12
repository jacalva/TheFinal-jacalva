using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TheFinal_jacalva.Models;

namespace TheFinal_jacalva.Pages_Directory
{
    public class IndexModel : PageModel
    {
        private readonly TheFinal_jacalva.Models.AppDbContext _context;

        public IndexModel(TheFinal_jacalva.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; } = default!;
         public IList<Studio> Studio { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        public int TotalPages {get; set;}

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;

        [BindProperty(SupportsGet =  true)]
        public string CurrentSearch {get; set;} = string.Empty;

        public async Task OnGetAsync()
        {
            var query = _context.Games.Include(s => s.StudioGames!).ThenInclude(sc => sc.Studio).Select(s => s);

            
            //search
            if (!string.IsNullOrEmpty(CurrentSearch))
            {
                query = query.Where(s => s.GameTitle.ToUpper().Contains(CurrentSearch.ToUpper()) /*|| s.LastName.ToUpper().Contains(CurrentSearch.ToUpper())*/);
            }

            //sort order
            switch (CurrentSort)
            {
                case "first_asc":
                    query = query.OrderBy(s => s.GameTitle);
                    break;
                case "first_desc":
                    query = query.OrderByDescending(s => s.GameTitle);
                    break;
                case "second_asc":
                     query = query.OrderBy(s => s.CopiesSold);
                    break;
                case "second_desc":
                    query = query.OrderByDescending(s => s.CopiesSold);
                    break;       
            }
            
            //prev next
            TotalPages = (int)Math.Ceiling(_context.Games.Count() / (double)PageSize);
    
            Game = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync(); 
        }
    }
}