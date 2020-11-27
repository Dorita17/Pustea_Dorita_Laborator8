using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pustea_Dorita_Lab8.Data;
using Pustea_Dorita_Lab8.Models;

namespace Pustea_Dorita_Lab8.Pages.BookCategories
{
    public class IndexModel : PageModel
    {
        private readonly Pustea_Dorita_Lab8.Data.Pustea_Dorita_Lab8Context _context;

        public IndexModel(Pustea_Dorita_Lab8.Data.Pustea_Dorita_Lab8Context context)
        {
            _context = context;
        }

        public IList<BookCategory> BookCategory { get; set; }

        public async Task OnGetAsync()
        {
            BookCategory = await _context.BookCategory
                .Include(b => b.Book)
                .Include(b => b.Category).ToListAsync();
        }
    }
}
