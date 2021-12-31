using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ivanov_Ioana_Lab8.Data;
using Ivanov_Ioana_Lab8.Models;

namespace Ivanov_Ioana_Lab8.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly Ivanov_Ioana_Lab8.Data.Ivanov_Ioana_Lab8Context _context;

        public DeleteModel(Ivanov_Ioana_Lab8.Data.Ivanov_Ioana_Lab8Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FindAsync(id);

            if (Category != null)
            {
                _context.Category.Remove(Category);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
