using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorMovies.Data;
using RazorMovies.Models;

namespace RazorMovies.Pages.Directors
{
    public class IndexModel : PageModel
    {
        private readonly RazorMovies.Data.RazorMoviesContext _context;

        public IndexModel(RazorMovies.Data.RazorMoviesContext context)
        {
            _context = context;
        }

        public IList<Director> Director { get;set; }

        public async Task OnGetAsync()
        {
            Director = await _context.Director.ToListAsync();
        }
    }
}
