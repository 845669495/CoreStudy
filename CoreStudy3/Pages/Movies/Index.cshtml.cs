using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreStudy3.Models;

namespace CoreStudy3.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly CoreStudy3.Models.MovieContext _context;

        public IndexModel(CoreStudy3.Models.MovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
