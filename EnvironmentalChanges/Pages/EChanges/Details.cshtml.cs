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
    public class DetailsModel : PageModel
    {
        private readonly EnvironmentalChangesContext _context;

        public DetailsModel(EnvironmentalChangesContext context)
        {
            _context = context;
        }

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
    }
}
