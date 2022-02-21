using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EnvironmentalChanges.Models;
using EnvironmentalChanges.Data;

namespace EnvironmentalChanges.Pages_EChanges
{
    public class EditModel : PageModel
    {
        private readonly EnvironmentalChangesContext _context;

        public EditModel(EnvironmentalChangesContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(EChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EChangeExists(EChange.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EChangeExists(int id)
        {
            return _context.EChange.Any(e => e.ID == id);
        }
    }
}
