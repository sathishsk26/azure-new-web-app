using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using azure_new_web_app.Data;

namespace azure_new_web_app.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly azure_new_web_app.Data.ApplicationDbContext _context;

        public IndexModel(azure_new_web_app.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Persons != null)
            {
                Person = await _context.Persons.ToListAsync();
            }
        }
    }
}
