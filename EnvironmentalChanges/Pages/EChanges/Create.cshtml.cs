using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EnvironmentalChanges.Models;
using EnvironmentalChanges.Data;

namespace EnvironmentalChanges.Pages_EChanges
{
    public class CreateModel : PageModel
    {
        private readonly EnvironmentalChangesContext _context;

        public CreateModel(EnvironmentalChangesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public EChange EChange { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.EChange.Add(EChange);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
