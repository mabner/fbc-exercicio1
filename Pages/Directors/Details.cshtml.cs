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
    public class DetailsModel : PageModel
    {
        private readonly RazorMovies.Data.RazorMoviesContext _context;

        public DetailsModel(RazorMovies.Data.RazorMoviesContext context)
        {
            _context = context;
        }

        public Director Director { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Director = await _context.Director.FirstOrDefaultAsync(m => m.ID == id);

            if (Director == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
