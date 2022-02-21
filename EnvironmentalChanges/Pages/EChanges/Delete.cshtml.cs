using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EnvironmentalChanges.Models;
using EnvironmentalChanges.Data;

namespace EnvironmentalChanges.Pages_EChanges
{
    public class DeleteModel : PageModel
    {
        private readonly EnvironmentalChangesContext _context;

        public DeleteModel(EnvironmentalChangesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EChange EChange { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EChange = await _context.EChange.FirstOrDefaultAsync(m => m.ID == id);

            if (EChange == null)
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

            EChange = await _context.EChange.FindAsync(id);

            if (EChange != null)
            {
                _context.EChange.Remove(EChange);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
