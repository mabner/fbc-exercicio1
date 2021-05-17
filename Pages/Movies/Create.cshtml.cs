using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorMovies.Data;
using RazorMovies.Models;

namespace RazorMovies.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly RazorMovies.Data.RazorMoviesContext _context;

        public CreateModel(RazorMovies.Data.RazorMoviesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DirectorID"] = new SelectList(_context.Director, "ID", "Name");
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
