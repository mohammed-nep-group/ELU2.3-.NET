using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cinematix.Data;
using Cinematix.Models;

namespace Cinematix
{
    public class IndexModel : PageModel
    {
        private readonly Cinematix.Data.CinematixContext _context;

        public IndexModel(Cinematix.Data.CinematixContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movies.ToListAsync();
        }
    }
}
