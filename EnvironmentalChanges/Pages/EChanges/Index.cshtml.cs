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
    public class IndexModel : PageModel
    {
        private readonly EnvironmentalChangesContext _context;

        public IndexModel(EnvironmentalChangesContext context)
        {
            _context = context;
        }

        public IList<EChange> EChange { get;set; }

        public async Task OnGetAsync()
        {
            EChange = await _context.EChange.ToListAsync();
        }
    }
}
